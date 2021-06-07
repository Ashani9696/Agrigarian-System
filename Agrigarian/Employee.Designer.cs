namespace Agrigarian
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvEmployee = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_oficial_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starting_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtEmpTele = new System.Windows.Forms.TextBox();
            this.txtEmpNic = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.txtSearch);
            this.bunifuGradientPanel1.Controls.Add(this.dgvEmployee);
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Controls.Add(this.btnDelete);
            this.bunifuGradientPanel1.Controls.Add(this.btnUpdate);
            this.bunifuGradientPanel1.Controls.Add(this.btnSave);
            this.bunifuGradientPanel1.Controls.Add(this.txtEmpTele);
            this.bunifuGradientPanel1.Controls.Add(this.txtEmpNic);
            this.bunifuGradientPanel1.Controls.Add(this.txtEmpName);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(978, 560);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(31)))));
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(225)))), ((int)(((byte)(240)))));
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Location = new System.Drawing.Point(471, 172);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(311, 30);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.text = "";
            this.txtSearch.OnTextChange += new System.EventHandler(this.txtSearch_OnTextChange);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employee_id,
            this.employee_name,
            this.employee_NIC,
            this.employee_oficial_telephone,
            this.starting_date});
            this.dgvEmployee.DoubleBuffered = true;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvEmployee.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvEmployee.Location = new System.Drawing.Point(471, 235);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEmployee.Size = new System.Drawing.Size(495, 249);
            this.dgvEmployee.TabIndex = 4;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // employee_id
            // 
            this.employee_id.DataPropertyName = "employee_id";
            this.employee_id.HeaderText = "Employee ID";
            this.employee_id.MinimumWidth = 6;
            this.employee_id.Name = "employee_id";
            this.employee_id.ReadOnly = true;
            this.employee_id.Width = 125;
            // 
            // employee_name
            // 
            this.employee_name.DataPropertyName = "employee_name";
            this.employee_name.HeaderText = "Employee Name";
            this.employee_name.MinimumWidth = 6;
            this.employee_name.Name = "employee_name";
            this.employee_name.ReadOnly = true;
            this.employee_name.Width = 125;
            // 
            // employee_NIC
            // 
            this.employee_NIC.DataPropertyName = "employee_NIC";
            this.employee_NIC.HeaderText = "Employee NIC";
            this.employee_NIC.MinimumWidth = 6;
            this.employee_NIC.Name = "employee_NIC";
            this.employee_NIC.ReadOnly = true;
            this.employee_NIC.Width = 125;
            // 
            // employee_oficial_telephone
            // 
            this.employee_oficial_telephone.DataPropertyName = "employee_oficial_telephone";
            this.employee_oficial_telephone.HeaderText = "Employee TP Number";
            this.employee_oficial_telephone.MinimumWidth = 6;
            this.employee_oficial_telephone.Name = "employee_oficial_telephone";
            this.employee_oficial_telephone.ReadOnly = true;
            this.employee_oficial_telephone.Width = 125;
            // 
            // starting_date
            // 
            this.starting_date.DataPropertyName = "starting_date";
            this.starting_date.HeaderText = "Starting Date";
            this.starting_date.MinimumWidth = 6;
            this.starting_date.Name = "starting_date";
            this.starting_date.ReadOnly = true;
            this.starting_date.Width = 125;
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.Transparent;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "X";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = null;
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 90D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(913, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHovercolor = System.Drawing.Color.Red;
            this.btnClose.OnHoverTextColor = System.Drawing.Color.Thistle;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(65, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "DELETE";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(305, 397);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(84, 39);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "UPDATE";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(190, 397);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(84, 39);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "SAVE";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = null;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(75, 397);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(84, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmpTele
            // 
            this.txtEmpTele.Location = new System.Drawing.Point(253, 307);
            this.txtEmpTele.Name = "txtEmpTele";
            this.txtEmpTele.Size = new System.Drawing.Size(185, 20);
            this.txtEmpTele.TabIndex = 1;
            // 
            // txtEmpNic
            // 
            this.txtEmpNic.Location = new System.Drawing.Point(253, 262);
            this.txtEmpNic.Name = "txtEmpNic";
            this.txtEmpNic.Size = new System.Drawing.Size(185, 20);
            this.txtEmpNic.TabIndex = 1;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(253, 217);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(185, 20);
            this.txtEmpName.TabIndex = 1;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(32, 307);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(193, 24);
            this.bunifuCustomLabel5.TabIndex = 0;
            this.bunifuCustomLabel5.Text = "Telephone Number";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(32, 262);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(144, 24);
            this.bunifuCustomLabel4.TabIndex = 0;
            this.bunifuCustomLabel4.Text = "Employee NIC";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(32, 217);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(165, 24);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "Employee Name";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(246, 46);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(373, 39);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "EMPLOYEE DETAILS";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 560);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.TextBox txtEmpTele;
        private System.Windows.Forms.TextBox txtEmpNic;
        private System.Windows.Forms.TextBox txtEmpName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEmployee;
        private Bunifu.Framework.UI.BunifuTextbox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_oficial_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn starting_date;
    }
}