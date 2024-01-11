using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace latihanCRUD1
{
    public partial class LoginPage : Form
    {
        MYDB_MYSQL mysqlDB;

        //Like void Start in Unity
        public LoginPage()
        {
            //Initialize Component Form
            InitializeComponent();

            //Init DB Connection
            mysqlDB = new MYDB_MYSQL("localhost", "root", "", "registered_user");
            
        }

        private void login(object sender, EventArgs e)
        {
            //Set login Query 
            string loginQuery = "SELECT * FROM users WHERE username='" + username_field.Text+ "' and password='" + password_field.Text +"';";
            
            //Check
            if (username_field.Text == ""  || password_field.Text == "")
            {
                MessageBox.Show("Please fill empty field", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Trim Password or Username if username or password has space Char

            if (username_field.Text.EndsWith(" "))
            {
                username_field.Text.Trim(username_field.Text[username_field.Text.Length - 1]);
            }

            if (username_field.Text.EndsWith(" "))
            {
                password_field.Text.Trim(password_field.Text[password_field.Text.Length - 1]);
            }

            //Execute Command Query 
            if (mysqlDB.db_command(loginQuery))
            {
                MessageBox.Show("Succesfully to connect", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //Clear all text
                username_field.Text = "";
                password_field.Text = "";

                //GotoNextPage

                this.Close();
                this.FormClosed += (object send , FormClosedEventArgs es) => {
                    Scene.ChangeScene(new LoadingFormcs());
                };

            }
            else
            {
                MessageBox.Show("Wrong Username or Password !!", "Failed to Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username_field.Text = "";
                password_field.Text = "";
            }
        }
    }

    /// <summary>
    /// Load Scene class here , just set Class of Screen you want of load
    /// </summary>
    public static class Scene
    {
        public static void ChangeScene(Form loadPage)
        {
            loadPage.ShowDialog();
        }
    }

    /// <summary>
    /// Connecting class for mysql
    /// </summary>
    public class MYDB_MYSQL
    {
        
        public MySqlConnection connectionSQL;
        public QUERY_TYPE typeQuery;
        public MYDB_MYSQL(string DB_HOST , string DB_USER , string DB_PASSWORD , string DB_NAME)
        {
            string connectionStr = "HOST=" + DB_HOST + "; USERNAME=" + DB_USER + "; PASSWORD=" + DB_PASSWORD + "; DATABASE=" + DB_NAME;
            connectionSQL = new MySqlConnection(connectionStr);
            
            try
            {
                //try to connect Db if the DB is running
                if (connectionSQL.State == ConnectionState.Closed)
                {
                    connectionSQL.Open();
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message , "Error While Connect",  MessageBoxButtons.OK , MessageBoxIcon.Error);
                
            }

        }

        /// <summary>
        /// set db command
        /// </summary>
        /// <param name="Query"></param>
        /// <returns></returns>
        public bool db_command(string Query)
        {
            
            if (connectionSQL.State == ConnectionState.Open)
            {
                connectionSQL.Close();
            }

            if (connectionSQL.State == ConnectionState.Closed)
            {
                connectionSQL.Open();
            }


            try
            {

                //Check if READER OR NOT 
                if (Query.Contains("SELECT"))
                {
                    typeQuery = QUERY_TYPE.READER;
                }else
                {
                    typeQuery = QUERY_TYPE.NONQUERY;
                }

                //IF READER 
                if (typeQuery == QUERY_TYPE.READER)
                {
                    MySqlDataReader readdata = readDataQuery(sqlQuery(Query, connectionSQL));
                    if (readdata.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }else
                {
                   int affectedRows =  MYSQL_NONQUERY_READER(sqlQuery(Query, connectionSQL));
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Succesfull", "Succesfull Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }else
                    {
                        return false;
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connectionSQL.Close();
            }

        }

        /// <summary>
        /// Add this if you need to get Data 
        /// </summary>
        /// <param name="Query">Query SQL</param>
        /// <param name="viewgraph">Grid for visualizing Data</param>
        /// <param name="tableData">Table to Store Data</param>
        /// <returns></returns>
        public bool db_command(string Query , ref DataGridView viewgraph , ref DataTable tableData)
        {

            if (connectionSQL.State == ConnectionState.Open)
            {
                connectionSQL.Close();
            }

            if (connectionSQL.State == ConnectionState.Closed)
            {
                connectionSQL.Open();
            }


            try
            {

                //Check if READER OR NOT 
                if (Query.Contains("SELECT"))
                {
                    typeQuery = QUERY_TYPE.READER;
                }
                else
                {
                    typeQuery = QUERY_TYPE.NONQUERY;
                }

                //IF READER 
                if (typeQuery == QUERY_TYPE.READER)
                {
                    //Set Adapter 
                    MySqlDataAdapter da = new MySqlDataAdapter(sqlQuery(Query , connectionSQL));
                    da.Fill(tableData);

                    //Fill Data Source wit table data
                    viewgraph.DataSource = tableData;

                    return true;
                }
                else
                {
                    int affectedRows = MYSQL_NONQUERY_READER(sqlQuery(Query, connectionSQL));
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Succesfull", "Succesfull Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connectionSQL.Close();
            }

        }


        public enum QUERY_TYPE {
            READER , 
            NONQUERY
        }

        private MySqlDataReader readDataQuery(MySqlCommand commandQuery)
        {
            return commandQuery.ExecuteReader();
        }

        private int MYSQL_NONQUERY_READER(MySqlCommand commandQuery)
        {
            return commandQuery.ExecuteNonQuery();
        }

        private MySqlCommand sqlQuery(string command , MySqlConnection mySqlConnection)
        {
            return new MySqlCommand(command, mySqlConnection);
        }
    }
}
