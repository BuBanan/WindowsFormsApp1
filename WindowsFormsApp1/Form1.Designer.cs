namespace WindowsFormsApp1
{
    partial class Lab5
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtY11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtY21 = new System.Windows.Forms.Label();
            this.txtX11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 412);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(139, 26);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Вычислить z(x, y)";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(492, 184);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 20);
            this.txtY2.TabIndex = 1;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(156, 184);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 20);
            this.txtY1.TabIndex = 2;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(156, 82);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 20);
            this.txtX1.TabIndex = 3;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(492, 82);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 20);
            this.txtX2.TabIndex = 4;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(492, 236);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(207, 212);
            this.lstResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "y range";
            // 
            // txtX21
            // 
            this.txtX21.AutoSize = true;
            this.txtX21.Location = new System.Drawing.Point(339, 85);
            this.txtX21.Name = "txtX21";
            this.txtX21.Size = new System.Drawing.Size(16, 13);
            this.txtX21.TabIndex = 7;
            this.txtX21.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "x range";
            // 
            // txtY11
            // 
            this.txtY11.AutoSize = true;
            this.txtY11.Location = new System.Drawing.Point(40, 187);
            this.txtY11.Name = "txtY11";
            this.txtY11.Size = new System.Drawing.Size(27, 13);
            this.txtY11.TabIndex = 9;
            this.txtY11.Text = "from";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Result";
            // 
            // txtY21
            // 
            this.txtY21.AutoSize = true;
            this.txtY21.Location = new System.Drawing.Point(339, 187);
            this.txtY21.Name = "txtY21";
            this.txtY21.Size = new System.Drawing.Size(16, 13);
            this.txtY21.TabIndex = 11;
            this.txtY21.Text = "to";
            // 
            // txtX11
            // 
            this.txtX11.AutoSize = true;
            this.txtX11.Location = new System.Drawing.Point(40, 85);
            this.txtX11.Name = "txtX11";
            this.txtX11.Size = new System.Drawing.Size(27, 13);
            this.txtX11.TabIndex = 12;
            this.txtX11.Text = "from";
            // 
            // Lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtX11);
            this.Controls.Add(this.txtY21);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtY11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtX21);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.btnCalc);
            this.Name = "Lab5";
            this.Text = "цикл for";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtX21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtY11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtY21;
        private System.Windows.Forms.Label txtX11;
    }
}

