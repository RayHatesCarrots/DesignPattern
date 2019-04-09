using System.Net;

namespace BuilderPattern.Models
{
    public class ResponseMessage<T>
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
    }
}