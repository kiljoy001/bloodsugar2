using System.Windows.Forms;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace bloodsugar_2
{
   
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public void dbcreate()
        {
            //Create the database and populate it with a table called result
            SQLiteConnection.CreateFile("database.sqlite");
            //Connection String
            SQLiteConnection dbConnect;
            dbConnect = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            //Open for business!
            dbConnect.Open();
            //Table Creation
            string createTable = "CREATE TABLE result (testid INTEGER PRIMARY KEY, date DEFAULT CURRENT_TIMESTAMP , testResult TEXT";
            SQLiteCommand newTable = new SQLiteCommand(createTable, dbConnect);
            //Close the connection.
            dbConnect.Close();
        }// returns a string from a datetime object
        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2} {3}:{4}:{5}.{6}";
            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second, datetime.Millisecond);
        }
    }//still being worked on
    public class TestResult
    {
        //fields
        Dictionary<string, string> _resultsMemory;

        //construtor
        public TestResult(Dictionary<string, string> resultsMemory)
        {
            _resultsMemory = resultsMemory;
        }
        //properties
        private Dictionary<string, string> resultsMemory
        {
            get
            {
                return _resultsMemory;
            }
        }
        //methods
        public void readIt()
        {
            SQLiteConnection dbConnect;
            dbConnect = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            dbConnect.Open();
            string readAllRows = "SELECT date, testResult FROM result ORDER BY date ASC";
    
        SQLiteCommand readRow = new SQLiteCommand(readAllRows, dbConnect);
            SQLiteDataReader reader = readRow.ExecuteReader();
            string dbDate = reader["date"].ToString();
            string dbResult = reader["testResult"].ToString();
            while (reader.Read())
            {
                _resultsMemory.Add(dbDate, dbResult);
            }
        }
        public void writeIt(string inputText)
        {
            SQLiteConnection dbConnect;
            dbConnect = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            dbConnect.Open();
            string result = "INSERT INTO result(testResult) VALUES(@param1)";
            SQLiteCommand writeRow = new SQLiteCommand(result, dbConnect);
            writeRow.Parameters.Add(new SQLiteParameter("@param1", inputText));
        }
        public void chartIt(Chart mainChart, Dictionary<string, string> resultsMemory)
        {
            mainChart.Series[0].XValueType = ChartValueType.DateTime;
            foreach (KeyValuePair<string, string> pair in resultsMemory)
            {


                //creating a new datetime object that takes the key from the dictionary and then converts it to a string to be parsed as a double to be used for fromOADate (total hack, storing this crap would better in a actual database).
                DateTime x = DateTime.FromOADate(double.Parse(pair.Key.ToString()));
                mainChart.Series[0].Points.AddXY(x.ToOADate(), pair.Value);
            }
        }
    }
}
