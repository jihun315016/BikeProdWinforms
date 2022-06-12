using BikeProd.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeProd
{
    public partial class popSavePur : bPopCommon
    {
        List<PartVO> partList = null;
        List<CommonCodeVO> commonList = null;
        PurchaseService purchaseSrv = null;
        public popSavePur()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void popAddBalJu_Load(object sender, EventArgs e)
        {
            purchaseSrv = new PurchaseService();
            commonList = purchaseSrv.getCategory();
            commonList.Insert(0, new CommonCodeVO()
            {
                Category = "선택",
                
            });
            ComboBoxUtil.SetComboBoxByList(cboCate, commonList, "Category", "Category");
            cboCate.SelectedIndex = 0;
        }

        private void cboCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            purchaseSrv = new PurchaseService();
            if (cboCate.SelectedIndex < 1) return;
            string Cate = cboCate.SelectedIndex.ToString();
            if (commonList == null)
            {
                commonList = purchaseSrv.getModelList(Cate);
            }

            //전체 productList 중에서 선택된 카테고리에 해당하는 제품목록을 보여줘야 한다.
            var ModelList = (from Common in commonList
                             where Common.Category == cboCate.SelectedValue.ToString()
                             select new CommonCodeVO
                             {
                                 Code = Common.Code,
                                 Category = Common.Category,
                                 Name = Common.Name,
                             }).ToList();

            //List<CommonCodeVO> ModelList = commonList.Where((s) =>s.Category == cboCate.ToString()).ToList();
            //string name = ModelList.Find((c) => c.Category == cboCate.SelectedValue.ToString()).Name;

            //var list = commonList.Where<CommonCodeVO>((e) => e.Category.Equals(Cate)).ToList();
            ComboBoxUtil.CategoryComboBinding(cboModel, ModelList, Cate);
        }

        private void chkNull_CheckedChanged(object sender, EventArgs e)
        {
            dtpAliveDate.Value = DateTime.MaxValue;
        }

        private void txtBusiness_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusiness_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtBusiness_Enter(object sender, EventArgs e)
        {
            popSearchClient pop = new popSearchClient(false);
            pop.ShowDialog();
        }
    }
}
