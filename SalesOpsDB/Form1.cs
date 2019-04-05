using System;
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
    //public double totalAcceoHours;
    public string mainProcess;
    public string secondaryProcess;
    public string thirdProcess;
    public string sharepoint;
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

namespace SalesOpsDB
{
    public partial class FormSalesOpsDB : Form
    {
        public FormSalesOpsDB()
        {
            InitializeComponent();
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
                        projectNumber, salesData[i].totalHoursEstimated);
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
                        salesData[i].sharepoint, salesData[i].totalHoursEstimated);
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
                        "", "", "", "", projectNumber, 0);
                    pkOpportunity = DatabaseAccess.ProjectPK(connectionString, projectNumber);
                }
                int timeSheetPk = DatabaseAccess.TimeSheetPK(connectionString, acceoData[i].projectTask, pkOpportunity, 
                    namePk, weekPk, acceoData[i].description);

                if(timeSheetPk == -1)
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
                    textBoxDebug.Text = textBoxDebug.Text + "shit";
                }

            }


            textBoxDebug.Text = textBoxDebug.Text + "  ACCEO FINISHED";
        }
    }
}
