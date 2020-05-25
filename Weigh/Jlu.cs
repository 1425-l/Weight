using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using HZH_Controls.Controls;
using HZH_Controls.Forms;
using Weigh;
using System.Threading;

namespace Weigh1
{
    public partial class Jlu : UserControl
    {
        public Jlu()
        {
            InitializeComponent();
        }
        string token = Token.token;
        Apiweb apiweb = new Apiweb();
        string ss = "";
        string api = "";
        private string Getapi(string u)
        {
            string url = string.Format(u + "?token={0}", token);
            string getapi = apiweb.HttpPost(u);
            return getapi;
        }
        string msg = "";
        #region 列表
        List<object> lstPage2;
        private void weilist(string api1)
        {
            try
            {

                ss = Getapi(api1);
                var json2 = ss;
                JObject json3 = (JObject)JsonConvert.DeserializeObject(ss);
                msg = json3["msg"].ToString();
                var json = (JObject)JsonConvert.DeserializeObject(json3["data"].ToString());

                //JObject json1 = (JObject)JsonConvert.DeserializeObject(json);
                JArray array = (JArray)json["data"];
                lstPage2 = new List<object>();
                int lenn = int.Parse(json["pagenum"].ToString());
                for (int i = 0; i < lenn; i++)
                {
                    lstPage2.Add(i);
                }
               

                List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
               // lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "id", HeadText = "编号", Width = 50, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "orderno", HeadText = "时间", Width = 250, WidthType = SizeType.Absolute });
               // lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "operatid", HeadText = "账户", Width = 50, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "createtime", HeadText = "名称", Width = 180, WidthType = SizeType.Absolute });
               // lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "starttime", HeadText = "类别", Width = 80, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "markettime", HeadText = "图片路径", Width = 50, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "catid", HeadText = "数量", Width = 100, WidthType = SizeType.Absolute });
               // lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "purchid", HeadText = "采购", Width = 30, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "realamount", HeadText = "职位", Width = 150, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "realprice", HeadText = "价格", Width = 150, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "status", HeadText = "供应时间", Width = 30, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "packageno", HeadText = "地址", Width = 70, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "nickname", HeadText = "昵称", Width = 100, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "mobile", HeadText = "电话", Width = 130, WidthType = SizeType.Absolute });
                lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "goodtitle", HeadText = "名称", Width = 150, WidthType = SizeType.Absolute });
                //lstCulumns.Add(new DataGridViewColumnEntity() { Width = 15, HeadText = "操作", WidthType = SizeType.Absolute, CustomCellType = typeof(UCTestGridTable_CustomCell1) });
                lstCulumns.Add(new DataGridViewColumnEntity() { Width = 15, HeadText = "操作", WidthType = SizeType.Absolute, CustomCellType = typeof(UCTestGridTable_CustomCell1) });
                this.dataweilist.Columns = lstCulumns;
                this.dataweilist.IsShowCheckBox = true;
                List<object> lstSource = new List<object>();
                int len = array.Count;
                string id1;
                string orderno1;
                string operatid1;
                string createtime1;
                string starttime1;
                string markettime1;
                string catid1;
                string purchid1;
                string realamount1;
                string realprice1;
                string status1;
                string packageno1;
                string nickname1;
                string mobile1;
                string goodtitle1;
                string is_packageno1;
                foreach (var item in array)
                {
                    id1 = item["id"].ToString();
                    orderno1 = item["orderno"].ToString();
                    operatid1 = item["operatid"].ToString();
                    createtime1 = item["createtime"].ToString();
                    starttime1 = item["starttime"].ToString();
                    markettime1 = item["markettime"].ToString();
                    catid1 = item["catid"].ToString();
                    purchid1 = item["purchid"].ToString();
                    realamount1 = item["realamount"].ToString();
                    realprice1 = item["realprice"].ToString();
                    status1 = item["status"].ToString();
                    
                    packageno1 = item["packageno"].ToString();
                    //nickname1 = item["nickname"].ToString();
                   // mobile1 = item["mobile"].ToString();
                    goodtitle1 = item["goodtitle"].ToString();
                    is_packageno1 = item["is_packageno"].ToString();
                    

                        JJlu model = new JJlu()
                        {
                            
                            id = id1,
                            orderno = orderno1,
                            operatid = operatid1,
                            createtime = createtime1,
                            starttime = starttime1,
                            markettime = markettime1,
                            catid = catid1,
                            purchid = purchid1,
                            realamount = realamount1,
                            realprice = realprice1,
                            status = status1,
                            packageno = packageno1,
                           // nickname = nickname1,
                            //mobile = mobile1,
                            goodtitle = goodtitle1,
                            is_packageno = is_packageno1,


                        };
                        lstSource.Add(model);
                    
                }
                pictureBox1.Visible = false;
                
                //FrmTips.ShowTipsSuccess(this.FindForm(), msg);
                label1.Visible = false;
                this.dataweilist.DataSource = lstSource;
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
                if (msg == "")
                {
                    pictureBox2.Enabled = false;
                    // FrmTips.ShowTipsWarning(this.FindForm(), "网络已断开！");
                    wifo.Visible = true;
                    wifo1.Visible = true;
                    ucPagerControl22.Visible = false;
                    pictureBox1.Visible = false;
                    //FrmTips.ShowTipsSuccess(this.FindForm(), msg);
                    label1.Visible = false;
                }
                else
                {
                    wifo.Visible = false;
                    wifo1.Visible = false;
                   // ucPagerControl21.Visible = false;
                    pictureBox2.Enabled = false;
                    pictureBox1.Visible = true;
                    //FrmTips.ShowTipsSuccess(this.FindForm(), msg);
                    label1.Visible = true;
                    ucPagerControl22.Visible = false;
                }

            }

        }
        #endregion
        private void Jlu_Load(object sender, EventArgs e)
        {
            List<comitem> ts = new List<comitem>();
            ts.Add(new comitem("-1", "请选择"));
            //ts.Add(new comitem("0", "审核中"));
            ts.Add(new comitem("1", "已完成"));
            ts.Add(new comitem("2", "议价中"));
            ts.Add(new comitem("3", "交易中"));
            ts.Add(new comitem("4", "发货中"));
            ts.Add(new comitem("5", "打款中"));
            //comboBox4.DataSource = ts;
            //comboBox4.DisplayMember = "Name";
            //comboBox4.ValueMember = "Id";
            //label2.Visible = false;
            //comboBox1.Hide();
            //    comboBox2.Visible = false;
            //comboBox3.Visible = false;
            api = "http://wy.bii.cn/api/purchase/weighlist?token=" + token;
            
            try
            {
                api = "http://wy.bii.cn/api/purchase/weighlist?token=" + token;
                
                boo = 1;
                weilist(api);
                ucPagerControl22.DataSource = lstPage2;

                double co = (double)(lstPage2.Count) / 10;
                if (co > (int)co)
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
                // FrmTips.ShowTipsWarning(this.FindForm(), "网络连接已断开！");
            }

            //MethodInvoker threadInsertValue = new MethodInvoker(InsertCardValue);
            //threadInsertValue.BeginInvoke(null, null);
           //Thread t = new Thread(InsertCardValue);
           //t.Start();

        }
        private void InsertCardValue()
        {
            try
            {
               // Thre();
            }
            catch (Exception)
            {
                pictureBox1.Visible = false;
                label1.Visible = false;
                //FrmTips.ShowTipsWarning(this.FindForm(), "网络连接已断开！");
                //HZH_Controls.Forms.FrmTips.ShowTipsSuccess(this.FindForm(), "修改：");
                wifo.Visible = true;
                wifo1.Visible = true;
            }



        }
        private void dataweilist_Load(object sender, EventArgs e)
        {

        }
        public string GetTimeStamp(DateTime dateTime)
        {
            TimeSpan ts = dateTime - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string createstart = GetTimeStamp(dateTimePicker2.Value);
            string createend = GetTimeStamp(dateTimePicker3.Value);
            //txtorderno.Text = GetTimeStamp(createstart);
            // api = string.Format("http://wy.bii.cn/api/purchase/weighlist" + "?token={0}&orderno={1}&catid={2}", token, txtorderno.Text, comboBox3.SelectedValue.ToString());
            //textBox1.AppendText(comboBox3.SelectedValue.ToString()+"**");


            string aapi = string.Format("http://wy.bii.cn/api/purchase/weighlist" + "?token={0}", token);
            aapi += "&createstart=" + createstart + "&createend=" + createend;
            //string caid = comboBox3.SelectedValue.ToString();

            //if (int.Parse(comboBox3.SelectedValue.ToString()) < 0)
            //{
            //    caid = "";
            //}
            //else
            //{
            //    aapi += "&catid=" + caid;
            //}
            //textBox1.Text = aapi;
            string ordr = "";
            if (txtorderno.Text.Trim() != "")
            {
                ordr = txtorderno.Text;
                aapi += "&orderno=" + ordr;
            }
            
            

            weilist(aapi);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataweilist_Load_1(object sender, EventArgs e)
        {

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
        int boo = 0;
        
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
        }
        int page = 1;
        private void ucPagerControl22_ShowSourceChanged(object currentSource)
        {
            page = ucPagerControl22.PageIndex;
            api = "http://wy.bii.cn/api/purchase/weighlist?token=" + token + "&page=" + page;

            weilist(api);
            return;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
