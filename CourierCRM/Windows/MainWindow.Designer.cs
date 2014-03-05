namespace CourierCRM
{
    partial class MainWindow
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
            this.name_string = new System.Windows.Forms.Label();
            this.name_combo = new System.Windows.Forms.ComboBox();
            this.add_client_button = new System.Windows.Forms.Button();
            this.address_label = new System.Windows.Forms.Label();
            this.address_box = new System.Windows.Forms.TextBox();
            this.postal_label = new System.Windows.Forms.Label();
            this.postal_box = new System.Windows.Forms.TextBox();
            this.city_label = new System.Windows.Forms.Label();
            this.city_box = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.client_grid = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recieversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.client_grid)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_string
            // 
            this.name_string.AutoSize = true;
            this.name_string.Location = new System.Drawing.Point(9, 27);
            this.name_string.Name = "name_string";
            this.name_string.Size = new System.Drawing.Size(64, 13);
            this.name_string.TabIndex = 0;
            this.name_string.Text = "Client Name";
            // 
            // name_combo
            // 
            this.name_combo.FormattingEnabled = true;
            this.name_combo.Location = new System.Drawing.Point(79, 24);
            this.name_combo.Name = "name_combo";
            this.name_combo.Size = new System.Drawing.Size(236, 21);
            this.name_combo.TabIndex = 1;
            // 
            // add_client_button
            // 
            this.add_client_button.Location = new System.Drawing.Point(357, 22);
            this.add_client_button.Name = "add_client_button";
            this.add_client_button.Size = new System.Drawing.Size(75, 23);
            this.add_client_button.TabIndex = 2;
            this.add_client_button.Text = "Add Client";
            this.add_client_button.UseVisualStyleBackColor = true;
            this.add_client_button.Click += new System.EventHandler(this.add_to_db_click);
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(9, 95);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(45, 13);
            this.address_label.TabIndex = 3;
            this.address_label.Text = "Address";
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(79, 92);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(236, 20);
            this.address_box.TabIndex = 4;
            // 
            // postal_label
            // 
            this.postal_label.AutoSize = true;
            this.postal_label.Location = new System.Drawing.Point(9, 129);
            this.postal_label.Name = "postal_label";
            this.postal_label.Size = new System.Drawing.Size(64, 13);
            this.postal_label.TabIndex = 5;
            this.postal_label.Text = "Postal Code";
            // 
            // postal_box
            // 
            this.postal_box.Location = new System.Drawing.Point(79, 126);
            this.postal_box.MaxLength = 7;
            this.postal_box.Name = "postal_box";
            this.postal_box.Size = new System.Drawing.Size(75, 20);
            this.postal_box.TabIndex = 6;
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(9, 163);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(24, 13);
            this.city_label.TabIndex = 7;
            this.city_label.Text = "City";
            // 
            // city_box
            // 
            this.city_box.Location = new System.Drawing.Point(79, 160);
            this.city_box.Name = "city_box";
            this.city_box.Size = new System.Drawing.Size(116, 20);
            this.city_box.TabIndex = 8;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(9, 61);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(48, 13);
            this.phone_label.TabIndex = 9;
            this.phone_label.Text = "Phone #";
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(79, 58);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(116, 20);
            this.phone_box.TabIndex = 10;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(357, 51);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 11;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Visible = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // client_grid
            // 
            this.client_grid.AllowUserToAddRows = false;
            this.client_grid.AllowUserToDeleteRows = false;
            this.client_grid.AllowUserToResizeColumns = false;
            this.client_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.client_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.client_grid.Location = new System.Drawing.Point(12, 203);
            this.client_grid.MultiSelect = false;
            this.client_grid.Name = "client_grid";
            this.client_grid.ReadOnly = true;
            this.client_grid.RowHeadersVisible = false;
            this.client_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.client_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.client_grid.ShowCellErrors = false;
            this.client_grid.Size = new System.Drawing.Size(420, 147);
            this.client_grid.TabIndex = 12;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(444, 24);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToXMLToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToXMLToolStripMenuItem
            // 
            this.exportToXMLToolStripMenuItem.Name = "exportToXMLToolStripMenuItem";
            this.exportToXMLToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exportToXMLToolStripMenuItem.Text = "Export to XML";
            this.exportToXMLToolStripMenuItem.Click += new System.EventHandler(this.exportToXMLToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientWindowToolStripMenuItem,
            this.recieversToolStripMenuItem,
            this.invoicesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // clientWindowToolStripMenuItem
            // 
            this.clientWindowToolStripMenuItem.CheckOnClick = true;
            this.clientWindowToolStripMenuItem.Name = "clientWindowToolStripMenuItem";
            this.clientWindowToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.clientWindowToolStripMenuItem.Text = "Shippers";
            this.clientWindowToolStripMenuItem.Click += new System.EventHandler(this.shippersWindowToolStripMenuItem_Click);
            // 
            // recieversToolStripMenuItem
            // 
            this.recieversToolStripMenuItem.CheckOnClick = true;
            this.recieversToolStripMenuItem.Name = "recieversToolStripMenuItem";
            this.recieversToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.recieversToolStripMenuItem.Text = "Recievers";
            this.recieversToolStripMenuItem.Click += new System.EventHandler(this.recieversToolStripMenuItem_Click);
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.invoicesToolStripMenuItem.Text = "Invoices";
            this.invoicesToolStripMenuItem.Click += new System.EventHandler(this.invoicesToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 362);
            this.Controls.Add(this.client_grid);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.city_box);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.postal_box);
            this.Controls.Add(this.postal_label);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.add_client_button);
            this.Controls.Add(this.name_combo);
            this.Controls.Add(this.name_string);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Jesse App";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.client_grid)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_string;
        private System.Windows.Forms.ComboBox name_combo;
        private System.Windows.Forms.Button add_client_button;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.Label postal_label;
        private System.Windows.Forms.TextBox postal_box;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox city_box;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.TextBox phone_box;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.DataGridView client_grid;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recieversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
    }
}

