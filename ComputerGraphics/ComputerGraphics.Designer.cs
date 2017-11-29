using System.ComponentModel;
using System.Windows.Forms;

namespace ComputerGraphics
{
    partial class ComputerGraphics
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2DrawLine = new System.Windows.Forms.Button();
            this.groupBox2SecondPoint = new System.Windows.Forms.GroupBox();
            this.numericUpDown2SecondY = new System.Windows.Forms.NumericUpDown();
            this.label2SecondY = new System.Windows.Forms.Label();
            this.numericUpDown2SecondX = new System.Windows.Forms.NumericUpDown();
            this.label2SecondX = new System.Windows.Forms.Label();
            this.groupBox2FirstPoint = new System.Windows.Forms.GroupBox();
            this.numericUpDown2FirstY = new System.Windows.Forms.NumericUpDown();
            this.label2FirstY = new System.Windows.Forms.Label();
            this.numericUpDown2FirstX = new System.Windows.Forms.NumericUpDown();
            this.label2FirstX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3Ellipse = new System.Windows.Forms.GroupBox();
            this.button3DrawEllipse = new System.Windows.Forms.Button();
            this.numericUpDown3B = new System.Windows.Forms.NumericUpDown();
            this.label3B = new System.Windows.Forms.Label();
            this.numericUpDown3A = new System.Windows.Forms.NumericUpDown();
            this.label3A = new System.Windows.Forms.Label();
            this.groupBox3Circle = new System.Windows.Forms.GroupBox();
            this.button3DrawCircle = new System.Windows.Forms.Button();
            this.numericUpDown3Radius = new System.Windows.Forms.NumericUpDown();
            this.label3Radius = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4FillPolygon = new System.Windows.Forms.Button();
            this.button4AddPoint = new System.Windows.Forms.Button();
            this.groupBox4AddingPoint = new System.Windows.Forms.GroupBox();
            this.numericUpDown4Y = new System.Windows.Forms.NumericUpDown();
            this.label4Y = new System.Windows.Forms.Label();
            this.numericUpDown4X = new System.Windows.Forms.NumericUpDown();
            this.label4X = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button8SaveImage = new System.Windows.Forms.Button();
            this.button8ChooseImage = new System.Windows.Forms.Button();
            this.pictureBox8UntreatedImage = new System.Windows.Forms.PictureBox();
            this.button8ConvertingToHalftone = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.buttonRefreshPanel = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2SecondPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2SecondY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2SecondX)).BeginInit();
            this.groupBox2FirstPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2FirstY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2FirstX)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3Ellipse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3A)).BeginInit();
            this.groupBox3Circle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3Radius)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4AddingPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4X)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8UntreatedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(900, 600);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(900, 600);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Controls.Add(this.tabPage8);
            this.tabControl.Controls.Add(this.tabPage9);
            this.tabControl.Controls.Add(this.tabPage10);
            this.tabControl.Controls.Add(this.tabPage11);
            this.tabControl.Controls.Add(this.tabPage12);
            this.tabControl.Controls.Add(this.tabPage13);
            this.tabControl.Controls.Add(this.tabPage14);
            this.tabControl.Controls.Add(this.tabPage15);
            this.tabControl.ItemSize = new System.Drawing.Size(26, 18);
            this.tabControl.Location = new System.Drawing.Point(902, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(195, 426);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 11;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2DrawLine);
            this.tabPage2.Controls.Add(this.groupBox2SecondPoint);
            this.tabPage2.Controls.Add(this.groupBox2FirstPoint);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(187, 382);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2DrawLine
            // 
            this.button2DrawLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2DrawLine.Location = new System.Drawing.Point(54, 306);
            this.button2DrawLine.Name = "button2DrawLine";
            this.button2DrawLine.Size = new System.Drawing.Size(87, 31);
            this.button2DrawLine.TabIndex = 12;
            this.button2DrawLine.Text = "Draw line";
            this.button2DrawLine.UseVisualStyleBackColor = true;
            this.button2DrawLine.Click += new System.EventHandler(this.buttonDrawLine_Click);
            // 
            // groupBox2SecondPoint
            // 
            this.groupBox2SecondPoint.Controls.Add(this.numericUpDown2SecondY);
            this.groupBox2SecondPoint.Controls.Add(this.label2SecondY);
            this.groupBox2SecondPoint.Controls.Add(this.numericUpDown2SecondX);
            this.groupBox2SecondPoint.Controls.Add(this.label2SecondX);
            this.groupBox2SecondPoint.Location = new System.Drawing.Point(14, 175);
            this.groupBox2SecondPoint.Margin = new System.Windows.Forms.Padding(25);
            this.groupBox2SecondPoint.Name = "groupBox2SecondPoint";
            this.groupBox2SecondPoint.Size = new System.Drawing.Size(148, 103);
            this.groupBox2SecondPoint.TabIndex = 11;
            this.groupBox2SecondPoint.TabStop = false;
            this.groupBox2SecondPoint.Text = "Second point";
            // 
            // numericUpDown2SecondY
            // 
            this.numericUpDown2SecondY.Location = new System.Drawing.Point(55, 66);
            this.numericUpDown2SecondY.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDown2SecondY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2SecondY.Name = "numericUpDown2SecondY";
            this.numericUpDown2SecondY.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2SecondY.TabIndex = 2;
            // 
            // label2SecondY
            // 
            this.label2SecondY.AutoSize = true;
            this.label2SecondY.Location = new System.Drawing.Point(19, 68);
            this.label2SecondY.Name = "label2SecondY";
            this.label2SecondY.Size = new System.Drawing.Size(23, 13);
            this.label2SecondY.TabIndex = 5;
            this.label2SecondY.Text = "Y : ";
            // 
            // numericUpDown2SecondX
            // 
            this.numericUpDown2SecondX.Location = new System.Drawing.Point(55, 26);
            this.numericUpDown2SecondX.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDown2SecondX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2SecondX.Name = "numericUpDown2SecondX";
            this.numericUpDown2SecondX.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2SecondX.TabIndex = 1;
            // 
            // label2SecondX
            // 
            this.label2SecondX.AutoSize = true;
            this.label2SecondX.Location = new System.Drawing.Point(19, 28);
            this.label2SecondX.Name = "label2SecondX";
            this.label2SecondX.Size = new System.Drawing.Size(23, 13);
            this.label2SecondX.TabIndex = 4;
            this.label2SecondX.Text = "X : ";
            // 
            // groupBox2FirstPoint
            // 
            this.groupBox2FirstPoint.Controls.Add(this.numericUpDown2FirstY);
            this.groupBox2FirstPoint.Controls.Add(this.label2FirstY);
            this.groupBox2FirstPoint.Controls.Add(this.numericUpDown2FirstX);
            this.groupBox2FirstPoint.Controls.Add(this.label2FirstX);
            this.groupBox2FirstPoint.Location = new System.Drawing.Point(14, 54);
            this.groupBox2FirstPoint.Margin = new System.Windows.Forms.Padding(25);
            this.groupBox2FirstPoint.Name = "groupBox2FirstPoint";
            this.groupBox2FirstPoint.Size = new System.Drawing.Size(148, 103);
            this.groupBox2FirstPoint.TabIndex = 10;
            this.groupBox2FirstPoint.TabStop = false;
            this.groupBox2FirstPoint.Text = "First point";
            // 
            // numericUpDown2FirstY
            // 
            this.numericUpDown2FirstY.Location = new System.Drawing.Point(55, 66);
            this.numericUpDown2FirstY.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDown2FirstY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2FirstY.Name = "numericUpDown2FirstY";
            this.numericUpDown2FirstY.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2FirstY.TabIndex = 2;
            // 
            // label2FirstY
            // 
            this.label2FirstY.AutoSize = true;
            this.label2FirstY.Location = new System.Drawing.Point(19, 68);
            this.label2FirstY.Name = "label2FirstY";
            this.label2FirstY.Size = new System.Drawing.Size(23, 13);
            this.label2FirstY.TabIndex = 5;
            this.label2FirstY.Text = "Y : ";
            // 
            // numericUpDown2FirstX
            // 
            this.numericUpDown2FirstX.Location = new System.Drawing.Point(55, 26);
            this.numericUpDown2FirstX.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDown2FirstX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2FirstX.Name = "numericUpDown2FirstX";
            this.numericUpDown2FirstX.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2FirstX.TabIndex = 1;
            // 
            // label2FirstX
            // 
            this.label2FirstX.AutoSize = true;
            this.label2FirstX.Location = new System.Drawing.Point(19, 28);
            this.label2FirstX.Name = "label2FirstX";
            this.label2FirstX.Size = new System.Drawing.Size(23, 13);
            this.label2FirstX.TabIndex = 4;
            this.label2FirstX.Text = "X : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Drawing lines";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.groupBox3Ellipse);
            this.tabPage3.Controls.Add(this.groupBox3Circle);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(187, 382);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Drawing a circle and an ellipse";
            // 
            // groupBox3Ellipse
            // 
            this.groupBox3Ellipse.Controls.Add(this.button3DrawEllipse);
            this.groupBox3Ellipse.Controls.Add(this.numericUpDown3B);
            this.groupBox3Ellipse.Controls.Add(this.label3B);
            this.groupBox3Ellipse.Controls.Add(this.numericUpDown3A);
            this.groupBox3Ellipse.Controls.Add(this.label3A);
            this.groupBox3Ellipse.Location = new System.Drawing.Point(19, 204);
            this.groupBox3Ellipse.Margin = new System.Windows.Forms.Padding(25);
            this.groupBox3Ellipse.Name = "groupBox3Ellipse";
            this.groupBox3Ellipse.Size = new System.Drawing.Size(148, 150);
            this.groupBox3Ellipse.TabIndex = 7;
            this.groupBox3Ellipse.TabStop = false;
            this.groupBox3Ellipse.Text = "Ellipse";
            // 
            // button3DrawEllipse
            // 
            this.button3DrawEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3DrawEllipse.Location = new System.Drawing.Point(22, 99);
            this.button3DrawEllipse.Name = "button3DrawEllipse";
            this.button3DrawEllipse.Size = new System.Drawing.Size(113, 31);
            this.button3DrawEllipse.TabIndex = 9;
            this.button3DrawEllipse.Text = "Draw ellipse";
            this.button3DrawEllipse.UseVisualStyleBackColor = true;
            this.button3DrawEllipse.Click += new System.EventHandler(this.buttonDrawEllipse_Click);
            // 
            // numericUpDown3B
            // 
            this.numericUpDown3B.Location = new System.Drawing.Point(55, 66);
            this.numericUpDown3B.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDown3B.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown3B.Name = "numericUpDown3B";
            this.numericUpDown3B.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown3B.TabIndex = 2;
            // 
            // label3B
            // 
            this.label3B.AutoSize = true;
            this.label3B.Location = new System.Drawing.Point(19, 68);
            this.label3B.Name = "label3B";
            this.label3B.Size = new System.Drawing.Size(23, 13);
            this.label3B.TabIndex = 5;
            this.label3B.Text = "B : ";
            // 
            // numericUpDown3A
            // 
            this.numericUpDown3A.Location = new System.Drawing.Point(55, 28);
            this.numericUpDown3A.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDown3A.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown3A.Name = "numericUpDown3A";
            this.numericUpDown3A.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown3A.TabIndex = 1;
            // 
            // label3A
            // 
            this.label3A.AutoSize = true;
            this.label3A.Location = new System.Drawing.Point(19, 28);
            this.label3A.Name = "label3A";
            this.label3A.Size = new System.Drawing.Size(23, 13);
            this.label3A.TabIndex = 4;
            this.label3A.Text = "A : ";
            // 
            // groupBox3Circle
            // 
            this.groupBox3Circle.Controls.Add(this.button3DrawCircle);
            this.groupBox3Circle.Controls.Add(this.numericUpDown3Radius);
            this.groupBox3Circle.Controls.Add(this.label3Radius);
            this.groupBox3Circle.Location = new System.Drawing.Point(19, 71);
            this.groupBox3Circle.Margin = new System.Windows.Forms.Padding(25);
            this.groupBox3Circle.Name = "groupBox3Circle";
            this.groupBox3Circle.Size = new System.Drawing.Size(148, 108);
            this.groupBox3Circle.TabIndex = 6;
            this.groupBox3Circle.TabStop = false;
            this.groupBox3Circle.Text = "Circle";
            // 
            // button3DrawCircle
            // 
            this.button3DrawCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3DrawCircle.Location = new System.Drawing.Point(22, 59);
            this.button3DrawCircle.Name = "button3DrawCircle";
            this.button3DrawCircle.Size = new System.Drawing.Size(113, 31);
            this.button3DrawCircle.TabIndex = 8;
            this.button3DrawCircle.Text = "Draw circle";
            this.button3DrawCircle.UseVisualStyleBackColor = true;
            this.button3DrawCircle.Click += new System.EventHandler(this.buttonDrawCircle_Click);
            // 
            // numericUpDown3Radius
            // 
            this.numericUpDown3Radius.Location = new System.Drawing.Point(55, 26);
            this.numericUpDown3Radius.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDown3Radius.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown3Radius.Name = "numericUpDown3Radius";
            this.numericUpDown3Radius.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown3Radius.TabIndex = 1;
            // 
            // label3Radius
            // 
            this.label3Radius.AutoSize = true;
            this.label3Radius.Location = new System.Drawing.Point(6, 28);
            this.label3Radius.Name = "label3Radius";
            this.label3Radius.Size = new System.Drawing.Size(49, 13);
            this.label3Radius.TabIndex = 4;
            this.label3Radius.Text = "Radius : ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4FillPolygon);
            this.tabPage4.Controls.Add(this.button4AddPoint);
            this.tabPage4.Controls.Add(this.groupBox4AddingPoint);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(187, 382);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4FillPolygon
            // 
            this.button4FillPolygon.Location = new System.Drawing.Point(44, 259);
            this.button4FillPolygon.Name = "button4FillPolygon";
            this.button4FillPolygon.Size = new System.Drawing.Size(113, 44);
            this.button4FillPolygon.TabIndex = 14;
            this.button4FillPolygon.Text = "Fill polygon";
            this.button4FillPolygon.UseVisualStyleBackColor = true;
            this.button4FillPolygon.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // button4AddPoint
            // 
            this.button4AddPoint.Location = new System.Drawing.Point(57, 182);
            this.button4AddPoint.Name = "button4AddPoint";
            this.button4AddPoint.Size = new System.Drawing.Size(75, 23);
            this.button4AddPoint.TabIndex = 13;
            this.button4AddPoint.Text = "Add point";
            this.button4AddPoint.UseVisualStyleBackColor = true;
            this.button4AddPoint.Click += new System.EventHandler(this.buttonAddPoint_Click);
            // 
            // groupBox4AddingPoint
            // 
            this.groupBox4AddingPoint.Controls.Add(this.numericUpDown4Y);
            this.groupBox4AddingPoint.Controls.Add(this.label4Y);
            this.groupBox4AddingPoint.Controls.Add(this.numericUpDown4X);
            this.groupBox4AddingPoint.Controls.Add(this.label4X);
            this.groupBox4AddingPoint.Location = new System.Drawing.Point(22, 51);
            this.groupBox4AddingPoint.Margin = new System.Windows.Forms.Padding(25);
            this.groupBox4AddingPoint.Name = "groupBox4AddingPoint";
            this.groupBox4AddingPoint.Size = new System.Drawing.Size(148, 103);
            this.groupBox4AddingPoint.TabIndex = 12;
            this.groupBox4AddingPoint.TabStop = false;
            this.groupBox4AddingPoint.Text = "New point";
            // 
            // numericUpDown4Y
            // 
            this.numericUpDown4Y.Location = new System.Drawing.Point(55, 66);
            this.numericUpDown4Y.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDown4Y.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown4Y.Name = "numericUpDown4Y";
            this.numericUpDown4Y.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown4Y.TabIndex = 2;
            // 
            // label4Y
            // 
            this.label4Y.AutoSize = true;
            this.label4Y.Location = new System.Drawing.Point(19, 68);
            this.label4Y.Name = "label4Y";
            this.label4Y.Size = new System.Drawing.Size(23, 13);
            this.label4Y.TabIndex = 5;
            this.label4Y.Text = "Y : ";
            // 
            // numericUpDown4X
            // 
            this.numericUpDown4X.Location = new System.Drawing.Point(55, 26);
            this.numericUpDown4X.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDown4X.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown4X.Name = "numericUpDown4X";
            this.numericUpDown4X.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown4X.TabIndex = 1;
            // 
            // label4X
            // 
            this.label4X.AutoSize = true;
            this.label4X.Location = new System.Drawing.Point(19, 28);
            this.label4X.Name = "label4X";
            this.label4X.Size = new System.Drawing.Size(23, 13);
            this.label4X.TabIndex = 4;
            this.label4X.Text = "X : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filling polygons";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Location = new System.Drawing.Point(4, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(187, 382);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Clipping";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Location = new System.Drawing.Point(4, 40);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(187, 382);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Approximation of curves";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Location = new System.Drawing.Point(4, 40);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(187, 382);
            this.tabPage7.TabIndex = 5;
            this.tabPage7.Text = "7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Building an image histogram";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.button8SaveImage);
            this.tabPage8.Controls.Add(this.button8ChooseImage);
            this.tabPage8.Controls.Add(this.pictureBox8UntreatedImage);
            this.tabPage8.Controls.Add(this.button8ConvertingToHalftone);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Location = new System.Drawing.Point(4, 40);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(187, 382);
            this.tabPage8.TabIndex = 6;
            this.tabPage8.Text = "8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // button8SaveImage
            // 
            this.button8SaveImage.Location = new System.Drawing.Point(57, 254);
            this.button8SaveImage.Name = "button8SaveImage";
            this.button8SaveImage.Size = new System.Drawing.Size(84, 30);
            this.button8SaveImage.TabIndex = 14;
            this.button8SaveImage.Text = "Save";
            this.button8SaveImage.UseVisualStyleBackColor = true;
            this.button8SaveImage.Click += new System.EventHandler(this.button8Save_Click);
            // 
            // button8ChooseImage
            // 
            this.button8ChooseImage.Location = new System.Drawing.Point(57, 208);
            this.button8ChooseImage.Name = "button8ChooseImage";
            this.button8ChooseImage.Size = new System.Drawing.Size(84, 29);
            this.button8ChooseImage.TabIndex = 13;
            this.button8ChooseImage.Text = "Choose image";
            this.button8ChooseImage.UseVisualStyleBackColor = true;
            this.button8ChooseImage.Click += new System.EventHandler(this.buttonChooseImage_Click);
            // 
            // pictureBox8UntreatedImage
            // 
            this.pictureBox8UntreatedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8UntreatedImage.Location = new System.Drawing.Point(6, 37);
            this.pictureBox8UntreatedImage.Name = "pictureBox8UntreatedImage";
            this.pictureBox8UntreatedImage.Size = new System.Drawing.Size(175, 165);
            this.pictureBox8UntreatedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8UntreatedImage.TabIndex = 12;
            this.pictureBox8UntreatedImage.TabStop = false;
            // 
            // button8ConvertingToHalftone
            // 
            this.button8ConvertingToHalftone.Location = new System.Drawing.Point(34, 320);
            this.button8ConvertingToHalftone.Name = "button8ConvertingToHalftone";
            this.button8ConvertingToHalftone.Size = new System.Drawing.Size(130, 43);
            this.button8ConvertingToHalftone.TabIndex = 11;
            this.button8ConvertingToHalftone.Text = "Converting";
            this.button8ConvertingToHalftone.UseVisualStyleBackColor = true;
            this.button8ConvertingToHalftone.Click += new System.EventHandler(this.buttonConvertingToHalftone_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Converting a color image to a halftone";
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 40);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(187, 382);
            this.tabPage9.TabIndex = 7;
            this.tabPage9.Text = "9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 40);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(187, 382);
            this.tabPage10.TabIndex = 8;
            this.tabPage10.Text = "10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 40);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(187, 382);
            this.tabPage11.TabIndex = 9;
            this.tabPage11.Text = "11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 40);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(187, 382);
            this.tabPage12.TabIndex = 10;
            this.tabPage12.Text = "12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 40);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(187, 382);
            this.tabPage13.TabIndex = 11;
            this.tabPage13.Text = "13";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 40);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(187, 382);
            this.tabPage14.TabIndex = 12;
            this.tabPage14.Text = "14";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Location = new System.Drawing.Point(4, 40);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(187, 382);
            this.tabPage15.TabIndex = 13;
            this.tabPage15.Text = "15";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshPanel
            // 
            this.buttonRefreshPanel.Location = new System.Drawing.Point(972, 565);
            this.buttonRefreshPanel.Name = "buttonRefreshPanel";
            this.buttonRefreshPanel.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshPanel.TabIndex = 12;
            this.buttonRefreshPanel.Text = "Refresh panel";
            this.buttonRefreshPanel.UseVisualStyleBackColor = true;
            this.buttonRefreshPanel.Click += new System.EventHandler(this.buttonRefreshPanel_Click);
            // 
            // ComputerGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.buttonRefreshPanel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1116, 638);
            this.MinimumSize = new System.Drawing.Size(1116, 638);
            this.Name = "ComputerGraphics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer graphics";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2SecondPoint.ResumeLayout(false);
            this.groupBox2SecondPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2SecondY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2SecondX)).EndInit();
            this.groupBox2FirstPoint.ResumeLayout(false);
            this.groupBox2FirstPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2FirstY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2FirstX)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3Ellipse.ResumeLayout(false);
            this.groupBox3Ellipse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3A)).EndInit();
            this.groupBox3Circle.ResumeLayout(false);
            this.groupBox3Circle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3Radius)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox4AddingPoint.ResumeLayout(false);
            this.groupBox4AddingPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4X)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8UntreatedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel;
        private NumericUpDown numericUpDown3Radius;
        private Label label3Radius;
        private GroupBox groupBox3Circle;
        private GroupBox groupBox3Ellipse;
        private NumericUpDown numericUpDown3B;
        private Label label3B;
        private NumericUpDown numericUpDown3A;
        private Label label3A;
        private Button button3DrawCircle;
        private Button button3DrawEllipse;
        private TabControl tabControl;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private TabPage tabPage13;
        private TabPage tabPage14;
        private TabPage tabPage15;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2FirstPoint;
        private NumericUpDown numericUpDown2FirstY;
        private Label label2FirstY;
        private NumericUpDown numericUpDown2FirstX;
        private Label label2FirstX;
        private GroupBox groupBox2SecondPoint;
        private NumericUpDown numericUpDown2SecondY;
        private Label label2SecondY;
        private NumericUpDown numericUpDown2SecondX;
        private Label label2SecondX;
        private Button button2DrawLine;
        private Button buttonRefreshPanel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button4FillPolygon;
        private Button button4AddPoint;
        private GroupBox groupBox4AddingPoint;
        private NumericUpDown numericUpDown4Y;
        private Label label4Y;
        private NumericUpDown numericUpDown4X;
        private Label label4X;
        private PictureBox pictureBox;
        private Label label7;
        private Label label8;
        private Button button8ConvertingToHalftone;
        private PictureBox pictureBox8UntreatedImage;
        private Button button8ChooseImage;
        private Button button8SaveImage;
    }
}
