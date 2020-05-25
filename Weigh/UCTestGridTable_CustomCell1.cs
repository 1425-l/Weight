using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls.Controls;
using Weigh1;
using HZH_Controls.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Weigh
{
    public partial class UCTestGridTable_CustomCell1 : UserControl, IDataGridViewCustomCell
    {
        public UCTestGridTable_CustomCell1()
        {
            InitializeComponent();
        }
        private JJlu cailist = null;

        public void SetBindSource(object obj)
        {
            if (obj is JJlu)
            {
                cailist = (JJlu)obj;
            }

        }

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            //if (cailist.status == "打款中")
            //{
                Weighsumbit.orderno = cailist.orderno;
                Weighsumbit.catid = int.Parse(cailist.catid);
                Packagenos sign = new Packagenos();
                sign.ShowDialog();
            //}
            //else
            //{

               // FrmTips.ShowTipsInfo(this.FindForm(), "供货单不在签收状态");
            //}

        }

        private void UCTestGridTable_CustomCell1_Load(object sender, EventArgs e)
        {
            if (cailist.is_packageno == "1")
            {
                
            }
            else
            {

                ucBtnExt1.Enabled = false;
                //ucBtnExt3.Enabled = false;
            }
        }
        string token = Token.token;
        Apiweb apiweb = new Apiweb();
        string ss = "";
        string api = "";
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            Weighsumbit.orderno = cailist.orderno;
            kuang sign = new kuang();
            sign.ShowDialog();
           
        }
    }
}
