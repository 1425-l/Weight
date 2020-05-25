using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HZH_Controls.Controls;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using HZH_Controls.Forms;

namespace Weigh1
{
    public partial class UserControl1 : UserControl, IDataGridViewCustomCell
    {
        public UserControl1()
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

        string token = Token.token;
        Apiweb apiweb = new Apiweb();
        string ss = "";
        string api = "";
        private string Getapi(string u)
        {
            string url = string.Format(u + "?token={0}", token);
            string getapi = apiweb.HttpPost(url);
            return getapi;
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                string gong1 = string.Format("http://wy.bii.cn/api/purchase/gonglist" + "?token={0}", token);
                string getapi = apiweb.HttpPost(gong1);
                var json = getapi;
                JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
                var js = (JObject)JsonConvert.DeserializeObject(json1["data"].ToString());
                lblgongn.Text = js["total"].ToString();
                string cai1 = string.Format("http://wy.bii.cn/api/purchase/cailist" + "?token={0}", token);
                getapi = apiweb.HttpPost(cai1);
                json = getapi;
                json1 = (JObject)JsonConvert.DeserializeObject(json);
                js = (JObject)JsonConvert.DeserializeObject(json1["data"].ToString());
                lblcain.Text = js["total"].ToString();
                string wei1 = string.Format("http://wy.bii.cn/api/purchase/weighlist" + "?token={0}", token);
                getapi = apiweb.HttpPost(wei1);
                json = getapi;
                json1 = (JObject)JsonConvert.DeserializeObject(json);
                if (json1["msg"].ToString() == "没有记录!")
                {

                    lbwein.Text = "0";
                }
                else
                {
                    js = (JObject)JsonConvert.DeserializeObject(json1["data"].ToString());
                    lbwein.Text = js["total"].ToString();

                }
            }
            catch (Exception)
            {

                FrmTips.ShowTipsWarning(this.FindForm(), "网络已断开！");

            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }
        Main main = new Main();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            main.Tre();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
