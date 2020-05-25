using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HZH_Controls.Controls;
using HZH_Controls.Forms;
using Weigh;

namespace Weigh1
{
    public partial class UCTestGridTable_CustomCell : UserControl, IDataGridViewCustomCell
    {
        public UCTestGridTable_CustomCell()
        {
            InitializeComponent();
        }
        private Gonglist cailist = null;

        public void SetBindSource(object obj)
        {
            if (obj is Gonglist)
            {
                cailist = (Gonglist)obj;
            }

        }
        //Fath.BarcodeX barCode = new Fath.BarcodeX();
        //public Image DrawBarCode(string serialNum, int width, int height)
        //{
        //    //创建条码生成对象
        //                                                //生成条形码
        //    barCode.Text = serialNum;//条码数据
        //    barCode.Symbology = Fath.bcType.Code128;//设置条码格式
        //    barCode.ShowText = true;//同时显示文本 
        //    return barCode.Image(width, height);
        //}

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {

           
            Token.once = cailist.orderno;
            DY page = new DY();
            page.ShowDialog();

        }

        private void ucBtnExt3_BtnClick(object sender, EventArgs e)
        {
            // if (Token.status == "4")
            // {
            Weighsumbit.createtime = cailist.createtime;
                Weighsumbit.orderno = cailist.orderno;
                Weighsumbit.catid = int.Parse(cailist.category);
                Weighsumbit.address = cailist.address;
                Weighsumbit.title = cailist.title;
            Weighsumbit.realprice = cailist.replyprice;
            Weighsumbit.amount = cailist.replyamount;
                Wie page = new Wie();
                page.ShowDialog();
            
           
                

            
                
           // }
           // else
           // {
           //     FrmTips.ShowTipsInfo(this.FindForm(), "供货单不在签收状态");
           // }

        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            Token.xq = 0;
            gonghuoxiangq.id = cailist.id;
            gonghuoxiangq.orderno = cailist.orderno;
            gonghuoxiangq.uid= cailist.uid;
            gonghuoxiangq.title = cailist.title;
            gonghuoxiangq.category = cailist.category;
            gonghuoxiangq.thumb = cailist.thumb;
            gonghuoxiangq.amount = cailist.amount;
            gonghuoxiangq.price = cailist.price;
            gonghuoxiangq.replyamount = cailist.replyamount;
            gonghuoxiangq.replyprice = cailist.replyprice;

            gonghuoxiangq.status = cailist.status;
            gonghuoxiangq.createtime= cailist.createtime;
            gonghuoxiangq.supplytime= cailist.supplytime;
            gonghuoxiangq.address = cailist.address;
            gonghuoxiangq.purchid  = cailist.purchid;
            gonghuoxiangq.nickname = cailist.nickname;
            gonghuoxiangq.mobile  = cailist.mobile;

            Xiang xiang = new Xiang();
            xiang.ShowDialog();
        }

        private void UCTestGridTable_CustomCell_Load(object sender, EventArgs e)
        {
            if (cailist.status == "发货中")
            {
               
            }
            else
            {
                
                //ucBtnExt2.Enabled = false;
                
                ucBtnExt3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));
                ucBtnExt3.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            ucBtnExt3.Enabled = false;}

        }
    }
}
