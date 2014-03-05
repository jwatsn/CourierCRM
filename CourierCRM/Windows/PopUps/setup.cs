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
    public partial class setup : Form
    {
        public static setup CurrentForm;

        public setup()
        {
            InitializeComponent();
        }

        private void setup_Load(object sender, EventArgs e)
        {
            if (CurrentForm != null)
                CurrentForm = null;

            CurrentForm = this;
        }


        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();

            if (psql_button.Checked)
            {
                postgres_setup psql_setup = new postgres_setup();
                psql_setup.ShowDialog();
            }
            else if(xml_button.Checked)
            {
                xml_setup xml_form = new xml_setup();
                xml_form.ShowDialog();
            }

            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void psql_button_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
