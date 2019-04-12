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
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.buttonUpdateChart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlMainInterface = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.listBoxWeeks = new System.Windows.Forms.ListBox();
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            this.listBoxDepartments = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewForecast = new System.Windows.Forms.DataGridView();
            this.WeekNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeeklyTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxAvailableHours = new System.Windows.Forms.TextBox();
            this.chartForecast = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlMainInterface.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForecast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).BeginInit();
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
            this.tabControlMainInterface.Controls.Add(this.tabPage3);
            this.tabControlMainInterface.Controls.Add(this.tabPage4);
            this.tabControlMainInterface.Controls.Add(this.tabPage5);
            this.tabControlMainInterface.Controls.Add(this.tabPage1);
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
            // listBoxProjects
            // 
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.Location = new System.Drawing.Point(521, 33);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(120, 251);
            this.listBoxProjects.TabIndex = 3;
            // 
            // listBoxWeeks
            // 
            this.listBoxWeeks.FormattingEnabled = true;
            this.listBoxWeeks.Location = new System.Drawing.Point(352, 33);
            this.listBoxWeeks.Name = "listBoxWeeks";
            this.listBoxWeeks.Size = new System.Drawing.Size(120, 251);
            this.listBoxWeeks.TabIndex = 2;
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.Location = new System.Drawing.Point(189, 33);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(120, 251);
            this.listBoxTeams.TabIndex = 1;
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
            this.tabPage4.Controls.Add(this.textBoxAvailableHours);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1302, 481);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Visualize Forecast";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewForecast);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1302, 481);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Forecast Table";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewForecast
            // 
            this.dataGridViewForecast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForecast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WeekNumber,
            this.ProjectNumber,
            this.WeeklyTotal});
            this.dataGridViewForecast.Location = new System.Drawing.Point(52, 40);
            this.dataGridViewForecast.Name = "dataGridViewForecast";
            this.dataGridViewForecast.Size = new System.Drawing.Size(886, 426);
            this.dataGridViewForecast.TabIndex = 0;
            // 
            // WeekNumber
            // 
            this.WeekNumber.HeaderText = "Week Number";
            this.WeekNumber.Name = "WeekNumber";
            // 
            // ProjectNumber
            // 
            this.ProjectNumber.HeaderText = "Project Number";
            this.ProjectNumber.Name = "ProjectNumber";
            // 
            // WeeklyTotal
            // 
            this.WeeklyTotal.HeaderText = "Weekly Total";
            this.WeeklyTotal.Name = "WeeklyTotal";
            // 
            // textBoxAvailableHours
            // 
            this.textBoxAvailableHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAvailableHours.Location = new System.Drawing.Point(436, 21);
            this.textBoxAvailableHours.Name = "textBoxAvailableHours";
            this.textBoxAvailableHours.Size = new System.Drawing.Size(221, 13);
            this.textBoxAvailableHours.TabIndex = 3;
            // 
            // chartForecast
            // 
            chartArea1.Name = "ChartArea1";
            this.chartForecast.ChartAreas.Add(chartArea1);
            this.chartForecast.Location = new System.Drawing.Point(23, 40);
            this.chartForecast.Name = "chartForecast";
            this.chartForecast.Size = new System.Drawing.Size(1244, 435);
            this.chartForecast.TabIndex = 4;
            this.chartForecast.Text = "chart1";
            // 
            // FormSalesOpsDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 548);
            this.Controls.Add(this.buttonUpdateChart);
            this.Controls.Add(this.tabControlMainInterface);
            this.Name = "FormSalesOpsDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesOPsDB";
            this.tabControlMainInterface.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForecast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.TextBox textBoxDebug;
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
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewForecast;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeeklyTotal;
        private System.Windows.Forms.TextBox textBoxAvailableHours;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartForecast;
    }
}

