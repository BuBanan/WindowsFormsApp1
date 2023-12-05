namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.Step = new System.Windows.Forms.TextBox();
            this.Xmin = new System.Windows.Forms.TextBox();
            this.Xmax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_z = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "X";
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(226, 425);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(112, 20);
            this.txt_x.TabIndex = 35;
            this.txt_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x_KeyPress);
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(383, 426);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(126, 20);
            this.txt_y.TabIndex = 34;
            this.txt_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_y_KeyPress);
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(548, 400);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(123, 20);
            this.Step.TabIndex = 31;
            this.Step.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Step_KeyPress);
            // 
            // Xmin
            // 
            this.Xmin.Location = new System.Drawing.Point(226, 400);
            this.Xmin.Name = "Xmin";
            this.Xmin.Size = new System.Drawing.Size(112, 20);
            this.Xmin.TabIndex = 30;
            this.Xmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Xmin_KeyPress);
            // 
            // Xmax
            // 
            this.Xmax.Location = new System.Drawing.Point(383, 400);
            this.Xmax.Name = "Xmax";
            this.Xmax.Size = new System.Drawing.Size(126, 20);
            this.Xmax.TabIndex = 29;
            this.Xmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Xmax_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Шаг";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 403);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Xmin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Xmax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 25;
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonCalc.Location = new System.Drawing.Point(12, 400);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(172, 42);
            this.buttonCalc.TabIndex = 24;
            this.buttonCalc.Text = "Создать график";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea2";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(800, 390);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Z";
            // 
            // txt_z
            // 
            this.txt_z.Location = new System.Drawing.Point(548, 426);
            this.txt_z.Name = "txt_z";
            this.txt_z.Size = new System.Drawing.Size(123, 20);
            this.txt_z.TabIndex = 39;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_z);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.Xmin);
            this.Controls.Add(this.Xmax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox Step;
        private System.Windows.Forms.TextBox Xmin;
        private System.Windows.Forms.TextBox Xmax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_z;
    }
}