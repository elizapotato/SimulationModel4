namespace WindowsFormsApp2
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startB = new System.Windows.Forms.Button();
            this.boxRate = new System.Windows.Forms.NumericUpDown();
            this.labDays = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labRub = new System.Windows.Forms.Label();
            this.labLary = new System.Windows.Forms.Label();
            this.butBuy = new System.Windows.Forms.Button();
            this.butSell = new System.Windows.Forms.Button();
            this.boxLary = new System.Windows.Forms.NumericUpDown();
            this.labRate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labRate);
            this.panel1.Controls.Add(this.boxLary);
            this.panel1.Controls.Add(this.butSell);
            this.panel1.Controls.Add(this.butBuy);
            this.panel1.Controls.Add(this.labLary);
            this.panel1.Controls.Add(this.labRub);
            this.panel1.Controls.Add(this.startB);
            this.panel1.Controls.Add(this.boxRate);
            this.panel1.Controls.Add(this.labDays);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 99);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // startB
            // 
            this.startB.Location = new System.Drawing.Point(486, 3);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(78, 35);
            this.startB.TabIndex = 5;
            this.startB.Text = "Next Day";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // boxRate
            // 
            this.boxRate.DecimalPlaces = 2;
            this.boxRate.Location = new System.Drawing.Point(668, 71);
            this.boxRate.Name = "boxRate";
            this.boxRate.Size = new System.Drawing.Size(120, 22);
            this.boxRate.TabIndex = 3;
            this.boxRate.Value = new decimal(new int[] {
            2269,
            0,
            0,
            131072});
            // 
            // labDays
            // 
            this.labDays.AutoSize = true;
            this.labDays.Location = new System.Drawing.Point(570, 12);
            this.labDays.Name = "labDays";
            this.labDays.Size = new System.Drawing.Size(58, 17);
            this.labDays.TabIndex = 1;
            this.labDays.Text = "День: 0";
            this.labDays.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальный курс:";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 99);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "f2";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(800, 351);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // labRub
            // 
            this.labRub.AutoSize = true;
            this.labRub.Location = new System.Drawing.Point(12, 12);
            this.labRub.Name = "labRub";
            this.labRub.Size = new System.Drawing.Size(96, 17);
            this.labRub.TabIndex = 6;
            this.labRub.Text = "Рублей: 1000";
            // 
            // labLary
            // 
            this.labLary.AutoSize = true;
            this.labLary.Location = new System.Drawing.Point(12, 39);
            this.labLary.Name = "labLary";
            this.labLary.Size = new System.Drawing.Size(84, 34);
            this.labLary.TabIndex = 7;
            this.labLary.Text = "Грузинские\r\nлари: 0";
            // 
            // butBuy
            // 
            this.butBuy.Location = new System.Drawing.Point(210, 39);
            this.butBuy.Name = "butBuy";
            this.butBuy.Size = new System.Drawing.Size(78, 35);
            this.butBuy.TabIndex = 8;
            this.butBuy.Text = "BUY";
            this.butBuy.UseVisualStyleBackColor = true;
            this.butBuy.Click += new System.EventHandler(this.butBuy_Click);
            // 
            // butSell
            // 
            this.butSell.Location = new System.Drawing.Point(372, 39);
            this.butSell.Name = "butSell";
            this.butSell.Size = new System.Drawing.Size(78, 35);
            this.butSell.TabIndex = 9;
            this.butSell.Text = "SELL";
            this.butSell.UseVisualStyleBackColor = true;
            this.butSell.Click += new System.EventHandler(this.butSell_Click);
            // 
            // boxLary
            // 
            this.boxLary.Location = new System.Drawing.Point(294, 46);
            this.boxLary.Name = "boxLary";
            this.boxLary.Size = new System.Drawing.Size(72, 22);
            this.boxLary.TabIndex = 10;
            this.boxLary.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Location = new System.Drawing.Point(291, 12);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(83, 17);
            this.labRate.TabIndex = 11;
            this.labRate.Text = "Курс: 22,69";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxLary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.NumericUpDown boxRate;
        private System.Windows.Forms.Label labDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labLary;
        private System.Windows.Forms.Label labRub;
        private System.Windows.Forms.NumericUpDown boxLary;
        private System.Windows.Forms.Button butSell;
        private System.Windows.Forms.Button butBuy;
        private System.Windows.Forms.Label labRate;
    }
}

