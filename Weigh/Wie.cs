using HZH_Controls.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Weigh1
{
    public partial class Wie : Form
    {
        public Wie()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
        string token = Token.token;
        Apiweb apiweb = new Apiweb();
        string ss = "";
        private string Getapi(string u, string orderno, int starttime, int markettime,
            decimal realamount, decimal realprice, int catid, string cainame, string address)
        {
            string url = string.Format(u +
                "?token={0}&orderno={1}&starttime={2}&markettime={3}&realamount={4}&realprice={5}&catid={6}&cainame={7}&address={8}"
                , token, orderno, starttime, markettime, realamount, realprice, catid, cainame, address);
            string getapi = apiweb.HttpPost(url);
            return getapi;
        }
        #region kk
        SerialPort serialPort1 = new SerialPort();
        void KK()
        {

            opencom();

        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)

        {

            try
            {
                Thread.Sleep(50);  //（毫秒）等待一定时间，确保数据的完整性 int len        

                int len = serialPort1.BytesToRead;

                string receivedata = string.Empty;

                if (len != 0)

                {

                    byte[] buff = new byte[len];

                    serialPort1.Read(buff, 0, len);

                    receivedata = Encoding.Default.GetString(buff);



                }

                richTextBox1.Text = "";
                double a = double.Parse(C(receivedata));
                //richTextBox1.AppendText("千克  " + a);
                richTextBox1.AppendText("" + a);
                //string as1 = richTextBox1.Text;
                //as1 = double.Parse(richTextBox1.Text);
            }
            catch (Exception)
            {

                //throw;
            }

        }
        private string C(string a)
        {
            string b = a.Substring(0, a.Length - 1);

            return b;
        }
        public void opencom()

        {

            try

            {

                //波特率

                serialPort1.BaudRate = 9600;

                //数据位

                String[] portnames = SerialPort.GetPortNames();

                foreach (var item in portnames)

                {
                    serialPort1.PortName = item;
                    //  comboBox1.Items.Add(item);

                }
                serialPort1.DataBits = 8;

                //serialPort1.PortName = comboBox1.Text;

                //两个停止位

                serialPort1.StopBits = System.IO.Ports.StopBits.One;

                //无奇偶校验位

                serialPort1.Parity = System.IO.Ports.Parity.None;

                serialPort1.ReadTimeout = 100;

                serialPort1.Open();

                if (!serialPort1.IsOpen)

                {

                    MessageBox.Show("端口打开失败");

                    return;

                }

                else

                {

                    //richTextBox1.AppendText("端口" + comboBox1.Text + "打开成功\r\n");

                }

                serialPort1.DataReceived += serialPort1_DataReceived;

            }

            catch (Exception ex)

            {

                serialPort1.Dispose();



            }

        }

        #endregion
        private void Wie_Load(object sender, EventArgs e)
        {
            try
            {

                KK();

                radioButton2.Checked = true;


                lblorderno.Text = "流水号: " + Weighsumbit.orderno;
                lbladdress.Text = "实际重量(千克): " + 0;
                lbltitle.Text = "商品分类: " + Weighsumbit.title;
                lblpurchid.Text = "交易价格: " + Weighsumbit.realprice;
                //realprice.Text = Weighsumbit.realprice;
                lblcreatetime.Text = "提交时间: " + Weighsumbit.createtime;
                txttitle.Text = "0";
                txttitle.Enabled = false;
                lblreplyamount.Text = "交易重量(千克)：" + Weighsumbit.amount;
            }
            catch (Exception)
            {

                FrmTips.ShowTipsInfo(this.FindForm(), "电子称未连接");
            }

        }
        string msg = "";
        public static string GetTimeStamp(DateTime dateTime)
        {
            TimeSpan ts = dateTime - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            Console.WriteLine(Convert.ToInt64(ts.TotalSeconds).ToString());
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
        private void ucBtnExt2_BtnClick(object sender, EventArgs e)
        {
            lblpurchid.Text = "交易价格: " + Weighsumbit.realprice;
            try
            {

                if (name.Text != "")
                {
                    if (Regex.Match(name.Text, @"[\u4e00-\u9fa5]").Success)
                    {
                        if (textBox4.Text == "" && radioButton2.Checked)
                        {
                            FrmTips.ShowTipsInfo(this, "皮重不可为空");
                        }
                        else if (textBox5.Text == "" && radioButton1.Checked)
                        {
                            FrmTips.ShowTipsInfo(this, "数量不可为空");
                        }
                        else
                        {
                            if (radioButton2.Checked)
                            {
                                if (Weighsumbit.z1 < 0)
                                {
                                    Weighsumbit.z1 = 0;
                                }
                                //string orderno1 = orderno.Text;
                                string orderno1 = Weighsumbit.orderno;
                                int starttime1 = int.Parse(GetTimeStamp(starttime.Value));
                                int markettime1 = int.Parse(GetTimeStamp(markettime.Value));
                                string sud = lbladdress.Text.Substring(10);
                                decimal realamount1 = decimal.Parse(sud);
                                decimal realprice1 = decimal.Parse(Weighsumbit.realprice);
                                string cainame = name.Text;
                                string address = adr.Text;
                                //int catid = int.Parse(orderno.Text);
                                int catid1 = Weighsumbit.catid;
                                ss = Getapi("http://wy.bii.cn/api/purchase/weighsumbit", orderno1, starttime1, markettime1, realamount1, realprice1, catid1, cainame, address);
                                var json2 = ss;
                                JObject json3 = (JObject)JsonConvert.DeserializeObject(ss);

                                //var json = (JObject)JsonConvert.DeserializeObject(json3["data"].ToString()); ;
                                //JObject json1 = (JObject)JsonConvert.DeserializeObject(json);

                                msg = json3["msg"].ToString();
                                serialPort1.Close();

                                FrmTips.ShowTipsWarning(FindForm(), msg);

                                // this.Close();
                            }
                            else
                            {
                                if (Weighsumbit.z1 < 0)
                                {
                                    Weighsumbit.z1 = 0;
                                }
                                //string orderno1 = orderno.Text;
                                string orderno1 = Weighsumbit.orderno;
                                int starttime1 = int.Parse(GetTimeStamp(starttime.Value));
                                int markettime1 = int.Parse(GetTimeStamp(markettime.Value));
                                string sud = textBox5.Text;
                                int realamount1 = int.Parse(sud);
                                decimal realprice1 = decimal.Parse(Weighsumbit.realprice);
                                string cainame = name.Text;
                                string address = adr.Text;
                                //int catid = int.Parse(orderno.Text);
                                int catid1 = Weighsumbit.catid;
                                ss = Getapi("http://wy.bii.cn/api/purchase/weighsumbit", orderno1, starttime1, markettime1, realamount1, realprice1, catid1, cainame, address);
                                var json2 = ss;
                                JObject json3 = (JObject)JsonConvert.DeserializeObject(ss);

                                //var json = (JObject)JsonConvert.DeserializeObject(json3["data"].ToString()); ;
                                //JObject json1 = (JObject)JsonConvert.DeserializeObject(json);

                                msg = json3["msg"].ToString();
                                serialPort1.Close();

                                FrmTips.ShowTipsWarning(FindForm(), msg);

                                // this.Close();
                            }

                        }
                    }
                    else
                    {
                        name.Text = "";
                        FrmTips.ShowTipsInfo(this, "姓名只能为汉字");

                    }
                }
                else
                {
                    FrmTips.ShowTipsInfo(this, "请检查必填字段");

                }

            }
            catch (Exception)
            {
                if (msg == "")
                {
                    if (richTextBox1.Text == "" || Weighsumbit.realprice == "")
                    {
                        ///FrmTips.ShowTipsWarning(this.FindForm(), "请检查必填字段");
                        FrmTips.ShowTipsInfo(this, "请检查必填字段");

                    }
                    else
                    {
                        FrmTips.ShowTipsWarning(this.FindForm(), "提交失败，请检查网络设置");

                    }
                }
                else
                {
                    FrmTips.ShowTipsWarning(this.FindForm(), msg);

                }

            }


        }
        string as11;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            if (bo == 1)
            {
                lblreplyamount.Text = "交易重量(千克)：" + 0;
            }
            else
            {
                if (richTextBox1.Text != "")
                {
                    #region 测试
                    as11 = richTextBox1.Text;
                    lblreplyamount.Text = "交易重量(千克)：" + as11;
                    #endregion
                    double as1 = double.Parse(as11);
                    // lblreplyamount.Text = "交易重量(千克)：" + richTextBox1.Text;
                    if (zlpd == 0)
                    {
                        //string as1 = richTextBox1.Text;
                        lblreplyamount.Text = "交易重量(千克)：" + as1;

                    }
                    else
                    {
                        //string as1 = richTextBox1.Text;
                        double sum = zhongliang + as1;
                        lblreplyamount.Text = "交易重量(千克)：" + sum;
                    }
                }


            }
        }

        private void starttime_Load(object sender, EventArgs e)
        {

        }
        int bo = 0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }

                // serialPort1.Open();
                bo = 1;
                label4.Text = "交易数量：";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox5.Enabled = true;
                richTextBox1.BackColor = System.Drawing.Color.Gray;
                richTextBox1.Enabled = false;
                richTextBox1.Text = "";
                richTextBox1.ReadOnly = true;
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                textBox4.Enabled = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //textBox4.Enabled = false;
            if (radioButton2.Checked)
            {

                if (!serialPort1.IsOpen)
                {
                    try
                    {
                        serialPort1.Open();
                    }
                    catch (Exception)
                    {
                        FrmTips.ShowTipsInfo(this.FindForm(), "电子称未连接");

                    }

                }

                textBox5.Enabled = false;
                label4.Text = "交易数量：";
                textBox4.Text = "";
                textBox5.Text = "";
                richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
                richTextBox1.Enabled = false;
                richTextBox1.ReadOnly = false;
                bo = 0;
            }
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();
        }

        private void realprice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            double num = 0;
            double ui = 0;
            try
            {
                if (textBox4.Text != "")
                {
                    if (zlpd == 1)
                    {
                        ui = (double)zhongliang + double.Parse(richTextBox1.Text);
                        if (richTextBox1.Text != "")
                        {
                            double z = ui;
                            //double z = double.Parse(as11);
                            double z1 = double.Parse(textBox4.Text);
                            num = z - z1;
                            Weighsumbit.z1 = num;
                            if (num < 0)
                            {
                                num = 0;
                                lbladdress.Text = "实际重量(千克): " + 0;
                            }
                            else
                            {
                                lbladdress.Text = "实际重量(千克): " + num.ToString();

                            }
                        }
                    }
                    else
                    {
                        ui = double.Parse(textBox4.Text);
                        if (richTextBox1.Text != "")
                        {
                            double z = double.Parse(richTextBox1.Text);
                            //double z = double.Parse(as11);
                            double z1 = double.Parse(textBox4.Text);
                            num = z - z1;
                            Weighsumbit.z1 = num;
                            if (num < 0)
                            {
                                num = 0;
                                lbladdress.Text = "实际重量(千克): " + 0;
                            }
                            else
                            {
                                //textBox5.Text = num.ToString();
                                lbladdress.Text = "实际重量(千克): " + num.ToString();
                            }
                        }
                    }
                }
                double sudk = (num * double.Parse(Weighsumbit.realprice));
                txttitle.Text = sudk.ToString();

            }
            catch (Exception)
            {
                this.textBox4.Text = ""; // textBox内容不变
                FrmTips.ShowTipsInfo(this, "皮重只可为数字");

            }
            //if (ui >= 1)
            //{
            //    string pattern = @"^[1-9]\d*(\.\d+)?$";
            //    string param1 = null;
            //    Match m = Regex.Match(textBox4.Text.Trim(), pattern); // 匹配正则表达式
            //    if (!m.Success) // 输入的不是数字
            //    {
            //        this.textBox4.Text = param1; // textBox内容不变
            //        FrmTips.ShowTipsInfo(this, "皮重只可为数字");                         // 将光标定位到文本框的最后

            //    }
            //    else // 输入的是数字
            //    {
            //        if (richTextBox1.Text != "")
            //        {
            //            double z = double.Parse(richTextBox1.Text);
            //            //double z = double.Parse(as11);
            //            double z1 = double.Parse(textBox4.Text);
            //            double num = z - z1;
            //            Weighsumbit.z1 = num;
            //            if (num < 0)
            //            {
            //                textBox5.Text = "0";
            //            }
            //            else
            //            {
            //                textBox5.Text = num.ToString();

            //            }
            //        }


            //    }
            //}
            //else
            //{

            //}

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //清空
            richTextBox1.Text = "0";
            lblreplyamount.Text = "交易重量(千克)：" + "0";
            //textBox5.Text = "";
            zhongliang = 0;
            textBox5.Text = "0";
            txttitle.Text = "0";
        }
        double zhongliang = 0;
        int zlpd = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (("1" + richTextBox1.Text).Trim() == "1")
            {

            }
            else
            {
                zlpd = 1;
                //继续
                zhongliang = zhongliang + double.Parse(richTextBox1.Text);
                //textBox5.Text = zhongliang.ToString();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_Paint(object sender, PaintEventArgs e)
        {

        }
        int na = 0;

        private void name_MouseLeave(object sender, EventArgs e)
        {

        }

        private void name_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //button1.BackColor = System.Drawing.Color.Red;
            //button1.ForeColor = System.Drawing.Color.White;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //    button1.BackColor = System.Drawing.Color.White;
            //    button1.ForeColor = System.Drawing.Color.Gray;



        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            try
            {
               if(textBox5.Text != "")
                {
                    double su = double.Parse(textBox5.Text) * double.Parse(Weighsumbit.realprice);
                    txttitle.Text = su + "";
                }
            }
            catch (Exception)
            {
                textBox5.Text = "";
                FrmTips.ShowTipsInfo(this, "数量只可以为数字");
            }
           

        }
    }
}
