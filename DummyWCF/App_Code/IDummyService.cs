using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDummyService" in both code and config file together.
[ServiceContract]
public interface IDummyService
{
	[OperationContract]
    [WebGet(ResponseFormat = WebMessageFormat.Json,UriTemplate = "/DoWork/{id}/{time}")]
	string DoWork(string id, string time);
}
