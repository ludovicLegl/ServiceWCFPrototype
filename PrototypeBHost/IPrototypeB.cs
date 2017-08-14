using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrototypeBHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IprototypeB" in both code and config file together.
    [ServiceContract]
    public interface IprototypeB
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
           RequestFormat = WebMessageFormat.Xml,
           ResponseFormat = WebMessageFormat.Xml,
           BodyStyle = WebMessageBodyStyle.Wrapped,
           UriTemplate = "xml/{id}")]
        string XmlData(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "json/{id}")]
        string JsonData(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "Test")]
        List<Test> GetPatientList();

        [OperationContract]
        [WebInvoke(Method = "GET",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "Test/{id}")]
        Test GetTestId(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "AddTest")]
        void AddTest(Test test);

        [OperationContract]
        [WebInvoke(Method = "PUT",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "UpdateTest")]
        void UpdateTest(Test test);

        [OperationContract]
        [WebInvoke(Method = "DELETE",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "DeleteTest")]
        void DeleteTest(Test test);

        /*  [OperationContract]
          string SayHelloTo(string name);

          [OperationContract]
         PrototypeBData GetHelloData(PrototypeBData helloWorldData);*/

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
   /* [DataContract]
    public class PrototypeBData
    {
        public PrototypeBData()
        {
            Name = "Hello ";
            SayHello = false;
        }

        [DataMember]
        public bool SayHello { get; set; }

        [DataMember]
        public string Name { get; set; }
    }*/
}
