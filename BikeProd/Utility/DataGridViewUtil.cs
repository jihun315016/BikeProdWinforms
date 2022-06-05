using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeProd
{
    class DataGridViewUtil
    {
        /// <summary>
        /// Author : 강지훈
        /// DataGridView 기본 프레임 설정
        /// </summary>
        /// <param name="dgv">DataGricView 객체</param>
        public static void SetInitGridView(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersWidth = 10;
        }

        /// <summary>
        /// Author : 강지훈
        /// DataGridView에서 TextBoxColumn 설정
        /// </summary>
        /// <param name="dgv">DataGridView 이름</param>
        /// <param name="headerText">headerText 값</param>
        /// <param name="propertyName">propertyName 값</param>
        /// <param name="colWidth">칼럼 가로 길이</param>
        /// <param name="isVisible">Visible 여부</param>
        /// <param name="isReadlonly">Readlonly 여부</param>
        /// <param name="alignHeader">칼럼 정렬 방식</param>
        /// <param name="alignContent">내용 정렬 방식</param>
        public static void SetDataGridViewColumn_TextBox
            (
                DataGridView dgv,
                string headerText,
                string propertyName,
                int colWidth = 100,
                bool isVisible = true,
                bool isReadlonly = true,
                DataGridViewContentAlignment alignHeader = DataGridViewContentAlignment.MiddleCenter,
                DataGridViewContentAlignment alignContent = DataGridViewContentAlignment.MiddleLeft

            )
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = propertyName;
            col.Name = propertyName;
            col.ReadOnly = isReadlonly;
            col.Width = colWidth;
            col.HeaderCell.Style.Alignment = alignHeader;
            col.DefaultCellStyle.Alignment = alignContent;
            
            col.Visible = isVisible;

            dgv.Columns.Add(col);
        }
    }
}
