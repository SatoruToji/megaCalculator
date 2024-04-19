namespace megaCalculator
{
    partial class mainWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWnd));
            this.tBox = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.ravno = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.root = new System.Windows.Forms.Button();
            this.degree = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBox
            // 
            this.tBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBox.ForeColor = System.Drawing.Color.White;
            this.tBox.Location = new System.Drawing.Point(12, 52);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(260, 36);
            this.tBox.TabIndex = 0;
            this.tBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBox.TextChanged += new System.EventHandler(this.tBox_TextChanged);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Location = new System.Drawing.Point(48, 120);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 47);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Location = new System.Drawing.Point(48, 173);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 47);
            this.minus.TabIndex = 2;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // ravno
            // 
            this.ravno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ravno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ravno.Location = new System.Drawing.Point(216, 173);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(50, 47);
            this.ravno.TabIndex = 3;
            this.ravno.Text = "=";
            this.ravno.UseVisualStyleBackColor = false;
            this.ravno.Click += new System.EventHandler(this.ravno_Click);
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Location = new System.Drawing.Point(191, 20);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(0, 29);
            this.line.TabIndex = 4;
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.clean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clean.Location = new System.Drawing.Point(278, 52);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(27, 36);
            this.clean.TabIndex = 5;
            this.clean.Text = "c";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.clean_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divide.Location = new System.Drawing.Point(104, 173);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(50, 47);
            this.divide.TabIndex = 6;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiply.Location = new System.Drawing.Point(104, 120);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(50, 47);
            this.multiply.TabIndex = 7;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // root
            // 
            this.root.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.root.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.root.Location = new System.Drawing.Point(160, 173);
            this.root.Name = "root";
            this.root.Size = new System.Drawing.Size(50, 47);
            this.root.TabIndex = 8;
            this.root.Text = "√";
            this.root.UseVisualStyleBackColor = false;
            this.root.Click += new System.EventHandler(this.root_Click);
            // 
            // degree
            // 
            this.degree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.degree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.degree.Location = new System.Drawing.Point(160, 120);
            this.degree.Name = "degree";
            this.degree.Size = new System.Drawing.Size(50, 47);
            this.degree.TabIndex = 9;
            this.degree.Text = "^";
            this.degree.UseVisualStyleBackColor = false;
            this.degree.Click += new System.EventHandler(this.degree_Click);
            // 
            // factorial
            // 
            this.factorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.factorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.factorial.Location = new System.Drawing.Point(216, 120);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(50, 47);
            this.factorial.TabIndex = 10;
            this.factorial.Text = "!";
            this.factorial.UseVisualStyleBackColor = false;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // mainWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(317, 322);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.degree);
            this.Controls.Add(this.root);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.clean);
            this.Controls.Add(this.line);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.tBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "mainWnd";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.mainWnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button ravno;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button root;
        private System.Windows.Forms.Button degree;
        private System.Windows.Forms.Button factorial;
    }
}

