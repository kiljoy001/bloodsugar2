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
            string createTable = "CREATE TABLE result (testID INTEGER PRIMARY KEY, date TIMESTAMP DEFAULT(STRFTIME('%s', 'now')) , testResult TEXT);";
            SQLiteCommand newTable = new SQLiteCommand(createTable, dbConnect);
            //Close the connection.
            dbConnect.Close();
        }// returns a string from a datetime object
        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2} {3}:{4}:{5}.{6}";
            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second, datetime.Millisecond);
        }
    }
}

  

