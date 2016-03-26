﻿using System.Windows.Forms;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;


namespace bloodsugar_2
{

    public partial class Form1 : Form
    {
        Dictionary<long, string> tempStorage = new Dictionary<long, string>();
        TestResult mainModel = new TestResult();
        List<long> retrivedDates = new List<long>();

        public Form1()
        {
            InitializeComponent();
            
            string dbName = "database.sqlite";
            if (File.Exists(dbName) == false)
            {
                dbcreate();
            }
            
            if (tempStorage.Count == 0)
            {
                 mainModel.readIt(tempStorage);
            }
            mainModel.chartIt(chartResults, tempStorage);
        }
        //helper method to create a basic 1 bit boolean value to be stored in the database
        private int isFasting()
        {
            if(rdoFasting.Checked)
            {
                return 1;
            }
            else
            {
                return 0;
            }
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
            string createTable = "CREATE TABLE result (date TIMESTAMP PRIMARY KEY DEFAULT(STRFTIME('%s', 'now')) , testResult TEXT, fasting INTEGER)";
            SQLiteCommand newTable = new SQLiteCommand(createTable, dbConnect);
            newTable.ExecuteNonQuery();
            //Close the connection.
            dbConnect.Close();
        }// returns a string from a datetime object
        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2} {3}:{4}:{5}.{6}";
            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day, datetime.Hour, datetime.Minute, datetime.Second, datetime.Millisecond);
        }
        private void searchDateOnChange(object sender, EventArgs e)
        {
            //gets value from the control
            DateTime selectedDate = findDate.Value;
            //pulls internal dictionary from testresult class and adds it to a local dictionary for the method
            Dictionary<long, string> checkDate = mainModel.Map;
            
            //check if there is anything in the list, and if not populates it
            if (retrivedDates.Count <= 0 )
            {
                foreach (KeyValuePair<long, string> entry in checkDate)
                {
                    retrivedDates.Add(entry.Key);
                }
                foreach (long items in retrivedDates)
                {
                    long dbDate = 0;
                    string dbResult = null;
                    int dbFast = 0;

                    using (SQLiteConnection dbConnect = new SQLiteConnection("Data Source=database.sqlite; Version=3;"))
                    {
                        dbConnect.Open();
                        
                        using (SQLiteCommand compareDates = new SQLiteCommand(dbConnect))
                        {
                            SQLiteParameter findDate = new SQLiteParameter();
                            compareDates.CommandText = "SELECT date, testResult, fasting FROM result WHERE date <= @selectedDateValue";
                            compareDates.Parameters.AddWithValue("@selectedDateValue", System.Data.DbType.String).Value = items;
                            using (SQLiteDataReader reader = compareDates.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    //date is autogenerated when inserted into the database (uses timestamp unix epoch)
                                    dbDate = reader.GetInt64(0);
                                    dbResult = reader["testResult"].ToString();
                                    dbFast = int.Parse(reader["fasting"].ToString());
                                    
                                }
                            }
                        }
                        dbConnect.Close();
                    }
                    listBResult.Items.Add(mainModel.fromUnixTime(dbDate).ToShortDateString() +" " + dbResult);
                }
            }
            else
            {
                foreach (long items in retrivedDates)
                {
                    long dbDate = 0;
                    string dbResult = null;
                    int dbFast = 0;

                    using (SQLiteConnection dbConnect = new SQLiteConnection("Data Source=database.sqlite; Version=3;"))
                    {
                        dbConnect.Open();

                        using (SQLiteCommand compareDates = new SQLiteCommand(dbConnect))
                        {
                            SQLiteParameter findDate = new SQLiteParameter();
                            compareDates.CommandText = "SELECT date, testResult, fasting FROM result WHERE date <= @selectedDateValue";
                            compareDates.Parameters.AddWithValue("@selectedDateValue", System.Data.DbType.String).Value = items;
                            using (SQLiteDataReader reader = compareDates.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    //date is autogenerated when inserted into the database (uses timestamp unix epoch)
                                    dbDate = reader.GetInt64(0);
                                    dbResult = reader["testResult"].ToString();
                                    dbFast = int.Parse(reader["fasting"].ToString());

                                }
                            }
                        }
                        dbConnect.Close();
                    }
                    listBResult.Items.Add(mainModel.fromUnixTime(dbDate).ToShortDateString() + " " + dbResult);
                }
            }
           }
        private void btnResult_Click(object sender, EventArgs e)
        {
            mainModel.writeIt(txtResult.Text, isFasting());
            txtResult.Clear();
            chartResults.Series[0].Points.Clear();
            mainModel.chartIt(chartResults, tempStorage);
        }
    }
   
}


  

