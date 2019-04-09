using System;
using System.Data.Common;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Factory Method Pattern ===========");

            using (var db1 = ConnectionFactory.Db1())
            {
                //TODO: do something for DB1
            }

            using (var db2 = ConnectionFactory.Db2())
            {
                //TODO: do something for DB2
            }

            var db3 = ConnectionFactory.Db3();
            //TODO: do something for DB3

            Console.WriteLine("=========== Factory Method Pattern(END) ===========");
            Console.ReadLine();
        }
    }
}
