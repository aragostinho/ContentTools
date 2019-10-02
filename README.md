# ContentTools .NET SDK
.Net SKD for ContentTools Rest API.

## About ContentTools
It's a CMS platform to centralize  content marketing operation: plan, manage, collaborate, publish. All in one place giving up email threads, spreadsheets, and lack of data. 

Site: https://contentools.com

## About Contentools Integration API Version 1
With Contentools Integration API, one can make requests to our software through a defined endpoint and retrieve data from their project. As of the API version 1, it is only possible to retrieve data through GET requests as long as it is an authenticated request. The request should be filled in the following format, adjusting with the company name as present in the software URL and desired endpoint.

For instance: https://[accountname].contentools.com/api/v1/[endpoint]
Every response will come in JSON format with the data organized in Javascript objects.

For more information see [V1 API Documentation](https://github.com/aragostinho/ContentTools/blob/master/slnContentToolsApi/Docs/Contentools%20REST%20API%20-%20V1.pdf).

## About ContentTools .NET SDK
It's a SDK Rest API  developed in .Net Framework 4.6+ consuming Contentools API Version 1.

### Dependencies
- .Net framework 4.6.1
- Newtonsoft.Json 12.0.2
- RestSharp 106.6.10

### How to setup it
Just call the method ContentToolClient(string baseUrl, string token, string emailAccount, int projectId) with the following parameters:
 - baseUrl =  https://[accountname].contentools.com/api/v1/[endpoint]
 - token   = The API Token that needs to configure on ContentTools platform. For more information see [here](https://help.contentools.com/knowledge/how-to-configure-an-access-token-for-contentools-api-integration).
 - emailAccount = Your email account on Content Tools platform.
 - projectId = Your content project id on Content Tools. 

In ContentTools.Client console project there is a good example using appSettings keys.

### Returning values
After setup, the object instanced *ContentToolClient* has the property *Posts* that connects to endpoint *public_content*.
Using the method *Get()* it's enought to return data from ContentTools.
``` 
ContentToolClient client = new ContentToolClient(baseUrl, token, emailAccount, projectId);
var posts = client.Posts.Get();
``` 

### Using filters
Use the method *AddFilter()* with the following signatures to filter contents:
``` 
void AddFilter(ContentType contentType);
void AddFilter(Paginate paginate);
void AddFilter(bool getDeletedContents = true);
void AddFilter(Status status);
void AddFilter(DateTime? dategt, DateTime? datelt)
``` 
#### ContentType filter
A Enum with the following definations:
```
[Description("blog-post")]
blogpost,
[Description("page")]
page,
[Description("social-post")]
socialpost,
[Description("webinar")]
webinar,
[Description("ebook")]
ebook,
[Description("Newsletter")]
newsletter
``` 

#### Paginate filter
A class with two main properties that possibiliy paginate contents.
*Limit* to define how many records should be return and *Offset* a number of records to skype
``` 
public int Limit { get; set; }      
public int Offset { get; set; }
``` 

#### GetDeletedContents filter
A boolean property to able Rest API return deleted contents.  *False is default*
``` 
bool getDeletedContents = false
``` 

#### Status filter
A Enum with the following definations:
``` 
[Description("In progress")]
InProgress = 1,
[Description("Finished")]
Finished = 2,
[Description("Archived")]
Archived = 3,
[Description("Published")]
Published = 4,
[Description("Delayed")]
Delayed = 5,
[Description("Scheduled")]
Scheduled = 6
```      
        
#### DateTime filter
A date range with optional startDate and endDate.
``` 
DateTime? dategt, DateTime? datelt
``` 

### How to use
All the code is very didactic and clean to understating.
Enjoy it :)

