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
            ModelDAC dac = new ModelDAC();
            List<CommonCodeVO> list = dac.GetCategory();
            dac.Dispose();
            return list;
        }

        /// <summary>
        /// Author : 강지훈
        /// 제품과 부품에 대한 기본적인 정보를 조회하여 폼에 전달한다.
        /// </summary>
        /// <returns></returns>
        public List<ProdPartVO> GetModelList()
        {
            ModelDAC dac = new ModelDAC();
            List<ProdPartVO> list = dac.GetModelList();
            dac.Dispose();
            return list;
        }

        /// <summary>
        /// Author : 강지훈
        /// 부품 코드에 대한 거래처명과 재고 정보를 조회 후 폼에 전달한다.
        /// </summary>
        /// <param name="PartCode"></param>
        /// <returns></returns>
        public PartVO GetPartClientAndQtyInfo(string PartCode)
        {
            ModelDAC dac = new ModelDAC();
            PartVO part = dac.GetPartClientAndQtyInfo(PartCode);
            dac.Dispose();
            return part;
        }

        /// <summary>
        /// Author : 강지훈
        /// 제품 코드에 대한 LeadTime 조회 후 폼에 전달한다.
        /// </summary>
        /// <param name="ProdCode"></param>
        /// <returns></returns>
        public int GetProdLeadTime(string ProdCode)
        {
            ModelDAC dac = new ModelDAC();
            int leadTime = dac.GetProdLeadTime(ProdCode);
            dac.Dispose();
            return leadTime;
        }

        /// <summary>
        /// Author : 강지훈
        /// BOM 등록되었거나 등록되지 않은 제품 조회 후 폼에 전달한다.
        /// </summary>
        /// <returns></returns>
        public List<ProdPartVO> GetBomProd(bool isBom)
        {
            ModelDAC dac = new ModelDAC();
            List<ProdPartVO> list = dac.GetBomProd(isBom);
            dac.Dispose();
            return list;
        }

        /// <summary>
        /// Author : 강지훈
        /// 특정 제품에 대한 정전개와 역전개 조회 후 폼에 전달한다.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<BomRelationVO> GetBomRelation(string code)
        {
            ModelDAC dac = new ModelDAC();
            List<BomRelationVO> list = dac.GetBomRelation(code);
            dac.Dispose();
            return list;
        }

        /// <summary>
        /// Author : 강지훈
        /// BOM 등록을 위해 부품과 반제품 정보 또는 부품 정보만 조회하여 폼에 전달한다.
        /// </summary>
        /// <param name="isGetSemiProd">반제품 정보도 조회할지 여부</param>
        /// <returns></returns>
        public List<ProdPartVO> GetPartAndSemiProd(bool isGetSemiProd)
        {
            ModelDAC dac = new ModelDAC();
            List<ProdPartVO> list = dac.GetPartAndSemiProd(isGetSemiProd);
            dac.Dispose();
            return list;
        }

        /// <summary>
        /// Author : 강지훈
        /// BOM 등록 후 결과 반환
        /// </summary>
        /// <param name="parentCode">BOM 등록될 상위 항목</param>
        /// <param name="list">하위 항목 리스트</param>
        /// <returns></returns>
        public bool SaveBom(string parentCode, List<BomRelationVO> list)
        {
            ModelDAC dac = new ModelDAC();
            bool result = dac.SaveBom(parentCode, list);
            dac.Dispose();
            return result;

        }

        /// <summary>
        /// Author : 강지훈
        /// 제품 또는 부품 등록 Service
        /// 이미지가 포함되었는지 확인하고, 포함되었다면 웹 서버에 이미지 데이터를 저장한다.
        /// </summary>
        /// <param name="product">등록할 제품 정보, 부품 등록이라면 null</param>
        /// <param name="part">등록할 부품 정보, 제품 등록이라면 null</param>
        /// <param name="startCode">제품 코드</param>
        /// <param name="path">이미지 로컬 경로</param>
        /// <returns></returns>
        public bool SaveModel(ProductVO product, PartVO part, string startCode, string path)
        {
            string fileName = product == null ? part.PartName : product.ProdName;
            IsExistImageAndSave(path, fileName);

            ModelDAC dac = new ModelDAC();
            bool result = dac.SaveModel(product, part, startCode);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// Author : 강지훈
        /// 제품 또는 부품 등록시 이미지가 포함되었는지 검사한다.
        /// 이미지가 포함되었다면 이미지 byte[] 배열을 웹서버에 전송한다.
        /// </summary>
        /// <param name="path">이미지 로컬 경로</param>
        /// <param name="fileName">저장할 파일명</param>
        /// <returns>이미지 포함 유무</returns>
        /// <exception cref="Exception">웹서버가 꺼져있는지 확인할 것</exception>
        void IsExistImageAndSave(string path, string fileName)
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

                string url = "http://jihun3100.pythonanywhere.com/saveImg";

                try
                {
                    WebRequestUtil.SaveImage(url, fileName, imageByte);
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
            }            
        }

        /// <summary>
        /// Author : 강지훈
        /// 제품 및 부품 수정
        /// </summary>
        /// <param name="code"></param>
        /// <param name="price"></param>
        /// <param name="leadTime"></param>
        /// <param name="path"></param>
        /// <param name="fileName"></param>
        /// <param name="part"></param>
        /// <returns></returns>
        public bool UpdateProdPart(string code, int price, int leadTime, string path, string fileName, PartVO part)
        {
            IsExistImageAndSave(path, fileName);
            int isImage = path == string.Empty? 0 : 1; // 이미지 수정 유무

            ModelDAC dac = new ModelDAC();
            bool result = dac.UpdateProdPart(code, price, leadTime, part, isImage);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// Author : 강지훈
        /// 제품 및 부품 폐기 처리 및 재등록 후 폼에 결과 전달
        /// </summary>
        /// <param name="code">작업 모델 코드</param>
        /// <param name="isProd">제품인지 부품인지 여부</param>
        /// <param name="changedValue">수정할 Dealing 값</param>
        /// <returns></returns>
        public bool UpdateModelDealing(string code, bool isProd, int changedValue)
        {
            ModelDAC dac = new ModelDAC();
            bool result = dac.UpdateModelDealing(code, isProd, changedValue);
            dac.Dispose();
            return result;
        }
    }
}
