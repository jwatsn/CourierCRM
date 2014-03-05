using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using ExcelLibrary.SpreadSheet;

namespace CourierCRM.Database
{
   
    class DB_MAIN
    {

        /// <summary>
        /// Main database class. Initializes and handles queries.
        /// </summary>
        /// 

        public static DB_MAIN postgres;

        //postgres
        

        //query
        string db_query_selectall = "SELECT * FROM customers";

        //data
        public DataSet db_dataset;
        
        //init and connect to db

        //TODO: Make DB info readable from config file
        #region Initialization
        public DB_MAIN()
        {

            if (postgres != null)
                postgres = null;

            postgres = this;



            gen_dataset();
           

           if (Settings.get_setting("db_type").ToString() == "psql")
               DB_PSQL.Start_PSQL();
           else if (Settings.get_setting("db_type").ToString() == "xml")
               DB_XML.Start_XML();

           
            
        }

        

#endregion

   

        public void AddClient(string table,string name, string phone, string address, string postal, string city)
        {


            DataRow new_row = db_dataset.Tables[table].NewRow();
            new_row["name"] = name;
            new_row["phone_number"] = phone;
            new_row["street_address"] = address;
            new_row["postal_code"] = postal;
            new_row["city"] = city;



            db_dataset.Tables[table].Rows.Add(new_row);


            if (Settings.get_setting("db_type").ToString() == "psql")
                DB_PSQL.SQL_DB.Update();
            else if (Settings.get_setting("db_type").ToString() == "xml")
                DB_XML.xml_db.Update();
        }

        public void gen_dataset()
        {
            db_dataset = new DataSet("database");

            //Customer table
            DataTable table = new DataTable("customers");

            table.Columns.Add("id");
            table.Columns.Add("name");
            table.Columns.Add("phone_number");
            table.Columns.Add("street_address");
            table.Columns.Add("postal_code");
            table.Columns.Add("city");


            table.Columns["id"].AutoIncrement = true;

            db_dataset.Tables.Add(table);



            //Invoice Table
            DataTable invoices_table = new DataTable("invoices");

            invoices_table.Columns.Add("id");
            invoices_table.Columns.Add("date");
            invoices_table.Columns.Add("due_date");
            invoices_table.Columns.Add("customer");
            invoices_table.Columns.Add("client_attn");                                           
            invoices_table.Columns.Add("statement_id");
            invoices_table.Columns.Add("bn_num");



            invoices_table.Columns["id"].AutoIncrement = true;

            db_dataset.Tables.Add(invoices_table);

            //Orders Table
            DataTable orders_table = new DataTable("orders");
            orders_table.Columns.Add("id");
            orders_table.Columns.Add("invoice_id");
            
            orders_table.Columns.Add("shipper");
            orders_table.Columns.Add("reciever");
            orders_table.Columns.Add("num_items");
            orders_table.Columns.Add("price");
            orders_table.Columns.Add("date");

            orders_table.Columns["id"].AutoIncrement = true;


           

            db_dataset.Tables.Add(orders_table);

            //shippers
            DataTable shippers_table = new DataTable("shippers");

            shippers_table.Columns.Add("id");
            shippers_table.Columns.Add("name");
            shippers_table.Columns.Add("phone_number");
            shippers_table.Columns.Add("street_address");
            shippers_table.Columns.Add("postal_code");
            shippers_table.Columns.Add("city");


            shippers_table.Columns["id"].AutoIncrement = true;

            db_dataset.Tables.Add(shippers_table);

            //recievers

            DataTable recv_table = new DataTable("recievers");

            recv_table.Columns.Add("id");
            recv_table.Columns.Add("name");
            recv_table.Columns.Add("phone_number");
            recv_table.Columns.Add("street_address");
            recv_table.Columns.Add("postal_code");
            recv_table.Columns.Add("city");


            recv_table.Columns["id"].AutoIncrement = true;

            db_dataset.Tables.Add(recv_table);

 
        }

        public void UpdateClient(string table,string name, string phone, string address, string postal, string city)
        {



            DataRow[] rows = db_dataset.Tables[table].Select("name = '" + name + "'");

            for (int j = 0; j < rows.Length; j++)
            {

                int i = db_dataset.Tables[table].Rows.IndexOf(rows[j]);

                if (db_dataset.Tables[table].Rows[i]["name"].ToString() != name)
                    continue;


                db_dataset.Tables[table].Rows[i]["name"] = name;
                db_dataset.Tables[table].Rows[i]["phone_number"] = phone;
                db_dataset.Tables[table].Rows[i]["street_address"] = address;
                db_dataset.Tables[table].Rows[i]["postal_code"] = postal;
                db_dataset.Tables[table].Rows[i]["city"] = city;

                
            }


            if (Settings.get_setting("db_type").ToString() == "psql")
                DB_PSQL.SQL_DB.Update();
            else if (Settings.get_setting("db_type").ToString() == "xml")
                DB_XML.xml_db.Update();
            

        }

        public static void Update()
        {
            if (Settings.get_setting("db_type").ToString() == "psql")
                DB_PSQL.SQL_DB.Update();
            else if (Settings.get_setting("db_type").ToString() == "xml")
                DB_XML.xml_db.Update();
        }

        public void DeleteClient(string table,string name)
        {

            for (int i = 0; i < db_dataset.Tables[table].Rows.Count; i++)
            {
                DataRow row = db_dataset.Tables[table].Rows[i];
                if (row["name"].ToString() == name)
                {
                   
                    db_dataset.Tables[table].Rows[i].Delete();


                  
                }
            }

            if (Settings.get_setting("db_type").ToString() == "psql")
                DB_PSQL.SQL_DB.Update();
            else if (Settings.get_setting("db_type").ToString() == "xml")
                DB_XML.xml_db.Update();
            
       
            
   
        }

        

    }
}
