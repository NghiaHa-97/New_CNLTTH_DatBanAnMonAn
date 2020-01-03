using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
namespace PM_DatBanAnMonAn.Public
{
    public class Service
    {
        public static object Get(string url, DataContractJsonSerializer data)
        {
            HttpWebRequest requet = WebRequest.CreateHttp(url);
            HttpWebResponse repon = requet.GetResponse() as HttpWebResponse;
            object repData = data.ReadObject(repon.GetResponseStream());
            return repData;
        }

        public static bool Post_Put_Delete(string method, string url, string pra)
        {
            string pra1 = pra;



            HttpWebRequest request = WebRequest.CreateHttp(url + pra);

            request.Method = method;
            request.ContentType = "Application/json;charset=UTF-8";
            byte[] byteArray = Encoding.UTF8.GetBytes(pra);
            request.ContentLength = byteArray.Length;
            Stream data = request.GetRequestStream();
            data.Write(byteArray, 0, byteArray.Length);
            data.Close();
            DataContractJsonSerializer datajson = new DataContractJsonSerializer(typeof(bool));

            object repon1 = datajson.ReadObject(request.GetResponse().GetResponseStream());
            return (bool)repon1;
        }
    }
}
