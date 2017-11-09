namespace _3.Drawing_a_circle_and_an_ellipse
{
    partial class DrawingCircleAndEllipse
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.labelRadius = new System.Windows.Forms.Label();
            this.groupBoxCircle = new System.Windows.Forms.GroupBox();
            this.buttonDrawCircle = new System.Windows.Forms.Button();
            this.groupBoxEllipse = new System.Windows.Forms.GroupBox();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.labelB = new System.Windows.Forms.Label();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.labelA = new System.Windows.Forms.Label();
            this.buttonDrawEllipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            this.groupBoxCircle.SuspendLayout();
            this.groupBoxEllipse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(900, 600);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
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
            // groupBoxCircle
            // 
            this.groupBoxCircle.Controls.Add(this.buttonDrawCircle);
            this.groupBoxCircle.Controls.Add(this.numericUpDownRadius);
            this.groupBoxCircle.Controls.Add(this.labelRadius);
            this.groupBoxCircle.Location = new System.Drawing.Point(928, 86);
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
            // groupBoxEllipse
            // 
            this.groupBoxEllipse.Controls.Add(this.buttonDrawEllipse);
            this.groupBoxEllipse.Controls.Add(this.numericUpDownB);
            this.groupBoxEllipse.Controls.Add(this.labelB);
            this.groupBoxEllipse.Controls.Add(this.numericUpDownA);
            this.groupBoxEllipse.Controls.Add(this.labelA);
            this.groupBoxEllipse.Location = new System.Drawing.Point(928, 244);
            this.groupBoxEllipse.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxEllipse.Name = "groupBoxEllipse";
            this.groupBoxEllipse.Size = new System.Drawing.Size(148, 150);
            this.groupBoxEllipse.TabIndex = 7;
            this.groupBoxEllipse.TabStop = false;
            this.groupBoxEllipse.Text = "Ellipse";
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
            // DrawingCircleAndEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.groupBoxEllipse);
            this.Controls.Add(this.groupBoxCircle);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1116, 638);
            this.MinimumSize = new System.Drawing.Size(1116, 638);
            this.Name = "DrawingCircleAndEllipse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drawing a circle and an ellipse";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            this.groupBoxCircle.ResumeLayout(false);
            this.groupBoxCircle.PerformLayout();
            this.groupBoxEllipse.ResumeLayout(false);
            this.groupBoxEllipse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.GroupBox groupBoxCircle;
        private System.Windows.Forms.GroupBox groupBoxEllipse;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button buttonDrawCircle;
        private System.Windows.Forms.Button buttonDrawEllipse;
    }
}

