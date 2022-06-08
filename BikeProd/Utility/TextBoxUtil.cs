using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProd
{
    class TextBoxUtil
    {
        /// <summary>
        /// Author : 강지훈
        /// 필수 입력이지만 아무것도 입력되지 않은 ccTextBox 컨트롤을 알려준다.
        /// </summary>
        /// <param name="txts">검사할 ccTextBox 컨트롤 배열</param>
        /// <returns>
        /// isRequired 처리된 ccTextBox가 모두 입력되었다면 빈 문자열 리턴,
        /// 입력되지 않은 게 있다면 해당 컨트롤의 태그 값을 담아 리턴
        /// </returns>
        public static string IsRequiredCheck(ccTextBox[] txts)
        {
            StringBuilder sb = new StringBuilder();

            foreach (ccTextBox txt in txts)
            {
                if (txt.isRequired)
                {
                    if (string.IsNullOrEmpty(txt.Text) || txt.Text.Equals(txt.PlaceHolder))
                        sb.Append($"[{txt.Tag}] ");
                }
            }

            if (sb.Length > 0)            
                sb.Append($"{Environment.NewLine}필수 입력입니다.");
            return sb.ToString();
        }
    }
}
