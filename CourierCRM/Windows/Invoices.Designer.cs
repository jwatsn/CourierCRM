namespace CourierCRM.Windows
{
    partial class Invoices
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.ComboBox();
            this.due_date = new System.Windows.Forms.TextBox();
            this.statement_id = new System.Windows.Forms.TextBox();
            this.bn_num = new System.Windows.Forms.TextBox();
            this.invoices_grid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelxlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recieversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.client_attn = new System.Windows.Forms.TextBox();
            this.order_grid = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.TextBox();
            this.date_label = new System.Windows.Forms.Label();
            this.order_rightclick_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_order_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoices_grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_grid)).BeginInit();
            this.order_rightclick_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Due Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Statement #";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "BN #";
            // 
            // customer
            // 
            this.customer.FormattingEnabled = true;
            this.customer.Location = new System.Drawing.Point(84, 32);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(172, 21);
            this.customer.TabIndex = 9;
            // 
            // due_date
            // 
            this.due_date.Location = new System.Drawing.Point(84, 80);
            this.due_date.Name = "due_date";
            this.due_date.Size = new System.Drawing.Size(112, 20);
            this.due_date.TabIndex = 15;
            // 
            // statement_id
            // 
            this.statement_id.Location = new System.Drawing.Point(84, 104);
            this.statement_id.Name = "statement_id";
            this.statement_id.Size = new System.Drawing.Size(72, 20);
            this.statement_id.TabIndex = 16;
            // 
            // bn_num
            // 
            this.bn_num.Location = new System.Drawing.Point(84, 128);
            this.bn_num.Name = "bn_num";
            this.bn_num.Size = new System.Drawing.Size(72, 20);
            this.bn_num.TabIndex = 17;
            // 
            // invoices_grid
            // 
            this.invoices_grid.AllowUserToAddRows = false;
            this.invoices_grid.AllowUserToDeleteRows = false;
            this.invoices_grid.AllowUserToResizeRows = false;
            this.invoices_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invoices_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoices_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoices_grid.Location = new System.Drawing.Point(0, 260);
            this.invoices_grid.MultiSelect = false;
            this.invoices_grid.Name = "invoices_grid";
            this.invoices_grid.ReadOnly = true;
            this.invoices_grid.RowHeadersVisible = false;
            this.invoices_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoices_grid.ShowEditingIcon = false;
            this.invoices_grid.Size = new System.Drawing.Size(676, 180);
            this.invoices_grid.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newInvoiceToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newInvoiceToolStripMenuItem
            // 
            this.newInvoiceToolStripMenuItem.Name = "newInvoiceToolStripMenuItem";
            this.newInvoiceToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.newInvoiceToolStripMenuItem.Text = "New Invoice";
            this.newInvoiceToolStripMenuItem.Click += new System.EventHandler(this.newInvoiceToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelxlsToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // excelxlsToolStripMenuItem
            // 
            this.excelxlsToolStripMenuItem.Name = "excelxlsToolStripMenuItem";
            this.excelxlsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.excelxlsToolStripMenuItem.Text = "Excel (.xls)";
            this.excelxlsToolStripMenuItem.Click += new System.EventHandler(this.excelxlsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shippersToolStripMenuItem,
            this.recieversToolStripMenuItem,
            this.invoicesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // shippersToolStripMenuItem
            // 
            this.shippersToolStripMenuItem.CheckOnClick = true;
            this.shippersToolStripMenuItem.Name = "shippersToolStripMenuItem";
            this.shippersToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.shippersToolStripMenuItem.Text = "Shippers";
            this.shippersToolStripMenuItem.Click += new System.EventHandler(this.shippersToolStripMenuItem_Click);
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
            this.invoicesToolStripMenuItem.CheckOnClick = true;
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.invoicesToolStripMenuItem.Text = "Invoices";
            this.invoicesToolStripMenuItem.Click += new System.EventHandler(this.invoicesToolStripMenuItem_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(88, 188);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 20;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(8, 188);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 21;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Visible = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Attn:";
            // 
            // client_attn
            // 
            this.client_attn.Location = new System.Drawing.Point(84, 56);
            this.client_attn.Name = "client_attn";
            this.client_attn.Size = new System.Drawing.Size(172, 20);
            this.client_attn.TabIndex = 23;
            // 
            // order_grid
            // 
            this.order_grid.AllowUserToAddRows = false;
            this.order_grid.AllowUserToResizeRows = false;
            this.order_grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.order_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.order_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.order_grid.Location = new System.Drawing.Point(264, 28);
            this.order_grid.Name = "order_grid";
            this.order_grid.RowHeadersVisible = false;
            this.order_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.order_grid.ShowEditingIcon = false;
            this.order_grid.Size = new System.Drawing.Size(412, 232);
            this.order_grid.TabIndex = 24;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(84, 152);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(112, 20);
            this.date.TabIndex = 25;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(48, 156);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(30, 13);
            this.date_label.TabIndex = 26;
            this.date_label.Text = "Date";
            // 
            // order_rightclick_menu
            // 
            this.order_rightclick_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem});
            this.order_rightclick_menu.Name = "order_rightclick_menu";
            this.order_rightclick_menu.Size = new System.Drawing.Size(108, 26);
            this.order_rightclick_menu.Opening += new System.ComponentModel.CancelEventHandler(this.order_rightclick_menu_Opening);
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helloToolStripMenuItem.Text = "Delete";
            this.helloToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // add_order_button
            // 
            this.add_order_button.Location = new System.Drawing.Point(172, 188);
            this.add_order_button.Name = "add_order_button";
            this.add_order_button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_order_button.Size = new System.Drawing.Size(75, 23);
            this.add_order_button.TabIndex = 27;
            this.add_order_button.Text = "Add Order";
            this.add_order_button.UseVisualStyleBackColor = true;
            this.add_order_button.Visible = false;
            this.add_order_button.Click += new System.EventHandler(this.add_order_button_Click);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 436);
            this.Controls.Add(this.add_order_button);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.date);
            this.Controls.Add(this.order_grid);
            this.Controls.Add(this.client_attn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.invoices_grid);
            this.Controls.Add(this.bn_num);
            this.Controls.Add(this.statement_id);
            this.Controls.Add(this.due_date);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoices_grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_grid)).EndInit();
            this.order_rightclick_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox customer;
        private System.Windows.Forms.TextBox due_date;
        private System.Windows.Forms.TextBox statement_id;
        private System.Windows.Forms.TextBox bn_num;
        private System.Windows.Forms.DataGridView invoices_grid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shippersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recieversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.ToolStripMenuItem newInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelxlsToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox client_attn;
        private System.Windows.Forms.DataGridView order_grid;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.ContextMenuStrip order_rightclick_menu;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.Button add_order_button;
    }
}