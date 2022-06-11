using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BikeProd
{
    public class WebRequestUtil
    {
        /// <summary>
        /// Author : 강지훈
        /// 이미지 데이터를 웹 서버에 저장하기 위한 메서드
        /// 이미지 Byte 배열을 JSON에 담아 POST 요청을 하기 위한 데이터를 준비한다.
        /// </summary>
        /// <param name="url">요청 경로</param>
        /// <param name="fileName">저장된 파일명</param>
        /// <param name="imageByte">이미지 byte 배열</param>
        public static void SaveImage(string url, string fileName, byte[] imageByte)
        {                        
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.Timeout = 30 * 1000;  // 30초 // ContentType은 지정된 것이 있으면 그것을 사용해준다.
            webRequest.ContentType = "application/json; charset=utf-8";

            string[] imageData = Array.ConvertAll(imageByte, Convert.ToString);

            // json을 string type으로 입력해준다.
            string postData = "{\"img\":" + $"\"{string.Join("-", imageData)}\"" + ", \"fileName\" :" + $"\"{fileName}\"" + " }";
            ReqPost(postData, webRequest);
        }

        public static byte[] GetImage(string url, string fileName)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.Timeout = 30 * 1000;
            webRequest.ContentType = "application/json; charset=utf-8";

            string postData = "{\"fileName\":" + $"\"{fileName}\"" + " }";
            string response = ReqPost(postData, webRequest);
            byte[] result = Array.ConvertAll(response.Split('-'), byte.Parse);
            return result;
        }

        /// <summary>
        /// Author : 강지훈
        /// 웹 서버에 에러 로그 등록
        /// </summary>
        /// <param name="url">로그 경로</param>
        /// <param name="msg">에러 메세지</param>
        /// <param name="stackTrace">에러 Strack Trace</param>
        public static void WriteErrLog(string url, string msg, string stackTrace)
        {
            string responseText = string.Empty;
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.Timeout = 30 * 1000;
            webRequest.ContentType = "application/json; charset=utf-8";

            Regex engRegex = new Regex(@"[a-zA-Z]");
            StringBuilder sb = new StringBuilder();
            foreach (char c in stackTrace)
            {
                if (char.IsDigit(c) || engRegex.IsMatch(c.ToString()) ||
                    char.GetUnicodeCategory(c) == System.Globalization.UnicodeCategory.OtherLetter || c == ' ')
                    sb.Append(c);
            }

            string postData = "{\"msg\":" + $"\"{msg}\"" + ", \"stack\" :" + $"\"{sb.ToString()}\"" + " }";
            ReqPost(postData, webRequest);
        }


        /// <summary>
        /// Author : 강지훈
        /// webRequest에 저장된 경로로 POST 요청을 수행하는 메서드
        /// </summary>
        /// <param name="postData">넘겨줄 JSON 데이터</param>
        /// <param name="webRequest">요청 정보</param>
        static string ReqPost(string postData, HttpWebRequest webRequest)
        {
            // 보낼 데이터를 byteArray로 바꿔준다.
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // 요청 Data를 쓰는 데 사용할 Stream 개체를 가져온다.
            Stream dataStream;
            try
            {
                dataStream = webRequest.GetRequestStream();
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // 호출단에 예외처리 필요
            }

            // Data를 전송한다.
            dataStream.Write(byteArray, 0, byteArray.Length);

            // dataStream 개체 닫기
            dataStream.Close();

            // 응답 받기
            string responseText = string.Empty;
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

            return responseText;
        }        
    }
}
