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
using System.Windows.Forms;

namespace Weigh1
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            this.BackColor = ColorTranslator.FromHtml("#F7F1F1");
            this.TransparencyKey = ColorTranslator.FromHtml("#F7F1F1");
            this.Opacity = 2;
        }
        Apiweb apiweb = new Apiweb();
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         textBoxEx1.Text= "13687388731";
         txtpassword.Text = "12345678";
        }
        #region 文本框输入提示
        Boolean textboxHasText = false;//判断输入框是否有文本
        Boolean textboxHasText2 = false;//判断输入框是否有文本
       
        #endregion

        private void ucControlBase1_Load(object sender, EventArgs e)
        {
            textBoxEx1.Text = "请输入用户名";
            textBoxEx1.ForeColor = Color.LightGray;
            textboxHasText = false; txtpassword.Text = "请输入密码";
            txtpassword.ForeColor = Color.LightGray;
            textboxHasText2 = false;
            txtpassword.IsPasswordChat = '\0';
        }

        private void txtaccount_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
            {
                textBoxEx1.Text = "";
                textBoxEx1.ForeColor = Color.Black;
            }
        }

        private void txtaccount_Leave(object sender, EventArgs e)
        {
            if (textBoxEx1.Text == "")
            {
                textBoxEx1.Text = "请输入用户名";
                textBoxEx1.ForeColor = Color.LightGray;
                textboxHasText = false;
            }
            else
            {
                textboxHasText = true;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (textboxHasText2 == false)
            {
                txtpassword.Text = "";
                txtpassword.IsPasswordChat = (char)42;
                txtpassword.ForeColor = Color.Black;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "请输入密码";
                txtpassword.ForeColor = Color.LightGray;
                textboxHasText2 = false;
                txtpassword.IsPasswordChat = '\0';
            }
            else
            {
                textboxHasText2 = true;
            }
        }

        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            try
            {
                string account = textBoxEx1.Text;
                string password = txtpassword.Text;

                //string url = string.Format("http://wy.bii.cn/api/user/login" + "?account={0}&password={1}", "13687388731", "12345678");
                string url = string.Format("http://wy.bii.cn/api/purchase/login" + "?account={0}&password={1}", account, password);
                string getapi = apiweb.HttpPost(url);
                var json = getapi;
                JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
                if(json1["code"].ToString() != "1")
                {
                    if (json1["msg"].ToString() == "Password is incorrect")
                    {
                        FrmTips.ShowTipsWarning(this, "密码错误");
                    }

                    if (json1["msg"].ToString() == "Account is incorrect")
                    {
                        FrmTips.ShowTipsWarning(this, "账户不存在");
                    }
                    // FrmDialog.ShowDialog(this, json1["msg"].ToString(), "提示");
                   // FrmTips.ShowTipsWarning(this, json1["msg"].ToString());

                    //MessageBox.Show(json1["msg"].ToString());
                    return;
                }
                JObject json2 = (JObject)JsonConvert.DeserializeObject(json1["data"].ToString());
                //JArray array = (JArray)json1["data"];
                var obj = JsonConvert.DeserializeObject(json);
                JArray array = new JArray();
                if (obj is JArray)
                {
                    array = JsonConvert.DeserializeObject<JArray>(json);
                }
                else
                {
                    array = JsonConvert.DeserializeObject<JArray>("[" + json2["userinfo"] + "]");
                }
                int i = array.Count;
                string aa = "";
                foreach (var jObject in array)
                {
                    aa = json1["msg"].ToString();
                    Token.token = jObject["token"].ToString();
                    Token.nickname = jObject["nickname"].ToString(); 
                }
                Main main = new Main();
                main.Show();
                this.Hide();
                // Page main = new Page();
                // main.Show();
                // this.Hide();
            }
            catch (Exception)
            {
                FrmTips.ShowTipsInfo(this, "请检查网络设置");
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #region 鼠标移动窗体
        private Point mPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

    }
}
