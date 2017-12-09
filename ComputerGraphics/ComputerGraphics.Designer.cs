using System.Collections.Generic;
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
            this.panelPixel = new System.Windows.Forms.Panel();
            this.panelHistogram = new System.Windows.Forms.Panel();
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
            this.button7BuildHistogram = new System.Windows.Forms.Button();
            this.button7ChooseImage = new System.Windows.Forms.Button();
            this.pictureBox7ExploredImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.button8SaveImage = new System.Windows.Forms.Button();
            this.button8ChooseImage = new System.Windows.Forms.Button();
            this.pictureBox8UntreatedImage = new System.Windows.Forms.PictureBox();
            this.button8ConvertingToHalftone = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label9UpperLimitValue = new System.Windows.Forms.Label();
            this.label9LowerLimitValue = new System.Windows.Forms.Label();
            this.label9UpperLimit = new System.Windows.Forms.Label();
            this.label9LowerLimit = new System.Windows.Forms.Label();
            this.trackBar9UpperLimit = new System.Windows.Forms.TrackBar();
            this.trackBar9LowerLimit = new System.Windows.Forms.TrackBar();
            this.comboBox9BinarizationMethods = new System.Windows.Forms.ComboBox();
            this.button9SaveImage = new System.Windows.Forms.Button();
            this.button9ChooseImage = new System.Windows.Forms.Button();
            this.button9ConvertingToBinary = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox9UntreatedImage = new System.Windows.Forms.PictureBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabControl10 = new System.Windows.Forms.TabControl();
            this.tabPage10AddingNoise = new System.Windows.Forms.TabPage();
            this.button10AddNoise = new System.Windows.Forms.Button();
            this.label10ProbabilityValue = new System.Windows.Forms.Label();
            this.label10Probability = new System.Windows.Forms.Label();
            this.trackBar10Probability = new System.Windows.Forms.TrackBar();
            this.groupBox10NoiseType = new System.Windows.Forms.GroupBox();
            this.radioButton10ImpulseNoise = new System.Windows.Forms.RadioButton();
            this.radioButton10SaltAndPepperNoise = new System.Windows.Forms.RadioButton();
            this.tabPage10RemovingNoise = new System.Windows.Forms.TabPage();
            this.label10NeighbourhoodSizeValue = new System.Windows.Forms.Label();
            this.label10NeighbourhoodSize = new System.Windows.Forms.Label();
            this.trackBar10NeighbourhoodSize = new System.Windows.Forms.TrackBar();
            this.button10RemoveNoise = new System.Windows.Forms.Button();
            this.groupBox10FilterType = new System.Windows.Forms.GroupBox();
            this.radioButton10MedianFilter = new System.Windows.Forms.RadioButton();
            this.radioButton10LogicalFilter = new System.Windows.Forms.RadioButton();
            this.button10SaveImage = new System.Windows.Forms.Button();
            this.button10ChooseImage = new System.Windows.Forms.Button();
            this.pictureBox10UntreatedImage = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.buttonRefreshPanel = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7ExploredImage)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8UntreatedImage)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9UpperLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9LowerLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9UntreatedImage)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.tabControl10.SuspendLayout();
            this.tabPage10AddingNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10Probability)).BeginInit();
            this.groupBox10NoiseType.SuspendLayout();
            this.tabPage10RemovingNoise.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10NeighbourhoodSize)).BeginInit();
            this.groupBox10FilterType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10UntreatedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPixel
            // 
            this.panelPixel.BackColor = System.Drawing.Color.White;
            this.panelPixel.Location = new System.Drawing.Point(0, 0);
            this.panelPixel.Name = "panelPixel";
            this.panelPixel.Size = new System.Drawing.Size(900, 600);
            this.panelPixel.TabIndex = 0;
            this.panelPixel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPixel_Paint);
            // 
            // panelHistogram
            // 
            this.panelHistogram.BackColor = System.Drawing.Color.White;
            this.panelHistogram.Location = new System.Drawing.Point(0, 0);
            this.panelHistogram.Name = "panelHistogram";
            this.panelHistogram.Size = new System.Drawing.Size(900, 600);
            this.panelHistogram.TabIndex = 1;
            this.panelHistogram.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
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
            this.tabControl.Location = new System.Drawing.Point(904, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(195, 530);
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
            this.tabPage2.Size = new System.Drawing.Size(187, 486);
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
            this.tabPage3.Size = new System.Drawing.Size(187, 486);
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
            this.tabPage4.Size = new System.Drawing.Size(187, 486);
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
            this.tabPage5.Size = new System.Drawing.Size(187, 486);
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
            this.tabPage6.Size = new System.Drawing.Size(187, 486);
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
            this.tabPage7.Controls.Add(this.button7BuildHistogram);
            this.tabPage7.Controls.Add(this.button7ChooseImage);
            this.tabPage7.Controls.Add(this.pictureBox7ExploredImage);
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Location = new System.Drawing.Point(4, 40);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(187, 486);
            this.tabPage7.TabIndex = 5;
            this.tabPage7.Text = "7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // button7BuildHistogram
            // 
            this.button7BuildHistogram.Location = new System.Drawing.Point(5, 299);
            this.button7BuildHistogram.Name = "button7BuildHistogram";
            this.button7BuildHistogram.Size = new System.Drawing.Size(175, 60);
            this.button7BuildHistogram.TabIndex = 15;
            this.button7BuildHistogram.Text = "Build a histogram";
            this.button7BuildHistogram.UseVisualStyleBackColor = true;
            this.button7BuildHistogram.Click += new System.EventHandler(this.button7BuildHistogram_Click);
            // 
            // button7ChooseImage
            // 
            this.button7ChooseImage.Location = new System.Drawing.Point(5, 211);
            this.button7ChooseImage.Name = "button7ChooseImage";
            this.button7ChooseImage.Size = new System.Drawing.Size(175, 50);
            this.button7ChooseImage.TabIndex = 14;
            this.button7ChooseImage.Text = "Choose image";
            this.button7ChooseImage.UseVisualStyleBackColor = true;
            this.button7ChooseImage.Click += new System.EventHandler(this.button7ChooseImage_Click);
            // 
            // pictureBox7ExploredImage
            // 
            this.pictureBox7ExploredImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7ExploredImage.Location = new System.Drawing.Point(5, 40);
            this.pictureBox7ExploredImage.Name = "pictureBox7ExploredImage";
            this.pictureBox7ExploredImage.Size = new System.Drawing.Size(175, 165);
            this.pictureBox7ExploredImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7ExploredImage.TabIndex = 13;
            this.pictureBox7ExploredImage.TabStop = false;
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
            this.tabPage8.Size = new System.Drawing.Size(187, 486);
            this.tabPage8.TabIndex = 6;
            this.tabPage8.Text = "8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // button8SaveImage
            // 
            this.button8SaveImage.Location = new System.Drawing.Point(6, 274);
            this.button8SaveImage.Name = "button8SaveImage";
            this.button8SaveImage.Size = new System.Drawing.Size(175, 50);
            this.button8SaveImage.TabIndex = 14;
            this.button8SaveImage.Text = "Save";
            this.button8SaveImage.UseVisualStyleBackColor = true;
            this.button8SaveImage.Click += new System.EventHandler(this.button8Save_Click);
            // 
            // button8ChooseImage
            // 
            this.button8ChooseImage.Location = new System.Drawing.Point(6, 208);
            this.button8ChooseImage.Name = "button8ChooseImage";
            this.button8ChooseImage.Size = new System.Drawing.Size(175, 50);
            this.button8ChooseImage.TabIndex = 13;
            this.button8ChooseImage.Text = "Choose image";
            this.button8ChooseImage.UseVisualStyleBackColor = true;
            this.button8ChooseImage.Click += new System.EventHandler(this.button8ChooseImage_Click);
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
            this.button8ConvertingToHalftone.Location = new System.Drawing.Point(6, 351);
            this.button8ConvertingToHalftone.Name = "button8ConvertingToHalftone";
            this.button8ConvertingToHalftone.Size = new System.Drawing.Size(175, 60);
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
            this.tabPage9.Controls.Add(this.label9UpperLimitValue);
            this.tabPage9.Controls.Add(this.label9LowerLimitValue);
            this.tabPage9.Controls.Add(this.label9UpperLimit);
            this.tabPage9.Controls.Add(this.label9LowerLimit);
            this.tabPage9.Controls.Add(this.trackBar9UpperLimit);
            this.tabPage9.Controls.Add(this.trackBar9LowerLimit);
            this.tabPage9.Controls.Add(this.comboBox9BinarizationMethods);
            this.tabPage9.Controls.Add(this.button9SaveImage);
            this.tabPage9.Controls.Add(this.button9ChooseImage);
            this.tabPage9.Controls.Add(this.button9ConvertingToBinary);
            this.tabPage9.Controls.Add(this.label9);
            this.tabPage9.Controls.Add(this.pictureBox9UntreatedImage);
            this.tabPage9.Location = new System.Drawing.Point(4, 40);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(187, 486);
            this.tabPage9.TabIndex = 7;
            this.tabPage9.Text = "9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // label9UpperLimitValue
            // 
            this.label9UpperLimitValue.AutoSize = true;
            this.label9UpperLimitValue.Location = new System.Drawing.Point(94, 329);
            this.label9UpperLimitValue.Name = "label9UpperLimitValue";
            this.label9UpperLimitValue.Size = new System.Drawing.Size(25, 13);
            this.label9UpperLimitValue.TabIndex = 24;
            this.label9UpperLimitValue.Text = "128";
            // 
            // label9LowerLimitValue
            // 
            this.label9LowerLimitValue.AutoSize = true;
            this.label9LowerLimitValue.Location = new System.Drawing.Point(94, 265);
            this.label9LowerLimitValue.Name = "label9LowerLimitValue";
            this.label9LowerLimitValue.Size = new System.Drawing.Size(25, 13);
            this.label9LowerLimitValue.TabIndex = 23;
            this.label9LowerLimitValue.Text = "128";
            // 
            // label9UpperLimit
            // 
            this.label9UpperLimit.AutoSize = true;
            this.label9UpperLimit.Location = new System.Drawing.Point(28, 329);
            this.label9UpperLimit.Name = "label9UpperLimit";
            this.label9UpperLimit.Size = new System.Drawing.Size(62, 13);
            this.label9UpperLimit.TabIndex = 22;
            this.label9UpperLimit.Text = "Upper limit :";
            // 
            // label9LowerLimit
            // 
            this.label9LowerLimit.AutoSize = true;
            this.label9LowerLimit.Location = new System.Drawing.Point(28, 265);
            this.label9LowerLimit.Name = "label9LowerLimit";
            this.label9LowerLimit.Size = new System.Drawing.Size(62, 13);
            this.label9LowerLimit.TabIndex = 21;
            this.label9LowerLimit.Text = "Lower limit :";
            // 
            // trackBar9UpperLimit
            // 
            this.trackBar9UpperLimit.LargeChange = 32;
            this.trackBar9UpperLimit.Location = new System.Drawing.Point(7, 345);
            this.trackBar9UpperLimit.Maximum = 255;
            this.trackBar9UpperLimit.Name = "trackBar9UpperLimit";
            this.trackBar9UpperLimit.Size = new System.Drawing.Size(174, 45);
            this.trackBar9UpperLimit.SmallChange = 16;
            this.trackBar9UpperLimit.TabIndex = 20;
            this.trackBar9UpperLimit.TickFrequency = 16;
            this.trackBar9UpperLimit.Value = 128;
            this.trackBar9UpperLimit.Scroll += new System.EventHandler(this.trackBar9UpperLimit_Scroll);
            // 
            // trackBar9LowerLimit
            // 
            this.trackBar9LowerLimit.LargeChange = 32;
            this.trackBar9LowerLimit.Location = new System.Drawing.Point(7, 281);
            this.trackBar9LowerLimit.Maximum = 255;
            this.trackBar9LowerLimit.Name = "trackBar9LowerLimit";
            this.trackBar9LowerLimit.Size = new System.Drawing.Size(174, 45);
            this.trackBar9LowerLimit.SmallChange = 16;
            this.trackBar9LowerLimit.TabIndex = 19;
            this.trackBar9LowerLimit.TickFrequency = 16;
            this.trackBar9LowerLimit.Value = 128;
            this.trackBar9LowerLimit.Scroll += new System.EventHandler(this.trackBar9LowerLimit_Scroll);
            // 
            // comboBox9BinarizationMethods
            // 
            this.comboBox9BinarizationMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9BinarizationMethods.Items.AddRange(new object[] {
            "With lower limit",
            "With upper limit",
            "Double-limited"});
            this.comboBox9BinarizationMethods.Location = new System.Drawing.Point(6, 241);
            this.comboBox9BinarizationMethods.Name = "comboBox9BinarizationMethods";
            this.comboBox9BinarizationMethods.Size = new System.Drawing.Size(175, 21);
            this.comboBox9BinarizationMethods.TabIndex = 18;
            this.comboBox9BinarizationMethods.SelectedIndexChanged += new System.EventHandler(this.comboBox9BinarizationMethods_SelectedIndexChanged);
            // 
            // button9SaveImage
            // 
            this.button9SaveImage.Location = new System.Drawing.Point(97, 205);
            this.button9SaveImage.Name = "button9SaveImage";
            this.button9SaveImage.Size = new System.Drawing.Size(84, 30);
            this.button9SaveImage.TabIndex = 17;
            this.button9SaveImage.Text = "Save";
            this.button9SaveImage.UseVisualStyleBackColor = true;
            this.button9SaveImage.Click += new System.EventHandler(this.button9SaveImage_Click);
            // 
            // button9ChooseImage
            // 
            this.button9ChooseImage.Location = new System.Drawing.Point(6, 205);
            this.button9ChooseImage.Name = "button9ChooseImage";
            this.button9ChooseImage.Size = new System.Drawing.Size(84, 30);
            this.button9ChooseImage.TabIndex = 16;
            this.button9ChooseImage.Text = "Choose image";
            this.button9ChooseImage.UseVisualStyleBackColor = true;
            this.button9ChooseImage.Click += new System.EventHandler(this.button9ChooseImage_Click);
            // 
            // button9ConvertingToBinary
            // 
            this.button9ConvertingToBinary.Location = new System.Drawing.Point(21, 396);
            this.button9ConvertingToBinary.Name = "button9ConvertingToBinary";
            this.button9ConvertingToBinary.Size = new System.Drawing.Size(147, 43);
            this.button9ConvertingToBinary.TabIndex = 15;
            this.button9ConvertingToBinary.Text = "Converting";
            this.button9ConvertingToBinary.UseVisualStyleBackColor = true;
            this.button9ConvertingToBinary.Click += new System.EventHandler(this.button9ConvertingToBinary_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Binarization of halftone images";
            // 
            // pictureBox9UntreatedImage
            // 
            this.pictureBox9UntreatedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9UntreatedImage.Location = new System.Drawing.Point(6, 34);
            this.pictureBox9UntreatedImage.Name = "pictureBox9UntreatedImage";
            this.pictureBox9UntreatedImage.Size = new System.Drawing.Size(175, 165);
            this.pictureBox9UntreatedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9UntreatedImage.TabIndex = 13;
            this.pictureBox9UntreatedImage.TabStop = false;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.tabControl10);
            this.tabPage10.Controls.Add(this.button10SaveImage);
            this.tabPage10.Controls.Add(this.button10ChooseImage);
            this.tabPage10.Controls.Add(this.pictureBox10UntreatedImage);
            this.tabPage10.Controls.Add(this.label10);
            this.tabPage10.Location = new System.Drawing.Point(4, 40);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(187, 486);
            this.tabPage10.TabIndex = 8;
            this.tabPage10.Text = "10";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabControl10
            // 
            this.tabControl10.Controls.Add(this.tabPage10AddingNoise);
            this.tabControl10.Controls.Add(this.tabPage10RemovingNoise);
            this.tabControl10.Location = new System.Drawing.Point(7, 227);
            this.tabControl10.Name = "tabControl10";
            this.tabControl10.SelectedIndex = 0;
            this.tabControl10.Size = new System.Drawing.Size(173, 253);
            this.tabControl10.TabIndex = 19;
            // 
            // tabPage10AddingNoise
            // 
            this.tabPage10AddingNoise.Controls.Add(this.button10AddNoise);
            this.tabPage10AddingNoise.Controls.Add(this.label10ProbabilityValue);
            this.tabPage10AddingNoise.Controls.Add(this.label10Probability);
            this.tabPage10AddingNoise.Controls.Add(this.trackBar10Probability);
            this.tabPage10AddingNoise.Controls.Add(this.groupBox10NoiseType);
            this.tabPage10AddingNoise.Location = new System.Drawing.Point(4, 22);
            this.tabPage10AddingNoise.Name = "tabPage10AddingNoise";
            this.tabPage10AddingNoise.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10AddingNoise.Size = new System.Drawing.Size(165, 227);
            this.tabPage10AddingNoise.TabIndex = 0;
            this.tabPage10AddingNoise.Text = "Add noise";
            this.tabPage10AddingNoise.UseVisualStyleBackColor = true;
            // 
            // button10AddNoise
            // 
            this.button10AddNoise.Location = new System.Drawing.Point(6, 183);
            this.button10AddNoise.Name = "button10AddNoise";
            this.button10AddNoise.Size = new System.Drawing.Size(153, 38);
            this.button10AddNoise.TabIndex = 23;
            this.button10AddNoise.Text = "Add";
            this.button10AddNoise.UseVisualStyleBackColor = true;
            this.button10AddNoise.Click += new System.EventHandler(this.button10AddNoise_Click);
            // 
            // label10ProbabilityValue
            // 
            this.label10ProbabilityValue.AutoSize = true;
            this.label10ProbabilityValue.Location = new System.Drawing.Point(95, 90);
            this.label10ProbabilityValue.Name = "label10ProbabilityValue";
            this.label10ProbabilityValue.Size = new System.Drawing.Size(30, 13);
            this.label10ProbabilityValue.TabIndex = 22;
            this.label10ProbabilityValue.Text = "25 %";
            // 
            // label10Probability
            // 
            this.label10Probability.AutoSize = true;
            this.label10Probability.Location = new System.Drawing.Point(36, 90);
            this.label10Probability.Name = "label10Probability";
            this.label10Probability.Size = new System.Drawing.Size(61, 13);
            this.label10Probability.TabIndex = 21;
            this.label10Probability.Text = "Probability :";
            // 
            // trackBar10Probability
            // 
            this.trackBar10Probability.Location = new System.Drawing.Point(6, 109);
            this.trackBar10Probability.Maximum = 50;
            this.trackBar10Probability.Name = "trackBar10Probability";
            this.trackBar10Probability.Size = new System.Drawing.Size(153, 45);
            this.trackBar10Probability.SmallChange = 2;
            this.trackBar10Probability.TabIndex = 20;
            this.trackBar10Probability.TickFrequency = 5;
            this.trackBar10Probability.Value = 25;
            this.trackBar10Probability.Scroll += new System.EventHandler(this.trackBar10Probability_Scroll);
            // 
            // groupBox10NoiseType
            // 
            this.groupBox10NoiseType.Controls.Add(this.radioButton10ImpulseNoise);
            this.groupBox10NoiseType.Controls.Add(this.radioButton10SaltAndPepperNoise);
            this.groupBox10NoiseType.Location = new System.Drawing.Point(6, 6);
            this.groupBox10NoiseType.Name = "groupBox10NoiseType";
            this.groupBox10NoiseType.Size = new System.Drawing.Size(153, 71);
            this.groupBox10NoiseType.TabIndex = 0;
            this.groupBox10NoiseType.TabStop = false;
            this.groupBox10NoiseType.Text = "Noise type";
            // 
            // radioButton10ImpulseNoise
            // 
            this.radioButton10ImpulseNoise.AutoSize = true;
            this.radioButton10ImpulseNoise.Location = new System.Drawing.Point(7, 42);
            this.radioButton10ImpulseNoise.Name = "radioButton10ImpulseNoise";
            this.radioButton10ImpulseNoise.Size = new System.Drawing.Size(61, 17);
            this.radioButton10ImpulseNoise.TabIndex = 1;
            this.radioButton10ImpulseNoise.TabStop = true;
            this.radioButton10ImpulseNoise.Text = "Impulse";
            this.radioButton10ImpulseNoise.UseVisualStyleBackColor = true;
            // 
            // radioButton10SaltAndPepperNoise
            // 
            this.radioButton10SaltAndPepperNoise.AutoSize = true;
            this.radioButton10SaltAndPepperNoise.Checked = true;
            this.radioButton10SaltAndPepperNoise.Location = new System.Drawing.Point(7, 19);
            this.radioButton10SaltAndPepperNoise.Name = "radioButton10SaltAndPepperNoise";
            this.radioButton10SaltAndPepperNoise.Size = new System.Drawing.Size(100, 17);
            this.radioButton10SaltAndPepperNoise.TabIndex = 0;
            this.radioButton10SaltAndPepperNoise.TabStop = true;
            this.radioButton10SaltAndPepperNoise.Text = "Salt and pepper";
            this.radioButton10SaltAndPepperNoise.UseVisualStyleBackColor = true;
            // 
            // tabPage10RemovingNoise
            // 
            this.tabPage10RemovingNoise.Controls.Add(this.label10NeighbourhoodSizeValue);
            this.tabPage10RemovingNoise.Controls.Add(this.label10NeighbourhoodSize);
            this.tabPage10RemovingNoise.Controls.Add(this.trackBar10NeighbourhoodSize);
            this.tabPage10RemovingNoise.Controls.Add(this.button10RemoveNoise);
            this.tabPage10RemovingNoise.Controls.Add(this.groupBox10FilterType);
            this.tabPage10RemovingNoise.Location = new System.Drawing.Point(4, 22);
            this.tabPage10RemovingNoise.Name = "tabPage10RemovingNoise";
            this.tabPage10RemovingNoise.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10RemovingNoise.Size = new System.Drawing.Size(165, 227);
            this.tabPage10RemovingNoise.TabIndex = 1;
            this.tabPage10RemovingNoise.Text = "Remove noise";
            this.tabPage10RemovingNoise.UseVisualStyleBackColor = true;
            // 
            // label10NeighbourhoodSizeValue
            // 
            this.label10NeighbourhoodSizeValue.AutoSize = true;
            this.label10NeighbourhoodSizeValue.Location = new System.Drawing.Point(115, 90);
            this.label10NeighbourhoodSizeValue.Name = "label10NeighbourhoodSizeValue";
            this.label10NeighbourhoodSizeValue.Size = new System.Drawing.Size(30, 13);
            this.label10NeighbourhoodSizeValue.TabIndex = 27;
            this.label10NeighbourhoodSizeValue.Text = "3 x 3";
            // 
            // label10NeighbourhoodSize
            // 
            this.label10NeighbourhoodSize.AutoSize = true;
            this.label10NeighbourhoodSize.Location = new System.Drawing.Point(10, 90);
            this.label10NeighbourhoodSize.Name = "label10NeighbourhoodSize";
            this.label10NeighbourhoodSize.Size = new System.Drawing.Size(107, 13);
            this.label10NeighbourhoodSize.TabIndex = 26;
            this.label10NeighbourhoodSize.Text = "Neighbourhood size :";
            // 
            // trackBar10NeighbourhoodSize
            // 
            this.trackBar10NeighbourhoodSize.LargeChange = 1;
            this.trackBar10NeighbourhoodSize.Location = new System.Drawing.Point(6, 109);
            this.trackBar10NeighbourhoodSize.Maximum = 7;
            this.trackBar10NeighbourhoodSize.Minimum = 1;
            this.trackBar10NeighbourhoodSize.Name = "trackBar10NeighbourhoodSize";
            this.trackBar10NeighbourhoodSize.Size = new System.Drawing.Size(153, 45);
            this.trackBar10NeighbourhoodSize.TabIndex = 25;
            this.trackBar10NeighbourhoodSize.Value = 1;
            this.trackBar10NeighbourhoodSize.Scroll += new System.EventHandler(this.trackBar10NeighbourhoodSize_Scroll);
            // 
            // button10RemoveNoise
            // 
            this.button10RemoveNoise.Location = new System.Drawing.Point(6, 183);
            this.button10RemoveNoise.Name = "button10RemoveNoise";
            this.button10RemoveNoise.Size = new System.Drawing.Size(153, 38);
            this.button10RemoveNoise.TabIndex = 24;
            this.button10RemoveNoise.Text = "Remove";
            this.button10RemoveNoise.UseVisualStyleBackColor = true;
            this.button10RemoveNoise.Click += new System.EventHandler(this.button10RemoveNoise_Click);
            // 
            // groupBox10FilterType
            // 
            this.groupBox10FilterType.Controls.Add(this.radioButton10MedianFilter);
            this.groupBox10FilterType.Controls.Add(this.radioButton10LogicalFilter);
            this.groupBox10FilterType.Location = new System.Drawing.Point(6, 6);
            this.groupBox10FilterType.Name = "groupBox10FilterType";
            this.groupBox10FilterType.Size = new System.Drawing.Size(153, 71);
            this.groupBox10FilterType.TabIndex = 1;
            this.groupBox10FilterType.TabStop = false;
            this.groupBox10FilterType.Text = "Filter type";
            // 
            // radioButton10MedianFilter
            // 
            this.radioButton10MedianFilter.AutoSize = true;
            this.radioButton10MedianFilter.Location = new System.Drawing.Point(7, 42);
            this.radioButton10MedianFilter.Name = "radioButton10MedianFilter";
            this.radioButton10MedianFilter.Size = new System.Drawing.Size(60, 17);
            this.radioButton10MedianFilter.TabIndex = 1;
            this.radioButton10MedianFilter.TabStop = true;
            this.radioButton10MedianFilter.Text = "Median";
            this.radioButton10MedianFilter.UseVisualStyleBackColor = true;
            // 
            // radioButton10LogicalFilter
            // 
            this.radioButton10LogicalFilter.AutoSize = true;
            this.radioButton10LogicalFilter.Checked = true;
            this.radioButton10LogicalFilter.Location = new System.Drawing.Point(7, 19);
            this.radioButton10LogicalFilter.Name = "radioButton10LogicalFilter";
            this.radioButton10LogicalFilter.Size = new System.Drawing.Size(59, 17);
            this.radioButton10LogicalFilter.TabIndex = 0;
            this.radioButton10LogicalFilter.TabStop = true;
            this.radioButton10LogicalFilter.Text = "Logical";
            this.radioButton10LogicalFilter.UseVisualStyleBackColor = true;
            // 
            // button10SaveImage
            // 
            this.button10SaveImage.Location = new System.Drawing.Point(96, 190);
            this.button10SaveImage.Name = "button10SaveImage";
            this.button10SaveImage.Size = new System.Drawing.Size(84, 30);
            this.button10SaveImage.TabIndex = 18;
            this.button10SaveImage.Text = "Save";
            this.button10SaveImage.UseVisualStyleBackColor = true;
            this.button10SaveImage.Click += new System.EventHandler(this.button10SaveImage_Click);
            // 
            // button10ChooseImage
            // 
            this.button10ChooseImage.Location = new System.Drawing.Point(5, 190);
            this.button10ChooseImage.Name = "button10ChooseImage";
            this.button10ChooseImage.Size = new System.Drawing.Size(84, 30);
            this.button10ChooseImage.TabIndex = 17;
            this.button10ChooseImage.Text = "Choose image";
            this.button10ChooseImage.UseVisualStyleBackColor = true;
            this.button10ChooseImage.Click += new System.EventHandler(this.button10ChooseImage_Click);
            // 
            // pictureBox10UntreatedImage
            // 
            this.pictureBox10UntreatedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox10UntreatedImage.Location = new System.Drawing.Point(5, 19);
            this.pictureBox10UntreatedImage.Name = "pictureBox10UntreatedImage";
            this.pictureBox10UntreatedImage.Size = new System.Drawing.Size(175, 165);
            this.pictureBox10UntreatedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10UntreatedImage.TabIndex = 16;
            this.pictureBox10UntreatedImage.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Noise elimination on a binary image";
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 40);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(187, 486);
            this.tabPage11.TabIndex = 9;
            this.tabPage11.Text = "11";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 40);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(187, 486);
            this.tabPage12.TabIndex = 10;
            this.tabPage12.Text = "12";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 40);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(187, 486);
            this.tabPage13.TabIndex = 11;
            this.tabPage13.Text = "13";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 40);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(187, 486);
            this.tabPage14.TabIndex = 12;
            this.tabPage14.Text = "14";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Location = new System.Drawing.Point(4, 40);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(187, 486);
            this.tabPage15.TabIndex = 13;
            this.tabPage15.Text = "15";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshPanel
            // 
            this.buttonRefreshPanel.Location = new System.Drawing.Point(945, 555);
            this.buttonRefreshPanel.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRefreshPanel.Name = "buttonRefreshPanel";
            this.buttonRefreshPanel.Size = new System.Drawing.Size(108, 35);
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
            this.Controls.Add(this.panelHistogram);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panelPixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1116, 638);
            this.MinimumSize = new System.Drawing.Size(1116, 638);
            this.Name = "ComputerGraphics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer graphics";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7ExploredImage)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8UntreatedImage)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9UpperLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9LowerLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9UntreatedImage)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabControl10.ResumeLayout(false);
            this.tabPage10AddingNoise.ResumeLayout(false);
            this.tabPage10AddingNoise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10Probability)).EndInit();
            this.groupBox10NoiseType.ResumeLayout(false);
            this.groupBox10NoiseType.PerformLayout();
            this.tabPage10RemovingNoise.ResumeLayout(false);
            this.tabPage10RemovingNoise.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10NeighbourhoodSize)).EndInit();
            this.groupBox10FilterType.ResumeLayout(false);
            this.groupBox10FilterType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10UntreatedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelPixel;
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
        private Label label9;
        private PictureBox pictureBox9UntreatedImage;
        private Button button9SaveImage;
        private Button button9ChooseImage;
        private Button button9ConvertingToBinary;
        private ComboBox comboBox9BinarizationMethods;
        private TrackBar trackBar9LowerLimit;
        private TrackBar trackBar9UpperLimit;
        private Label label9LowerLimit;
        private Label label9UpperLimit;
        private Label label9UpperLimitValue;
        private Label label9LowerLimitValue;
        private Button button7BuildHistogram;
        private Button button7ChooseImage;
        private PictureBox pictureBox7ExploredImage;
        private Panel panelHistogram;
        private Label label10;
        private Button button10SaveImage;
        private Button button10ChooseImage;
        private PictureBox pictureBox10UntreatedImage;
        private TabControl tabControl10;
        private TabPage tabPage10AddingNoise;
        private TabPage tabPage10RemovingNoise;
        private GroupBox groupBox10NoiseType;
        private RadioButton radioButton10ImpulseNoise;
        private RadioButton radioButton10SaltAndPepperNoise;
        private Label label10ProbabilityValue;
        private Label label10Probability;
        private TrackBar trackBar10Probability;
        private Button button10AddNoise;
        private Label label10NeighbourhoodSizeValue;
        private Label label10NeighbourhoodSize;
        private TrackBar trackBar10NeighbourhoodSize;
        private Button button10RemoveNoise;
        private GroupBox groupBox10FilterType;
        private RadioButton radioButton10MedianFilter;
        private RadioButton radioButton10LogicalFilter;
    }
}
