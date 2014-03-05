namespace CourierCRM.Windows.PopUps.setup_db
{
    partial class xml_setup
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
            this.label1 = new System.Windows.Forms.Label();
            this.location_box = new System.Windows.Forms.TextBox();
            this.browse_button = new System.Windows.Forms.Button();
            this.done_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "XML Location:";
            // 
            // location_box
            // 
            this.location_box.Location = new System.Drawing.Point(96, 44);
            this.location_box.Name = "location_box";
            this.location_box.Size = new System.Drawing.Size(176, 20);
            this.location_box.TabIndex = 2;
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(196, 72);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 23);
            this.browse_button.TabIndex = 3;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(196, 152);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(75, 23);
            this.done_button.TabIndex = 5;
            this.done_button.Text = "Done";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(112, 152);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 4;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Database Name:";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(96, 16);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 20);
            this.name_box.TabIndex = 1;
            // 
            // xml_setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.location_box);
            this.Controls.Add(this.label1);
            this.Name = "xml_setup";
            this.Text = "XML Database Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox location_box;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_box;
    }
}