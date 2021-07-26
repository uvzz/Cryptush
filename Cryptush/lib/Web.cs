using System.IO;
using System.Net;
using System.Text;

namespace Cryptush.lib
{
    class Web
    {
        public static string SendRequest(string JsonData, string EndPoint)
        {
            string response = "";
            byte[] dataStream = Encoding.UTF8.GetBytes(JsonData);
            WebRequest webRequest = WebRequest.Create(Cryptush.url + EndPoint);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = dataStream.Length;
            Stream newStream = webRequest.GetRequestStream();
            newStream.Write(dataStream, 0, dataStream.Length);
            newStream.Close();
            WebResponse webResponse = webRequest.GetResponse();
            using (var reader = new StreamReader(webResponse.GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }
            return response;
        }
    }
}
