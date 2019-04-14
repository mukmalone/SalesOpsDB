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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.buttonUpdateChart = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlMainInterface = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.listBoxWeeks = new System.Windows.Forms.ListBox();
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            this.listBoxDepartments = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chartForecast = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxAvailableHours = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewProjectAnalysis = new System.Windows.Forms.DataGridView();
            this.dataGridViewForecast = new System.Windows.Forms.DataGridView();
            this.WeekNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeeklyTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProjectNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberWeeks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEstimate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHoursUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursAtelier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedHourAtelier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursElec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedHourElec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursGestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedHourGestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursLogiciel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedHourLogiciel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursMechanical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedHourMechanical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursProcede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedHourProcede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedHourRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursRobot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedHourRobot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMainInterface.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForecast)).BeginInit();
            this.tabPage1.SuspendLayout();
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
            this.buttonUpdateChart.Location = new System.Drawing.Point(41, 558);
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
            this.tabControlMainInterface.Size = new System.Drawing.Size(1310, 540);
            this.tabControlMainInterface.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxProjects);
            this.tabPage3.Controls.Add(this.dataGridViewForecast);
            this.tabPage3.Controls.Add(this.listBoxWeeks);
            this.tabPage3.Controls.Add(this.listBoxTeams);
            this.tabPage3.Controls.Add(this.listBoxDepartments);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1302, 514);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Select Analytics Parameters";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.Location = new System.Drawing.Point(521, 33);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(120, 446);
            this.listBoxProjects.TabIndex = 3;
            // 
            // listBoxWeeks
            // 
            this.listBoxWeeks.FormattingEnabled = true;
            this.listBoxWeeks.Location = new System.Drawing.Point(352, 33);
            this.listBoxWeeks.Name = "listBoxWeeks";
            this.listBoxWeeks.Size = new System.Drawing.Size(120, 446);
            this.listBoxWeeks.TabIndex = 2;
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.Location = new System.Drawing.Point(189, 33);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(120, 446);
            this.listBoxTeams.TabIndex = 1;
            // 
            // listBoxDepartments
            // 
            this.listBoxDepartments.FormattingEnabled = true;
            this.listBoxDepartments.Location = new System.Drawing.Point(20, 33);
            this.listBoxDepartments.Name = "listBoxDepartments";
            this.listBoxDepartments.Size = new System.Drawing.Size(120, 446);
            this.listBoxDepartments.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chartForecast);
            this.tabPage4.Controls.Add(this.textBoxAvailableHours);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1302, 514);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Visualize Data";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chartForecast
            // 
            chartArea4.Name = "ChartArea1";
            this.chartForecast.ChartAreas.Add(chartArea4);
            this.chartForecast.Location = new System.Drawing.Point(23, 40);
            this.chartForecast.Name = "chartForecast";
            this.chartForecast.Size = new System.Drawing.Size(1244, 468);
            this.chartForecast.TabIndex = 4;
            this.chartForecast.Text = "chart1";
            // 
            // textBoxAvailableHours
            // 
            this.textBoxAvailableHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAvailableHours.Location = new System.Drawing.Point(436, 21);
            this.textBoxAvailableHours.Name = "textBoxAvailableHours";
            this.textBoxAvailableHours.Size = new System.Drawing.Size(221, 13);
            this.textBoxAvailableHours.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewProjectAnalysis);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1302, 514);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Detailed Data Table";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProjectAnalysis
            // 
            this.dataGridViewProjectAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjectAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectNum,
            this.AccountName,
            this.ProjectName,
            this.NumberWeeks,
            this.TotalEstimate,
            this.TotalHoursUsed,
            this.HoursAtelier,
            this.UsedHourAtelier,
            this.HoursElec,
            this.UsedHourElec,
            this.HoursGestion,
            this.UsedHourGestion,
            this.HoursLogiciel,
            this.UsedHourLogiciel,
            this.HoursMechanical,
            this.UsedHourMechanical,
            this.HoursProcede,
            this.UsedHourProcede,
            this.HoursRC,
            this.UsedHourRC,
            this.HoursRobot,
            this.UsedHourRobot});
            this.dataGridViewProjectAnalysis.Location = new System.Drawing.Point(9, 6);
            this.dataGridViewProjectAnalysis.Name = "dataGridViewProjectAnalysis";
            this.dataGridViewProjectAnalysis.Size = new System.Drawing.Size(1287, 502);
            this.dataGridViewProjectAnalysis.TabIndex = 1;
            // 
            // dataGridViewForecast
            // 
            this.dataGridViewForecast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForecast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WeekNumber,
            this.ProjectNumber,
            this.WeeklyTotal});
            this.dataGridViewForecast.Location = new System.Drawing.Point(760, 33);
            this.dataGridViewForecast.Name = "dataGridViewForecast";
            this.dataGridViewForecast.Size = new System.Drawing.Size(361, 468);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonUpdateData);
            this.tabPage1.Controls.Add(this.textBoxDebug);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1302, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Import Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProjectNum
            // 
            this.ProjectNum.HeaderText = "Project Number";
            this.ProjectNum.Name = "ProjectNum";
            // 
            // AccountName
            // 
            this.AccountName.HeaderText = "Account Name";
            this.AccountName.Name = "AccountName";
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            // 
            // NumberWeeks
            // 
            this.NumberWeeks.HeaderText = "Number Weeks";
            this.NumberWeeks.Name = "NumberWeeks";
            // 
            // TotalEstimate
            // 
            this.TotalEstimate.HeaderText = "Total Hours Estimated";
            this.TotalEstimate.Name = "TotalEstimate";
            // 
            // TotalHoursUsed
            // 
            this.TotalHoursUsed.HeaderText = "Total Hours Used";
            this.TotalHoursUsed.Name = "TotalHoursUsed";
            // 
            // HoursAtelier
            // 
            this.HoursAtelier.HeaderText = "Est Hours Atelier";
            this.HoursAtelier.Name = "HoursAtelier";
            // 
            // UsedHourAtelier
            // 
            this.UsedHourAtelier.HeaderText = "Used Hours Atelier";
            this.UsedHourAtelier.Name = "UsedHourAtelier";
            // 
            // HoursElec
            // 
            this.HoursElec.HeaderText = "Est Hours Elec";
            this.HoursElec.Name = "HoursElec";
            // 
            // UsedHourElec
            // 
            this.UsedHourElec.HeaderText = "Used Hours Elec";
            this.UsedHourElec.Name = "UsedHourElec";
            // 
            // HoursGestion
            // 
            this.HoursGestion.HeaderText = "Est Hours Gestion";
            this.HoursGestion.Name = "HoursGestion";
            // 
            // UsedHourGestion
            // 
            this.UsedHourGestion.HeaderText = "Used Hours Gestion";
            this.UsedHourGestion.Name = "UsedHourGestion";
            // 
            // HoursLogiciel
            // 
            this.HoursLogiciel.HeaderText = "Est Hours Logiciel";
            this.HoursLogiciel.Name = "HoursLogiciel";
            // 
            // UsedHourLogiciel
            // 
            this.UsedHourLogiciel.HeaderText = "Used Hours Logiciel";
            this.UsedHourLogiciel.Name = "UsedHourLogiciel";
            // 
            // HoursMechanical
            // 
            this.HoursMechanical.HeaderText = "Est Hours Mechanical";
            this.HoursMechanical.Name = "HoursMechanical";
            // 
            // UsedHourMechanical
            // 
            this.UsedHourMechanical.HeaderText = "Used Hours Mechanical";
            this.UsedHourMechanical.Name = "UsedHourMechanical";
            // 
            // HoursProcede
            // 
            this.HoursProcede.HeaderText = "Est Hours Procede";
            this.HoursProcede.Name = "HoursProcede";
            // 
            // UsedHourProcede
            // 
            this.UsedHourProcede.HeaderText = "Used Hours Procede";
            this.UsedHourProcede.Name = "UsedHourProcede";
            // 
            // HoursRC
            // 
            this.HoursRC.HeaderText = "Hours RC";
            this.HoursRC.Name = "HoursRC";
            // 
            // UsedHourRC
            // 
            this.UsedHourRC.HeaderText = "Used Hours RC";
            this.UsedHourRC.Name = "UsedHourRC";
            // 
            // HoursRobot
            // 
            this.HoursRobot.HeaderText = "Est Hours Robot";
            this.HoursRobot.Name = "HoursRobot";
            // 
            // UsedHourRobot
            // 
            this.UsedHourRobot.HeaderText = "Used Hours Robot";
            this.UsedHourRobot.Name = "UsedHourRobot";
            // 
            // FormSalesOpsDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 582);
            this.Controls.Add(this.buttonUpdateChart);
            this.Controls.Add(this.tabControlMainInterface);
            this.Name = "FormSalesOpsDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesOPsDB";
            this.tabControlMainInterface.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartForecast)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjectAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForecast)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridViewProjectAnalysis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberWeeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEstimate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHoursUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursAtelier;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedHourAtelier;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursElec;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedHourElec;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursGestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedHourGestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursLogiciel;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedHourLogiciel;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursMechanical;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedHourMechanical;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursProcede;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedHourProcede;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedHourRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursRobot;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedHourRobot;
    }
}

