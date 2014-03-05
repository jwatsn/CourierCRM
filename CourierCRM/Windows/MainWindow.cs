using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using CourierCRM.Database;
using CourierCRM.Windows.PopUps.setup_db;

namespace CourierCRM
{
    public partial class MainWindow : Form
    {

        DB_MAIN database;

        MainWindow invoices;
        
        //Boolean flags
        bool just_added;
        string table;

        public MainWindow(string table)
        {

            this.table = table;
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            

            check_config();

            database = new DB_MAIN();


            //Setting up events
            database.db_dataset.Tables[table].RowChanged += db_changed;
            database.db_dataset.Tables[table].RowDeleted += db_changed;
            name_combo.SelectedIndexChanged += selected_changed;
            name_combo.TextUpdate += text_changed;

            name_combo.AutoCompleteSource = AutoCompleteSource.ListItems;
            name_combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            

            //Init grid
            client_grid.DataSource = database.db_dataset.Tables[table];
            client_grid.Columns["id"].Visible = false;
            client_grid.Columns["name"].HeaderText = "Name";
            client_grid.Columns["phone_number"].HeaderText = "Phone #";
            client_grid.Columns["street_address"].HeaderText = "Address";
            client_grid.Columns["postal_code"].HeaderText = "Postal";
            client_grid.Columns["city"].HeaderText = "City";
            client_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            client_grid.ClearSelection();
            client_grid.Sort(client_grid.Columns["name"], ListSortDirection.Ascending);
            client_grid.CellClick += client_grid_changed;


            viewToolStripMenuItem.DropDownOpening += viewToolStripMenuItem_Click;

            update_textbox();

            

        }

        void MainWindow_Disposed(object sender, EventArgs e)
        {

            if (table == "shippers")
            {
                Program.main.clientWindowToolStripMenuItem.Checked = false;
            }

        }

        void check_config()
        {

            FileStream xml_config;



            if (!File.Exists("settings.xml"))
            {


              
                setup popup_form = new setup();
                popup_form.ShowDialog();
            }
            else
            {
                xml_config = File.OpenRead("settings.xml");
                DataSet set = new DataSet();
                set.ReadXml(xml_config);
                Settings.table = set.Tables["settings"];
            }
        }

        //Button Clicks
        private void add_to_db_click(object sender, EventArgs e)
        {

            if (add_client_button.Text == "Add Client")
            {
                if (name_combo.Text.Length > 0)
                {
                    add_client_button.Text = "Update";
                    delete_button.Visible = true;
                    just_added = true;
                    
                    database.AddClient(table,name_combo.Text, phone_box.Text, address_box.Text, postal_box.Text, city_box.Text);


                }
                else
                {
                    MessageBox.Show("Client Name field cannot be blank", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (add_client_button.Text == "Update")
                database.UpdateClient(table,name_combo.Text, phone_box.Text, address_box.Text, postal_box.Text, city_box.Text);
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            database.DeleteClient(table,name_combo.SelectedItem.ToString());
            name_combo.Text = "";
            clear_fields();
        }

        private void db_changed(object sender, EventArgs e)
        {


            
            update_textbox();

            if (just_added)
            {

                name_combo.SelectedItem = name_combo.Items[get_index_by_name(name_combo.Text)];
                just_added = false;
                client_grid.FirstDisplayedScrollingRowIndex = client_grid.SelectedRows[0].Index;
                
            }
        }

        private void selected_changed(object sender, EventArgs e)
        {

           


            DataRow[] rows = database.db_dataset.Tables[table].Select("name = '" + name_combo.SelectedItem.ToString() + "'");

            phone_box.Text = rows[0]["phone_number"].ToString();
            address_box.Text = rows[0]["street_address"].ToString();
            postal_box.Text = rows[0]["postal_code"].ToString();
            city_box.Text = rows[0]["city"].ToString();

            add_client_button.Text = "Update";
            delete_button.Visible = true;

            client_grid.Rows[get_index2_by_name(name_combo.SelectedItem.ToString())].Selected = true;
            
            
        
        }

        private void text_changed(object sender, EventArgs e)
        {
            if(name_combo.SelectedItem != null)
                clear_fields();
        }




        private void update_textbox()
        {


            string text = name_combo.Text;

            name_combo.Items.Clear();


            DataRow[] rows = database.db_dataset.Tables[table].Select(string.Empty, "name ASC");

           
            foreach (DataRow row in rows)
            {

                string name = row["name"].ToString();
                string address = row["street_address"].ToString();
                string postal_code = row["postal_code"].ToString();
                string city = row["city"].ToString();

         

     
                name_combo.Items.Add(name);
                


            }


           



        }

        void clear_fields()
        {
            phone_box.Text = "";
            address_box.Text = "";
            postal_box.Text = "";
            city_box.Text = "";
            add_client_button.Text = "Add Client";
            delete_button.Visible = false;
            client_grid.ClearSelection();
        }


        private void client_grid_changed(object sender, EventArgs e)
        {


            if(name_combo.Items.Count > 0)
                if (client_grid.SelectedRows.Count > 0)
                {

                    name_combo.SelectedItem = name_combo.Items[get_index_by_name(client_grid.SelectedRows[0].Cells["name"].Value.ToString())];

                }

            
        }

        private int get_index_by_name(string name)
        {
            for (int i = 0; i < name_combo.Items.Count; i++)
            {
                string name2 = name_combo.Items[i].ToString();

                if (name == name2)
                    return i;
            }
            return 0;
        }

       

        private int get_index2_by_name(string name)
        {
            for (int i = 0; i < client_grid.RowCount; i++)
            {
                string name2 = client_grid.Rows[i].Cells["name"].Value.ToString();

                if (name == name2)
                    return i;
            }
            return 0;
        }



        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FileStream xml = File.Create("xml.xml");
            database.db_dataset.Tables[table].WriteXml(xml);
            xml.Close();

        }

        private void recieversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recieversToolStripMenuItem.Checked)
            {
                Program.recievers = new MainWindow("recievers");

                Program.recievers.Text = "Recievers";
                Program.recievers.Show();
            }
            else
            {
                Program.recievers.Dispose();
            }
            
        }

        private void shippersWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (clientWindowToolStripMenuItem.Checked)
            {
                Program.shippers = new MainWindow("shippers");
                Program.shippers.Text = "Shippers";
                Program.shippers.Show();
                
            }
            else
            {
                Program.shippers.Dispose();
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.shippers.Visible)
            {
                clientWindowToolStripMenuItem.Checked = true;
            }
            else
            {
                clientWindowToolStripMenuItem.Checked = false;
            }

            if (Program.recievers.Visible)
            {
                recieversToolStripMenuItem.Checked = true;
            }
            else
            {
                recieversToolStripMenuItem.Checked = false;
            }

            if (Program.invoices.Visible)
            {
                invoicesToolStripMenuItem.Checked = true;

            }
            else
            {
                invoicesToolStripMenuItem.Checked = false;
            }

        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.invoices.Visible)
                Program.invoices.Dispose();
            else
            {
                Program.invoices = new Windows.Invoices();
                Program.invoices.Show();
            }
        }





    }
}
