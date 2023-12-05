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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Xmax = new System.Windows.Forms.TextBox();
            this.Xmin = new System.Windows.Forms.TextBox();
            this.Step = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea2";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(800, 390);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCalc.Location = new System.Drawing.Point(125, 396);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(172, 42);
            this.buttonCalc.TabIndex = 1;
            this.buttonCalc.Text = "Создать график";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Xmax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Xmin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Шаг";
            // 
            // Xmax
            // 
            this.Xmax.Location = new System.Drawing.Point(496, 396);
            this.Xmax.Name = "Xmax";
            this.Xmax.Size = new System.Drawing.Size(126, 20);
            this.Xmax.TabIndex = 11;
            this.Xmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Xmax_KeyPress);
            // 
            // Xmin
            // 
            this.Xmin.Location = new System.Drawing.Point(339, 396);
            this.Xmin.Name = "Xmin";
            this.Xmin.Size = new System.Drawing.Size(112, 20);
            this.Xmin.TabIndex = 12;
            this.Xmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Xmin_KeyPress);
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(665, 396);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(123, 20);
            this.Step.TabIndex = 13;
            this.Step.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Step_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "На другую форму";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(665, 422);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(123, 20);
            this.txt_c.TabIndex = 15;
            this.txt_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_c_KeyPress);
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(496, 422);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(126, 20);
            this.txt_b.TabIndex = 16;
            this.txt_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_b_KeyPress);
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(339, 422);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(112, 20);
            this.txt_a.TabIndex = 17;
            this.txt_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_a_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "b";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(646, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "c";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.Xmin);
            this.Controls.Add(this.Xmax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "y=ax^2+bx+c";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Xmax;
        private System.Windows.Forms.TextBox Xmin;
        private System.Windows.Forms.TextBox Step;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

