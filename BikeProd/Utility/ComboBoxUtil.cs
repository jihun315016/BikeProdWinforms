using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeProd
{
    class ComboBoxUtil
    {
        /// <summary>
        /// Author : 강지훈
        /// 콤보박스 리스트 타입의 데이터로 데이터바인딩을 수행한다.
        /// </summary>
        /// <typeparam name="T">콤보박스의 DataSource로 사용되는 리스트 타입</typeparam>
        /// <param name="cmb">바인딩되는 콤보박스</param>
        /// <param name="list">콤보박스에 입력된 리스트 데이터</param>
        /// <param name="displayMember">콤보박스의 DisplayMember</param>
        /// <param name="valueMember">콤보박스의 ValueMember</param>
        public static void SetComboBoxByList<T>(ComboBox cmb, IEnumerable<T> list, string displayMember, string valueMember)
        {
            cmb.DataSource = list;
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
        }

        /// <summary>
        /// Author : 강지훈
        /// 필수 선택이지만 선택되지 않은 ccTextBox 컨트롤을 알려준다.
        /// </summary>
        /// <param name="cmbs">검사할 ComboBox 컨트롤 배열</param>
        /// <returns>
        /// 파라미터로 입력된 ComboBox가 모두 선택되었다면 빈 문자열 리턴
        /// 선택되지 않은 ComboBox가 있다면 해당 컨트롤의 Text 값을 담아 리턴
        /// </returns>
        public static string IsRequiredCheck(ComboBox[] cmbs)
        {
            StringBuilder sb = new StringBuilder();

            foreach (ComboBox cmb in cmbs)
            {
                if (cmb.SelectedIndex == 0)
                    sb.Append($"[{cmb.Text}] ");
            }

            if (sb.Length > 0)
                sb.Append($"{Environment.NewLine}필수 입력입니다.");
            return sb.ToString();
        }
    }
}
