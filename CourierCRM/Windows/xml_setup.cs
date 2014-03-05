using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CourierCRM.Windows.PopUps.setup_db
{
    public partial class xml_setup : Form
    {
        public xml_setup()
        {
            InitializeComponent();
        }

        private void browse_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.SelectedPath = Environment.CurrentDirectory;
            fd.ShowDialog();
            location_box.Text = fd.SelectedPath;
        }

        private void done_button_Click(object sender, EventArgs e)
        {

            string path = location_box.Text + "//" + name_box.Text + ".xml";


            if (check_location(location_box.Text))
            {
                DataSet set = new DataSet();
                DataTable config_table = new DataTable();

                set.Tables.Add(config_table);


                config_table.Columns.Add("db_type", typeof(string));
                config_table.Columns.Add("db_database", typeof(string));
                config_table.Columns.Add("db_path", typeof(string));

                DataRow row = config_table.NewRow();

                row["db_type"] = "xml";
                row["db_database"] = name_box.Text;
                row["db_path"] = location_box.Text;

                config_table.Rows.Add(row);

                config_table.TableName = "settings";

                FileStream xml_config = File.Create("settings.xml");

                set.WriteXml(xml_config);

                xml_config.Close();



                Settings.table = config_table;





                this.Hide();
            }
        }

        bool check_location(string path)
        {
            if (!Directory.Exists(path))
            {
                System.Windows.Forms.MessageBox.Show("Folder does not exist", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        bool create_file(string path)
        {
            FileStream stream; 
            try
            {
               stream = File.Create(path);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return false;
            }
            stream.Close();
            return true;
        }


    }
}
