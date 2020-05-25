using HZH_Controls;
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
using Weigh;

namespace Weigh1
{
    public partial class Main : Form
    {
        public static Main mainFrm;
        public Main()
        {
            InitializeComponent();
            mainFrm = this;
        }
        private void AddControl(Control c)
        {
            //c.Dock = DockStyle.Fill;
            this.panControl.Controls.Clear();
            this.panControl.Controls.Add(c);
        }
        #region 鼠标事件

        #region btn2
        int bo1 = 0;
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            //button2.BackgroundImage = global::Weigh.Properties.Resources.btn;
            //button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));


        }


        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            bo = 0;
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            bo1 = 1; button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));

        }

        private void button2_Leave(object sender, EventArgs e)
        {
            bo1 = 0;
            //button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(207)))));
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if (bo1 == 0)
            {
                //button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(207)))));
                //button2.BackgroundImage = null;            
                button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));

            }

        }
        #endregion
        #region btn3
        int bo = 0;
        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.ForeColor = System.Drawing.Color.White;

            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
           
            if (bo == 0)
            {

                button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
                button3.ForeColor = System.Drawing.Color.White;
            }
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            bo = 0;
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            button3.ForeColor = System.Drawing.Color.White;
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            bo = 1;
            button3.ForeColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(121)))), ((int)(((byte)(194)))));
        }
        #endregion
        #region btn4
        int bo2 = 0;
        private void button4_Leave(object sender, EventArgs e)
        {
            bo2 = 0;
            //button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(207)))));
            //button4.BackgroundImage = null;
            button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {

            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            bo2 = 1;

            button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));

        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            //button4.BackgroundImage = global::Weigh.Properties.Resources.btn;
            //button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            if (bo2 == 0)
            {
                button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
                //button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(207)))));
                //button4.BackgroundImage = null;
               
            }
        }
        #endregion
        #region btn5
        int bo3 = 0;
        private void button5_Leave(object sender, EventArgs e)
        {
            bo3 = 0;
            //button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(207)))));
            //button5.BackgroundImage = null;
            button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            button5.ForeColor = System.Drawing.Color.White;
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            //button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(207)))));
            //button3.BackgroundImage = null;
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            bo3 = 1;
            //button5.BackgroundImage = global::Weigh.Properties.Resources.btn;
            //button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button5.ForeColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            if (bo3 == 0)
            {
                //button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(207)))));
                //button5.BackgroundImage = null;
                button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
                button5.ForeColor =System.Drawing.Color.White;
            }
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            //button5.BackgroundImage = global::Weigh.Properties.Resources.btn;
            //button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button5.ForeColor = System.Drawing.Color.White;
                button5.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));
            
           
        }
        #endregion



        #endregion
        private string Getap(string u)
        {
            string url = string.Format(u + "?token={0}", token);
            string getapi = apiweb.HttpPost(u);
            return getapi;
        }
        string msg = "";
        string token = Token.token;
        Apiweb apiweb = new Apiweb();
        string ss = "";
        string api = "";
        private void Main_Load(object sender, EventArgs e)
        {
            api = "http://wy.bii.cn/api/purchase/address?token=" + token;
            ss = Getap(api);
            var json2 = ss;
            JObject json3 = (JObject)JsonConvert.DeserializeObject(ss);
            msg = json3["data"].ToString();
            label2.Text = "采购点："+msg;
            label2.Top = 7;
            if(label2.Left+label2.Width >= panel1.Width - 10)
            {
                label2.Left = (label2.Left + label2.Width) - panel1.Width - 10;
            }
            //System.Drawing.GraphicsUnit.Point
            bo = 1;
            //button3.BackgroundImage = global::Weigh.Properties.Resources.btn;
            //button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));
            button6.Text = Token.nickname;
            //AddControl(new Gong());
            AddControl(new Gong());
            //AddControl1(new maxminclose());
            string da = "";
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday":
                    da = "一";
                    break;
                case "Tuesday":
                    da = "二";
                    break;
                case "Wednesday":
                    da = "三";
                    break;
                case "Thursday":
                    da = "四";
                    break;
                case "Friday":
                    da = "五";
                    break;
                case "Saturday":
                    da = "六";
                    break;
                case "Sunday":
                    da = "日";
                    break;
                default:
                    break;
            }
            label3.Text = DateTime.Now.Date.ToString().Substring(0, DateTime.Now.Date.ToString().Length-7) +"  星期"+da;
        }

        public void Tre()
        {
            //panControl.Controls.Clear();
            //tvMenu.SelectedNode = tnForm1;
        }
        private void Exitt_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panControl_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void Showz(int a)
        {

        }


        private void tvMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (b == 0)
            //{
            //    panControl.Controls.Clear();
            //    string strName = e.Node.Text.Trim();
            //    switch (strName)
            //    {
            //        case "系统主页":
            //            // panControl..()
            //            AddControl(new UserControl1());
            //            break;
            //        case "农户采购点":
            //            AddControl(new Cai());
            //            break;
            //        case "农户供货单":
            //            AddControl(new Gong());
            //            break;
            //        case "称重验收记录":
            //            AddControl(new Jlu());
            //            break;
            //        case "使用帮助":
            //            AddControl(new Help());
            //            break;
            //    }
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddControl(new UserControl1());
        }
        private void tvMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panControl_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            //panControl.Controls.Clear();
            //tvMenu.SelectedNode = tnForm1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        #region 鼠标移动窗体
        private Point mPoint;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        int win = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            win = 2;
            AddControl(new Cai());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            win = 1;
            AddControl(new Gong());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            win = 3;
            AddControl(new Jlu());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            win = 4;
            AddControl(new Help());
        }


        private void panControl_Paint_2(object sender, PaintEventArgs e)
        {

        }
        #region 右上角
        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));
            button6.Text = "退出"; 

        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
            button6.Text = Token.nickname;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_MouseMove(object sender, MouseEventArgs e)
        {
            button8.BackColor = System.Drawing.Color.Red;
        }

        private void button7_MouseMove(object sender, MouseEventArgs e)
        {
            button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(166)))));
        }



        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region 窗体大小改变
        //#region 去除窗体边框后，可以改变窗体尺寸
        ////定义用于设置的常量值
        //const int Guying_HTLEFT = 10;
        //const int Guying_HTRIGHT = 11;
        //const int Guying_HTTOP = 12;
        //const int Guying_HTTOPLEFT = 13;
        //const int Guying_HTTOPRIGHT = 14;
        //const int Guying_HTBOTTOM = 15;
        //const int Guying_HTBOTTOMLEFT = 0x10;
        //const int Guying_HTBOTTOMRIGHT = 17;

        ////重写系统WndProc函数：
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case 0x0084:
        //            base.WndProc(ref m);
        //            Point vPoint = new Point((int)m.LParam & 0xFFFF,
        //                (int)m.LParam >> 16 & 0xFFFF);
        //            vPoint = PointToClient(vPoint);
        //            if (vPoint.X <= 5)
        //                if (vPoint.Y <= 5)
        //                    m.Result = (IntPtr)Guying_HTTOPLEFT;
        //                else if (vPoint.Y >= ClientSize.Height - 5)
        //                    m.Result = (IntPtr)Guying_HTBOTTOMLEFT;
        //                else m.Result = (IntPtr)Guying_HTLEFT;
        //            else if (vPoint.X >= ClientSize.Width - 5)
        //                if (vPoint.Y <= 5)
        //                    m.Result = (IntPtr)Guying_HTTOPRIGHT;
        //                else if (vPoint.Y >= ClientSize.Height - 5)
        //                    m.Result = (IntPtr)Guying_HTBOTTOMRIGHT;
        //                else m.Result = (IntPtr)Guying_HTRIGHT;
        //            else if (vPoint.Y <= 5)
        //                m.Result = (IntPtr)Guying_HTTOP;
        //            else if (vPoint.Y >= ClientSize.Height - 5)
        //                m.Result = (IntPtr)Guying_HTBOTTOM;
        //            break;
        //        case 0x0201: //鼠标左键按下的消息
        //            m.Msg = 0x00A1; //更改消息为非客户区按下鼠标
        //            m.LParam = IntPtr.Zero; //默认值
        //            m.WParam = new IntPtr(2); //鼠标放在标题栏内
        //            base.WndProc(ref m);
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}
        //#endregion

        //#region 窗体拉伸重绘事件，窗体自适应屏幕尺寸，依旧屏幕自动缩放

        //private void frmWebmasterMain_Load(object sender, EventArgs e)
        //{
        //    this.Resize += new EventHandler(MainForm_Resize); //添加窗体拉伸重绘事件
        //    xvalues = this.Width;//记录窗体初始大小
        //    yvalues = this.Height;
        //    SetTag(this);
        //}

        //private void SetControls(float newX, float newY, Control cons)//改变控件的大小
        //{
        //    foreach (Control con in cons.Controls)
        //    {
        //        string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
        //        float a = Convert.ToSingle(mytag[0]) * newX;
        //        con.Width = (int)a;
        //        a = Convert.ToSingle(mytag[1]) * newY;
        //        con.Height = (int)a;
        //        a = Convert.ToSingle(mytag[2]) * newX;
        //        con.Left = (int)a;
        //        a = Convert.ToSingle(mytag[3]) * newY;
        //        con.Top = (int)a;
        //        Single currentSize = Convert.ToSingle(mytag[4]) * newY;

        //        con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
        //        if (con.Controls.Count > 0)
        //        {
        //            SetControls(newX, newY, con);
        //        }
        //    }
        //}

        //private void MainForm_Resize(object sender, EventArgs e)//重绘事件
        //{
        //    float newX = this.Width / xvalues;//获得比例
        //    float newY = this.Height / yvalues;
        //    SetControls(newX, newY, this);
        //}


        //private void SetTag(Control cons)
        //{
        //    foreach (Control con in cons.Controls)  //遍历窗体中的控件,记录控件初始大小
        //    {
        //        con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
        //        if (con.Controls.Count > 0)
        //        {
        //            SetTag(con);
        //        }
        //    }
        //}

        //#endregion

        #endregion

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            switch (win)
            {
                case 1:
                    AddControl(new Gong());
                    break;
                case 2:
                    AddControl(new Cai());
                    break;
                case 3:
                    AddControl(new Jlu());
                    break;
                case 4:
                    AddControl(new Help());
                    break;
                default:
                    break;
            }
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));

        }
    }
}
