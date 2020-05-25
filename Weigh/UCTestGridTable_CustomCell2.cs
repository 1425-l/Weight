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

namespace Weigh
{
    public partial class UCTestGridTable_CustomCell2 : UserControl, IDataGridViewCustomCell
    {
        public UCTestGridTable_CustomCell2()
        {
            InitializeComponent();
        }
        private Cailist cailist = null;

        public void SetBindSource(object obj)
        {
            if (obj is Cailist)
            {
                cailist = (Cailist)obj;
            }

        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            Token.xq = 1;
            gonghuoxiangq.id = cailist.id;
            gonghuoxiangq.orderno = cailist.orderno;
            gonghuoxiangq.uid = cailist.uid;
            gonghuoxiangq.title = cailist.title;
            gonghuoxiangq.category = cailist.category;
            gonghuoxiangq.thumb = cailist.thumb;
            gonghuoxiangq.replyamount = cailist.replyamount;
            gonghuoxiangq.replyprice = cailist.replyprice;
            gonghuoxiangq.status = cailist.status;
            gonghuoxiangq.createtime = cailist.createtime;
            gonghuoxiangq.supplytime = cailist.supplytime;
            gonghuoxiangq.address = cailist.address;
            gonghuoxiangq.purchid = cailist.purchid;
            gonghuoxiangq.nickname = cailist.nickname;
            gonghuoxiangq.mobile = cailist.mobile;

            Xiang xiang = new Xiang();
            xiang.ShowDialog();
        }
    }
}
