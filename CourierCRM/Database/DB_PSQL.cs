using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace CourierCRM.Database
{

     

    class DB_PSQL
    {

        public static DB_PSQL SQL_DB;

        //Vars
        NpgsqlConnection db_connection;
        NpgsqlDataAdapter db_adapter;
        NpgsqlCommand db_command;
        NpgsqlParameter db_parameter;

        public DB_PSQL()
        {
            if (SQL_DB != null)
                SQL_DB = null;

            SQL_DB = this;

            init();

        }

        public static void Start_PSQL()
        {

            SQL_DB = new DB_PSQL();




        }

        private void init()
        {

            string ip = Settings.get_setting("db_ip");
            string port = Settings.get_setting("db_port");
            string username = Settings.get_setting("db_username");
            string password = Settings.get_setting("db_password");
            string database = Settings.get_setting("db_database");




            string connect_string = "Server="+ip+";Port="+port+";User Id="+username+";Password="+password+";Database="+database;

            string db_query_selectall = "Select * FROM customers";

            try
            {
                db_connection = new NpgsqlConnection(connect_string);
                db_connection.Open();

                db_adapter = new NpgsqlDataAdapter(db_query_selectall, db_connection);
                db_adapter.SelectCommand = new NpgsqlCommand(db_query_selectall, db_connection);
                db_adapter.Fill(DB_MAIN.postgres.db_dataset, Settings.get_setting("db_database"));
                


                updateCmd();
                deleteCmd();
                insertCmd();


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void updateCmd()
        {
            string insertQuery = "UPDATE customers SET (name,phone_number) = (@name,@phone) WHERE name = @name";
            db_adapter.UpdateCommand = new NpgsqlCommand(insertQuery, db_connection);
            db_adapter.UpdateCommand.UpdatedRowSource = UpdateRowSource.Both;

            db_parameter = db_adapter.UpdateCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Text);
            db_parameter.SourceVersion = DataRowVersion.Original;
            db_parameter.SourceColumn = "name";

            db_parameter = db_adapter.UpdateCommand.Parameters.Add("@phone", NpgsqlTypes.NpgsqlDbType.Text);
            db_parameter.SourceVersion = DataRowVersion.Current;
            db_parameter.SourceColumn = "phone_number";

            db_parameter = db_adapter.UpdateCommand.Parameters.Add("@adress", NpgsqlTypes.NpgsqlDbType.Text);
            db_parameter.SourceVersion = DataRowVersion.Current;
            db_parameter.SourceColumn = "street_address";

            db_parameter = db_adapter.UpdateCommand.Parameters.Add("@postal", NpgsqlTypes.NpgsqlDbType.Text);
            db_parameter.SourceVersion = DataRowVersion.Current;
            db_parameter.SourceColumn = "postal_code";

            db_parameter = db_adapter.UpdateCommand.Parameters.Add("@city", NpgsqlTypes.NpgsqlDbType.Text);
            db_parameter.SourceVersion = DataRowVersion.Current;
            db_parameter.SourceColumn = "city";
        }

        public void insertCmd()
        {



            string insertQuery = "INSERT INTO customers (name, phone_number, street_address, postal_code, city) VALUES (@name,@phone,@adress,@postal,@city)";
            db_adapter.InsertCommand = new NpgsqlCommand(insertQuery, db_connection);


            db_parameter = db_adapter.InsertCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Text);
            db_parameter.SourceVersion = DataRowVersion.Current;
            db_parameter.SourceColumn = "name";

            db_parameter = db_adapter.InsertCommand.Parameters.Add("@phone", NpgsqlTypes.NpgsqlDbType.Text);
            db_parameter.SourceVersion = DataRowVersion.Current;
            db_parameter.SourceColumn = "phone_number";

            db_parameter = db_adapter.InsertCommand.Parameters.Add("@adress", NpgsqlTypes.NpgsqlDbType.Text);
            db_parameter.SourceVersion = DataRowVersion.Current;
            db_parameter.SourceColumn = "street_address";

            db_parameter = db_adapter.InsertCommand.Parameters.Add("@postal", NpgsqlTypes.NpgsqlDbType.Text);
            db_parameter.SourceVersion = DataRowVersion.Current;
            db_parameter.SourceColumn = "postal_code";

            db_parameter = db_adapter.InsertCommand.Parameters.Add("@city", NpgsqlTypes.NpgsqlDbType.Text);
            db_parameter.SourceVersion = DataRowVersion.Current;
            db_parameter.SourceColumn = "city";

        }

        public void deleteCmd()
        {
            string insertQuery = "DELETE FROM customers WHERE name = @name";
            db_adapter.DeleteCommand = new NpgsqlCommand(insertQuery, db_connection);


            db_parameter = db_adapter.DeleteCommand.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Text);

            db_parameter.SourceColumn = "name";
            db_parameter.SourceVersion = DataRowVersion.Original;

        }

        public void Update()
        {
            try
            {

                db_adapter.Update(DB_MAIN.postgres.db_dataset, Settings.get_setting("db_database"));


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
