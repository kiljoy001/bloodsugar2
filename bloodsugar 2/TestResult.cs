﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms.DataVisualization.Charting;

namespace bloodsugar_2
{
    public class TestResult
    {
        //fields
        private Dictionary<long, string> _resultsMemory;
        private string _dbName;

        //construtor
        public TestResult()
        {
            _resultsMemory = new Dictionary<long, string> ();
            _dbName = Database;
        }

        //properties
        public Dictionary<long, string> Map
        {
            get
            {
                return _resultsMemory;
            }
        }

        public string Database
        {
            get; set;
        }

        //methods
        public void readIt(Dictionary<long, string> addMemory)
        {
            long dbDate;
            string dbResult;
            int dbFast;
            //SQLiteConnection dbConnect;
            using (SQLiteConnection dbConnect = new SQLiteConnection("Data Source=" +Database + "; Version=3;"))
            {
                try
                {
                    dbConnect.Open();
                    string readAllRows = "SELECT date, testResult, fasting FROM result ORDER BY date ASC";
                    using (SQLiteCommand readRow = new SQLiteCommand(readAllRows, dbConnect))
                    {
                        using (SQLiteDataReader reader = readRow.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //date is autogenerated when inserted into the database (uses timestamp)
                                dbDate = reader.GetInt64(0);
                                dbResult = reader["testResult"].ToString();
                                dbFast = int.Parse(reader["fasting"].ToString());
                                addMemory.Add(dbDate, dbResult);
                                _resultsMemory.Add(dbDate, dbResult);
                            }
                        }
                    }
                }
                catch
                {

                }

                dbConnect.Close();
            }
        }

        public void writeIt(string inputText, int fasting)
        {
            //open db connection uses the database property to get the location of the sqlite file.
            var dbConnect = new SQLiteConnection("Data Source=" + Database + "; Version=3;");
            dbConnect.Open();
            using (SQLiteTransaction insertTrans = dbConnect.BeginTransaction())
            { //start transaction
                using (SQLiteCommand insertCommand = new SQLiteCommand(dbConnect))
                { //insert command
                    SQLiteParameter resultEntry = new SQLiteParameter();
                    insertCommand.CommandText = "INSERT INTO result(testResult, fasting) VALUES(@param1, @param2)";
                    insertCommand.Parameters.Add("@param1", System.Data.DbType.String).Value = inputText;
                    if(fasting == 1)
                    {
                        insertCommand.Parameters.Add("@param2", System.Data.DbType.Int32).Value = 1;
                    }
                    else
                    {
                        insertCommand.Parameters.Add("@param2", System.Data.DbType.Int32).Value = 0;
                    }
                    insertCommand.ExecuteNonQuery();
                }
                insertTrans.Commit();
            }
        }
        //method that converts unix time to a datetime object
        //http://stackoverflow.com/questions/2883576/how-do-you-convert-epoch-time-in-c
        public DateTime fromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }
        public void chartIt(Chart mainChart, Dictionary<long, string> resultsMemory)
        {
            mainChart.Series[0].XValueType = ChartValueType.DateTime;

            foreach (KeyValuePair<long, string> pair in resultsMemory)
            {
                DateTime x = fromUnixTime(pair.Key);
                mainChart.Series[0].Points.AddXY(x, pair.Value);
            }
        }
        public void Clear()
        {
            Database = null;
            _resultsMemory.Clear();
        }
        
    }
}

