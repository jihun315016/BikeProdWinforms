using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd
{
    public class ProductService
    {
        public List<CommonCodeVO> GetCategory()
        {
            ProductDAC dac = new ProductDAC();
            List<CommonCodeVO> list = dac.GetCategory();
            dac.Dispose();
            return list;
        }

        public void ImageTest(string fileName, string path)
        {
            byte[] imageByte;

            // 1. FileSteam을 이용한 이미지 직렬화
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                imageByte = br.ReadBytes((int)fs.Length);
            }

            ReqPost(fileName, imageByte);
        }

        void ReqPost(string fileName, byte[] imageByte)
        {
            string url = "http://127.0.0.1:5000/saveImg";  //테스트 사이트            
            string responseText = string.Empty;
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.Timeout = 30 * 1000;  // 30초 // ContentType은 지정된 것이 있으면 그것을 사용해준다.
            webRequest.ContentType = "application/json; charset=utf-8";

            string[] imageData = Array.ConvertAll(imageByte, Convert.ToString);

            // json을 string type으로 입력해준다.
            string postData = "{\"img\":" + $"\"{string.Join("-", imageData)}\"" + ", \"fileName\" :" + $"\"{fileName}\"" + " }";
            //string postData = "{\"img\":" + $"\"{string.Join("-", imageData)}\"" + "}";

            // 보낼 데이터를 byteArray로 바꿔준다.
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // 요청 Data를 쓰는 데 사용할 Stream 개체를 가져온다.
            Stream dataStream = webRequest.GetRequestStream();

            // Data를 전송한다.
            dataStream.Write(byteArray, 0, byteArray.Length);

            // dataStream 개체 닫기
            dataStream.Close();

            // 응답 받기
            using (HttpWebResponse resp = (HttpWebResponse)webRequest.GetResponse())
            {
                HttpStatusCode status = resp.StatusCode; Console.WriteLine(status);
                // status 가 정상일경우 OK가 입력된다. 
                // 응답과 관련된 stream을 가져온다.
                Stream respStream = resp.GetResponseStream();
                using (StreamReader streamReader = new StreamReader(respStream))
                {
                    responseText = streamReader.ReadToEnd();
                }
            }
            Console.WriteLine(responseText);
        }
    }
}
