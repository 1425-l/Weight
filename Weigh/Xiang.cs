using HZH_Controls.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weigh1;

namespace Weigh
{
    public partial class Xiang : Form
    {
        public Xiang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string token = Token.token;
        Apiweb apiweb = new Apiweb();
        string ss = "";
        string api = "";
        private void Kuanghao()
        {
            try
            {
                api = string.Format("http://wy.bii.cn/api/purchase/packagelist" +
                "?token={0}&orderno={1}"
                , token, gonghuoxiangq.orderno);

                string getapi = apiweb.HttpPost(api);
                JObject json3 = (JObject)JsonConvert.DeserializeObject(getapi);
                string msg = json3["data"].ToString();
                string ms = json3["msg"].ToString();
                if (ms == "操作成功")
                {
                    msg = "";
                    JArray array = (JArray)json3["data"];
                    foreach (var item in array)
                    {
                        msg += " " + item;
                    }
                    kuang.Text = "     框号列表：" + msg;
                    if (kuang.Left + kuang.Width > this.Width + 10)
                    {

                    }
                    if(msg == "")
                    {
                        Token.xq = 2;

                    }

                }
                else
                {
                    Token.xq = 3;
                    
                    //FrmTips.ShowTipsWarning(this.FindForm(), ms);
                }
                
            }
            catch (Exception)
            {

                FrmTips.ShowTipsWarning(this.FindForm(), "网络连接已断开！");
            }
        }
        private void Xiang_Load(object sender, EventArgs e)
        {
            if(Token.xq == 1)
            {
                label3.Visible = false;
               
                panel3.Visible = false;
                panel5.Visible = false;
                label8.Visible = false;
                panel6.Visible = false;
                panel1.Visible = false;
                this.Height = 250;
                this.Height = 250;
                //id.Text ="编号："+ gonghuoxiangq.id;
                orderno.Text = "流水号：" + gonghuoxiangq.orderno;
                //uid.Text = "编号：" + gonghuoxiangq.uid;
                title.Text = "名称：" + gonghuoxiangq.title;
                //category.Text = "分类：" + gonghuoxiangq.category;
                //thumb.Text = "图片：" + gonghuoxiangq.thumb;
                amount.Text = "数量：" + gonghuoxiangq.replyamount;
                price.Text = "单价：" + gonghuoxiangq.replyprice;
                status.Text = "状态：" + gonghuoxiangq.status;
                createtime.Text = "创建时间：" + gonghuoxiangq.createtime;
                supplytime.Text = "提交时间：" + gonghuoxiangq.supplytime;
                address.Text = "地址：" + gonghuoxiangq.address;
                //purchid.Text = "编号：" + gonghuoxiangq.purchid;
                nickname.Text = "用户名：" + gonghuoxiangq.nickname;
                mobile.Text = "电话：" + gonghuoxiangq.mobile;
                Kuanghao();
                jiben1();

            }
            else
            {
                //id.Text ="编号："+ gonghuoxiangq.id;
                orderno.Text = "流水号：" + gonghuoxiangq.orderno;
                //uid.Text = "编号：" + gonghuoxiangq.uid;
                title.Text = "名称：" + gonghuoxiangq.title;
                //category.Text = "分类：" + gonghuoxiangq.category;
                //thumb.Text = "图片：" + gonghuoxiangq.thumb;
                amount.Text = "数量：" + gonghuoxiangq.replyamount;
                price.Text = "单价：" + gonghuoxiangq.replyprice;
                status.Text = "状态：" + gonghuoxiangq.status;
                createtime.Text = "创建时间：" + gonghuoxiangq.createtime;
                supplytime.Text = "提交时间：" + gonghuoxiangq.supplytime;
                address.Text = "地址：" + gonghuoxiangq.address;
                //purchid.Text = "编号：" + gonghuoxiangq.purchid;
                nickname.Text = "用户名：" + gonghuoxiangq.nickname;
                mobile.Text = "电话：" + gonghuoxiangq.mobile;
                Kuanghao();
                jiben1();
                if (Token.xq == 3)
                {
                    label3.Visible = false;

                    panel3.Visible = false;
                    panel5.Visible = false;
                    label8.Visible = false;
                    panel6.Visible = false;
                    panel1.Visible = false;
                    this.Height = 250;
                    this.Height = 250;
                    //id.Text ="编号："+ gonghuoxiangq.id;
                    orderno.Text = "流水号：" + gonghuoxiangq.orderno;
                    //uid.Text = "编号：" + gonghuoxiangq.uid;
                    title.Text = "名称：" + gonghuoxiangq.title;
                    //category.Text = "分类：" + gonghuoxiangq.category;
                    //thumb.Text = "图片：" + gonghuoxiangq.thumb;
                    amount.Text = "数量：" + gonghuoxiangq.replyamount;
                    price.Text = "单价：" + gonghuoxiangq.replyprice;
                    status.Text = "状态：" + gonghuoxiangq.status;
                    createtime.Text = "创建时间：" + gonghuoxiangq.createtime;
                    supplytime.Text = "提交时间：" + gonghuoxiangq.supplytime;
                    address.Text = "地址：" + gonghuoxiangq.address;
                    //purchid.Text = "编号：" + gonghuoxiangq.purchid;
                    nickname.Text = "用户名：" + gonghuoxiangq.nickname;
                    mobile.Text = "电话：" + gonghuoxiangq.mobile;
                    Kuanghao();
                    jiben1();
                }
                if (Token.xq == 2)
                {
                    label8.Visible = false;
                    panel6.Visible = false;
                    panel1.Visible = false;
                    this.Height = 450;
                    //id.Text ="编号："+ gonghuoxiangq.id;
                    orderno.Text = "流水号：" + gonghuoxiangq.orderno;
                    //uid.Text = "编号：" + gonghuoxiangq.uid;
                    title.Text = "名称：" + gonghuoxiangq.title;
                    //category.Text = "分类：" + gonghuoxiangq.category;
                    //thumb.Text = "图片：" + gonghuoxiangq.thumb;
                    amount.Text = "数量：" + gonghuoxiangq.replyamount;
                    price.Text = "单价：" + gonghuoxiangq.replyprice;
                    status.Text = "状态：" + gonghuoxiangq.status;
                    createtime.Text = "创建时间：" + gonghuoxiangq.createtime;
                    supplytime.Text = "提交时间：" + gonghuoxiangq.supplytime;
                    address.Text = "地址：" + gonghuoxiangq.address;
                    //purchid.Text = "编号：" + gonghuoxiangq.purchid;
                    nickname.Text = "用户名：" + gonghuoxiangq.nickname;
                    mobile.Text = "电话：" + gonghuoxiangq.mobile;
                    Kuanghao();
                    jiben1();
                }
               
            }

           
        }
        public DateTime GetDateTime(string strLongTime)
        {
            Int64 begtime = Convert.ToInt64(strLongTime) * 10000000;//100毫微秒为单位,textBox1.text需要转化的int日期
            DateTime dt_1970 = new DateTime(1970, 1, 1, 8, 0, 0);
            long tricks_1970 = dt_1970.Ticks;//1970年1月1日刻度
            long time_tricks = tricks_1970 + begtime;//日志日期刻度
            DateTime dt = new DateTime(time_tricks);//转化为DateTim
            return dt;
        }
        private void jiben1()
        {
            try
            {
                api = string.Format("http://wy.bii.cn/api/purchase/goodsource" +
                "?&orderno={0}"
                , gonghuoxiangq.orderno);

                string getapi = apiweb.HttpPost(api);
                JObject json3 = (JObject)JsonConvert.DeserializeObject(getapi);
                string msg = json3["data"].ToString();
                string ms = json3["msg"].ToString();
                if (ms == "获取成功")
                {
                    msg = "";
                    var json = (JObject)JsonConvert.DeserializeObject(json3["data"].ToString());
                    JArray array = (JArray)json["data"];
                    //jiben.realname = json["realname"].ToString();
                    //jiben.address = json["address"].ToString();
                    //jiben.markettime = int.Parse(json["markettime"].ToString());
                    //jiben.starttime = int.Parse(json["starttime"].ToString());
                    realname.Text ="种植人：" +json["realname"].ToString();
                    adr.Text = "种植地点："+json["address"].ToString();
                    markettime.Text = "采摘时间："+ GetDateTime(json["markettime"].ToString()).ToString();
                    starttime.Text ="种植时间："+ GetDateTime(json["starttime"].ToString()).ToString();


                }
                else
                {
                    Token.xq = 3;

                    //FrmTips.ShowTipsWarning(this.FindForm(), ms);
                }

            }
            catch (Exception)
            {

                FrmTips.ShowTipsWarning(this.FindForm(), "网络连接已断开！");
            }
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
           //button1.ForeColor = System.Drawing.Color.White;
           // button1.BackColor = System.Drawing.Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.ForeColor = System.Drawing.Color.Gray;
            //button1.BackColor = System.Drawing.Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
