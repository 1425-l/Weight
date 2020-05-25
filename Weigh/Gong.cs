using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HZH_Controls.Controls;
using System.Threading;
using HZH_Controls.Forms;
using Weigh;

namespace Weigh1
{
    public partial class Gong : UserControl
    {
        public Gong()
        {
            InitializeComponent();
            //ComboBox.CheckForIllegalCrossThreadCalls = false;
        }
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle |= 0x02000000;
        //        return cp;
        //    }
        //}
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
        private string Getap(string u)
        {
            string url = string.Format(u + "?token={0}", token);
            string getapi = apiweb.HttpPost(u);
            return getapi;
        }
        string msg = "";
        #region 供货单列表
        List<object> lstPage2;
        private void Gonglist(string api1)
        {

            try
            {
                ss = Getap(api1);
                var json2 = ss;
                JObject json3 = (JObject)JsonConvert.DeserializeObject(ss);
                msg = json3["msg"].ToString();
                var json = (JObject)JsonConvert.DeserializeObject(json3["data"].ToString());
                //JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
                JArray array = (JArray)json["data"];
                lstPage2 = new List<object>();
                int lenn = int.Parse(json["total"].ToString());
                for (int i = 0; i < lenn; i++)
                {
                    lstPage2.Add(i);
                }

                //List<DataGridViewRow>

                List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "id", HeadText = "编号", Width = 50, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "orderno", HeadText = "时间", Width = 180, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "uid", HeadText = "账户", Width = 50, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "title", HeadText = "名称", Width = 110, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "category", HeadText = "类别", Width = 80, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "thumb", HeadText = "图片路径", Width = 50, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "replyamount", HeadText = "数量", Width = 100, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "price", HeadText = "价格", Width = 30, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "status", HeadText = "状态", Width = 80, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "createtime", HeadText = "创建时间", Width = 120, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "supplytime", HeadText = "供应时间", Width = 30, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "address", HeadText = "地址", Width = 70, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "purchid", HeadText = "采购", Width = 50, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "nickname", HeadText = "昵称", Width = 80, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "mobile", HeadText = "电话", Width = 130, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { Width = 15, HeadText = "操作", WidthType = SizeType.Absolute, CustomCellType = typeof(UCTestGridTable_CustomCell) });
                //this.datagonglist.Columns = lstCulumns;
                this.datagonglist.IsShowCheckBox = true;
                //datagonglist.Rows[0].Columns[0]
                List<object> lstSource = new List<object>();
                int len = array.Count;
                string id1;
                string orderno11;
                string uid1;
                string title1;
                string category1;
                string thumb1;
                string amount1;
                string price1;
                string replyamount1;
                string replyprice1;
                string status1;
                string createtime1;
                string supplytime1;
                string address1;
                string purchid1;
                string nickname1;
                string mobile1;
                foreach (var item in array)
                {
                    id1 = item["id"].ToString();
                    orderno11 = item["orderno"].ToString();
                    uid1 = item["uid"].ToString();
                    title1 = item["title"].ToString();
                    category1 = item["category"].ToString();
                    thumb1 = item["thumb"].ToString();
                    amount1 = item["amount"].ToString();
                    price1 = item["price"].ToString();
                    replyamount1 = item["replyamount"].ToString();
                    replyprice1 = item["replyprice"].ToString();
                    status1 = item["status"].ToString();
                    switch (item["status"].ToString())
                    {
                        case "0":
                            status1 = "审核中";
                            break;
                        case "1":
                            status1 = "已完成";
                            break;
                        case "2":
                            status1 = "议价中";
                            break;
                        case "3":
                            status1 = "交易中";
                            break;
                        case "4":
                            status1 = "发货中";
                            //最后一行
                            break;
                        case "5":
                            status1 = "打款中";
                            break;
                        default:
                            status1 = item["status"].ToString();
                            break;

                    }
                    createtime1 = item["createtime"].ToString();
                    supplytime1 = item["supplytime"].ToString();
                    address1 = item["address"].ToString();
                    purchid1 = item["purchid"].ToString();
                    nickname1 = item["nickname"].ToString();
                    mobile1 = item["mobile"].ToString();


                    Gonglist model = new Gonglist()
                    {
                        //    foreach (var jObject in array)
                        //    {
                        //        list.Add(jObject["name"].ToString());
                        //        list1.Add(jObject["id"].ToString());
                        //        valuePairs.Add(jObject["id"].ToString(), jObject["name"].ToString());
                        //        //赋值属性
                        //        aa += jObject["name"].ToString();//获取字符串中id值
                        //    }
                        id = id1,
                        orderno = orderno11,
                        uid = uid1,
                        title = title1,
                        category = category1,
                        thumb = thumb1,
                        amount = amount1,
                        price = price1,
                        replyprice = replyprice1,
                        replyamount = replyamount1,
                        status = status1,
                        createtime = createtime1,
                        supplytime = supplytime1,
                        address = address1,
                        purchid = purchid1,
                        nickname = nickname1,
                        mobile = mobile1

                    };
                    Token.status = status1;
                    lstSource.Add(model);
                }
                this.datagonglist.Columns = lstCulumns;

                this.datagonglist.DataSource = lstSource;

                pictureBox1.Visible = false;
                label1.Visible = false;
                //FrmTips.ShowTipsSuccess(this.FindForm(), msg);

                pictureBox2.Enabled = true;
                if (json["total"].ToString() == "0")
                {
                    pictureBox1.Visible = true;
                    label1.Visible = true;
                    wifo.Visible = false;
                    wifo1.Visible = false;
                    ucPagerControl22.Visible = false;

                }
            }
            catch (Exception)
            {
                JObject json3 = (JObject)JsonConvert.DeserializeObject(ss);
                var json = (JObject)JsonConvert.DeserializeObject(json3["data"].ToString());

                if (json["total"].ToString() == "0")
                {
                    pictureBox1.Visible = true;
                    label1.Visible = true;
                    wifo.Visible = false;
                    wifo1.Visible = false;
                    ucPagerControl22.Visible = false;

                }
                else
                {
                    pictureBox2.Enabled = false;
                    wifo.Visible = true;
                    wifo1.Visible = true;
                    ucPagerControl22.Visible = false;

                    pictureBox1.Visible = false;
                    label1.Visible = false;
                    //FrmTips.ShowTipsWarning(this.FindForm(), "网络已断开！");
                    // FrmTips.ShowTipsSuccess(this.FindForm(), msg);
                }

            }
        }

        #endregion
        #region MyRegion

        #region 三级联动
        private void First()
        {
            ss = Getapi0("http://wy.bii.cn/api/purchase/firstcategory");
            var json2 = ss;
            if (boo == 0)
            {

            }
            else
            {
                int a = ss.IndexOf("[");
                string sss = ss.Substring(0, a + 1);
                ss = sss + "{\"id\":0,\"name\":\"请选择\",\"image\":\"\"}," + ss.Substring(a + 1);
            }
            JObject json3 = (JObject)JsonConvert.DeserializeObject(ss);

            //var json = (JObject)JsonConvert.DeserializeObject(json3["data"].ToString()); ;
            //JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
            JArray array = (JArray)json3["data"];

            //one.Source = array;
            //comboBox1.DataSource
            comboBox1.DataSource = array;
            comboBox1.DisplayMember = "name";
            if (array.Count == 0)
            {
            }
            else
            {
                comboBox1.ValueMember = "id";
            }
        }
        private void Second(string fid)
        {

            ss = Getapi1("http://wy.bii.cn/api/purchase/secondcategory", fid);
            var json2 = ss;

            if (boo == 0)
            {

            }
            else
            {
                int a = ss.IndexOf("[");
                string sss = ss.Substring(0, a + 1);
                ss = sss + "{\"id\":-1,\"name\":\"请选择\",\"image\":\"\"}," + ss.Substring(a + 1);
            }
            JObject json3 = (JObject)JsonConvert.DeserializeObject(ss);

            //var json = (JObject)JsonConvert.DeserializeObject(json3["data"].ToString()); ;
            //JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
            JArray array = (JArray)json3["data"];
            comboBox2.DataSource = array;
            comboBox2.DisplayMember = "name";
            if (array.Count == 0)
            {
            }
            else
            {
                comboBox2.ValueMember = "id";
            }
        }
        private void Third(string sid)
        {
            ss = Getapi2("http://wy.bii.cn/api/purchase/thirdcategory", sid);
            var json2 = ss;
            if (boo == 0)
            {

            }
            else
            {
                int a = ss.IndexOf("[");
                string sss = ss.Substring(0, a + 1);
                ss = sss + "{\"id\":-2,\"name\":\"请选择\",\"image\":\"\"}," + ss.Substring(a + 1);
            }
            JObject json3 = (JObject)JsonConvert.DeserializeObject(ss);

            //var json = (JObject)JsonConvert.DeserializeObject(json3["data"].ToString()); ;
            //JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
            JArray array = (JArray)json3["data"];
            comboBox3.DataSource = array;
            comboBox3.DisplayMember = "name";
            if (array.Count == 0)
            {
            }
            else
            {
                comboBox3.ValueMember = "id";
            }
        }

        private void Thre()
        {

            First();
            Second("39");
            Third("297");

        }
        #endregion
        #region 三级联动使用
        private string Getapi0(string u)
        {
            string url = string.Format(u + "?token={0}", token);
            string getapi = apiweb.HttpPost(url);
            return getapi;
        }
        private string Getapi1(string u, string fid)
        {
            string url = string.Format(u + "?token={0}&fid={1}", token, fid);
            string getapi = apiweb.HttpPost(url);
            return getapi;
        }
        private string Getapi2(string u, string sid)
        {
            string url = string.Format(u + "?token={0}&sid={1}", token, sid);
            string getapi = apiweb.HttpPost(url);
            return getapi;
        }

        #endregion
        #endregion
        //panduan
        int boo = 0;
        //private void AddControl(Control c)
        //{
        //    //c.Dock = DockStyle.Fill;
        //    this.panel5.Controls.Add(c);
        //}
        private void Gong_Load(object sender, EventArgs e)
        {

            List<comitem> ts = new List<comitem>();
            ts.Add(new comitem("-1", "请选择"));
            //ts.Add(new comitem("0", "审核中"));
            ts.Add(new comitem("1", "已完成"));
            ts.Add(new comitem("2", "议价中"));
            ts.Add(new comitem("3", "交易中"));
            ts.Add(new comitem("4", "发货中"));
            ts.Add(new comitem("5", "打款中"));
            comboBox4.DataSource = ts;
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "Id";
            //  AddControl(new Seacth());
            try
            {
                api = "http://wy.bii.cn/api/purchase/gonglist?token=" + token;
                boo = 1;
                Gonglist(api);
                ucPagerControl22.DataSource = lstPage2;

                double co = (double)(lstPage2.Count)/10;
                if(co > (int)co)
                {
                    co += 1;
                }
                ucPagerControl22.PageCount = (int)co;
                ucPagerControl22.PageIndex = 1;
            }
            catch (Exception)
            {
                pictureBox1.Visible = false;
                label1.Visible = false;
                wifo.Visible = true;
                wifo1.Visible = true;
                ucPagerControl22.Visible = false;

                // FrmTips.ShowTipsWarning(this.FindForm(), "网络连接已断开！");
            }

            //MethodInvoker threadInsertValue = new MethodInvoker(InsertCardValue);
            //threadInsertValue.BeginInvoke(null, null);
            Thread t = new Thread(InsertCardValue);
            t.Start();

        }
        private void InsertCardValue()
        {
            try
            {
                //Thre();
            }
            catch (Exception)
            {
                pictureBox1.Visible = false;
                label1.Visible = false;
                //FrmTips.ShowTipsWarning(this.FindForm(), "网络连接已断开！");
                //HZH_Controls.Forms.FrmTips.ShowTipsSuccess(this.FindForm(), "修改：");
                wifo.Visible = true;
                wifo1.Visible = true;
                ucPagerControl22.Visible = false;

            }



        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Second(comboBox1.SelectedValue.ToString());

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Third(comboBox2.SelectedValue.ToString());
            comboBox1.Visible = true;
        }
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public string GetTimeStamp(DateTime dateTime)
        {
            TimeSpan ts = dateTime - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            string createstart = GetTimeStamp(dateTimePicker2.Value);
            string createend = GetTimeStamp(dateTimePicker3.Value);
            //txtorderno.Text = GetTimeStamp(createstart);
            // api = string.Format("http://wy.bii.cn/api/purchase/gonglist" + "?token={0}&orderno={1}&catid={2}", token, txtorderno.Text, comboBox3.SelectedValue.ToString());
            //textBox1.AppendText(comboBox3.SelectedValue.ToString()+"**");


            string aapi = string.Format("http://wy.bii.cn/api/purchase/gonglist" + "?token={0}", token);
            aapi += "&createstart=" + createstart + "&createend=" + createend;
            string caid = comboBox3.SelectedValue.ToString();

            if (int.Parse(comboBox3.SelectedValue.ToString()) < 0)
            {
                caid = "";
            }
            else
            {
                aapi += "&catid=" + caid;
            }
            //textBox1.Text = aapi;
            string ordr = "";
            if (txtorderno.Text.Trim() != "")
            {
                ordr = txtorderno.Text;
                aapi += "&orderno=" + ordr;
            }
            string stat = "";
            if (comboBox4.SelectedValue.ToString() != "-1")
            {
                stat = comboBox4.SelectedValue.ToString();
                aapi += "&status=" + stat;
            }

            Gonglist(aapi);
        }

        private void datagonglist_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            boo = 0;
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            boo = 0;
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            boo = 0;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #region 自定义成员变量

        //private TextBox m_TextBox;
        //private TreeView m_TreeView;
        //private Button m_DropdownButton;
        //private int m_MaxDropDownItems = 8;
        ////是否正在显示下拉列表
        //private bool b_Dropdown = false;
        ////使能
        //private bool b_Enabled = true;
        ////事件
        //public event EventHandler DropDown;
        //public event EventHandler DropDownClosed;
        //public event EventHandler EnableChanged;
        //public event TreeViewCancelEventHandler BeforeExpand;
        //public event TreeViewCancelEventHandler BeforeCollapse;
        //public event TreeViewEventHandler AfterExpand;
        //public event TreeViewEventHandler AfterCollapse;

        #endregion
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void datagonglist_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_DrawItem(object sender, DrawItemEventArgs e)
        {
            #region 原
            ComboBox cmb = sender as ComboBox;  //当前的ComboBox控件
            Color color = System.Drawing.Color.Gray;
            //SolidBrush myBrush = new SolidBrush(cmb.ForeColor);  //字体颜色
            SolidBrush myBrush = new SolidBrush(cmb.ForeColor);  //字体颜色
                                                                 //获取在属性中设置的字体
            Font font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            Font ft = font;
            //选项的文本
            string itemText = cmb.GetItemText(cmb.Items[e.Index]);//cmb.Items[e.Index].ToString(); 
                                                                  // 计算字符串尺寸（以像素为单位）
            SizeF ss = e.Graphics.MeasureString(itemText, cmb.Font);

            // 水平居中
            float left = 0;
            //left = (float)(e.Bounds.Width - ss.Width) / 2;  //如果需要水平居中取消注释
            if (left < 0) left = 0f;

            // 垂直居中
            float top = (float)(e.Bounds.Height - ss.Height) / 2;
            if (top <= 0) top = 0f;

            // 输出
            e.DrawBackground();
            e.Graphics.DrawString(itemText, ft, myBrush, new RectangleF(
                e.Bounds.X + left,    //设置X坐标偏移量
                e.Bounds.Y + top,     //设置Y坐标偏移量
                e.Bounds.Width, e.Bounds.Height), StringFormat.GenericDefault);

            //e.Graphics.DrawString(cmb.GetItemText(cmb.Items[e.Index]), ft, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();

            #endregion
            #region 后
            //try
            //{
            //    //匿名方法  
            //    Func<Color> SetBackColor = () =>
            //    {
            //        if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            //        {
            //            return Color.Lime; //高亮背景色  
            //        }
            //        return e.BackColor;
            //    };

            //    ComboBox cmb = sender as ComboBox;  //当前的ComboBox控件
            //    SolidBrush myBrush = new SolidBrush(cmb.ForeColor);  //字体颜色
            //    Font ft = cmb.Font;    //获取在属性中设置的字体

            //    //选项的文本
            //    string itemText = cmb.GetItemText(cmb.Items[e.Index]);//cmb.Items[e.Index].ToString(); 
            //    Color color = System.Drawing.Color.Blue;                                      // 计算字符串尺寸（以像素为单位）
            //    SizeF ss = e.Graphics.MeasureString(itemText, cmb.Font);

            //    // 水平居中
            //    float left = 0;
            //    //left = (float)(e.Bounds.Width - ss.Width) / 2;  //如果需要水平居中取消注释
            //    if (left < 0) left = 0f;

            //    // 垂直居中
            //    float top = (float)(e.Bounds.Height - ss.Height) / 2;
            //    if (top <= 0) top = 0f;

            //    // 输出
            //    e.DrawBackground();

            //    //选项背景高亮
            //    Rectangle rectangle1 = new Rectangle(e.Bounds.Left, e.Bounds.Top,
            //    e.Bounds.Width, e.Bounds.Height);
            //    e.Graphics.FillRectangle(new SolidBrush(SetBackColor()), rectangle1);

            //    //填充选项背景
            //    int x = 0, y = 0;
            //    Rectangle rectangle = new Rectangle(e.Bounds.Left+x, e.Bounds.Top +y,
            //        e.Bounds.Width-2*x, e.Bounds.Height - 2*y);
            //    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255,ColorTranslator.FromHtml("#ffffff"))), rectangle);

            //    e.Graphics.DrawString(itemText, ft, myBrush, new RectangleF(
            //        e.Bounds.X + left,    //设置X坐标偏移量
            //        e.Bounds.Y + top,     //设置Y坐标偏移量
            //        e.Bounds.Width, e.Bounds.Height), StringFormat.GenericDefault);

            //    //e.Graphics.DrawString(cmb.GetItemText(cmb.Items[e.Index]), ft, myBrush, e.Bounds, StringFormat.GenericDefault);
            //    e.DrawFocusRectangle();
            //}
            //catch (Exception ex)
            //{
            //    //log.ErrorFormat("FrmAccountActivate窗体:" + ex.Message, ex);
            //}
            #endregion


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                api = "http://wy.bii.cn/api/purchase/gonglist?token=" + token;
                boo = 1;
                Gonglist(api);
            }
            catch (Exception)
            {
                pictureBox1.Visible = false;
                label1.Visible = false;
                wifo.Visible = true;
                wifo1.Visible = true;
                ucPagerControl22.Visible = false;
                // FrmTips.ShowTipsWarning(this.FindForm(), "网络连接已断开！");
            }
        }

        private void ucPagerControl22_Load(object sender, EventArgs e)
        {

        }
        int page = 1;
        private void ucPagerControl22_ShowSourceChanged(object currentSource)
        {

            page = ucPagerControl22.PageIndex;
            api = "http://wy.bii.cn/api/purchase/gonglist?token=" + token+ "&page="+page;

             Gonglist(api);
        }

        private void ucPagerControl22_MouseMove(object sender, MouseEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
