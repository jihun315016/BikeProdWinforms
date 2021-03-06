using BikeProd.DAC;
using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd
{
    internal class ProductionService
    {
        /// <summary>
        /// Author : 강지훈
        /// 주문 처리 후 생산해야 하는 제품 리스트 전달
        /// </summary>
        /// <returns></returns>
        public List<BomInfoVO> GetOrderedProd()
        {
            ProductionDAC dac = new ProductionDAC();
            List<BomInfoVO> list = dac.GetOrderedProd();
            dac.Dispose();
            return list;
        }

        /// <summary>
        /// Author : 강지훈
        /// 특정 제품에 대한 정전개를 부품 단위로 조회
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public List<BomInfoVO> GetPartsByProd(string code)
        {
            ProductionDAC dac = new ProductionDAC();
            List<BomInfoVO> list = dac.GetPartsByProd(code);
            dac.Dispose();
            return list;
        }

        /// <summary>
        /// Author : 강지훈
        /// 생산 부서 소속 팀 리스트 조회
        /// </summary>
        /// <returns></returns>
        public List<TeamVO> GetProductionTeeamList()
        {
            DepartmentDAC dac = new DepartmentDAC();
            List<TeamVO> list = dac.GetProductionTeeamList( );
            dac.Dispose();
            return list;
        }

        public List<ProductionVO> GetProductionList(DateTime start, DateTime end, string state = "", string team = "")
        {
            ProductionDAC dac = new ProductionDAC();
            List<ProductionVO> list = dac.GetProductionList(start, end, state, team);
            dac.Dispose();          
            return list;
        }

        /// <summary>
        /// Author : 강지훈
        /// </summary>
        /// <param name="production"></param>
        /// <returns></returns>
        public bool SaveProduction(ProductionVO production, List<BomInfoVO> partList)
        {
            ProductionDAC dac = new ProductionDAC();
            bool result = dac.SaveProduction(production, partList);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// Author : 강지훈
        /// 생산 완료 또는 취소 처리
        /// </summary>
        /// <param name="isComplete"></param>
        /// <param name="id"></param>
        /// <param name="prodCode"></param>
        /// <param name="loss"></param>
        /// <returns></returns>
        public bool UpdateProductionState(bool isComplete, int id, string prodCode, int loss = -1)
        {
            ProductionDAC dac = new ProductionDAC();
            bool result = dac.UpdateProductionState(isComplete, id, prodCode, loss);
            dac.Dispose();
            return result;
        }
    }
}
