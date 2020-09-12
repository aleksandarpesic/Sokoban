using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //zbog MessageBox.Show...
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;

namespace Sokoban
{
    class Baza
    {
        MySqlConnection myCon;
        string connection;
        public bool conected;
        public Baza()
        {
            connection = "Server=den1.mysql1.gear.host;Database=rezultati;User ID=rezultati;Password=askme;"; //potreban je Password za pristup bazi 
            //deo za povezivanje na localhost u promenljivu connectionString
            string server = "localhost";
            string database = "rezultati";
            string uid = "root";
            string password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            myCon = new MySqlConnection(connection);
        }
        public bool conect()
        {
            try
            {
                myCon.Open(); conected = true;
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                } conected = false;
                return false;
            }
        }
        public int MinNum()
        {
            string query = "use rezultati; SELECT MIN(rez) FROM RGmain"; int Count = -1;
            // if (this.conect() == true){

            MySqlCommand cmd = new MySqlCommand(query, myCon);
            Count = int.Parse(cmd.ExecuteScalar() + "");
            // CloseConnection();
            // }
            return Count;
        }
        public List<String> getRez()
        {
            List<String> rez = new List<String>();
           string query = "SELECT * FROM RGmain";

            //Create a list to store the result
            

            
                //Create Command
           MySqlCommand cmd = new MySqlCommand(query, myCon);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    rez.Add("" + dataReader["rez"]);
                    rez.Add(""+dataReader["player"]);
                                           
                }  
                

                //close Data Reader
                dataReader.Close();

            
            /*
            string query1 = "use rezultati; SELECT MIN(id) FROM RGmain"; 
            string query2 = "use rezultati; SELECT MAX(id) FROM RGmain";

            
                MySqlCommand cmd = new MySqlCommand(query1, myCon);
                int minid = int.Parse(cmd.ExecuteScalar() + "");


                cmd = new MySqlCommand(query2, myCon);
                int maxid = int.Parse(cmd.ExecuteScalar() + "");

                

                for (int i = minid; i <= maxid; i++)
                {
                    //prvi podatak rezultat = (6Aleksandar)
                    string query3 = "SELECT rez FROM RGmain where id=" + i + "; ";
                    cmd = new MySqlCommand(query3, myCon);
                    rez.Add(cmd.ExecuteScalar() + "");

                    //drugi ime
                    string query4 = "SELECT player FROM RGmain where id=" + i + "; ";
                    cmd = new MySqlCommand(query4, myCon);
                    rez.Add(cmd.ExecuteScalar() + "");


                }
            */


            return rez;

        }
        public void Insert(int broj_poena, String playerName)
        {
            
            string query2 = "insert into RGmain (player, rez) values ( '" + playerName + "' ," + broj_poena + "); ";
            string query1 = "delete from RGmain order by rez asc limit 1";
           
                //obrise zadnjeg
                MySqlCommand cmd = new MySqlCommand(query1, myCon);
                cmd.ExecuteNonQuery();
                //upise trenutnog
               cmd = new MySqlCommand(query2, myCon);
                cmd.ExecuteNonQuery();

                // int id = CountRows();

               // CloseConnection();
            
        }

        
        public bool CloseConnection()
        {
            try
            {
                myCon.Close(); conected = false;
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message); conected = true;
                return false;
            }
        }
        
        public void KreiranjeTabela() //samo jednom se pozove nad bazom (setup baze)
        {
            string query = "drop table if exists RGmain; CREATE TABLE RGmain (id int(11) unsigned not null auto_increment, datum  DATETIME, player varchar(20), rez TINYINT," +
            "Primary key (id)) ENGINE = InnoDB;";

            if (this.conect() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, myCon);
                cmd.ExecuteNonQuery();

                query = "insert into RGmain (rez, player) values ("+0+", 'No_Name' ) ; ";
               
                for (int i = 0; i < 10; i++)
                {
                    cmd = new MySqlCommand(query, myCon);
                    cmd.ExecuteNonQuery();
                }
                this.CloseConnection();
            }
        }








    }
}
