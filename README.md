# ContentTools .NET SDK
.Net SKD for ContentTools Rest API.

## About ContentTools
It's a CMS platform to centralize  content marketing operation: plan, manage, collaborate, publish. All in one place giving up email threads, spreadsheets, and lack of data. 

Site: https://contentools.com

## About Contentools Integration API Version 1
With Contentools Integration API, one can make requests to our software through a defined endpoint and retrieve data from their project. As of the API version 1, it is only possible to retrieve data through GET requests as long as it is an authenticated request. The request should be filled in the following format, adjusting with the company name as present in the software URL and desired endpoint.

For instance: https://[accountname].contentools.com/api/v1/[endpoint]
Every response will come in JSON format with the data organized in Javascript objects.

For more information see [V1 API Documentation](https://github.com/aragostinho/ContentTools/blob/master/slnContentToolsApi/Docs/Contentools%20REST%20API%20-%20V1.pdf~).

## About ContentTools .NET SDK
It's a SDK Rest API  developed in .Net Framework 4.6+ consuming Contentools API Version 1.

### How to setup it
 The method ContentToolClient(string baseUrl, string token, string emailAccount, int projectId)
 - baseUrl =  https://[accountname].contentools.com/api/v1/[endpoint]
 - token   = The API Token that needs to configure on ContentTools platform. For more information see [here](https://help.contentools.com/knowledge/how-to-configure-an-access-token-for-contentools-api-integration).
 - emailAccount = Your email account on Content Tools platform.
 - projectId = Your content project id on Content Tools. 

In ContentTools.Client console project there is a good example using appSettings keys.

### How to use
All the code is very didactic and clean to understating.
Enjoy it :)

