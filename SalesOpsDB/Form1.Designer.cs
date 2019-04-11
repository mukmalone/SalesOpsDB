namespace SalesOpsDB
{
    partial class FormSalesOpsDB
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
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.chartForecast = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonUpdateChart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlMainInterface = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxDepartments = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            this.listBoxWeeks = new System.Windows.Forms.ListBox();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).BeginInit();
            this.tabControlMainInterface.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.Location = new System.Drawing.Point(6, 62);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(86, 23);
            this.buttonUpdateData.TabIndex = 0;
            this.buttonUpdateData.Text = "Update Data";
            this.buttonUpdateData.UseVisualStyleBackColor = true;
            this.buttonUpdateData.Click += new System.EventHandler(this.buttonUpdateData_Click);
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.Location = new System.Drawing.Point(6, 36);
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.Size = new System.Drawing.Size(397, 20);
            this.textBoxDebug.TabIndex = 1;
            // 
            // chartForecast
            // 
            chartArea1.Name = "ChartAreaForecast";
            this.chartForecast.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartForecast.Legends.Add(legend1);
            this.chartForecast.Location = new System.Drawing.Point(19, 33);
            this.chartForecast.Name = "chartForecast";
            series1.ChartArea = "ChartAreaForecast";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "SeriesHoursAvailable";
            this.chartForecast.Series.Add(series1);
            this.chartForecast.Size = new System.Drawing.Size(1277, 339);
            this.chartForecast.TabIndex = 2;
            this.chartForecast.Text = "chart1";
            this.chartForecast.Click += new System.EventHandler(this.chartForecast_Click);
            // 
            // buttonUpdateChart
            // 
            this.buttonUpdateChart.Location = new System.Drawing.Point(112, 521);
            this.buttonUpdateChart.Name = "buttonUpdateChart";
            this.buttonUpdateChart.Size = new System.Drawing.Size(110, 23);
            this.buttonUpdateChart.TabIndex = 3;
            this.buttonUpdateChart.Text = "Update Chart";
            this.buttonUpdateChart.UseVisualStyleBackColor = true;
            this.buttonUpdateChart.Click += new System.EventHandler(this.buttonUpdateChart_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabControlMainInterface
            // 
            this.tabControlMainInterface.Controls.Add(this.tabPage1);
            this.tabControlMainInterface.Controls.Add(this.tabPage3);
            this.tabControlMainInterface.Controls.Add(this.tabPage4);
            this.tabControlMainInterface.Location = new System.Drawing.Point(28, 12);
            this.tabControlMainInterface.Name = "tabControlMainInterface";
            this.tabControlMainInterface.SelectedIndex = 0;
            this.tabControlMainInterface.Size = new System.Drawing.Size(1310, 507);
            this.tabControlMainInterface.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonUpdateData);
            this.tabPage1.Controls.Add(this.textBoxDebug);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1302, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Update Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxProjects);
            this.tabPage3.Controls.Add(this.listBoxWeeks);
            this.tabPage3.Controls.Add(this.listBoxTeams);
            this.tabPage3.Controls.Add(this.listBoxDepartments);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1302, 481);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Select Forecast Parameters";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxDepartments
            // 
            this.listBoxDepartments.FormattingEnabled = true;
            this.listBoxDepartments.Location = new System.Drawing.Point(20, 33);
            this.listBoxDepartments.Name = "listBoxDepartments";
            this.listBoxDepartments.Size = new System.Drawing.Size(120, 251);
            this.listBoxDepartments.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chartForecast);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1302, 481);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Visualize Forecast";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.Location = new System.Drawing.Point(189, 33);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(120, 251);
            this.listBoxTeams.TabIndex = 1;
            // 
            // listBoxWeeks
            // 
            this.listBoxWeeks.FormattingEnabled = true;
            this.listBoxWeeks.Location = new System.Drawing.Point(352, 33);
            this.listBoxWeeks.Name = "listBoxWeeks";
            this.listBoxWeeks.Size = new System.Drawing.Size(120, 251);
            this.listBoxWeeks.TabIndex = 2;
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.Location = new System.Drawing.Point(521, 33);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(120, 251);
            this.listBoxProjects.TabIndex = 3;
            // 
            // FormSalesOpsDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 548);
            this.Controls.Add(this.buttonUpdateChart);
            this.Controls.Add(this.tabControlMainInterface);
            this.Name = "FormSalesOpsDB";
            this.Text = "SalesOPsDB";
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).EndInit();
            this.tabControlMainInterface.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.TextBox textBoxDebug;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForecast;
        private System.Windows.Forms.Button buttonUpdateChart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControlMainInterface;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBoxDepartments;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listBoxTeams;
        private System.Windows.Forms.ListBox listBoxWeeks;
        private System.Windows.Forms.ListBox listBoxProjects;
    }
}

