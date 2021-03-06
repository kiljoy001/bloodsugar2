﻿using System.Windows.Forms;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.IO;


namespace bloodsugar_2
{

    public partial class mainForm : Form
    {
        Dictionary<long, string> tempStorage = new Dictionary<long, string>();
        TestResult mainModel = new TestResult();
        List<long> retrivedDates = new List<long>();
        //returns an array of names that match *sqlite in the My Documents directory.
        string[] dbName = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"*.sqlite",SearchOption.TopDirectoryOnly );
        public mainForm()
        {
            InitializeComponent();

            if (String.IsNullOrEmpty(mainModel.Database))
            {
                DialogResult startNewDB = MessageBox.Show("There is no data loaded, would you like to create a new database?", "No Database Loaded", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if(startNewDB == DialogResult.OK)
                {
                    saveDBDialog();
                }
            }

            if (tempStorage.Count == 0)
            {
                mainModel.readIt(tempStorage);
            }
            mainModel.chartIt(chartResults, tempStorage);
        }
        //helper method to create a basic interger boolean value to be stored in the database
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
        public void dbcreate(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                //default file name
                SQLiteConnection.CreateFile("database.sqlite");
            }
            else
            {
                //Create the database with a chosen username
                SQLiteConnection.CreateFile(input + ".sqlite");
            }
            
            //Connection String
            SQLiteConnection dbConnect;
            dbConnect = new SQLiteConnection("Data Source=" + input+";Version=3;");
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
            long dbDate = 0;
            string dbResult = null;
            int dbFast = 0;

            mainModel.compareDate(selectedDate, ref dbDate, ref dbResult, ref dbFast);
            
                    listBResult.Items.Clear();
                    listBResult.Items.Add(mainModel.fromUnixTime(dbDate).ToShortDateString() +" " + dbResult);
            
                    listBResult.Items.Add(mainModel.fromUnixTime(dbDate).ToShortDateString() + " " + dbResult);
                }
           
        private void btnResult_Click(object sender, EventArgs e)
        {
            int numberResult;
            bool inputText = int.TryParse(txtResult.Text, out numberResult);
            if (inputText)
            {
                mainModel.writeIt(txtResult.Text, isFasting());
                txtResult.Clear();
                chartResults.Series[0].Points.Clear();
                mainModel.chartIt(chartResults, tempStorage);
            }
            else
            {
                MessageBox.Show("Please enter a number into the box!", "Error!", MessageBoxButtons.OK);
            }
            
        }

        private void btnShowDict_Click(object sender, EventArgs e)
        {
            long dbDate = 0;
            string dbResult = null;
            Dictionary<long, string> entries = mainModel.Map;
            foreach(KeyValuePair<long, string> resultPairs in entries)
            {
                dbDate = resultPairs.Key;
                dbResult = resultPairs.Value;
                listBResult.Items.Add(mainModel.fromUnixTime(dbDate).ToShortDateString() + " " + dbResult);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("Creating a new database will clear the chart!\nDo you still wish to proceed?", "WARNING!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(warning == DialogResult.OK)
            {
                mainModel.Clear();
                chartResults.Series[0].Points.Clear();
                saveDBDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }
        private void openDBDialog()
        {
            //new openfiledialog object
            OpenFileDialog openDB = new OpenFileDialog();
            //default extension
            openDB.DefaultExt = "sqlite";
            //extension filter
            openDB.Filter = "Sqlite files (*.sqlite) |*.sqlite|All Files (*.*) |*.*";
            //initial directory to search for the files - I have set to 'my documents'
            openDB.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //there can only be one file open ... lol highlander.
            openDB.Multiselect = false;
            //setting up the program to understand openDB dialog object's result
            DialogResult openMe = openDB.ShowDialog();
            if (openMe == DialogResult.OK)
            {
                //Sets the database property for the testResult object (it is not set by default)
                mainModel.Database = openDB.FileName;
                //read the information from the db
                mainModel.readIt(tempStorage);
                //display it
                mainModel.chartIt(chartResults, tempStorage);

            }
            else
            {
                //this does not seem to work, might need to use an exception to make this happen
                MessageBox.Show("The database did not load, it may be corrupted or empty.");

            }
        }
        private void saveDBDialog()
        {
            SaveFileDialog saveDB = new SaveFileDialog();
            saveDB.AddExtension = true;
            //saveDB.CheckFileExists = true;
            saveDB.OverwritePrompt = true;
            saveDB.DefaultExt = "sqlite";
            saveDB.Filter = "Sqlite files (*.sqlite) |*.sqlite|All Files (*.*) |*.*";
            saveDB.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //saveDB.ShowDialog();
            DialogResult saveMe = saveDB.ShowDialog();
            if (saveMe == DialogResult.OK)
            {
                dbcreate(saveDB.FileName);
                mainModel.Database = saveDB.FileName;


            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDBDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
                   
        }
    }
   
}


  

