using System;
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
        Dictionary<long, string> _resultsMemory;
        int _fasting;

        //construtor
        public TestResult(Dictionary<long, string> resultsMemory)
        {
            _resultsMemory = resultsMemory;
        }
        public bool isInitialized;
        public TestResult()
        {
            isInitialized = true;
        }

        //properties
        private Dictionary<long, string> resultsMemory
        {
            get
            {
                return _resultsMemory;
            }
        }
        private int fasting
        {
            get
            {
                return _fasting;
            }
        } 
        //methods
        public void readIt()
        {
            long dbDate;
            string dbResult;
            int dbFast;
            SQLiteConnection dbConnect;
            dbConnect = new SQLiteConnection("Data Source=database.sqlite; Version=3;");
            dbConnect.Open();
            string readAllRows = "SELECT date, testResult, fasting FROM result ORDER BY date ASC";

            SQLiteCommand readRow = new SQLiteCommand(readAllRows, dbConnect);
            SQLiteDataReader reader = readRow.ExecuteReader();
            
            while (reader.Read())
            {
                dbDate = long.Parse(reader["date"].ToString());
                dbResult = reader["testResult"].ToString();
                dbFast = int.Parse(reader["fasting"].ToString());
                _resultsMemory.Add(dbDate, dbResult);
            }
            
        }
        public void writeIt(string inputText, bool fasting)
        {
            var dbConnect = new SQLiteConnection("Data Source=database.sqlite;Version=3;");
            dbConnect.Open();
            using (SQLiteTransaction insertTrans = dbConnect.BeginTransaction())
            {
                using (SQLiteCommand insertCommand = new SQLiteCommand(dbConnect))
                {
                    SQLiteParameter resultEntry = new SQLiteParameter();
                    insertCommand.CommandText = "INSERT INTO result(testResult, fasting) VALUES(@param1, @param2)";
                    insertCommand.Parameters.AddWithValue(new SQLiteParameter("@param1", System.Data.SqlDbType.VarChar).Value = inputText);
                    if(fasting)
                    {
                        insertCommand.Parameters.Add(new SQLiteParameter("@param2", System.Data.SqlDbType.Int).Value = "1");
                    }
                    else
                    {
                        insertCommand.Parameters.Add(new SQLiteParameter("@param2", System.Data.SqlDbType.Int).Value = "0");
                    }
                    insertCommand.ExecuteNonQuery();
                }
                insertTrans.Commit();
            }
            
            //var resultEntry = "INSERT INTO result(testResult, fasting) VALUES(?, ?)";
            
            //writeRow.Parameters.Add(new SQLiteParameter("?", inputText));
            //if (fasting)
            //{
            //    insertCommand.Parameter.Add(new SQLiteParameter("@param2", 1));
            //}
            //else
            //{
            //    insertCommand.Parameter.Add(new SQLiteParameter("@param2", 0));
            //}
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
        
    }
}

