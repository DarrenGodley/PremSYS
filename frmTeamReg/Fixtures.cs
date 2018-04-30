using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace frmTeamReg
{
    class Fixtures
    {
        // instance variables
        private int fixtureID;
        private int homeTeamID;
        private int awayTeamID;
        private String fixtureDate;
        private double fixtureTime;
        private int homeScore;
        private int awayScore;

        //Define getters
        public int getFixtureID()
        {
            return fixtureID;
        }

        public int getHomeTeamID()
        {
            return homeTeamID;
        }

        public int getAwayTeamID()
        {
            return awayTeamID;
        }

        public String getFixtureDate()
        {
            return fixtureDate;
        }

        public double getFixtureTime()
        {
            return fixtureTime;
        }

        public int getHomeScore()
        {
            return homeScore;
        }

        public int getAwayScore()
        {
            return awayScore;
        }

        //Define setters
        public void setFixtureID(int FixtureID)
        {
            this.fixtureID = FixtureID;
        }

        public void setHomeTeamID(int HomeTeamID)
        {
            this.homeTeamID = HomeTeamID;
        }

        public void setAwayTeamID(int AwayTeamID)
        {
            this.awayTeamID = AwayTeamID;
        }

        public void setFixtureDate(String FixtureDate)
        {
            this.fixtureDate = FixtureDate;
        }

        public void setFixtureTime(double FixtureTime)
        {
            this.fixtureTime = FixtureTime;
        }

        public void setHomeScore(int HomeScore)
        {
            this.homeScore = HomeScore;
        }

        public void setAwayScore(int AwayScore)
        {
            this.awayScore = AwayScore;
        }

        //Constructor
        public Fixtures(int FixtureID, int HomeTeamID, int AwayTeamID, String FixtureDate, double FixtureTime, int HomeScore, int AwayScore)
        {
            fixtureID = FixtureID;
            homeTeamID = HomeTeamID;
            awayTeamID = AwayTeamID;
            fixtureDate = FixtureDate;
            fixtureTime = FixtureTime;
            homeScore = HomeScore;
            awayScore = AwayScore;
        }

        public static DataSet genFixtures(DataSet DS)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT T1.Team_ID, T2.Team_ID " +
                            "FROM Teams T1, Teams T2 " +
                            "WHERE T1.Team_ID != T2.Team_ID";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Clear Dataset
            DS.Clear();

            //Fill the DataSet DS with the query result
            da.Fill(DS, "fx");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        public static void insFixture(int fixId, int hTeamId, int aTeamId)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to create fixtures 
            String strSQL = "INSERT INTO fixtures(fixture_ID, Home_Team_ID, Away_Team_ID) Values (" + fixId + "," + hTeamId + "," + aTeamId + ")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }


        public static void scheduleFixture(int fixId, string fixDate, string fixTime)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to create fixtures 
            String strSQL = "UPDATE fixtures SET Fixture_Date = '" + fixDate + "', Fixture_Time = '" + fixTime + "' WHERE fixture_ID = " + fixId;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public static DataSet getUnplayedFixtures(DataSet ds, int TeamID)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to schedule fixtures
            String strSQL = "SELECT Fixture_ID, T.Team_Name, A.Team_Name FROM fixtures F Join Teams T  ON F.Home_Team_ID = T.Team_ID JOIN Teams A ON F.Away_team_ID = A.Team_ID WHERE (" +
                "Home_Team_ID = " + TeamID + " OR " +
                "Away_Team_ID = " + TeamID + " ) AND " +
                "Fixture_Date IS NULL";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Clear Dataset
            ds.Clear();

            //Fill the DataSet ds with the query result
            da.Fill(ds, "ufx");

            //close the DB Connection
            myConn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return ds;
        }
        public static DataSet getScheduledFixtures(DataSet ds, int TeamID)
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to schedule fixtures
            String strSQL = "SELECT Fixture_ID, T.Team_Name, A.Team_Name FROM fixtures F Join Teams T  ON F.Home_Team_ID = T.Team_ID JOIN Teams A ON F.Away_team_ID = A.Team_ID WHERE (" +
                "Home_Team_ID = " + TeamID + " OR " +
                "Away_Team_ID = " + TeamID + " ) AND " +
                "Fixture_Date IS NOT NULL";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Clear Dataset
            ds.Clear();

            //Fill the DataSet ds with the query result
            da.Fill(ds, "sfx");

            //close the DB Connection
            myConn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return ds;
        }
    }
}
