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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDrawLine = new System.Windows.Forms.Button();
            this.groupBoxSecondPoint = new System.Windows.Forms.GroupBox();
            this.numericUpDownSecondY = new System.Windows.Forms.NumericUpDown();
            this.labelSecondY = new System.Windows.Forms.Label();
            this.numericUpDownSecondX = new System.Windows.Forms.NumericUpDown();
            this.labelSecondX = new System.Windows.Forms.Label();
            this.groupBoxFirstPoint = new System.Windows.Forms.GroupBox();
            this.numericUpDownFirstY = new System.Windows.Forms.NumericUpDown();
            this.labelFirstY = new System.Windows.Forms.Label();
            this.numericUpDownFirstX = new System.Windows.Forms.NumericUpDown();
            this.labelFirstX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxEllipse = new System.Windows.Forms.GroupBox();
            this.buttonDrawEllipse = new System.Windows.Forms.Button();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.labelB = new System.Windows.Forms.Label();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.labelA = new System.Windows.Forms.Label();
            this.groupBoxCircle = new System.Windows.Forms.GroupBox();
            this.buttonDrawCircle = new System.Windows.Forms.Button();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.labelRadius = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonAddPoint = new System.Windows.Forms.Button();
            this.groupBoxAddingPoint = new System.Windows.Forms.GroupBox();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.labelY = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelX = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.buttonRefreshPanel = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonConvertingToHalftone = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxSecondPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondX)).BeginInit();
            this.groupBoxFirstPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstX)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxEllipse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            this.groupBoxCircle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBoxAddingPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDrawLine);
            this.tabPage1.Controls.Add(this.groupBoxSecondPoint);
            this.tabPage1.Controls.Add(this.groupBoxFirstPoint);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(187, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDrawLine
            // 
            this.buttonDrawLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDrawLine.Location = new System.Drawing.Point(54, 306);
            this.buttonDrawLine.Name = "buttonDrawLine";
            this.buttonDrawLine.Size = new System.Drawing.Size(87, 31);
            this.buttonDrawLine.TabIndex = 12;
            this.buttonDrawLine.Text = "Draw line";
            this.buttonDrawLine.UseVisualStyleBackColor = true;
            this.buttonDrawLine.Click += new System.EventHandler(this.buttonDrawLine_Click);
            // 
            // groupBoxSecondPoint
            // 
            this.groupBoxSecondPoint.Controls.Add(this.numericUpDownSecondY);
            this.groupBoxSecondPoint.Controls.Add(this.labelSecondY);
            this.groupBoxSecondPoint.Controls.Add(this.numericUpDownSecondX);
            this.groupBoxSecondPoint.Controls.Add(this.labelSecondX);
            this.groupBoxSecondPoint.Location = new System.Drawing.Point(14, 175);
            this.groupBoxSecondPoint.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxSecondPoint.Name = "groupBoxSecondPoint";
            this.groupBoxSecondPoint.Size = new System.Drawing.Size(148, 103);
            this.groupBoxSecondPoint.TabIndex = 11;
            this.groupBoxSecondPoint.TabStop = false;
            this.groupBoxSecondPoint.Text = "Second point";
            // 
            // numericUpDownSecondY
            // 
            this.numericUpDownSecondY.Location = new System.Drawing.Point(55, 66);
            this.numericUpDownSecondY.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownSecondY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownSecondY.Name = "numericUpDownSecondY";
            this.numericUpDownSecondY.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownSecondY.TabIndex = 2;
            // 
            // labelSecondY
            // 
            this.labelSecondY.AutoSize = true;
            this.labelSecondY.Location = new System.Drawing.Point(19, 68);
            this.labelSecondY.Name = "labelSecondY";
            this.labelSecondY.Size = new System.Drawing.Size(23, 13);
            this.labelSecondY.TabIndex = 5;
            this.labelSecondY.Text = "Y : ";
            // 
            // numericUpDownSecondX
            // 
            this.numericUpDownSecondX.Location = new System.Drawing.Point(55, 26);
            this.numericUpDownSecondX.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownSecondX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownSecondX.Name = "numericUpDownSecondX";
            this.numericUpDownSecondX.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownSecondX.TabIndex = 1;
            // 
            // labelSecondX
            // 
            this.labelSecondX.AutoSize = true;
            this.labelSecondX.Location = new System.Drawing.Point(19, 28);
            this.labelSecondX.Name = "labelSecondX";
            this.labelSecondX.Size = new System.Drawing.Size(23, 13);
            this.labelSecondX.TabIndex = 4;
            this.labelSecondX.Text = "X : ";
            // 
            // groupBoxFirstPoint
            // 
            this.groupBoxFirstPoint.Controls.Add(this.numericUpDownFirstY);
            this.groupBoxFirstPoint.Controls.Add(this.labelFirstY);
            this.groupBoxFirstPoint.Controls.Add(this.numericUpDownFirstX);
            this.groupBoxFirstPoint.Controls.Add(this.labelFirstX);
            this.groupBoxFirstPoint.Location = new System.Drawing.Point(14, 54);
            this.groupBoxFirstPoint.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxFirstPoint.Name = "groupBoxFirstPoint";
            this.groupBoxFirstPoint.Size = new System.Drawing.Size(148, 103);
            this.groupBoxFirstPoint.TabIndex = 10;
            this.groupBoxFirstPoint.TabStop = false;
            this.groupBoxFirstPoint.Text = "First point";
            // 
            // numericUpDownFirstY
            // 
            this.numericUpDownFirstY.Location = new System.Drawing.Point(55, 66);
            this.numericUpDownFirstY.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownFirstY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownFirstY.Name = "numericUpDownFirstY";
            this.numericUpDownFirstY.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownFirstY.TabIndex = 2;
            // 
            // labelFirstY
            // 
            this.labelFirstY.AutoSize = true;
            this.labelFirstY.Location = new System.Drawing.Point(19, 68);
            this.labelFirstY.Name = "labelFirstY";
            this.labelFirstY.Size = new System.Drawing.Size(23, 13);
            this.labelFirstY.TabIndex = 5;
            this.labelFirstY.Text = "Y : ";
            // 
            // numericUpDownFirstX
            // 
            this.numericUpDownFirstX.Location = new System.Drawing.Point(55, 26);
            this.numericUpDownFirstX.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownFirstX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownFirstX.Name = "numericUpDownFirstX";
            this.numericUpDownFirstX.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownFirstX.TabIndex = 1;
            // 
            // labelFirstX
            // 
            this.labelFirstX.AutoSize = true;
            this.labelFirstX.Location = new System.Drawing.Point(19, 28);
            this.labelFirstX.Name = "labelFirstX";
            this.labelFirstX.Size = new System.Drawing.Size(23, 13);
            this.labelFirstX.TabIndex = 4;
            this.labelFirstX.Text = "X : ";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.groupBoxEllipse);
            this.tabPage2.Controls.Add(this.groupBoxCircle);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(187, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "3";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // groupBoxEllipse
            // 
            this.groupBoxEllipse.Controls.Add(this.buttonDrawEllipse);
            this.groupBoxEllipse.Controls.Add(this.numericUpDownB);
            this.groupBoxEllipse.Controls.Add(this.labelB);
            this.groupBoxEllipse.Controls.Add(this.numericUpDownA);
            this.groupBoxEllipse.Controls.Add(this.labelA);
            this.groupBoxEllipse.Location = new System.Drawing.Point(19, 204);
            this.groupBoxEllipse.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxEllipse.Name = "groupBoxEllipse";
            this.groupBoxEllipse.Size = new System.Drawing.Size(148, 150);
            this.groupBoxEllipse.TabIndex = 7;
            this.groupBoxEllipse.TabStop = false;
            this.groupBoxEllipse.Text = "Ellipse";
            // 
            // buttonDrawEllipse
            // 
            this.buttonDrawEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDrawEllipse.Location = new System.Drawing.Point(22, 99);
            this.buttonDrawEllipse.Name = "buttonDrawEllipse";
            this.buttonDrawEllipse.Size = new System.Drawing.Size(113, 31);
            this.buttonDrawEllipse.TabIndex = 9;
            this.buttonDrawEllipse.Text = "Draw ellipse";
            this.buttonDrawEllipse.UseVisualStyleBackColor = true;
            this.buttonDrawEllipse.Click += new System.EventHandler(this.buttonDrawEllipse_Click);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(55, 66);
            this.numericUpDownB.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownB.TabIndex = 2;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(19, 68);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(23, 13);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B : ";
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(55, 28);
            this.numericUpDownA.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownA.TabIndex = 1;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(19, 28);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(23, 13);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "A : ";
            // 
            // groupBoxCircle
            // 
            this.groupBoxCircle.Controls.Add(this.buttonDrawCircle);
            this.groupBoxCircle.Controls.Add(this.numericUpDownRadius);
            this.groupBoxCircle.Controls.Add(this.labelRadius);
            this.groupBoxCircle.Location = new System.Drawing.Point(19, 71);
            this.groupBoxCircle.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxCircle.Name = "groupBoxCircle";
            this.groupBoxCircle.Size = new System.Drawing.Size(148, 108);
            this.groupBoxCircle.TabIndex = 6;
            this.groupBoxCircle.TabStop = false;
            this.groupBoxCircle.Text = "Circle";
            // 
            // buttonDrawCircle
            // 
            this.buttonDrawCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDrawCircle.Location = new System.Drawing.Point(22, 59);
            this.buttonDrawCircle.Name = "buttonDrawCircle";
            this.buttonDrawCircle.Size = new System.Drawing.Size(113, 31);
            this.buttonDrawCircle.TabIndex = 8;
            this.buttonDrawCircle.Text = "Draw circle";
            this.buttonDrawCircle.UseVisualStyleBackColor = true;
            this.buttonDrawCircle.Click += new System.EventHandler(this.buttonDrawCircle_Click);
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Location = new System.Drawing.Point(55, 26);
            this.numericUpDownRadius.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownRadius.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownRadius.TabIndex = 1;
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(6, 28);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(49, 13);
            this.labelRadius.TabIndex = 4;
            this.labelRadius.Text = "Radius : ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonFill);
            this.tabPage3.Controls.Add(this.buttonAddPoint);
            this.tabPage3.Controls.Add(this.groupBoxAddingPoint);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(187, 382);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "4";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(44, 259);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(113, 44);
            this.buttonFill.TabIndex = 14;
            this.buttonFill.Text = "Fill polygon";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonAddPoint
            // 
            this.buttonAddPoint.Location = new System.Drawing.Point(57, 182);
            this.buttonAddPoint.Name = "buttonAddPoint";
            this.buttonAddPoint.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPoint.TabIndex = 13;
            this.buttonAddPoint.Text = "Add point";
            this.buttonAddPoint.UseVisualStyleBackColor = true;
            this.buttonAddPoint.Click += new System.EventHandler(this.buttonAddPoint_Click);
            // 
            // groupBoxAddingPoint
            // 
            this.groupBoxAddingPoint.Controls.Add(this.numericUpDownY);
            this.groupBoxAddingPoint.Controls.Add(this.labelY);
            this.groupBoxAddingPoint.Controls.Add(this.numericUpDownX);
            this.groupBoxAddingPoint.Controls.Add(this.labelX);
            this.groupBoxAddingPoint.Location = new System.Drawing.Point(22, 51);
            this.groupBoxAddingPoint.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxAddingPoint.Name = "groupBoxAddingPoint";
            this.groupBoxAddingPoint.Size = new System.Drawing.Size(148, 103);
            this.groupBoxAddingPoint.TabIndex = 12;
            this.groupBoxAddingPoint.TabStop = false;
            this.groupBoxAddingPoint.Text = "New point";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(55, 66);
            this.numericUpDownY.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownY.TabIndex = 2;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(19, 68);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(23, 13);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "Y : ";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(55, 26);
            this.numericUpDownX.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownX.TabIndex = 1;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(19, 28);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(23, 13);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X : ";
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(187, 382);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "5";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(187, 382);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "6";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Location = new System.Drawing.Point(4, 40);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(187, 382);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "7";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.pictureBox8);
            this.tabPage7.Controls.Add(this.buttonConvertingToHalftone);
            this.tabPage7.Controls.Add(this.label8);
            this.tabPage7.Location = new System.Drawing.Point(4, 40);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(187, 382);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "8";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 40);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(187, 382);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "9";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 40);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(187, 382);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "10";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 40);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(187, 382);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "11";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 40);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(187, 382);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "12";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 40);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(187, 382);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "13";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 40);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(187, 382);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "14";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 40);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(187, 382);
            this.tabPage14.TabIndex = 13;
            this.tabPage14.Text = "15";
            this.tabPage14.UseVisualStyleBackColor = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Building an image histogram";
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
            // buttonConvertingToHalftone
            // 
            this.buttonConvertingToHalftone.Location = new System.Drawing.Point(34, 320);
            this.buttonConvertingToHalftone.Name = "buttonConvertingToHalftone";
            this.buttonConvertingToHalftone.Size = new System.Drawing.Size(130, 43);
            this.buttonConvertingToHalftone.TabIndex = 11;
            this.buttonConvertingToHalftone.Text = "Converting";
            this.buttonConvertingToHalftone.UseVisualStyleBackColor = true;
            this.buttonConvertingToHalftone.Click += new System.EventHandler(this.buttonConvertingToHalftone_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Location = new System.Drawing.Point(6, 37);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(175, 165);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
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
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxSecondPoint.ResumeLayout(false);
            this.groupBoxSecondPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondX)).EndInit();
            this.groupBoxFirstPoint.ResumeLayout(false);
            this.groupBoxFirstPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstX)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxEllipse.ResumeLayout(false);
            this.groupBoxEllipse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            this.groupBoxCircle.ResumeLayout(false);
            this.groupBoxCircle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxAddingPoint.ResumeLayout(false);
            this.groupBoxAddingPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel;
        private NumericUpDown numericUpDownRadius;
        private Label labelRadius;
        private GroupBox groupBoxCircle;
        private GroupBox groupBoxEllipse;
        private NumericUpDown numericUpDownB;
        private Label labelB;
        private NumericUpDown numericUpDownA;
        private Label labelA;
        private Button buttonDrawCircle;
        private Button buttonDrawEllipse;
        private TabControl tabControl;
        private TabPage tabPage1;
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
        private Label label3;
        private Label label2;
        private GroupBox groupBoxFirstPoint;
        private NumericUpDown numericUpDownFirstY;
        private Label labelFirstY;
        private NumericUpDown numericUpDownFirstX;
        private Label labelFirstX;
        private GroupBox groupBoxSecondPoint;
        private NumericUpDown numericUpDownSecondY;
        private Label labelSecondY;
        private NumericUpDown numericUpDownSecondX;
        private Label labelSecondX;
        private Button buttonDrawLine;
        private Button buttonRefreshPanel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonFill;
        private Button buttonAddPoint;
        private GroupBox groupBoxAddingPoint;
        private NumericUpDown numericUpDownY;
        private Label labelY;
        private NumericUpDown numericUpDownX;
        private Label labelX;
        private PictureBox pictureBox;
        private Label label7;
        private Label label8;
        private Button buttonConvertingToHalftone;
        private PictureBox pictureBox8;
    }
}
