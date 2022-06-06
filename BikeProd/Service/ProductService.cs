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

        /// <summary>
        /// Author : 강지훈
        /// 제품 등록 Service
        /// 이미지가 포함되었는지 확인하고, 포함되었다면 웹 서버에 이미지 데이터를 저장한다.
        /// </summary>
        /// <param name="product">등록할 제품 정보</param>
        /// <param name="startCode">제품 코드</param>
        /// <param name="path">이미지 로컬 경로</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool InsertProd(ProductVO product, string startCode, string path)
        {
            // 이미지 포함 유무 체크
            if (!string.IsNullOrWhiteSpace(path))
            {
                byte[] imageByte;

                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    BinaryReader br = new BinaryReader(fs);
                    imageByte = br.ReadBytes((int)fs.Length);
                }

                string[] temp = path.Split('\\');
                string fileName = temp[temp.Length - 1];

                try
                {
                    ReqPost(fileName, imageByte);
                    product.Image = 1;
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }

            ProductDAC dac = new ProductDAC();
            bool result = dac.InsertProd(product, startCode);
            dac.Dispose();
            return result;
        }


        /// <summary>
        /// Author : 강지훈
        /// 이미지 데이터를 웹 서버에 저장하기 위한 메서드
        /// Body에 JSON 데이터를 넣어 Post 요청
        /// </summary>
        /// <param name="fileName">저장될 파일명</param>
        /// <param name="imageByte">이미지 Byte 데이터</param>
        void ReqPost(string fileName, byte[] imageByte)
        {                       
            string url = "http://127.0.0.1:5000/saveImg";
            string responseText = string.Empty;
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.Timeout = 30 * 1000;  // 30초 // ContentType은 지정된 것이 있으면 그것을 사용해준다.
            webRequest.ContentType = "application/json; charset=utf-8";

            string[] imageData = Array.ConvertAll(imageByte, Convert.ToString);

            // json을 string type으로 입력해준다.
            string postData = "{\"img\":" + $"\"{string.Join("-", imageData)}\"" + ", \"fileName\" :" + $"\"{fileName}\"" + " }";

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
