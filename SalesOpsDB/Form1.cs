using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

struct SalesData
{
    public string proposalNumber;
    public string projectNumber;
    public string accountName;
    public string opportunityName;
    public string confidence;
    public string stage;
    public int probability;
    public DateTime closeDate;
    public string carnetAssignment;
    public DateTime carnetAssignmentDate;
    public int numberWeeks;
    public int hoursAtelier;
    public int hoursElec;
    public int hoursGestion;
    public int hoursLogiciel;
    public int hoursMechanical;
    public int hoursProcede;
    public int hoursRC;
    public int hoursRobot;
    public int totalHoursEstimated;
    public string mainProcess;
    public string secondaryProcess;
    public string thirdProcess;
    public string sharepoint;
    public string systemProposed;
}

struct AcceoData
{
    public string projectNumber;
    public string projectTask;
    public string projectTaskDescription;
    public string refNumber;
    public string employeeName;
    public string week;
    public string weekDescription;
    public double totalHours;
    public double monday;
    public double tuesday;
    public double wednesday;
    public double thursday;
    public double friday;
    public double saturday;
    public double sunday;
    public double weeklyTotal;
    public string description;
}

struct WeeklyProjectBurn
{
    public string weekNumber;
    public string projectNumber;
    public string accountName;
    public string projectName;
    public double weeklyTotal;
}

namespace SalesOpsDB
{
    public partial class FormSalesOpsDB : Form
    {
        public FormSalesOpsDB()
        {
            InitializeComponent();
            string connectionString = @"Data Source=AVR-L093\SQLEXPRESS;Initial Catalog=SalesOps;Integrated Security=SSPI;";
            List<string> weeks = DatabaseAccess.GetListofWeeks(connectionString);
            List<string> teams = DatabaseAccess.GetListofTeams(connectionString);
            List<string> departments = DatabaseAccess.GetListofDepartments(connectionString);
            List<string> projects = DatabaseAccess.GetListofProjects(connectionString);

            listBoxDepartments.SelectionMode = SelectionMode.MultiSimple;
            for (int j = 0; j < departments.Count; j++)
            {
                listBoxDepartments.Items.Add(departments[j]);
                listBoxDepartments.SetSelected(j, true);
            }
            listBoxDepartments.Update();

            listBoxTeams.SelectionMode = SelectionMode.MultiSimple;
            for (int j = 0; j < teams.Count; j++)
            {
                listBoxTeams.Items.Add(teams[j]);
                listBoxTeams.SetSelected(j, true);
            }
            listBoxTeams.Update();

            listBoxWeeks.SelectionMode = SelectionMode.MultiSimple;
            for (int j = 0; j < weeks.Count; j++)
            {
                listBoxWeeks.Items.Add(weeks[j]);
                //listBoxWeeks.SetSelected(j, true);
            }
            listBoxWeeks.Update();

            listBoxProjects.SelectionMode = SelectionMode.MultiSimple;
            for (int j = 0; j < projects.Count; j++)
            {
                listBoxProjects.Items.Add(projects[j]);
                listBoxProjects.SetSelected(j, true);
            }
            listBoxWeeks.Update();
        }

        private void buttonUpdateData_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=AVR-L093\SQLEXPRESS;Initial Catalog=SalesOps;Integrated Security=SSPI;";
            //*******************************************************************************
            //LOAD SALES DATA
            //*******************************************************************************
            int num_rows, num_cols;
            String salesCsv;
            string[] lines;
            //get the file
            salesCsv = File.ReadAllText("C:\\Users\\mmuldoon\\source\\repos\\SalesOps\\SalesOps\\excel\\salesforce.csv");

            //remove the " which SF puts in
            salesCsv = salesCsv.Replace('"', ' ');

            //split into lines
            salesCsv = salesCsv.Replace('\n', '\r');
            lines = salesCsv.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            //see how many rows and columns there are
            num_rows = lines.Length;
            num_cols = lines[0].Split(',').Length;


            //setup our struct
            SalesData[] salesData = new SalesData[num_rows - 1];

            //Allocate the data array
            string[,] values = new string[num_rows, num_cols];

            //Load the array, first row are headers

            for (int p = 0; p < num_rows; p++)
            {

                string[] line_r = lines[p].Split(',');

                int r = p - 1;
                if (p != 0)
                {
                    salesData[r].proposalNumber = line_r[0].Trim();
                    salesData[r].projectNumber = line_r[1].Trim();
                    salesData[r].accountName = line_r[2];
                    salesData[r].opportunityName = line_r[3];
                    salesData[r].confidence = line_r[4];
                    salesData[r].stage = line_r[5];
                    salesData[r].probability = Convert.ToInt32(line_r[6]);

                    string[] subStringDate = new string[3];
                    if (line_r[7].Equals("  ") || line_r[7].Equals(""))
                    {
                        salesData[r].closeDate = Convert.ToDateTime("01/01/2099");
                    }
                    else
                    {
                        subStringDate = line_r[7].Split('/');
                        salesData[r].closeDate = Convert.ToDateTime(subStringDate[1] + "/" + subStringDate[0] + "/" + subStringDate[2]);
                    }

                    //
                    salesData[r].carnetAssignment = line_r[8];

                    //
                    if (line_r[9].Equals("  ") || line_r[9].Equals(""))
                    {
                        salesData[r].carnetAssignmentDate = Convert.ToDateTime("01/01/2099");
                    }
                    else
                    {
                        subStringDate = line_r[9].Split('/');
                        salesData[r].carnetAssignmentDate = Convert.ToDateTime(subStringDate[1] + "/" + subStringDate[0] + "/" + subStringDate[2]);
                    }
                    //
                    if (line_r[10].Equals("  ") || line_r[10].Equals(""))
                    {
                        salesData[r].numberWeeks = 0;
                    }
                    else
                    {
                        salesData[r].numberWeeks = Convert.ToInt32(line_r[10]);
                    }
                    //
                    if (line_r[11].Equals("  ") || line_r[11].Equals(""))
                    {
                        salesData[r].hoursAtelier = 0;
                    }
                    else
                    {
                        salesData[r].hoursAtelier = Convert.ToInt32(line_r[11]);
                    }
                    //
                    if (line_r[12].Equals("  ") || line_r[12].Equals(""))
                    {
                        salesData[r].hoursElec = 0;
                    }
                    else
                    {
                        salesData[r].hoursElec = Convert.ToInt32(line_r[12]);
                    }
                    //
                    if (line_r[13].Equals("  ") || line_r[13].Equals(""))
                    {
                        salesData[r].hoursGestion = 0;
                    }
                    else
                    {
                        salesData[r].hoursGestion = Convert.ToInt32(line_r[13]);
                    }
                    //
                    if (line_r[14].Equals("  ") || line_r[14].Equals(""))
                    {
                        salesData[r].hoursLogiciel = 0;
                    }
                    else
                    {
                        salesData[r].hoursLogiciel = Convert.ToInt32(line_r[14]);
                    }
                    //
                    if (line_r[15].Equals("  ") || line_r[15].Equals(""))
                    {
                        salesData[r].hoursMechanical = 0;
                    }
                    else
                    {
                        salesData[r].hoursMechanical = Convert.ToInt32(line_r[15]);
                    }
                    //
                    if (line_r[16].Equals("  ") || line_r[16].Equals(""))
                    {
                        salesData[r].hoursProcede = 0;
                    }
                    else
                    {
                        salesData[r].hoursProcede = Convert.ToInt32(line_r[16]);
                    }
                    //
                    if (line_r[17].Equals("  ") || line_r[17].Equals(""))
                    {
                        salesData[r].hoursRC = 0;
                    }
                    else
                    {
                        salesData[r].hoursRC = Convert.ToInt32(line_r[17]);
                    }
                    //
                    if (line_r[18].Equals("  ") || line_r[18].Equals(""))
                    {
                        salesData[r].hoursRobot = 0;
                    }
                    else
                    {
                        salesData[r].hoursRobot = Convert.ToInt32(line_r[18]);
                    }
                    //
                    salesData[r].mainProcess = line_r[19];
                    salesData[r].secondaryProcess = line_r[20];
                    salesData[r].thirdProcess = line_r[21];
                    salesData[r].sharepoint = line_r[22];
                    salesData[r].systemProposed = line_r[23];
                }

                textBoxDebug.Text = r.ToString();

            }

            textBoxDebug.Text = "FINISHED SALES";

            //*******************************************************************************
            //PUT SALES DATA IN DB
            //*******************************************************************************
            string projectNumber; 

            for(int i = 0; i < salesData.Length; i++)
            {
                //first check if the data is already there.  if so we only update.
                if (salesData[i].proposalNumber.Equals("  ") || salesData[i].proposalNumber.Equals(""))
                {
                    //this is when we had the old ones
                    projectNumber = salesData[i].projectNumber.Substring(salesData[i].projectNumber.IndexOf('-') + 1);
                }
                else
                {
                    projectNumber = salesData[i].proposalNumber;
                }
                int pkProject = DatabaseAccess.ProjectPK(connectionString, projectNumber);

                salesData[i].totalHoursEstimated = salesData[i].hoursAtelier + salesData[i].hoursElec + salesData[i].hoursGestion + salesData[i].hoursLogiciel + salesData[i].hoursMechanical + salesData[i].hoursProcede + salesData[i].hoursRC + salesData[i].hoursRobot;

                if (pkProject == -1)
                {
                    //not present so we add
                    DatabaseAccess.WriteProjectToDatabase(connectionString, salesData[i].accountName, salesData[i].opportunityName, 
                        salesData[i].confidence, salesData[i].stage, salesData[i].probability, salesData[i].closeDate, 
                        salesData[i].carnetAssignment, salesData[i].carnetAssignmentDate, salesData[i].numberWeeks, 
                        salesData[i].hoursAtelier, salesData[i].hoursElec, salesData[i].hoursGestion, salesData[i].hoursLogiciel, 
                        salesData[i].hoursMechanical, salesData[i].hoursProcede, salesData[i].hoursRC, salesData[i].hoursRobot,
                        salesData[i].mainProcess, salesData[i].secondaryProcess, salesData[i].thirdProcess, salesData[i].sharepoint,
                        projectNumber, salesData[i].systemProposed, salesData[i].totalHoursEstimated);
                }
                else
                {
                    //present so we only update
                    DatabaseAccess.UpdateProjectInDatabase(connectionString, pkProject, salesData[i].accountName, 
                        salesData[i].opportunityName, salesData[i].confidence, salesData[i].stage, salesData[i].probability, 
                        salesData[i].closeDate, salesData[i].carnetAssignment, salesData[i].carnetAssignmentDate, 
                        salesData[i].numberWeeks, salesData[i].hoursAtelier, salesData[i].hoursElec, salesData[i].hoursGestion,
                        salesData[i].hoursLogiciel, salesData[i].hoursMechanical, salesData[i].hoursProcede, salesData[i].hoursRC,
                        salesData[i].hoursRobot, salesData[i].mainProcess, salesData[i].secondaryProcess, salesData[i].thirdProcess,
                        salesData[i].sharepoint, salesData[i].systemProposed, salesData[i].totalHoursEstimated);
                }
            }
            
            textBoxDebug.Text = textBoxDebug + "  DB Written";
            //*******************************************************************************
            //LOAD ACCEO DATA
            //*******************************************************************************

            num_rows = 0;
            num_cols = 0;
            String acceoCsv;
            string[] linesAcceo;
            //get the file
            acceoCsv = File.ReadAllText("C:\\Users\\mmuldoon\\source\\repos\\SalesOps\\SalesOps\\excel\\acceo.csv");

            //remove the " which SF puts in
            acceoCsv = acceoCsv.Replace('"', ' ');

            //split into lines
            acceoCsv = acceoCsv.Replace('\n', '\r');
            linesAcceo = acceoCsv.Split(new char[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            //see how many rows and columns there are
            num_rows = linesAcceo.Length;
            num_cols = linesAcceo[0].Split(',').Length;


            //setup our struct
            AcceoData[] acceoData = new AcceoData[num_rows - 1];

            //Allocate the data array
            //string[,] valuesAcceo = new string[num_rows, num_cols];

            //Load the array, first row are headers

            for (int p = 0; p < num_rows; p++)
            {
                string[] line_r = linesAcceo[p].Split(',');
                int r = p - 1;
                if (r == 12607)
                {
                    int test = 0;
                }
                if (p != 0)
                {
                    acceoData[r].projectNumber = line_r[0];
                    acceoData[r].projectTask = line_r[1];
                    acceoData[r].projectTaskDescription = line_r[2];
                    acceoData[r].refNumber = line_r[3];
                    acceoData[r].employeeName = line_r[4];
                    acceoData[r].week = line_r[5];
                    acceoData[r].weekDescription = line_r[6];
                    acceoData[r].totalHours = Convert.ToDouble(line_r[7]);
                    
                    if (line_r[8].Equals(""))
                    {
                        acceoData[r].monday = 0;
                    }
                    else
                    {
                        acceoData[r].monday = Convert.ToDouble(line_r[8]);
                    }
                    if (line_r[9].Equals(""))
                    {
                        acceoData[r].tuesday = 0;
                    }
                    else
                    {
                        acceoData[r].tuesday = Convert.ToDouble(line_r[9]);
                    }
                    if (line_r[10].Equals(""))
                    {
                        acceoData[r].wednesday = 0;
                    }
                    else
                    {
                        acceoData[r].wednesday = Convert.ToDouble(line_r[10]);
                    }
                    if (line_r[11].Equals(""))
                    {
                        acceoData[r].thursday = 0;
                    }
                    else
                    {
                        acceoData[r].thursday = Convert.ToDouble(line_r[11]);
                    }
                    if (line_r[12].Equals(""))
                    {
                        acceoData[r].friday = 0;
                    }
                    else
                    {
                        acceoData[r].friday = Convert.ToDouble(line_r[12]);
                    }

                    if (line_r[13].Equals(""))
                    {
                        acceoData[r].saturday = 0;
                    }
                    else
                    {
                        acceoData[r].saturday = Convert.ToDouble(line_r[13]);
                    }

                    if (line_r[14].Equals(""))
                    {
                        acceoData[r].sunday = 0;
                    }
                    else
                    {
                        acceoData[r].sunday = Convert.ToDouble(line_r[14]);
                    }

                    acceoData[r].description = line_r[15];
                }

            }

            //*******************************************************************************
            //PUT ACCEO DATA IN DB
            //*******************************************************************************
            int duplicateTimesheet = 0;

            DatabaseAccess.ClearTimeSheetTable(connectionString);

            for(int i = 0; i < acceoData.Length; i++)
            {
                int namePk = DatabaseAccess.ResourcePK(connectionString, acceoData[i].employeeName);
                if (namePk== -1)
                {
                    //we need to add resource
                    DatabaseAccess.WriteResourceToDatabase(connectionString, acceoData[i].employeeName);
                    namePk = DatabaseAccess.ResourcePK(connectionString, acceoData[i].employeeName);
                }

                int weekPk = DatabaseAccess.WeekPK(connectionString, acceoData[i].week);
                if(weekPk == -1)
                {
                    //add week to db
                    DatabaseAccess.WriteWeekToDatabase(connectionString, acceoData[i].weekDescription, acceoData[i].week);
                    weekPk = DatabaseAccess.WeekPK(connectionString, acceoData[i].week);
                }

                if (acceoData[i].projectNumber.Length < 3)
                {
                    projectNumber = "xxx";
                }
                else
                {
                    projectNumber = acceoData[i].projectNumber.Substring(acceoData[i].projectNumber.IndexOf('-') + 2);
                }

                int pkOpportunity = DatabaseAccess.ProjectPK(connectionString, projectNumber);
                if (pkOpportunity == -1)
                {
                    //means it could be an admin task and we need to add it
                    DatabaseAccess.WriteProjectToDatabase(connectionString, "ACCEO", "ACCEO",
                        "", "", 0, DateTime.Now, "", DateTime.Now, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                        "", "", "", "", projectNumber, "" ,0);
                    pkOpportunity = DatabaseAccess.ProjectPK(connectionString, projectNumber);
                }
                int timeSheetPk = DatabaseAccess.TimeSheetPK(connectionString, acceoData[i].projectTask, pkOpportunity, 
                    namePk, weekPk, acceoData[i].description);

                if(timeSheetPk > -5)
                {
                    acceoData[i].weeklyTotal = acceoData[i].monday + acceoData[i].tuesday + acceoData[i].wednesday + acceoData[i].thursday + acceoData[i].friday + acceoData[i].saturday + acceoData[i].sunday;
                    //we are ok to add
                    DatabaseAccess.WriteTimeSheetToDatabase(connectionString, pkOpportunity, acceoData[i].projectTask,
                        acceoData[i].projectTaskDescription,acceoData[i].refNumber,namePk,acceoData[i].weekDescription,weekPk, 
                        acceoData[i].totalHours, acceoData[i].monday, acceoData[i].tuesday, acceoData[i].wednesday,
                        acceoData[i].thursday, acceoData[i].friday, acceoData[i].saturday, acceoData[i].sunday, acceoData[i].description, acceoData[i].weeklyTotal);
                }
                else
                {

                    duplicateTimesheet += 1;

                }
                
            }

            DatabaseAccess.WriteDebugToDatabase(connectionString, "Number of Duplicate Timesheets: " + duplicateTimesheet.ToString(), DateTime.Now);

            textBoxDebug.Text = "Update Finished";
        }

        private void buttonUpdateChart_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=AVR-L093\SQLEXPRESS;Initial Catalog=SalesOps;Integrated Security=SSPI;";
            //these are all the lists I need to manipulate if I want to have different charts

            List<string> weeks = DatabaseAccess.GetListofWeeks(connectionString);
            List<string> teams = DatabaseAccess.GetListofTeams(connectionString);
            List<string> departments = DatabaseAccess.GetListofDepartments(connectionString);
            List<string> projects = DatabaseAccess.GetListofProjects(connectionString);

            List<double> hours = new List<double>();
            double runningTotal;



            //*******************************************************************************
            //this is where all the charting of existing efforts go
            //*******************************************************************************

            //get weekly hours available for the resources selected
            //for each department selected check the team selected

            string fullHoursQueryString = "";
            string headerHoursQueryString = "";
            string departmentQueryString = "";
            string teamQueryString = "";
            string departmentTeamQueryString = "";

            for (int j = 0; j < listBoxDepartments.Items.Count; j++)
            {
                //check if department is selected
                if (listBoxDepartments.GetSelected(j))
                {
                    if (departmentQueryString == "")
                    {
                        //first one
                        departmentQueryString = "(r.department like '"
                            + listBoxDepartments.Items[j].ToString() + "'";
                    }
                    else
                    {
                        //next query module
                        departmentQueryString += " OR r.department like '" + listBoxDepartments.Items[j].ToString() + "'";
                    }

                }
            }
            for (int i = 0; i < listBoxTeams.Items.Count; i++)
            {
                if (listBoxTeams.GetSelected(i))
                {
                    if (teamQueryString == "")
                    {
                        //first one
                        teamQueryString = " AND (r.team like '"
                            + listBoxTeams.Items[i].ToString() + "'";
                    }
                    else
                    {
                        //next query module
                        teamQueryString += " OR r.team like '" + listBoxTeams.Items[i].ToString() + "'";
                    }
                }
            }
            departmentTeamQueryString = departmentQueryString + ") " + teamQueryString + ") " + " AND r.status like 'active';";
            headerHoursQueryString = "select sum(weeklyAvailability) from Resources AS r where ";
            fullHoursQueryString = headerHoursQueryString + departmentTeamQueryString;
            double weeklyHoursAvailable = DatabaseAccess.GetAvailableWeeklyHours(connectionString, fullHoursQueryString);


            //now for each week selected let's cycle through each project and sum the hours based upon the Teams and Departments selected
            List<WeeklyProjectBurn> burnedHoursInProjects = new List<WeeklyProjectBurn>();
            WeeklyProjectBurn data = new WeeklyProjectBurn();

            string projectWeeklyHoursQueryString = "";
            string headerProjectWeeklyHours = "select sum(weeklyTotal) from TimeSheet as ts " +
                "inner join Week as w on w.pkWeek = ts.fkWeek " +
                "inner join Resources as r on r.pkResource = ts.fkResource " +
                "inner join Project as p on p.pkProjectNumber = ts.fkOpportunity " +
                "where w.weekNumber = '";

            List<string> test = new List<string>();
            foreach (string weekNumber in listBoxWeeks.SelectedItems)
            {
                test.Add(weekNumber);
            }


                //I need to filter the list of weeks to only the selected weeks
            foreach (string weekNumber in listBoxWeeks.SelectedItems)
            {
                List<string[]> releveantProjects = DatabaseAccess.GetRelevantProjects(connectionString, weekNumber, departmentTeamQueryString);
                for(int i = 0; i < releveantProjects.Count; i++)
                {
                    string project = releveantProjects[i][0];
                    projectWeeklyHoursQueryString = headerProjectWeeklyHours + weekNumber + "' AND p.projectNumber = '" +
                        project + "'AND" + departmentTeamQueryString;
                    double hourTotal = DatabaseAccess.GetHoursWeekProjectResourceTeam(connectionString, projectWeeklyHoursQueryString);
                    if (hourTotal != 0)
                    {
                        data.weekNumber = weekNumber;
                        data.projectNumber = project;
                        data.accountName = releveantProjects[i][1];
                        data.projectName = releveantProjects[i][2];
                        data.weeklyTotal = hourTotal;
                        burnedHoursInProjects.Add(data);
                    }
                }
                   
                
            }

            textBoxAvailableHours.Text = "Available Hours Weekly: " + weeklyHoursAvailable;

            dataGridViewForecast.Rows.Clear();
            chartForecast.Series.Clear();
            for (int i = 0; i < burnedHoursInProjects.Count; i++)
            {
                if (chartForecast.Series.IndexOf(burnedHoursInProjects[i].projectNumber) == -1)
                {
                    //it doesn't exist so we need to add it
                    chartForecast.Series.Add(new Series(burnedHoursInProjects[i].projectNumber));
                    chartForecast.Series[burnedHoursInProjects[i].projectNumber].IsValueShownAsLabel = false;
                    chartForecast.Series[burnedHoursInProjects[i].projectNumber].ChartType = SeriesChartType.StackedColumn;
                }

                chartForecast.Series[burnedHoursInProjects[i].projectNumber].Points.AddXY(Convert.ToInt32(burnedHoursInProjects[i].weekNumber), burnedHoursInProjects[i].weeklyTotal);
                chartForecast.Series[burnedHoursInProjects[i].projectNumber].ToolTip = "Project: " + burnedHoursInProjects[i].projectNumber 
                    + "\r\nAccount: " + burnedHoursInProjects[i].accountName
                    + "\r\nProject Name: " + burnedHoursInProjects[i].projectName
                    + "\r\nHours: " + burnedHoursInProjects[i].weeklyTotal.ToString();
                    
                dataGridViewForecast.Rows.Add(burnedHoursInProjects[i].weekNumber, burnedHoursInProjects[i].projectNumber, burnedHoursInProjects[i].weeklyTotal);
            }
            chartForecast.Update();
            textBoxDebug.Text += " " + weeks.Count;

        }

        private void chartForecast_Click(object sender, EventArgs e)
        {

        }
    }
}
