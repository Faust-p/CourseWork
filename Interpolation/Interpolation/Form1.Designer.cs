namespace Interpolation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BuildGraph = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNewton = new System.Windows.Forms.RadioButton();
            this.radioButtonLagrange = new System.Windows.Forms.RadioButton();
            this.radioButtonSplain = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(218, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(570, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(49, 115);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(163, 20);
            this.textBoxX1.TabIndex = 1;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(49, 141);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(163, 20);
            this.textBoxX2.TabIndex = 2;
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(49, 167);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(163, 20);
            this.textBoxH.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "x1 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "x2 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "h =";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(192, 216);
            this.dataGridView1.TabIndex = 7;
            // 
            // BuildGraph
            // 
            this.BuildGraph.Location = new System.Drawing.Point(12, 415);
            this.BuildGraph.Name = "BuildGraph";
            this.BuildGraph.Size = new System.Drawing.Size(200, 23);
            this.BuildGraph.TabIndex = 8;
            this.BuildGraph.Text = "Построить";
            this.BuildGraph.UseVisualStyleBackColor = true;
            this.BuildGraph.Click += new System.EventHandler(this.BuildGraph_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSplain);
            this.groupBox1.Controls.Add(this.radioButtonLagrange);
            this.groupBox1.Controls.Add(this.radioButtonNewton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите интерполяцию:";
            // 
            // radioButtonNewton
            // 
            this.radioButtonNewton.AutoSize = true;
            this.radioButtonNewton.Location = new System.Drawing.Point(7, 20);
            this.radioButtonNewton.Name = "radioButtonNewton";
            this.radioButtonNewton.Size = new System.Drawing.Size(146, 17);
            this.radioButtonNewton.TabIndex = 0;
            this.radioButtonNewton.TabStop = true;
            this.radioButtonNewton.Text = "Интерполяция Ньютона";
            this.radioButtonNewton.UseVisualStyleBackColor = true;
            // 
            // radioButtonLagrange
            // 
            this.radioButtonLagrange.AutoSize = true;
            this.radioButtonLagrange.Location = new System.Drawing.Point(7, 44);
            this.radioButtonLagrange.Name = "radioButtonLagrange";
            this.radioButtonLagrange.Size = new System.Drawing.Size(152, 17);
            this.radioButtonLagrange.TabIndex = 1;
            this.radioButtonLagrange.TabStop = true;
            this.radioButtonLagrange.Text = "Интерполяция Лагранжа";
            this.radioButtonLagrange.UseVisualStyleBackColor = true;
            // 
            // radioButtonSplain
            // 
            this.radioButtonSplain.AutoSize = true;
            this.radioButtonSplain.Location = new System.Drawing.Point(7, 68);
            this.radioButtonSplain.Name = "radioButtonSplain";
            this.radioButtonSplain.Size = new System.Drawing.Size(158, 17);
            this.radioButtonSplain.TabIndex = 2;
            this.radioButtonSplain.TabStop = true;
            this.radioButtonSplain.Text = "Интерполяция Сплайнами";
            this.radioButtonSplain.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuildGraph);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Интерполяция";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BuildGraph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSplain;
        private System.Windows.Forms.RadioButton radioButtonLagrange;
        private System.Windows.Forms.RadioButton radioButtonNewton;
    }
}

