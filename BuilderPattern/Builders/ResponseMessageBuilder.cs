using BuilderPattern.Helpers;
using BuilderPattern.Models;
using Newtonsoft.Json;
using System.Net;

namespace BuilderPattern.Builders
{
    public class ResponseMessageBuilder<T>
    {
        private readonly ResponseMessage<T> _responseMessage;

        public ResponseMessageBuilder()
        {
            _responseMessage = new ResponseMessage<T>();
        }

        public ResponseMessageBuilder<T> SetHttpStatusCode(HttpStatusCode httpStatusCode)
        {
            _responseMessage.HttpStatusCode = httpStatusCode;
            return this;
        }

        public ResponseMessageBuilder<T> SetMessage(string message)
        {
            _responseMessage.Message = message;
            return this;
        }

        public ResponseMessageBuilder<T> SetData(T data)
        {
            _responseMessage.Data = data;
            return this;
        }

        public ResponseMessage<T> Build()
        {
            return _responseMessage;
        }

        public string BuildJsonResult()
        {
            return JsonConvert.SerializeObject(_responseMessage);
        }

        public string BuildXmlResult()
        {
            return XmlConvertHelper.SerializeObject(_responseMessage);
        }
    }
}