using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Npgsql;
namespace CourierCRM.Windows.PopUps.setup_db
{
    public partial class postgres_setup : Form
    {

        public static postgres_setup CurrentForm;
        FileStream xml_config;

        public postgres_setup()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void postgres_setup_Load(object sender, EventArgs e)
        {
            if (CurrentForm != null)
                CurrentForm = null;

            CurrentForm = this;

        }

        private void done_button_Click(object sender, EventArgs e)
        {

            if (check_database(ip_edit.Text, port_edit.Text,username_edit.Text,password_edit.Text,table_edit.Text))
            {

                DataSet set = new DataSet();

                DataTable config_table = new DataTable();

                set.Tables.Add(config_table);

                config_table.Columns.Add("db_type", typeof(string));
                config_table.Columns.Add("db_ip", typeof(string));
                config_table.Columns.Add("db_port", typeof(string));
                config_table.Columns.Add("db_username", typeof(string));
                config_table.Columns.Add("db_password", typeof(string));
                config_table.Columns.Add("db_database", typeof(string));

                DataRow row = config_table.NewRow();

                row["db_type"] = "psql";
                row["db_ip"] = ip_edit.Text;
                row["db_port"] = port_edit.Text;
                row["db_username"] = username_edit.Text;
                row["db_password"] = password_edit.Text;
                row["db_database"] = table_edit.Text;

                config_table.Rows.Add(row);

                config_table.TableName = "settings";

                xml_config = File.Create("settings.xml");

                set.WriteXml(xml_config);

                xml_config.Close();



                Settings.table = config_table;





                this.Hide();

            }
            


        }

        bool check_database(string ip, string port, string username, string password, string database)
        {


            string connect_string = "Server=" + ip + ";Port=" + port + ";User Id=" + username + ";Password=" + password + ";Database=" + database;

            try
            {
                NpgsqlConnection con = new NpgsqlConnection(connect_string);
                con.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}

