using CCWin.SkinControl;
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
    public partial class Packagenos : Form
    {
        public Packagenos()
        {
            InitializeComponent();
        }
        string token = Token.token;
        Apiweb apiweb = new Apiweb();
        string ss = "";
        public static int top = 50;
        public static List<SkinTextBox> list = new List<SkinTextBox>();

        private void Packagenos_Load(object sender, EventArgs e)
        {
            kh.Height = 39;
            list.Add(kh);
            top = kh.Top;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private string Getapi(string u, string orderno, int catid, string packagenos)
        {
            string url = string.Format(u + "?token={0}&orderno={1}&catid={2}&packagenos={3}",
                token, orderno, catid, packagenos);
            string getapi = apiweb.HttpPost(url);
            return getapi;
        }

        private void Packagenos_FormClosed(object sender, FormClosedEventArgs e)
        {
            list.Clear();
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            //string reStr = "{ message:'123'}";
            //var json = (JObject)JsonConvert.DeserializeObject(reStr);
            string orderno = Weighsumbit.orderno;
            int catid = Weighsumbit.catid;
            string packagenos = "";
            foreach (var item in list)
            {
                packagenos += item.Text + ",";
            }
            packagenos = packagenos.Substring(0, packagenos.Length - 1);
            ss = Getapi("http://wy.bii.cn/api/purchase/packagesubmit", orderno, catid, packagenos);

            // or str=str.Remove(str.Length-i,i);
            var json2 = ss;
            JObject json3 = (JObject)JsonConvert.DeserializeObject(ss);

            //var json = (JObject)JsonConvert.DeserializeObject(json3["data"].ToString()); ;
            //JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
            FrmTips.ShowTipsWarning(this, json3["msg"].ToString());
            //MessageBox.Show(json3["msg"].ToString());
        }
        int top1 = 10;
        SkinTextBox tb = null;
        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
          //  ucBtnExt2.Top += 50;
               //kh.Text = "123";
               kh.Height = 39;
            if ((kh.Text).Trim() != "" && list.Count > 0)
            {
                if ((list[list.Count - 1].Text).Trim() != "")
                {
                    if(list.Count > 50)
                    {
                        FrmTips.ShowTipsWarning(this, "装箱上限为50");
                    }
                    else
                    {
                        //top += 50;
                        ////SkinTextBox tb = new SkinTextBox();
                         tb = new SkinTextBox();
                        tb.Name = "po";

                        tb.Top = top;
                        //top1 = tb.Top + 50;

                        tb.Width = kh.Width;
                        tb.Height = kh.Height;
                        tb.Font = kh.Font;
                        tb.Left = kh.Left;
                        if (top > panel1.Height)
                        {


                            tb.Top = tb.Top - top1;
                            top1 = top1 * 2;
                            // if(panel1.Height - )

                        }

                        tb.Location = ucBtnExt2.Location;
                        ucBtnExt2.Left = tb.Left + tb.Width;
                        if (panel1.Width - ucBtnExt2.Left < ucBtnExt2.Width + 40)
                        {
                            ucBtnExt2.Top += kh.Height + 5;
                            ucBtnExt2.Left = kh.Left;
                        }
                        list.Add(tb);

                        panel1.Controls.Add(tb);
                        //ucBtnExt2.Top = tb.Top;
                    }

                
                }
            }
        
            
            //if(top > panel1.Height)
            //{
            //    top = panel1.Height;
            //}
            kh.Height = 39;
        }

        private void ucBtnExt3_BtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            kh.Height = 39;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
            if (list.Count <= 1)
            {

            }
            else
            {
                if(ucBtnExt2.Left-10 <= list[0].Left)
                {
                    ucBtnExt2.Top -= list[0].Height+5;
                    ucBtnExt2.Left = list[list.Count - 1].Left;

                    string tb1 = tb.Name;
                    panel1.Controls.Remove(list[list.Count - 1]);
                    list.RemoveAt(list.Count - 1);
                }
                else
                {
                    ucBtnExt2.Left = ucBtnExt2.Left - tb.Width;
                    string tb1 = tb.Name;
                    panel1.Controls.Remove(list[list.Count - 1]);
                    list.RemoveAt(list.Count - 1);
                }
                
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.BackColor = System.Drawing.Color.White;
            //button1.ForeColor = System.Drawing.Color.Gray;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //button1.ForeColor = System.Drawing.Color.White;
            //button1.BackColor = System.Drawing.Color.Red;
        }
    }
}
