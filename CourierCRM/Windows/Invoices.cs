using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CourierCRM.Database;
using CourierCRM.Windows.PopUps;

namespace CourierCRM.Windows
{
    public partial class Invoices : Form
    {

        //Variables
        string selected_id;
        

        public Invoices()
        {
            InitializeComponent();
        }

        private void Invoices_Load(object sender, EventArgs e)
        {

            viewToolStripMenuItem.DropDownOpening += viewToolStripMenuItem_Click;

            LoadClients();
            //LoadShippers();
            //LoadRecievers();
            LoadGrid();

            

        }

        private void LoadClients()
        {
            foreach (DataRow row in DB_MAIN.postgres.db_dataset.Tables["customers"].Rows)
            {

                customer.Items.Add(row["name"].ToString());
                
            }
        }

        /*

        private void LoadShippers()
        {
            foreach (DataRow row in DB_MAIN.postgres.db_dataset.Tables["shippers"].Rows)
            {

                shipper.Items.Add(row["name"].ToString());

            }
        }
        private void LoadRecievers()
        {
            foreach (DataRow row in DB_MAIN.postgres.db_dataset.Tables["recievers"].Rows)
            {

                reciever.Items.Add(row["name"].ToString());

            }
        }
        */
        private void LoadGrid()
        {
            
            

            invoices_grid.DataSource = DB_MAIN.postgres.db_dataset.Tables["invoices"];
            
            invoices_grid.SelectionChanged += grid_selected;
            invoices_grid.ClearSelection();
            invoices_grid.Columns["client_attn"].Visible = false;
            invoices_grid.Columns["id"].Visible = false;
            //setup names

            
            
            invoices_grid.Columns["date"].HeaderText = "Date";
            
            invoices_grid.Columns["due_date"].HeaderText = "Due Date";
            
            invoices_grid.Columns["customer"].HeaderText = "Customer";           
            
            invoices_grid.Columns["statement_id"].HeaderText = "Statement #";
            
            invoices_grid.Columns["bn_num"].HeaderText = "BN #";


            //Order grid



            order_grid.DataSource = DB_MAIN.postgres.db_dataset.Tables["orders"];
            DB_MAIN.postgres.db_dataset.Tables["orders"].DefaultView.RowFilter = "id = '-1'";
            order_grid.CellMouseDoubleClick += order_grid_CellMouseDoubleClick;
            order_grid.UserDeletedRow += order_grid_UserDeletedRow;
            
            

            order_grid.Columns["id"].Visible = false;
            order_grid.Columns["invoice_id"].Visible = false;

            order_grid.Columns["date"].HeaderText = "Date";

            order_grid.Columns["shipper"].HeaderText = "Shipper";

            order_grid.Columns["reciever"].HeaderText = "Reciever";

            order_grid.Columns["num_items"].HeaderText = "Item #";
            order_grid.Columns["num_items"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            order_grid.Columns["price"].HeaderText = "Price";
            order_grid.Columns["price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            
            

        }

        void order_grid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DB_MAIN.Update();
        }

        void order_grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EditOrderBox.EditOrder(Int32.Parse(order_grid.Rows[e.RowIndex].Cells["id"].Value.ToString()));
        }

        void Invoices_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            refresh_order_grid();
        }

 

        void order_grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //refresh_order_grid();
        }

        private void GridStockItemEntry_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            DataGridViewRow row = order_grid.CurrentRow;
            DataGridViewCell cell = order_grid.CurrentCell;
            if (e.Control.GetType() == typeof(DataGridViewComboBoxEditingControl))
            {

                if (cell == row.Cells["shipper"] || cell == row.Cells["reciever"])
                {
                    DataGridViewComboBoxEditingControl cbo = e.Control as DataGridViewComboBoxEditingControl;

                    cbo.DropDownStyle = ComboBoxStyle.DropDown;
                    cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
                    cbo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    //cbo.Validating += new CancelEventHandler(cbo_Validating);
                }
            }


        }

        void refresh_order_grid()
        {
            order_grid.Rows.Clear();
            foreach (DataGridViewRow sel in invoices_grid.SelectedRows)
            {


                

                
                DataRow[] rows = DB_MAIN.postgres.db_dataset.Tables["orders"].Select("invoice_id = '" + sel.Cells["id"].Value + "'");

                foreach (DataRow r in rows)
                {

                    string[] cells = new string[order_grid.Columns.Count];
                    int i = 0;
                    foreach (DataGridViewColumn col in order_grid.Columns)
                    {
                        if (col.Name == "id" || col.Name == "invoice_id" || col.Name == "")
                            continue;

                        cells[i] = r[col.Name].ToString();
                        
                    }
                    string[] test = {"honksty", "chonk"};
                    order_grid.Rows.Add(test);

                    Console.WriteLine("YIP:" + order_grid.Rows[0].Cells[0].Value);


                }
                order_grid.Refresh();
            }
        }


        private void clear_boxes()
        {
            foreach (DataColumn col in DB_MAIN.postgres.db_dataset.Tables["invoices"].Columns)
            {
                if (col.ColumnName == "id")
                    continue;

                Controls[col.ColumnName].Text = "";
            }

        }

        private void shippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shippersToolStripMenuItem.Checked)
            {
                Program.shippers = new MainWindow("shippers");
                Program.shippers.Show();
            }
            else
            {
                Program.shippers.Close();
            }
        }

        private void recieversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recieversToolStripMenuItem.Checked)
            {
                Program.recievers = new MainWindow("recievers");
                Program.recievers.Show();

            }
            else
            {
                Program.recievers.Close();
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.shippers.Visible)
            {
                shippersToolStripMenuItem.Checked = true;
            }
            else
            {
                shippersToolStripMenuItem.Checked = false;
            }

            if (Program.recievers.Visible)
            {
                recieversToolStripMenuItem.Checked = true;
            }
            else
            {
                recieversToolStripMenuItem.Checked = false;
            }

            if (Visible)
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
            Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            if (add_button.Text == "Add")
            {
                DataRow row = DB_MAIN.postgres.db_dataset.Tables["invoices"].NewRow();

                foreach (DataColumn col in DB_MAIN.postgres.db_dataset.Tables["invoices"].Columns)
                {
                    if (col.ColumnName == "id")
                        continue;

                    row[col.ColumnName] = Controls[col.ColumnName].Text;
                }

                DB_MAIN.postgres.db_dataset.Tables["invoices"].Rows.Add(row);

            }
            else
            {

                foreach(DataGridViewRow row in invoices_grid.SelectedRows)
                {

                    DataRow[] rows = DB_MAIN.postgres.db_dataset.Tables["invoices"].Select("id = '" + row.Cells["id"].Value + "'");


                    foreach (DataRow row2 in rows)
                    {

                        foreach (DataColumn col in DB_MAIN.postgres.db_dataset.Tables["invoices"].Columns)
                        {

                            if (col.ColumnName == "id")
                                continue;

                            row2[col.ColumnName] = Controls[col.ColumnName].Text;

                        }
                    }
                }


            }

            if (Settings.get_setting("db_type").ToString() == "psql")
                DB_PSQL.SQL_DB.Update();
            else if (Settings.get_setting("db_type").ToString() == "xml")
                DB_XML.xml_db.Update();


        }

        private void grid_selected(object sender, EventArgs e)
        {
            bool selectflag = false;
            if (invoices_grid.SelectedRows.Count <= 0)
            {
                clear_boxes();
                add_button.Text = "Add";
                delete_button.Visible = false;
                add_order_button.Visible = false;
                //order_grid.AllowUserToAddRows = false;
                DB_MAIN.postgres.db_dataset.Tables["orders"].DefaultView.RowFilter = "id = '-1'";
            }
            else
            {
                add_button.Text = "Update";
                delete_button.Visible = true;
                add_order_button.Visible = true;
                //order_grid.AllowUserToAddRows = true;
                selectflag = true;
                
            }

            foreach (DataGridViewRow row in invoices_grid.SelectedRows)
            {

                selected_id = row.Cells["id"].Value.ToString();

                if(selectflag)
                    DB_MAIN.postgres.db_dataset.Tables["orders"].DefaultView.RowFilter = "invoice_id = '"+selected_id+"'";

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.Name == "id")
                        continue;

                    Controls[cell.OwningColumn.Name].Text = cell.Value.ToString();
                }
            }

            

            

        }


        private void delete_button_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in invoices_grid.SelectedRows)
            {

                DataRow[] rows = DB_MAIN.postgres.db_dataset.Tables["invoices"].Select("id = '" + row.Cells["id"].Value + "'");


                foreach (DataRow row2 in rows)
                {
                    row2.Delete();
                }


            }

            if (Settings.get_setting("db_type").ToString() == "psql")
                DB_PSQL.SQL_DB.Update();
            else if (Settings.get_setting("db_type").ToString() == "xml")
                DB_XML.xml_db.Update();
            
        }

        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            invoices_grid.ClearSelection();

        }

        private void excelxlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog diag = new SaveFileDialog();
                diag.Filter = "XML|*.xml";
                diag.ShowDialog();

                FileStream stream = (System.IO.FileStream)diag.OpenFile();
                stream.Position = 0;
                ExcelExporter.export_invoice(stream, selected_id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void order_rightclick_menu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void add_order_button_Click(object sender, EventArgs e)
        {
            EditOrderBox.AddOrder(Int32.Parse(selected_id));
        }


        
    }
}
