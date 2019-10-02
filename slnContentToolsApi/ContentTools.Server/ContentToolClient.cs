using ContentTools.Net;
using ContentTools.Net.Components;
using ContentTools.Net.Components.Interfaces;
using ContentTools.Net.Models;
using ContentTools.Net.Serializers;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ContentTools.Net
{
    public class ContentToolClient
    {

        private string _baseUrl;
        private string _token;
        private string _emailAccount;
        private int _projectId;
        private IDictionary<string, string> _filters = new Dictionary<string,string>(); 

        public IPublicContent Posts { get; private set; }
        public IDictionary<string, string> SetFilters {
            get { return _filters; }
            set { _filters = value; }
        }

        public ContentToolClient(string baseUrl, string token, string emailAccount, int projectId)
        {
            this._baseUrl = baseUrl;
            this._token = token;
            this._emailAccount = emailAccount;
            this._projectId = projectId;
            this.Posts = new PublicContent(this);
        }

        private RestClient CreateClient(string baseUrl)
        {
            var client = new RestClient(baseUrl);
            client.ClearHandlers();
            client.AddHandler("application/json", () => NewtonsoftJsonSerializer.Default);

            return client;
        }

        public T Execute<T>(RestRequest request, object objToBeSerialized = null, NewtonsoftJsonSerializer serializer = null) where T : new()
        {
            //Set Defaults for request
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = serializer != null ? serializer : NewtonsoftJsonSerializer.Default;
            request.AddHeader("Content-Type", "application/json");

            //Default params
            request.AddParameter("username", this._emailAccount);
            request.AddParameter("api_key", this._token);
            request.AddParameter("project__id__exact", this._projectId);

            //Custom params
            foreach (var filter in _filters)
                request.AddParameter(filter.Key, filter.Value);

            if (objToBeSerialized != null) request.AddJsonBody(objToBeSerialized);

            var client = CreateClient(_baseUrl);
            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var webApiException = new ApplicationException(message, response.ErrorException);
                throw webApiException;
            }
            return response.Data;
        }

        public T ExecuteURL<T>(string url, NewtonsoftJsonSerializer serializer = null) where T : new()
        {
            var request = new RestRequest();

            //Set Defaults for request
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = serializer != null ? serializer : NewtonsoftJsonSerializer.Default;
            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("username", this._emailAccount);
            request.AddParameter("api_key", this._token);
            request.AddParameter("project__id__exact", this._projectId);

            //Custom params
            foreach (var filter in _filters)
                request.AddParameter(filter.Key, filter.Value);

            var client = CreateClient(url);
            var response = client.Execute<T>(request);

            //Throw Error if Exception Occurred (Usually network issues)
            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var webApiException = new ApplicationException(message, response.ErrorException);
                throw webApiException;
            }
            return response.Data;
        }


    }
}
