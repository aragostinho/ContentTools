using ContentTools.Net.Client;
using ContentTools.Net.Components.Interfaces;
using ContentTools.Net.Models;
using RestSharp;
using System;
using System.Collections.Generic;

namespace ContentTools.Net.Components
{
    public class PublicContent : BaseRest, IPublicContent
    {
        public PublicContent(ContentToolClient client)
            : base(client)
        {
            _baseRoute = "public_content";


        }

        private IDictionary<string, string> _filters = new Dictionary<string, string>();

        /// <summary>
        /// Add paginate filter
        /// </summary>
        /// <returns>paginate</returns>
        public void AddFilter(Paginate paginate)
        {
            _filters.Add(new KeyValuePair<string, string>("limit", paginate.Limit.ToString()));
            _filters.Add(new KeyValuePair<string, string>("offset", paginate.Offset.ToString()));
        }

        /// <summary>
        /// Add content type filter
        /// </summary>
        /// <returns>content_type__component</returns>
        public void AddFilter(ObjectContentType contentType)
        {
            _filters.Add(new KeyValuePair<string, string>("content_type__component", contentType.GetDescription()));
        }


        /// <summary>
        /// Add getDeletedContents filter
        /// </summary>
        /// <returns>getDeletedContents</returns>
        public void AddFilter(bool getDeletedContents = true)
        {
            if (getDeletedContents)
                _filters.Add(new KeyValuePair<string, string>("deleted__exact", "true"));
        }


        /// <summary>
        /// Add filter status
        /// </summary>
        /// <returns>status</returns>
        public void AddFilter(Status status)
        {
            _filters.Add(new KeyValuePair<string, string>("status", ((byte)status).ToString()));
        }

        /// <summary>
        /// Add filter status array
        /// </summary>
        /// <returns>status</returns>
        public void AddFilter(Status[] statusArray)
        {
            foreach (var status in statusArray)
                _filters.Add(new KeyValuePair<string, string>("status_in", ((byte)status).ToString()));
        } 

        /// <summary>
        /// Add limit status (Default is 20), max secure limit in 40 to prevent server error
        /// </summary>
        /// <returns>limit</returns>
        public void AddFilter(int limit)
        {
            if (limit <= 40)
            {
                _filters.Add(new KeyValuePair<string, string>("limit", (limit).ToString()));
            }
            else
            {
                throw new Exception("Filter limit exceeded, please set a value up to 40");
            }
        }

        /// <summary>
        /// Add publish_date__gt filter
        /// </summary>
        /// <returns>publish_date__gt</returns>
        public void AddFilter(DateTime? dategt, DateTime? datelt)
        { 
            if(dategt!=null)
           _filters.Add(new KeyValuePair<string, string>("publish_date__gt", dategt.Value.ToString(("yyyy'-'MM'-'dd'T'HH':'mm':'ss"))));

            if(datelt!=null)
            _filters.Add(new KeyValuePair<string, string>("publish_date__lt", datelt.Value.ToString(("yyyy'-'MM'-'dd'T'HH':'mm':'ss"))));
        }



        /// <summary>
        /// Add order_by (Default is 20) to order based on content property and the order type
        /// </summary>
        /// <param name="contentProperty">Property of the content.</param>
        /// <param name="orderType">Set as Ascending or Descending(Default=Ascending)</param>
        /// <returns>limitorder_by</returns>
        public void AddOrderBy(ContentProperty contentProperty, OrderType orderType = OrderType.Ascending)
        {
            if(orderType == OrderType.Ascending)
            {
                _filters.Add(new KeyValuePair<string, string>("order_by", contentProperty.GetDescription()));
            }
            else
            {
                _filters.Add(new KeyValuePair<string, string>("order_by", $"-{contentProperty.GetDescription()}"));
            }
        }

        /// <summary>
        /// List contents
        /// </summary>
        /// <returns>Return contents</returns>
        public Response Get()
        {
            var request = base.BuildRequest(Method.GET);
            _client.SetFilters = _filters;
            return _client.Execute<Response>(request);
        }
    }
}
