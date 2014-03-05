namespace CourierCRM.Windows.PopUps.setup_db
{
    partial class postgres_setup
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
            this.back_button = new System.Windows.Forms.Button();
            this.done_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ip_edit = new System.Windows.Forms.TextBox();
            this.port_edit = new System.Windows.Forms.TextBox();
            this.username_edit = new System.Windows.Forms.TextBox();
            this.password_edit = new System.Windows.Forms.TextBox();
            this.table_edit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(116, 227);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(197, 227);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(75, 23);
            this.done_button.TabIndex = 1;
            this.done_button.Text = "Done";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Database";
            // 
            // ip_edit
            // 
            this.ip_edit.Location = new System.Drawing.Point(88, 28);
            this.ip_edit.Name = "ip_edit";
            this.ip_edit.Size = new System.Drawing.Size(100, 20);
            this.ip_edit.TabIndex = 7;
            // 
            // port_edit
            // 
            this.port_edit.Location = new System.Drawing.Point(88, 52);
            this.port_edit.Name = "port_edit";
            this.port_edit.Size = new System.Drawing.Size(56, 20);
            this.port_edit.TabIndex = 8;
            // 
            // username_edit
            // 
            this.username_edit.Location = new System.Drawing.Point(88, 76);
            this.username_edit.Name = "username_edit";
            this.username_edit.Size = new System.Drawing.Size(104, 20);
            this.username_edit.TabIndex = 9;
            // 
            // password_edit
            // 
            this.password_edit.Location = new System.Drawing.Point(88, 100);
            this.password_edit.Name = "password_edit";
            this.password_edit.PasswordChar = '*';
            this.password_edit.Size = new System.Drawing.Size(104, 20);
            this.password_edit.TabIndex = 10;
            // 
            // table_edit
            // 
            this.table_edit.Location = new System.Drawing.Point(88, 124);
            this.table_edit.Name = "table_edit";
            this.table_edit.Size = new System.Drawing.Size(104, 20);
            this.table_edit.TabIndex = 11;
            // 
            // postgres_setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.table_edit);
            this.Controls.Add(this.password_edit);
            this.Controls.Add(this.username_edit);
            this.Controls.Add(this.port_edit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.ip_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "postgres_setup";
            this.Text = "PostgreSQL Settings";
            this.Load += new System.EventHandler(this.postgres_setup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ip_edit;
        private System.Windows.Forms.TextBox port_edit;
        private System.Windows.Forms.TextBox username_edit;
        private System.Windows.Forms.TextBox password_edit;
        private System.Windows.Forms.TextBox table_edit;
    }
}