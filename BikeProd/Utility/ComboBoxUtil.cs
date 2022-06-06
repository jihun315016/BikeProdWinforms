﻿using System;
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
    }
}
