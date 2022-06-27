using BikeProd.DAC;
using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd
{
    public class ClientService
    {
        /// <summary>
        /// Author : 강지훈
        /// 입고 또는 출고 거래처의 사업자 번호와 이름을 가져와 폼에 전달
        /// </summary>
        /// <param name="isCustomer">출고처인지 여부</param>
        /// <returns></returns>
        public List<ClientVO> GetClientNameByType(bool isCustomer)
        {
            string clientType = (isCustomer) ? "출고" : "입고";
            ClientDAC dac = new ClientDAC();
            List<ClientVO> list = dac.GetClientNameByType(clientType);
            dac.Dispose();
            return list;
        }

        /// <summary>
        /// Author : 이진형
        /// 모든 거래처 정보 전달 
        /// </summary>
        /// <returns></returns>
        public List<ClientVO> GetClientList()
        {
            ClientDAC dac = new ClientDAC();
            List<ClientVO> result = dac.GetClientList();
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// 입력된 거래처 정보 등록
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public bool SaveClient(ClientVO client)
        {
            ClientDAC dac = new ClientDAC();
            bool result = dac.SaveClient(client);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// Author : 이진형
        /// 선택된 거래처 정보 삭제
        /// </summary>
        /// <param name="clientName"></param>
        /// <returns></returns>
        public bool DeleteClient(string clientName)
        {
            ClientDAC dac = new ClientDAC();
            bool result = dac.DeleteClient(clientName);
            dac.Dispose();
            return result;
        }

        /// <summary>
        /// Author : 이진형
        /// 거래처 등록을 위한 사업자 번호 체크 정보를 폼에 전달
        /// </summary>
        /// <param name="BusinessNo"></param>
        /// <returns></returns>
        public ClientVO GetBusinessNo(string BusinessNo)
        {
            ClientDAC dac = new ClientDAC();
            ClientVO B_no = dac.GetBusinessNo(BusinessNo);
            dac.Dispose();
            return B_no;
        }

        /// <summary>
        /// Author : 이진형
        /// 거래처 삭제를 위한 거래상태, 제품, 부품의 등록 상태를 폼에 전달
        /// </summary>
        /// <param name="BusinessNO"></param>
        /// <returns></returns>
        public bool ChkClient(string BusinessNO)
        {
            ClientDAC dac = new ClientDAC();
            bool result = dac.ChkClient(BusinessNO);
            dac.Dispose();

            return result;
        }
    }

}
