namespace WindowsFormsApp1
{
    partial class Form1
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
            this.str = new System.Windows.Forms.TextBox();
            this.symb = new System.Windows.Forms.TextBox();
            this.Nsymb = new System.Windows.Forms.TextBox();
            this.Nma = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // str
            // 
            this.str.Location = new System.Drawing.Point(173, 12);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(266, 20);
            this.str.TabIndex = 0;
            // 
            // symb
            // 
            this.symb.Location = new System.Drawing.Point(173, 38);
            this.symb.Name = "symb";
            this.symb.Size = new System.Drawing.Size(266, 20);
            this.symb.TabIndex = 1;
            // 
            // Nsymb
            // 
            this.Nsymb.Location = new System.Drawing.Point(173, 64);
            this.Nsymb.Name = "Nsymb";
            this.Nsymb.Size = new System.Drawing.Size(266, 20);
            this.Nsymb.TabIndex = 2;
            // 
            // Nma
            // 
            this.Nma.Location = new System.Drawing.Point(173, 90);
            this.Nma.Name = "Nma";
            this.Nma.Size = new System.Drawing.Size(266, 20);
            this.Nma.TabIndex = 3;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(12, 97);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(155, 13);
            this.t.TabIndex = 4;
            this.t.Text = "Колличество сочетаний \"Ма\"";
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(12, 67);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(125, 13);
            this.N.TabIndex = 5;
            this.N.Text = "Колличество символов";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(12, 41);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(139, 13);
            this.v.TabIndex = 6;
            this.v.Text = "Введите искомый символ";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(12, 15);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(86, 13);
            this.s.TabIndex = 7;
            this.s.Text = "Введите строку";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(71, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Подсчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 197);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.s);
            this.Controls.Add(this.v);
            this.Controls.Add(this.N);
            this.Controls.Add(this.t);
            this.Controls.Add(this.Nma);
            this.Controls.Add(this.Nsymb);
            this.Controls.Add(this.symb);
            this.Controls.Add(this.str);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox str;
        private System.Windows.Forms.TextBox symb;
        private System.Windows.Forms.TextBox Nsymb;
        private System.Windows.Forms.TextBox Nma;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Button button1;
    }
}

