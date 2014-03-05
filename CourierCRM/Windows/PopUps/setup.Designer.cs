namespace CourierCRM.Windows.PopUps.setup_db
{
    partial class setup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.psql_button = new System.Windows.Forms.RadioButton();
            this.xml_button = new System.Windows.Forms.RadioButton();
            this.next_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // psql_button
            // 
            this.psql_button.AutoSize = true;
            this.psql_button.Location = new System.Drawing.Point(48, 35);
            this.psql_button.Name = "psql_button";
            this.psql_button.Size = new System.Drawing.Size(82, 17);
            this.psql_button.TabIndex = 0;
            this.psql_button.TabStop = true;
            this.psql_button.Text = "PostgreSQL";
            this.psql_button.UseVisualStyleBackColor = true;
            this.psql_button.CheckedChanged += new System.EventHandler(this.psql_button_CheckedChanged);
            // 
            // xml_button
            // 
            this.xml_button.AutoSize = true;
            this.xml_button.Location = new System.Drawing.Point(48, 58);
            this.xml_button.Name = "xml_button";
            this.xml_button.Size = new System.Drawing.Size(80, 17);
            this.xml_button.TabIndex = 1;
            this.xml_button.TabStop = true;
            this.xml_button.Text = "Offline XML";
            this.xml_button.UseVisualStyleBackColor = true;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(197, 146);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(75, 23);
            this.next_button.TabIndex = 3;
            this.next_button.Text = "Next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.xml_button);
            this.Controls.Add(this.psql_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setup";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Choose Database";
            this.Load += new System.EventHandler(this.setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton psql_button;
        private System.Windows.Forms.RadioButton xml_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button button1;

    
    }
}