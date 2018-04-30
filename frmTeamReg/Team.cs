using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;

namespace frmTeamReg
{
    class Team
    {
        // instance variables
        private int team_ID;
        private string team_Name;
        private string home_Ground;
        private string manager;
        private string email;
        private string phone;
        private int points;

        //Define getters
        public int getTeam_ID()
        {
            return team_ID;
        }

        public String getTeam_Name()
        {
            return team_Name;
        }

        public String getHome_Ground()
        {
            return home_Ground;
        }

        public String getManager()
        {
            return manager;
        }

        public String getEmail()
        {
            return email;
        }

        public String getPhone()
        {
            return phone;
        }

        public int getPoints()
        {
            return points;
        }

        //Define setters
        public void setTeamID(int Team_ID)
        {
            this.team_ID = Team_ID;
        }

        public void setTeamName(String Team_Name)
        {
            this.team_Name = Team_Name;
        }

        public void setHomeGround(String Home_Ground)
        {
            this.home_Ground = Home_Ground;
        }

        public void setManager(String Manager)
        {
            this.manager = Manager;
        }

        public void setEmail(String Email)
        {
            this.email = Email;
        }

        public void setPhone(String Phone)
        {
            this.phone = Phone;
        }

        public void setPoints(int Points)
        {
            this.points = Points;
        }

        //constructor
        public Team(int TeamID, String Name, String HG, String Manager, String Email, String Phone, int Points)
        {
            team_ID = TeamID;
            team_Name = Name;
            home_Ground = HG;
            manager = Manager;
            email = Email;
            phone = Phone;
            points = Points;
        }

        //define a static method to get all data from Teams table
        public static DataSet getTeamStanding(DataSet DS)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT * FROM teams ORDER BY Points DESC";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Clear Dataset
            DS.Clear();

            //Fill the DataSet DS with the query result
            da.Fill(DS, "ss");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        public static DataSet getAllTeams(DataSet DS)
        {
            //create an OracleConnection object using the connection string defined in static class DBConnect
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT * FROM Teams ORDER BY Team_ID";

            //Create an OracleCommand object and instantiate it
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Clear Dataset
            DS.Clear();

            //Fill the DataSet DS with the query result
            da.Fill(DS, "ss");

            //close the DB Connection
            conn.Close();

            //Return the Dataset with the required data to the windows form which executed this method
            return DS;
        }

        public static int NextTeamID()
        {
            //variable to hold the value to be returned
            int intNextTeamID;

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to get max Team_ID used
            String strSQL = "SELECT MAX(Team_ID) FROM Teams";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Execute the sql query and put result in OracleDataRead
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the first (only) value 
            dr.Read();

            if (dr.IsDBNull(0))
                intNextTeamID = 1;
            else
                intNextTeamID = Convert.ToInt16(dr.GetValue(0)) + 1;

            myConn.Close();

            return intNextTeamID;
        }

        //Register team method
       public void regTeam()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT teams record
            String strSQL = "INSERT INTO teams Values (" + this.team_ID + ",'" +
                this.team_Name.ToUpper() + "','" + this.home_Ground.ToUpper() + "','" +
                this.manager.ToUpper() + "','" + this.email + "','" + this.phone + "'," +
                this.points + ")";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        //Update team method
        public void updTeam()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL query to UPDATE Teams record
            String strSQL = "UPDATE Teams SET Team_Name = '" + this.team_Name.ToUpper() +
                "', Home_Ground = '" + this.home_Ground.ToUpper() + "', Manager = '" + this.manager.ToUpper() + "', Email = '" + this.email.ToUpper() +
                "', Phone = '" + this.phone + "', Points = " + this.points + "  WHERE Team_ID = " + this.team_ID;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        //Relegate team
        public void relTeam()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define sql query to DELETE Teams record
            String strSQL = "DELETE FROM Teams WHERE Team_Name = '" + this.team_Name;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
    }
}