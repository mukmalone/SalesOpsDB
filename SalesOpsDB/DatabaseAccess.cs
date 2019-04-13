using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOpsDB
{
    class DatabaseAccess
    {
        public static int ProjectPK(string connectionString, string projectNumber)
        {
            int result = -1;

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = "select pkProjectNumber from Project where projectNumber like '" + projectNumber + "'; ";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result = Convert.ToInt32(dataReader.GetValue(0));
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection projectNumberPK");
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

        public static void WriteProjectToDatabase(string connectionString, string accountName, string projectName, string confidence, 
            string stage, int probability, DateTime closeDate, string carnetAssignment, DateTime carnetAssignmentDate, int numberWeeks, 
            int hoursAtelier, int hoursElec, int hoursGestion, int hoursLogiciel, int hoursMechanical, int hoursProcede, int hoursRC, 
            int hoursRobot, string mainProcess, string secondaryProcess, string thirdProcess, string sharepoint, string projectNumber, string systemProposed, int totalHoursEstimated)
        {
            SqlConnection cnn;
            SqlCommand commandInsert;

            string sql = null;
            sql = "INSERT INTO Project(accountName, projectName, confidence, stage, probability, " +
                "closeDate, carnetAssignment, carnetAssignmentDate, numberWeeks, " +
                "hoursAtelier, hoursElec, hoursGestion, hoursLogiciel, hoursMechanical, " +
                "hoursProcede, hoursRC, hoursRobot, mainProcess, secondaryProcess, thirdProcess, " +
                "sharepoint, projectNumber, systemProposed, totalHoursEstimated) " +
                "VALUES ('" + accountName + "', " +
                "'" + projectName + "'," +
                "'" + confidence + "'," +
                "'" + stage + "'," +
                probability.ToString() + "," +
                "'" + closeDate.ToString() + "'," +
                "'" + carnetAssignment + "'," +
                "'" + carnetAssignmentDate.ToString() + "'," +
                numberWeeks.ToString() + "," +
                hoursAtelier.ToString() + "," +
                hoursElec.ToString() + "," +
                hoursGestion.ToString() + "," +
                hoursLogiciel.ToString() + "," +
                hoursMechanical.ToString() + "," +
                hoursProcede.ToString() + "," +
                hoursRC.ToString() + "," +
                hoursRobot.ToString() + "," +
                "'" + mainProcess + "'," +
                "'" + secondaryProcess + "'," +
                "'" + thirdProcess + "'," +
                "'" + sharepoint + "'," +
                "'" + projectNumber + "'," +
                "'" + systemProposed + "'," +
                totalHoursEstimated.ToString() + "); ";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                commandInsert = new SqlCommand(sql, cnn);

                commandInsert.ExecuteNonQuery();
                commandInsert.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection write Event: " + sql);
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
        }

        public static void UpdateProjectInDatabase(string connectionString, int pkProject,string accountName, string projectName, string confidence,
    string stage, int probability, DateTime closeDate, string carnetAssignment, DateTime carnetAssignmentDate, int numberWeeks,
    int hoursAtelier, int hoursElec, int hoursGestion, int hoursLogiciel, int hoursMechanical, int hoursProcede, int hoursRC,
    int hoursRobot, string mainProcess, string secondaryProcess, string thirdProcess, string sharepoint, string systemProposed, int totalHoursEstimated)
        {
            SqlConnection cnn;
            SqlCommand commandInsert;

            string sql = null;
            sql = "UPDATE Project SET accountName = '" + accountName + "', " +
                "projectName = '" + projectName + "', " +
                "confidence = '" + confidence + "', " +
                "stage = '" + stage + "'," +
                "probability = " + probability.ToString() + "," +
                "closeDate = '" + closeDate.ToString() + "'," +
                "carnetAssignment = '" + carnetAssignment + "'," +
                "carnetAssignmentDate = '" + carnetAssignmentDate.ToString() + "'," +
                "numberWeeks = " + numberWeeks.ToString() + "," +
                "hoursAtelier = " + hoursAtelier.ToString() + "," +
                "hoursElec = " + hoursElec.ToString() + "," +
                "hoursGestion = " + hoursGestion.ToString() + "," +
                "hoursLogiciel = " + hoursLogiciel.ToString() + "," +
                "hoursMechanical = " + hoursMechanical.ToString() + "," +
                "hoursProcede = " + hoursProcede.ToString() + "," +
                "hoursRC = " + hoursRC.ToString() + "," +
                "hoursRobot = " + hoursRobot.ToString() + "," +
                "mainProcess = '" + mainProcess + "'," +
                "secondaryProcess = '" + secondaryProcess + "'," +
                "thirdProcess = '" + thirdProcess + "'," +
                "sharepoint = '" + sharepoint + "'," +
                "systemProposed = '" + systemProposed + "'," +
                "totalHoursEstimated = " + totalHoursEstimated.ToString() +
                " WHERE pkProjectNumber = " + pkProject.ToString() + ";";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                commandInsert = new SqlCommand(sql, cnn);

                commandInsert.ExecuteNonQuery();
                commandInsert.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection write Event: " + sql);
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
        }

        public static int ResourcePK(string connectionString, string name)
        {
            int result = -1;

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = "select pkResource from Resources where name like '" + name + "'; ";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result = Convert.ToInt32(dataReader.GetValue(0));
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection projectNumberPK");
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

        public static void WriteResourceToDatabase(string connectionString, string name)
        {
            SqlConnection cnn;
            SqlCommand commandInsert;

            string sql = null;
            sql = "INSERT INTO Resources(name) " +
                "VALUES ('" + name + "');";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                commandInsert = new SqlCommand(sql, cnn);

                commandInsert.ExecuteNonQuery();
                commandInsert.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection write Event: " + sql);
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
        }

        public static int WeekPK(string connectionString, string week)
        {
            int result = -1;

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = "select pkWeek from Week where weekNumber = " + week + "; ";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result = Convert.ToInt32(dataReader.GetValue(0));
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection projectNumberPK");
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

        public static void WriteWeekToDatabase(string connectionString, string weekDescription, string week)
        {
            SqlConnection cnn;
            SqlCommand commandInsert;

            string sql = null;
            sql = "INSERT INTO Week(acceoWeekName,weekNumber) " +
                "VALUES ('" + weekDescription + "'," + week +");";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                commandInsert = new SqlCommand(sql, cnn);

                commandInsert.ExecuteNonQuery();
                commandInsert.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection write Event: " + sql);
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
        }

        public static int TimeSheetPK(string connectionString, string projectTask, int fkOpportunity, int fkResource, int fkWeek, string description)
        {
            int result = -1;

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = "select pkTimeSheet from TimeSheet where projectTask like '" + projectTask + 
                "' AND fkOpportunity = " + fkOpportunity.ToString() + 
                " AND fkResource = " + fkResource.ToString() +
                " AND fkWeek = " + fkWeek.ToString() + 
                " AND description LIKE'" + description + "';";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result = Convert.ToInt32(dataReader.GetValue(0));
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection projectNumberPK");
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

        public static void WriteTimeSheetToDatabase(string connectionString, int fkOpportunity, string projectTask, 
            string projectTaskDescription, string refNumber, int fkResource, string week, int fkWeek, double totalHours,
            double monday, double tuesday, double wednesday, double thursday, double friday, double saturday, double sunday,
            string description, double weeklyTotal)
        {
            SqlConnection cnn;
            SqlCommand commandInsert;

            string sql = null;
            sql = "INSERT INTO TimeSheet(fkOpportunity, projectTask, projectTaskDescriptison, refNumber, fkResource, " +
                "week,fkWeek,totalHours, monday, tuesday, wednesday, thursday, friday, saturday, sunday, description, weeklyTotal) VALUES ("
                + fkOpportunity.ToString() + ","
                + "'" + projectTask + "',"
                + "'" + projectTaskDescription + "',"
                + "'" + refNumber + "',"
                + fkResource.ToString() + ","
                + "'" + week + "',"
                + fkWeek.ToString() + ","
                + totalHours.ToString() + ","
                + monday.ToString() + ","
                + tuesday.ToString() + ","
                + wednesday.ToString() + ","
                + thursday.ToString() + ","
                + friday.ToString() + ","
                + saturday.ToString() + ","
                + sunday.ToString() + ","
                + "'" + description + "',"
                + weeklyTotal.ToString() + ");";
             

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                commandInsert = new SqlCommand(sql, cnn);

                commandInsert.ExecuteNonQuery();
                commandInsert.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection write Event: " + sql);
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
        }

        public static void WriteDebugToDatabase(string connectionString, string debugString, DateTime date)
        {
            SqlConnection cnn;
            SqlCommand commandInsert;

            string sql = null;
            sql = "INSERT INTO DebugTable(debugMessage, dateTime) Values ('" + debugString + "','" + date.ToString() + "');";


            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                commandInsert = new SqlCommand(sql, cnn);

                commandInsert.ExecuteNonQuery();
                commandInsert.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection write Event: " + sql);
            }
            cnn.Close();
        }

        public static double GetAvailableWeeklyHours(string connectionString, string fullQueryString)
        {
            double result = 0;

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = fullQueryString;

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result = Convert.ToDouble(dataReader.GetValue(0));
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection projectNumberPK");
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

        public static double GetHoursWeekProjectResourceTeam(string connectionString, string queryString)
        {
            
            double result = 0;
            
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = queryString;

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result = Convert.ToDouble(dataReader.GetValue(0));
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection projectNumberPK");
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

        public static List<string> GetListofWeeks(string connectionString)
        {
            
            List<string> result = new List<string>();
            
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = "select weekNumber from Week order by weekNumber;";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result.Add(Convert.ToString(dataReader.GetValue(0)));
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

        public static List<string> GetListofProjects(string connectionString)
        {

            List<string> result = new List<string>();

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            //where accountName not like 'acceo' 
            sql = "select projectNumber from Project order by projectNumber;";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result.Add(Convert.ToString(dataReader.GetValue(0)).Trim());
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

        public static double GetProjectHoursInWeek(string connectionString,string weekNumber, string projectNumber)
        {
            double result = 0;

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = "select sum(totalHours) from TimeSheet as ts " +
                "inner join Project as p on p.pkProjectNumber =ts.fkOpportunity " +
                "inner join Week as w on w.pkWeek = ts.fkWeek " +
                "where w.weekNumber like '" + weekNumber.Trim() + "' and p.projectNumber like '" + projectNumber.Trim() +" ';";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result = Convert.ToDouble(dataReader.GetValue(0));
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection projectNumberPK");
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }
        public static List<string> GetListofTeams(string connectionString)
        {

            List<string> result = new List<string>();

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = "select distinct team from Resources order by team asc;";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result.Add(Convert.ToString(dataReader.GetValue(0)).Trim());
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

        public static List<string> GetListofDepartments(string connectionString)
        {
            List<string> result = new List<string>();

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = "select distinct department from Resources order by department asc;";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result.Add(Convert.ToString(dataReader.GetValue(0)).Trim());
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

        public static List<string[]> GetRelevantProjects(string connectionString, string weekNumber, string departmentTeamQueryString)
        {

            List<string[]> result = new List<string[]>();

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = "select distinct p.projectNumber, p.accountName, p.projectName,p.numberWeeks,p.hoursAtelier,p.hoursElec,p.hoursGestion, " +
                "p.hoursLogiciel,p.hoursMechanical, p.hoursProcede, p.hoursRC, p.hoursRobot, p.totalHoursEstimated from TimeSheet as ts " +
                "inner join Week as w on w.pkWeek = ts.fkWeek " +
                "inner join Resources as r on r.pkResource = ts.fkResource " +
                "inner join Project as p on p.pkProjectNumber = ts.fkOpportunity " +
                "where ts.weeklyTotal <> 0 and (w.weekNumber = " + weekNumber + ") and "+departmentTeamQueryString;

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string[] projectArray = new string[13];
                    projectArray[0] = Convert.ToString(dataReader.GetValue(0)).Trim();
                    projectArray[1] = Convert.ToString(dataReader.GetValue(1));
                    projectArray[2] = Convert.ToString(dataReader.GetValue(2));
                    projectArray[3] = Convert.ToString(dataReader.GetValue(3));
                    projectArray[4] = Convert.ToString(dataReader.GetValue(4));
                    projectArray[5] = Convert.ToString(dataReader.GetValue(5));
                    projectArray[6] = Convert.ToString(dataReader.GetValue(6));
                    projectArray[7] = Convert.ToString(dataReader.GetValue(7));
                    projectArray[8] = Convert.ToString(dataReader.GetValue(8));
                    projectArray[9] = Convert.ToString(dataReader.GetValue(9));
                    projectArray[10] = Convert.ToString(dataReader.GetValue(10));
                    projectArray[11] = Convert.ToString(dataReader.GetValue(11));
                    projectArray[12] = Convert.ToString(dataReader.GetValue(12));
                    result.Add(projectArray);
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

        public static void ClearTimeSheetTable(string connectionString)
        {

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = "delete from TimeSheet;";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
        }

        public static double GetProjectHoursTotal(string connectionString, string projectNumber)
        {
            double result = 0;

            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;

            string sql = null;
            sql = "select sum(ts.weeklyTotal) from TimeSheet as ts " +
                "inner join week as w on w.pkWeek = ts.fkWeek " +
                "inner join Project as p on p.pkProjectNumber = ts.fkOpportunity " +
                "where p.projectNumber = '" + projectNumber.Trim() + "'";          

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();

                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    result = Convert.ToDouble(dataReader.GetValue(0));
                }
                dataReader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Can not open connection projectNumberPK");
                DatabaseAccess.WriteDebugToDatabase(connectionString, sql, DateTime.Now);
            }
            cnn.Close();
            return result;
        }

    }
}



