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


            //ở đây; đầu tiên là http request gửi từ clien nên server
            HttpWebRequest request = WebRequest.CreateHttp(url + pra);
            //kiểu method
            request.Method = method;

            // định dang trả về
            request.ContentType = "Application/json;charset=UTF-8";
            //gửi dữ liệu dưới dạng byte nên server theo chuỗi (pra) đó
            byte[] byteArray = Encoding.UTF8.GetBytes(pra);
            request.ContentLength = byteArray.Length;

            //đọc dữ liệu
            Stream data = request.GetRequestStream();
            data.Write(byteArray, 0, byteArray.Length);
            data.Close();
            DataContractJsonSerializer datajson = new DataContractJsonSerializer(typeof(bool));

            object repon1 = datajson.ReadObject(request.GetResponse().GetResponseStream());
            return (bool)repon1;
        }
    }
}
