using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weigh1;

namespace Weigh
{
    public partial class DY : Form
    {
        public DY()
        {
            InitializeComponent();
        }

        private void DY_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Token.image;

        }
        string BarcodeString = Token.once;//条码
        int ImgWidth = 500;
        int ImgHeight = 350;

        //打印按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //实例化打印对象
            PrintDocument printDocument1 = new PrintDocument();

            //设置打印用的纸张,可以自定义纸张的大小(单位：mm).   当打印高度不确定时也可以不设置
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custum", 70, 20);

            //注册PrintPage事件，打印每一页时会触发该事件
            printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);

            //开始打印
            printDocument1.Print();

            //打印预览
            //PrintPreviewDialog ppd = new PrintPreviewDialog();
            //ppd.Document = printDocument1;
            //ppd.ShowDialog();
        }


        //打印事件
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\r\n\r\n");
            //sb.Append("*******兴隆超市*******\r\n");
            sb.Append(" " + Token.once);
            //sb.Append("精品白沙  1    8元\r\n");
            //sb.Append("张新发槟榔 1   10元\r\n");
            //sb.Append("合计：   2   18元\r\n");
            //sb.Append("---收银员：张三---\r\n");
            //sb.Append("---技术支持：李四---\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");

            DrawPrint(e, sb.ToString(), BarcodeString, ImgWidth, ImgHeight);
            //Font font = new Font("宋体", 14);
            //Font font1 = new Font("宋体", 11);
            //Brush bru = Brushes.Black;
            //e.Graphics.DrawString("XXXXXX ", font, bru, 130, 35);
            //e.Graphics.DrawString("订单号： ", font1, bru, 100, 65);
            //e.Graphics.DrawString("13216543214313", font1, bru, 185, 65);
            //e.Graphics.DrawString("XXXXXX：", font1, bru, 350, 65);
            //e.Graphics.DrawString("XXXXXX", font1, bru, 400, 65);

        }

        /// <summary>
        /// 绘制打印内容
        /// </summary>
        /// <param name="e">PrintPageEventArgs</param>
        /// <param name="PrintStr">需要打印的文本</param>
        /// <param name="BarcodeStr">条码</param>
        public void DrawPrint(PrintPageEventArgs e, string PrintStr, string BarcodeStr, int BarcodeWidth, int BarcodeHeight)
        {
            try
            {
                //绘制打印字符串
                e.Graphics.DrawString(PrintStr, new Font(new FontFamily("黑体"), 10), System.Drawing.Brushes.Black, 1, 1);

                if (!string.IsNullOrEmpty(BarcodeStr))
                {
                    int PrintWidth = 175;
                    int PrintHeight = 35;
                    //绘制打印图片
                    e.Graphics.DrawImage(CreateBarcodePicture(BarcodeStr, BarcodeWidth, BarcodeHeight), 0, 0, PrintWidth, PrintHeight);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        /// <summary>
        /// 根据字符串生成条码图片( 需添加引用：BarcodeLib.dll )
        /// </summary>
        /// <param name="BarcodeString">条码字符串</param>
        /// <param name="ImgWidth">图片宽带</param>
        /// <param name="ImgHeight">图片高度</param>
        /// <returns></returns>
        public System.Drawing.Image CreateBarcodePicture(string BarcodeString, int ImgWidth, int ImgHeight)
        {
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();//实例化一个条码对象
            BarcodeLib.TYPE type = BarcodeLib.TYPE.CODE128;//编码类型

            //获取条码图片
            System.Drawing.Image BarcodePicture = b.Encode(type, BarcodeString, System.Drawing.Color.Black, System.Drawing.Color.White, ImgWidth, ImgHeight);

            //BarcodePicture.Save(@"D:\Barcode.jpg");

            //b.Dispose();

            return BarcodePicture;
        }


        //预览条码
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = CreateBarcodePicture(BarcodeString, ImgWidth, ImgHeight);
            label1.Text = Token.once;
        }

        private void printDocument1_QueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {

        }
    }
}
