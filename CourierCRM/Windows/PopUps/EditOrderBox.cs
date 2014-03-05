using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CourierCRM.Database;

namespace CourierCRM.Windows.PopUps
{
    public partial class EditOrderBox : Form
    {

        static EditOrderBox self;
        int id;
        bool edit;

        public EditOrderBox(int id, bool edit=false)
        {
            this.id = id;
            this.edit = edit;
            InitializeComponent();

        }

        private void EditOrderBox_Load(object sender, EventArgs e)
        {

            GenerateTextBoxes();

            if (edit)
            {
                Name = "Update Order";
                FillTextBoxs();
                edit_button.Text = "Update";
            }
            else
            {
                Name = "Add Order";
                edit_button.Text = "Add";
            }
        }


        public static void AddOrder(int id)
        {
            if (self != null)
                self.Dispose();

            self = new EditOrderBox(id);
            self.ShowDialog();
        }

        public static void EditOrder(int id)
        {
            if (self != null)
                self.Dispose();

            self = new EditOrderBox(id,true);
            self.ShowDialog();
        }

        void GenerateTextBoxes()
        {

            DataTable ordertable = DB_MAIN.postgres.db_dataset.Tables["orders"];

            int pos = 0;
            
            for (int i = 0; i < ordertable.Columns.Count; i++)
            {
                if (ordertable.Columns[i].ColumnName == "id")
                    continue;

                Label label = new Label();
                label.TextAlign = ContentAlignment.MiddleRight;
                label.Text = fixname(ordertable.Columns[i].ColumnName);
                label.Location = new Point(0, 28 + (22 * pos));
                label.Size = new Size(64, 15);

                Control tbox = new TextBox();

                if (ordertable.Columns[i].ColumnName == "invoice_id")
                {                  
                    tbox.Text = "" + id;
                    tbox.Enabled = false;
                }
                if (ordertable.Columns[i].ColumnName == "shipper")
                {
                    ComboBox cbox = new ComboBox();
                    cbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cbox.AutoCompleteSource = AutoCompleteSource.ListItems;

                    DataRowCollection rows = DB_MAIN.postgres.db_dataset.Tables["shippers"].Rows;

                    foreach (DataRow row in rows)
                    {
                        cbox.Items.Add(row["name"]);
                    }

                    tbox = cbox;
                }

                if (ordertable.Columns[i].ColumnName == "reciever")
                {
                    ComboBox cbox = new ComboBox();
                    cbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cbox.AutoCompleteSource = AutoCompleteSource.ListItems;

                    DataRowCollection rows = DB_MAIN.postgres.db_dataset.Tables["recievers"].Rows;

                    foreach (DataRow row in rows)
                    {
                        cbox.Items.Add(row["name"]);
                    }

                    tbox = cbox;
                }
                if (ordertable.Columns[i].ColumnName == "date")
                {
                    tbox.Text = DateTime.UtcNow.Day+ "/" + DateTime.UtcNow.Month + "/" + DateTime.UtcNow.Year;

                }

                tbox.Name = ordertable.Columns[i].ColumnName;
                tbox.Location = new Point(65, 26 + (22 * pos));
                tbox.Size = new Size(200, 20);




                
                Controls.Add(label);
                Controls.Add(tbox);



                pos++;
            }

        }

        string fixname(string name)
        {
            char[] buf = name.ToCharArray();

            buf[0] = Char.ToUpper(buf[0]);

            for (int i = 0; i < buf.Length; i++)
            {
                if (buf[i].ToString() == "_")
                    buf[i] = Char.Parse(" ");
            }

            string str = new String(buf);
            return str;
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (edit)
                UpdateOrder();
            else
                AddOrder();

            DB_MAIN.Update();

            this.Close();
        }

        private void AddOrder()
        {
            DataRow newrow = DB_MAIN.postgres.db_dataset.Tables["orders"].NewRow();

            for (int i = 0; i < DB_MAIN.postgres.db_dataset.Tables["orders"].Columns.Count; i++)
            {
                string colname = DB_MAIN.postgres.db_dataset.Tables["orders"].Columns[i].ColumnName;

                if (colname == "id")
                    continue;

                newrow[colname] = Controls[colname].Text;
            }

            DB_MAIN.postgres.db_dataset.Tables["orders"].Rows.Add(newrow);
            DB_MAIN.Update();
        }

        private void UpdateOrder()
        {
            DataRow[] rows = DB_MAIN.postgres.db_dataset.Tables["orders"].Select("id = '" + id + "'");

            foreach (DataRow row in rows)
            {
                foreach (DataColumn col in DB_MAIN.postgres.db_dataset.Tables["orders"].Columns)
                {
                    if (col.ColumnName == "id")
                        continue;

                    row[col.ColumnName] = Controls[col.ColumnName].Text;
                }
            }
        }

        private void FillTextBoxs()
        {
            DataRow[] rows = DB_MAIN.postgres.db_dataset.Tables["orders"].Select("id = '"+id+"'");

            foreach (DataRow row in rows)
            {
                foreach (DataColumn col in DB_MAIN.postgres.db_dataset.Tables["orders"].Columns)
                {
                    if (col.ColumnName == "id")
                        continue;

                    Controls[col.ColumnName].Text = row[col.ColumnName].ToString();
                }
            }
        }
    }
}
