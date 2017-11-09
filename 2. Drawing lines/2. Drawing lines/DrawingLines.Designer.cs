namespace _2.Drawing_lines
{
    partial class DrawingLines
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
            this.numericUpDownFirstX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFirstY = new System.Windows.Forms.NumericUpDown();
            this.labelFirstX = new System.Windows.Forms.Label();
            this.labelFirstY = new System.Windows.Forms.Label();
            this.groupBoxFirstPoint = new System.Windows.Forms.GroupBox();
            this.groupBoxSecondPoint = new System.Windows.Forms.GroupBox();
            this.numericUpDownSecondY = new System.Windows.Forms.NumericUpDown();
            this.labelSecondY = new System.Windows.Forms.Label();
            this.numericUpDownSecondX = new System.Windows.Forms.NumericUpDown();
            this.labelSecondX = new System.Windows.Forms.Label();
            this.buttonDraw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstY)).BeginInit();
            this.groupBoxFirstPoint.SuspendLayout();
            this.groupBoxSecondPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondX)).BeginInit();
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
            // labelFirstX
            // 
            this.labelFirstX.AutoSize = true;
            this.labelFirstX.Location = new System.Drawing.Point(19, 28);
            this.labelFirstX.Name = "labelFirstX";
            this.labelFirstX.Size = new System.Drawing.Size(23, 13);
            this.labelFirstX.TabIndex = 4;
            this.labelFirstX.Text = "X : ";
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
            // groupBoxFirstPoint
            // 
            this.groupBoxFirstPoint.Controls.Add(this.numericUpDownFirstY);
            this.groupBoxFirstPoint.Controls.Add(this.labelFirstY);
            this.groupBoxFirstPoint.Controls.Add(this.numericUpDownFirstX);
            this.groupBoxFirstPoint.Controls.Add(this.labelFirstX);
            this.groupBoxFirstPoint.Location = new System.Drawing.Point(928, 86);
            this.groupBoxFirstPoint.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxFirstPoint.Name = "groupBoxFirstPoint";
            this.groupBoxFirstPoint.Size = new System.Drawing.Size(148, 103);
            this.groupBoxFirstPoint.TabIndex = 6;
            this.groupBoxFirstPoint.TabStop = false;
            this.groupBoxFirstPoint.Text = "First point";
            // 
            // groupBoxSecondPoint
            // 
            this.groupBoxSecondPoint.Controls.Add(this.numericUpDownSecondY);
            this.groupBoxSecondPoint.Controls.Add(this.labelSecondY);
            this.groupBoxSecondPoint.Controls.Add(this.numericUpDownSecondX);
            this.groupBoxSecondPoint.Controls.Add(this.labelSecondX);
            this.groupBoxSecondPoint.Location = new System.Drawing.Point(928, 207);
            this.groupBoxSecondPoint.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxSecondPoint.Name = "groupBoxSecondPoint";
            this.groupBoxSecondPoint.Size = new System.Drawing.Size(148, 103);
            this.groupBoxSecondPoint.TabIndex = 7;
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
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(950, 338);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(87, 31);
            this.buttonDraw.TabIndex = 8;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // DrawingLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.groupBoxSecondPoint);
            this.Controls.Add(this.groupBoxFirstPoint);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1116, 638);
            this.MinimumSize = new System.Drawing.Size(1116, 638);
            this.Name = "DrawingLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drawing lines";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstY)).EndInit();
            this.groupBoxFirstPoint.ResumeLayout(false);
            this.groupBoxFirstPoint.PerformLayout();
            this.groupBoxSecondPoint.ResumeLayout(false);
            this.groupBoxSecondPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondX)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.NumericUpDown numericUpDownFirstX;
        private System.Windows.Forms.NumericUpDown numericUpDownFirstY;
        private System.Windows.Forms.Label labelFirstX;
        private System.Windows.Forms.Label labelFirstY;
        private System.Windows.Forms.GroupBox groupBoxFirstPoint;
        private System.Windows.Forms.GroupBox groupBoxSecondPoint;
        private System.Windows.Forms.NumericUpDown numericUpDownSecondY;
        private System.Windows.Forms.Label labelSecondY;
        private System.Windows.Forms.NumericUpDown numericUpDownSecondX;
        private System.Windows.Forms.Label labelSecondX;
        private System.Windows.Forms.Button buttonDraw;
    }
}

