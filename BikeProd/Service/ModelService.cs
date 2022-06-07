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
    public class ModelService
    {
        public List<CommonCodeVO> GetCategory()
        {
            MedelDAC dac = new MedelDAC();
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

                string url = "http://127.0.0.1:5000/saveImg";
                string[] temp = path.Split('\\');
                string fileName = temp[temp.Length - 1];

                try
                {
                    WebRequestUtil.SaveImage(url, fileName, imageByte);
                    product.Image = 1;
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }

            MedelDAC dac = new MedelDAC();
            bool result = dac.InsertProd(product, startCode);
            dac.Dispose();
            return result;
        }


        
    }
}
