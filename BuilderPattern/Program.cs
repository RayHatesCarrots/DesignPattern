using BuilderPattern.Builders;
using BuilderPattern.Models;
using System;
using System.Net;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=========== Builder Pattern ===========");

            var rspBuilder1 =
                    new ResponseMessageBuilder<string>()
                        .SetHttpStatusCode(HttpStatusCode.OK)
                        .SetData("Success");

            Console.WriteLine($"ResponseMessage1 JsonResult: {rspBuilder1.BuildJsonResult()}");
            Console.WriteLine($"ResponseMessage1 XmlResult: {rspBuilder1.BuildXmlResult()}");
            Console.WriteLine();

            var rspBuilder2 =
                new ResponseMessageBuilder<string>()
                    .SetHttpStatusCode(HttpStatusCode.BadRequest)
                    .SetMessage("Invalid token");

            Console.WriteLine($"ResponseMessage2 JsonResult: {rspBuilder2.BuildJsonResult()}");
            Console.WriteLine($"ResponseMessage2 XmlResult: {rspBuilder2.BuildXmlResult()}");
            Console.WriteLine();

            var rspBuilder3 =
                new ResponseMessageBuilder<Member>()
                    .SetHttpStatusCode(HttpStatusCode.OK)
                    .SetData(new Member("member", 50m));

            Console.WriteLine($"ResponseMessage3 JsonResult: {rspBuilder3.BuildJsonResult()}");
            Console.WriteLine($"ResponseMessage3 XmlResult: {rspBuilder3.BuildXmlResult()}");
            Console.WriteLine();

            Console.WriteLine("=========== Builder Pattern(END) ===========");

            Console.ReadLine();
        }
    }
}