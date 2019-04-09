using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace BuilderPattern.Helpers
{
    public static class XmlConvertHelper
    {
        public static string SerializeObject<T>(T obj)
        {
            var ser = new XmlSerializer(obj.GetType());
            var sb = new StringBuilder();
            var sw = new StringWriter(sb);
            ser.Serialize(sw, obj);
            return sb.ToString();
        }
    }
}