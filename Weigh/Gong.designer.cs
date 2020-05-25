namespace Weigh1
{
    partial class Gong
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ucPagerControl22 = new HZH_Controls.Controls.UCPagerControl2();
            this.comboBo1 = new CCWin.SkinControl.SkinComboBox();
            this.comboBo2 = new CCWin.SkinControl.SkinComboBox();
            this.comboBo3 = new CCWin.SkinControl.SkinComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtorderno = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.datagonglist = new HZH_Controls.Controls.UCDataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ctiem = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wifo = new System.Windows.Forms.Label();
            this.wifo1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wifo1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.ucPagerControl22);
            this.panel1.Controls.Add(this.comboBo1);
            this.panel1.Controls.Add(this.comboBo2);
            this.panel1.Controls.Add(this.comboBo3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 588);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 112);
            this.panel1.TabIndex = 56;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(969, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(302, 50);
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // ucPagerControl22
            // 
            this.ucPagerControl22.BackColor = System.Drawing.Color.White;
            this.ucPagerControl22.DataSource = ((System.Collections.Generic.List<object>)(resources.GetObject("ucPagerControl22.DataSource")));
            this.ucPagerControl22.Location = new System.Drawing.Point(30, 11);
            this.ucPagerControl22.Name = "ucPagerControl22";
            this.ucPagerControl22.PageCount = 0;
            this.ucPagerControl22.PageIndex = 1;
            this.ucPagerControl22.PageModel = HZH_Controls.Controls.PageModel.PageCount;
            this.ucPagerControl22.PageSize = 0;
            this.ucPagerControl22.Size = new System.Drawing.Size(1123, 30);
            this.ucPagerControl22.StartIndex = 0;
            this.ucPagerControl22.TabIndex = 85;
            this.ucPagerControl22.ShowSourceChanged += new HZH_Controls.Controls.PageControlEventHandler(this.ucPagerControl22_ShowSourceChanged);
            // 
            // comboBo1
            // 
            this.comboBo1.ArrowColor = System.Drawing.Color.Silver;
            this.comboBo1.BaseColor = System.Drawing.Color.Transparent;
            this.comboBo1.BorderColor = System.Drawing.Color.Gray;
            this.comboBo1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBo1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBo1.FormattingEnabled = true;
            this.comboBo1.ItemHeight = 20;
            this.comboBo1.Location = new System.Drawing.Point(719, 66);
            this.comboBo1.Name = "comboBo1";
            this.comboBo1.Size = new System.Drawing.Size(87, 26);
            this.comboBo1.TabIndex = 83;
            this.comboBo1.Visible = false;
            this.comboBo1.WaterText = "";
            this.comboBo1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBo2
            // 
            this.comboBo2.ArrowColor = System.Drawing.Color.Silver;
            this.comboBo2.BaseColor = System.Drawing.Color.Transparent;
            this.comboBo2.BorderColor = System.Drawing.Color.Gray;
            this.comboBo2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBo2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBo2.FormattingEnabled = true;
            this.comboBo2.ItemHeight = 20;
            this.comboBo2.Location = new System.Drawing.Point(811, 66);
            this.comboBo2.Name = "comboBo2";
            this.comboBo2.Size = new System.Drawing.Size(86, 26);
            this.comboBo2.TabIndex = 83;
            this.comboBo2.Visible = false;
            this.comboBo2.WaterText = "";
            this.comboBo2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBo3
            // 
            this.comboBo3.ArrowColor = System.Drawing.Color.Silver;
            this.comboBo3.BaseColor = System.Drawing.Color.Transparent;
            this.comboBo3.BorderColor = System.Drawing.Color.Gray;
            this.comboBo3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBo3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBo3.FormattingEnabled = true;
            this.comboBo3.ItemHeight = 20;
            this.comboBo3.Location = new System.Drawing.Point(899, 66);
            this.comboBo3.Name = "comboBo3";
            this.comboBo3.Size = new System.Drawing.Size(94, 26);
            this.comboBo3.TabIndex = 83;
            this.comboBo3.Visible = false;
            this.comboBo3.WaterText = "";
            this.comboBo3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.txtorderno);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 61);
            this.panel2.TabIndex = 57;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Weigh.Properties.Resources.j12dt1;
            this.pictureBox2.Location = new System.Drawing.Point(1274, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker3.CalendarForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker3.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(1000, 21);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(113, 27);
            this.dateTimePicker3.TabIndex = 81;
            // 
            // comboBox3
            // 
            this.comboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 20;
            this.comboBox3.Location = new System.Drawing.Point(675, 22);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(89, 26);
            this.comboBox3.TabIndex = 69;
            this.comboBox3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox4_DrawItem);
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboBox4_MouseMove);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(879, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(114, 27);
            this.dateTimePicker2.TabIndex = 82;
            // 
            // txtorderno
            // 
            this.txtorderno.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtorderno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtorderno.Location = new System.Drawing.Point(121, 21);
            this.txtorderno.Multiline = true;
            this.txtorderno.Name = "txtorderno";
            this.txtorderno.Size = new System.Drawing.Size(250, 26);
            this.txtorderno.TabIndex = 65;
            // 
            // comboBox2
            // 
            this.comboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 20;
            this.comboBox2.Location = new System.Drawing.Point(572, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(97, 26);
            this.comboBox2.TabIndex = 69;
            this.comboBox2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox4_DrawItem);
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboBox4_MouseMove);
            // 
            // comboBox4
            // 
            this.comboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.ItemHeight = 20;
            this.comboBox4.Location = new System.Drawing.Point(1177, 21);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(82, 26);
            this.comboBox4.TabIndex = 69;
            this.comboBox4.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox4_DrawItem);
            this.comboBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboBox4_MouseMove);
            // 
            // comboBox1
            // 
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Location = new System.Drawing.Point(477, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 26);
            this.comboBox1.TabIndex = 69;
            this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox4_DrawItem);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboBox4_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(386, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 62;
            this.label2.Text = "商品分类";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1119, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 64;
            this.label5.Text = "状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(780, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 63;
            this.label4.Text = "起始时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 61;
            this.label3.Text = "订单号";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1370, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(30, 527);
            this.flowLayoutPanel1.TabIndex = 59;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 527);
            this.panel3.TabIndex = 58;
            // 
            // datagonglist
            // 
            this.datagonglist.AutoScroll = true;
            this.datagonglist.BackColor = System.Drawing.Color.White;
            this.datagonglist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.datagonglist.Columns = null;
            this.datagonglist.Cursor = System.Windows.Forms.Cursors.Default;
            this.datagonglist.DataSource = null;
            this.datagonglist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagonglist.Font = new System.Drawing.Font("微软雅黑 Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datagonglist.ForeColor = System.Drawing.Color.White;
            this.datagonglist.HeadFont = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datagonglist.HeadHeight = 40;
            this.datagonglist.HeadPadingLeft = 0;
            this.datagonglist.HeadTextColor = System.Drawing.Color.Silver;
            this.datagonglist.IsShowCheckBox = true;
            this.datagonglist.IsShowHead = false;
            this.datagonglist.Location = new System.Drawing.Point(40, 96);
            this.datagonglist.Name = "datagonglist";
            this.datagonglist.RowHeight = 40;
            this.datagonglist.RowType = typeof(HZH_Controls.Controls.UCDataGridViewRow);
            this.datagonglist.Size = new System.Drawing.Size(1330, 492);
            this.datagonglist.TabIndex = 62;
            this.datagonglist.Load += new System.EventHandler(this.datagonglist_Load_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(302, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "名称";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(797, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "用户";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(432, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "数量";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(542, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "状态";
            // 
            // ctiem
            // 
            this.ctiem.AutoSize = true;
            this.ctiem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctiem.ForeColor = System.Drawing.Color.White;
            this.ctiem.Location = new System.Drawing.Point(649, 3);
            this.ctiem.Name = "ctiem";
            this.ctiem.Size = new System.Drawing.Size(92, 27);
            this.ctiem.TabIndex = 0;
            this.ctiem.Text = "创建时间";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phone.ForeColor = System.Drawing.Color.White;
            this.phone.Location = new System.Drawing.Point(931, 3);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(52, 27);
            this.phone.TabIndex = 0;
            this.phone.Text = "电话";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1158, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 27);
            this.label14.TabIndex = 0;
            this.label14.Text = "操作";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.phone);
            this.panel4.Controls.Add(this.ctiem);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(40, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1330, 35);
            this.panel4.TabIndex = 64;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(117, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "流水号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(671, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 69;
            this.label1.Text = "没有记录";
            this.label1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Weigh.Properties.Resources.页面为空;
            this.pictureBox1.Location = new System.Drawing.Point(643, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // wifo
            // 
            this.wifo.AutoSize = true;
            this.wifo.Font = new System.Drawing.Font("微软雅黑", 10.2F);
            this.wifo.ForeColor = System.Drawing.Color.Gray;
            this.wifo.Location = new System.Drawing.Point(652, 327);
            this.wifo.Name = "wifo";
            this.wifo.Size = new System.Drawing.Size(112, 23);
            this.wifo.TabIndex = 71;
            this.wifo.Text = "网络连接中断";
            this.wifo.Visible = false;
            // 
            // wifo1
            // 
            this.wifo1.Image = global::Weigh.Properties.Resources.断网;
            this.wifo1.Location = new System.Drawing.Point(643, 174);
            this.wifo1.Name = "wifo1";
            this.wifo1.Size = new System.Drawing.Size(136, 133);
            this.wifo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wifo1.TabIndex = 70;
            this.wifo1.TabStop = false;
            this.wifo1.Visible = false;
            // 
            // Gong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Weigh.Properties.Resources.图层_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.wifo);
            this.Controls.Add(this.wifo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.datagonglist);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "Gong";
            this.Size = new System.Drawing.Size(1400, 700);
            this.Load += new System.EventHandler(this.Gong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wifo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private HZH_Controls.Controls.UCDataGridView datagonglist;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox txtorderno;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ctiem;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wifo;
        private System.Windows.Forms.PictureBox wifo1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private CCWin.SkinControl.SkinComboBox comboBo1;
        private CCWin.SkinControl.SkinComboBox comboBo2;
        private CCWin.SkinControl.SkinComboBox comboBo3;
        private HZH_Controls.Controls.UCPagerControl2 ucPagerControl22;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
