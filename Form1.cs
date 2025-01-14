using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// IMPORTING 
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Lap_6
{
    public partial class Form1 : Form
    {
        bool menuIsCollapsed;
        public Form1()
        {
            InitializeComponent();
            //ConnectToDB();
        }






        //DB CONNECTION
        private void ConnectToDB()
        {
            //SQL
            try
            {
                //SQL CONNECTION
                //1. Direct
                String SqlConnectionString = "Data Source=ZAKI_OMER_22\\SQLEXPRESS;Initial Catalog=Lps;Integrated Security=True;";
                SqlConnection con = new SqlConnection(SqlConnectionString);
                con.Open();
                con.Close();
                //2. APP CONFIGURATION
                String AppConfigSqlConnectionString = ConfigurationManager.ConnectionStrings["Lap_6.Properties.Settings.LpsConnectionString"].ConnectionString;
                SqlConnection app_con = new SqlConnection(AppConfigSqlConnectionString);
                app_con.Open();
                app_con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show($"Error is Occured: {error}");
            }

            //APP SERVER
            try
            {
                //APP SERVER
                //1. Direct Connection
                String MySqlConnectionString = "Server=localhost;Database=UohC;User ID=root";
                MySqlConnection MySqlCon = new MySqlConnection(MySqlConnectionString);
                MySqlCon.Open();
                MySqlCon.Close();
                //2. App Config
                string MySqlConnectionStringAppConfig = ConfigurationManager.ConnectionStrings["Lap_6.Properties.Settings.MySqlLpsConnectionString"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(MySqlConnectionStringAppConfig);
                connection.Open();
            }
            catch (MySqlException error)
            {
                MessageBox.Show($"Error is Occured: {error}");
            }
        }

        private void tmSidebar_Tick(object sender, EventArgs e)
        {
            if (menuIsCollapsed)
            {
                pnlSideBar.Height += 10;
                if (pnlSideBar.Height == pnlSideBar.MaximumSize.Height)
                {
                    menuIsCollapsed = false;
                    tmSidebar.Stop();
                }
            }
            else
            {
                pnlSideBar.Height -= 10;
                if (pnlSideBar.Height == pnlSideBar.MinimumSize.Height)
                {
                    menuIsCollapsed = true;
                    tmSidebar.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmSidebar.Start();
        }
    }
}


///SUMMARY
///STEP 1 - CONNECTION STRING
///          SERVERNAME COMPUTER_NAME/SQLEXPRESS  LOCALHOST ( 127.0.0.0 )
///          DATABASENAME
///          ACCESS TYPE  WINDOWS AUTH, USER, PASSWORD .....
///STEP 2 - Type Of Connection
///         DIRECTLY
///         CONFIGURATION [ CONFIGURATION MANAGER /  App.config / ENV )
///STEP 3 - DATABASE TYPE
///         MYSQL
///         SQL
///         MongoDB
///         FireBase
///SQL CONNECTION STRING : Data Source=ZAKI_OMER_22\SQLEXPRESS;Initial Catalog=Lps;Integrated Security=True;