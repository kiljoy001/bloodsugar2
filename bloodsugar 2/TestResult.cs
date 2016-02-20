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

        //construtor
        public TestResult(Dictionary<long, string> resultsMemory)
        {
            _resultsMemory = resultsMemory;
        }
        //properties
        private Dictionary<long, string> resultsMemory
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
            long dbDate = long.Parse(reader["date"].ToString());
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

