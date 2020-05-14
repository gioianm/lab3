namespace Lab3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.orderDELabel = new System.Windows.Forms.Label();
            this.OrderDETextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.calculateMatrixButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvAkfs = new System.Windows.Forms.DataGridView();
            this.dgvBkfs = new System.Windows.Forms.DataGridView();
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.dgvC = new System.Windows.Forms.DataGridView();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.CLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBkfs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDELabel
            // 
            this.orderDELabel.AutoSize = true;
            this.orderDELabel.Location = new System.Drawing.Point(76, 12);
            this.orderDELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderDELabel.Name = "orderDELabel";
            this.orderDELabel.Size = new System.Drawing.Size(53, 20);
            this.orderDELabel.TabIndex = 0;
            this.orderDELabel.Text = "Order:";
            // 
            // OrderDETextBox
            // 
            this.OrderDETextBox.Location = new System.Drawing.Point(137, 9);
            this.OrderDETextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrderDETextBox.Name = "OrderDETextBox";
            this.OrderDETextBox.Size = new System.Drawing.Size(36, 26);
            this.OrderDETextBox.TabIndex = 1;
            this.OrderDETextBox.Text = "2";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(226, 6);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(112, 35);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(226, 58);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 35);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // calculateMatrixButton
            // 
            this.calculateMatrixButton.Location = new System.Drawing.Point(80, 59);
            this.calculateMatrixButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculateMatrixButton.Name = "calculateMatrixButton";
            this.calculateMatrixButton.Size = new System.Drawing.Size(135, 35);
            this.calculateMatrixButton.TabIndex = 4;
            this.calculateMatrixButton.Text = "Calculate matrix";
            this.calculateMatrixButton.UseVisualStyleBackColor = true;
            this.calculateMatrixButton.Click += new System.EventHandler(this.calculateMatrixButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(22, 349);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "StateSpace";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1160, 340);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // dgvAkfs
            // 
            this.dgvAkfs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAkfs.Location = new System.Drawing.Point(348, 6);
            this.dgvAkfs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAkfs.Name = "dgvAkfs";
            this.dgvAkfs.RowHeadersWidth = 62;
            this.dgvAkfs.Size = new System.Drawing.Size(428, 88);
            this.dgvAkfs.TabIndex = 6;
            // 
            // dgvBkfs
            // 
            this.dgvBkfs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBkfs.Location = new System.Drawing.Point(801, 6);
            this.dgvBkfs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBkfs.Name = "dgvBkfs";
            this.dgvBkfs.RowHeadersWidth = 62;
            this.dgvBkfs.Size = new System.Drawing.Size(381, 88);
            this.dgvBkfs.TabIndex = 7;
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(104, 109);
            this.dgvA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvA.Name = "dgvA";
            this.dgvA.RowHeadersWidth = 62;
            this.dgvA.Size = new System.Drawing.Size(386, 231);
            this.dgvA.TabIndex = 8;
            // 
            // dgvB
            // 
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Location = new System.Drawing.Point(526, 109);
            this.dgvB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvB.Name = "dgvB";
            this.dgvB.RowHeadersWidth = 62;
            this.dgvB.Size = new System.Drawing.Size(250, 231);
            this.dgvB.TabIndex = 9;
            // 
            // dgvC
            // 
            this.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC.Location = new System.Drawing.Point(912, 149);
            this.dgvC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvC.Name = "dgvC";
            this.dgvC.RowHeadersWidth = 62;
            this.dgvC.Size = new System.Drawing.Size(270, 112);
            this.dgvC.TabIndex = 10;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(76, 109);
            this.ALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(20, 20);
            this.ALabel.TabIndex = 11;
            this.ALabel.Text = "A";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(498, 109);
            this.BLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(20, 20);
            this.BLabel.TabIndex = 12;
            this.BLabel.Text = "B";
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(884, 149);
            this.CLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(20, 20);
            this.CLabel.TabIndex = 13;
            this.CLabel.Text = "C";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.dgvC);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.dgvA);
            this.Controls.Add(this.dgvBkfs);
            this.Controls.Add(this.dgvAkfs);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.calculateMatrixButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.OrderDETextBox);
            this.Controls.Add(this.orderDELabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAkfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBkfs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderDELabel;
        private System.Windows.Forms.TextBox OrderDETextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button calculateMatrixButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgvAkfs;
        private System.Windows.Forms.DataGridView dgvBkfs;
        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.Label CLabel;
    }
}

