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
    public partial class kuang : Form
    {
        public kuang()
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
        private void kuang_Load(object sender, EventArgs e)
        {
            try
            {
                api = string.Format("http://wy.bii.cn/api/purchase/packagelist" +
                "?token={0}&orderno={1}"
                , token, Weighsumbit.orderno);

                string getapi = apiweb.HttpPost(api);
                JObject json3 = (JObject)JsonConvert.DeserializeObject(getapi);
                string msg = json3["data"].ToString();
                
                
                msg = "";
                JArray array = (JArray)json3["data"];
                foreach (var item in array)
                {
                    msg += "   " + item;
                }
                kkid.Text = "框号列表：" + msg;
                if(kkid.Left+kkid.Width > this.Width + 10)
                {

                }
            }
            catch (Exception)
            {

                FrmTips.ShowTipsWarning(this.FindForm(), "网络连接已断开！");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
