namespace Agrigarian
{
    partial class FertilizerSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FertilizerSupplier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvFertilizer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.fertilizer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertilizer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.official_unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSupplier = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.supplier_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppplier_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtFerQuan = new System.Windows.Forms.TextBox();
            this.txtFerTotalAmount = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnFertDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnFertUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFertSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtFerName = new System.Windows.Forms.TextBox();
            this.txtFerUPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuppDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSuppUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSuppSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSuppTp = new System.Windows.Forms.TextBox();
            this.txtSuppAddress = new System.Windows.Forms.TextBox();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.bunifuGradientPanel1.Controls.Add(this.dgvFertilizer);
            this.bunifuGradientPanel1.Controls.Add(this.dgvSupplier);
            this.bunifuGradientPanel1.Controls.Add(this.groupBox2);
            this.bunifuGradientPanel1.Controls.Add(this.groupBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGradientPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(13)))), ((int)(((byte)(31)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1168, 633);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // dgvFertilizer
            // 
            this.dgvFertilizer.AllowUserToAddRows = false;
            this.dgvFertilizer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvFertilizer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFertilizer.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvFertilizer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFertilizer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFertilizer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFertilizer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFertilizer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fertilizer_id,
            this.fertilizer_name,
            this.official_unit_price,
            this.quantity});
            this.dgvFertilizer.DoubleBuffered = true;
            this.dgvFertilizer.EnableHeadersVisualStyles = false;
            this.dgvFertilizer.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvFertilizer.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvFertilizer.Location = new System.Drawing.Point(552, 363);
            this.dgvFertilizer.Name = "dgvFertilizer";
            this.dgvFertilizer.ReadOnly = true;
            this.dgvFertilizer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFertilizer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFertilizer.RowHeadersWidth = 51;
            this.dgvFertilizer.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvFertilizer.Size = new System.Drawing.Size(605, 249);
            this.dgvFertilizer.TabIndex = 6;
            this.dgvFertilizer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFertilizer_CellContentClick);
            // 
            // fertilizer_id
            // 
            this.fertilizer_id.DataPropertyName = "fertilizer_id";
            this.fertilizer_id.HeaderText = "Fertilizer id";
            this.fertilizer_id.MinimumWidth = 6;
            this.fertilizer_id.Name = "fertilizer_id";
            this.fertilizer_id.ReadOnly = true;
            this.fertilizer_id.Width = 125;
            // 
            // fertilizer_name
            // 
            this.fertilizer_name.DataPropertyName = "fertilizer_name";
            this.fertilizer_name.HeaderText = "Fertilizer Name";
            this.fertilizer_name.MinimumWidth = 6;
            this.fertilizer_name.Name = "fertilizer_name";
            this.fertilizer_name.ReadOnly = true;
            this.fertilizer_name.Width = 125;
            // 
            // official_unit_price
            // 
            this.official_unit_price.DataPropertyName = "official_unit_price";
            this.official_unit_price.HeaderText = "Official Unit Price";
            this.official_unit_price.MinimumWidth = 6;
            this.official_unit_price.Name = "official_unit_price";
            this.official_unit_price.ReadOnly = true;
            this.official_unit_price.Width = 125;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 125;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Green;
            this.dgvSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSupplier.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplier_id,
            this.supplier_name,
            this.supplier_address,
            this.suppplier_telephone});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplier.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSupplier.DoubleBuffered = true;
            this.dgvSupplier.EnableHeadersVisualStyles = false;
            this.dgvSupplier.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvSupplier.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvSupplier.Location = new System.Drawing.Point(552, 66);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSupplier.RowHeadersWidth = 51;
            this.dgvSupplier.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSupplier.Size = new System.Drawing.Size(604, 249);
            this.dgvSupplier.TabIndex = 6;
            this.dgvSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellContentClick);
            // 
            // supplier_id
            // 
            this.supplier_id.DataPropertyName = "supplier_id";
            this.supplier_id.HeaderText = "Supplier ID";
            this.supplier_id.MinimumWidth = 6;
            this.supplier_id.Name = "supplier_id";
            this.supplier_id.ReadOnly = true;
            this.supplier_id.Width = 125;
            // 
            // supplier_name
            // 
            this.supplier_name.DataPropertyName = "supplier_name";
            this.supplier_name.HeaderText = "Supplier Name";
            this.supplier_name.MinimumWidth = 6;
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.ReadOnly = true;
            this.supplier_name.Width = 125;
            // 
            // supplier_address
            // 
            this.supplier_address.DataPropertyName = "supplier_address";
            this.supplier_address.HeaderText = "Supplier Address";
            this.supplier_address.MinimumWidth = 6;
            this.supplier_address.Name = "supplier_address";
            this.supplier_address.ReadOnly = true;
            this.supplier_address.Width = 125;
            // 
            // suppplier_telephone
            // 
            this.suppplier_telephone.DataPropertyName = "suppplier_telephone";
            this.suppplier_telephone.HeaderText = "Suppplier Telephone";
            this.suppplier_telephone.MinimumWidth = 6;
            this.suppplier_telephone.Name = "suppplier_telephone";
            this.suppplier_telephone.ReadOnly = true;
            this.suppplier_telephone.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox2.Controls.Add(this.txtFerQuan);
            this.groupBox2.Controls.Add(this.txtFerTotalAmount);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox2.Controls.Add(this.btnFertDelete);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox2.Controls.Add(this.btnFertUpdate);
            this.groupBox2.Controls.Add(this.btnFertSave);
            this.groupBox2.Controls.Add(this.txtFerName);
            this.groupBox2.Controls.Add(this.txtFerUPrice);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(40, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 291);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fertilizer";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(16, 98);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(86, 24);
            this.bunifuCustomLabel4.TabIndex = 10;
            this.bunifuCustomLabel4.Text = "Quantity";
            // 
            // txtFerQuan
            // 
            this.txtFerQuan.Enabled = false;
            this.txtFerQuan.Location = new System.Drawing.Point(223, 94);
            this.txtFerQuan.Name = "txtFerQuan";
            this.txtFerQuan.Size = new System.Drawing.Size(223, 29);
            this.txtFerQuan.TabIndex = 11;
            // 
            // txtFerTotalAmount
            // 
            this.txtFerTotalAmount.Enabled = false;
            this.txtFerTotalAmount.Location = new System.Drawing.Point(223, 179);
            this.txtFerTotalAmount.Name = "txtFerTotalAmount";
            this.txtFerTotalAmount.Size = new System.Drawing.Size(223, 29);
            this.txtFerTotalAmount.TabIndex = 9;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(16, 181);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(134, 24);
            this.bunifuCustomLabel8.TabIndex = 6;
            this.bunifuCustomLabel8.Text = "Total Amount";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(16, 57);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(152, 24);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Fertilizer Name";
            // 
            // btnFertDelete
            // 
            this.btnFertDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFertDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFertDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFertDelete.BorderRadius = 0;
            this.btnFertDelete.ButtonText = "DELETE";
            this.btnFertDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFertDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnFertDelete.Enabled = false;
            this.btnFertDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFertDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFertDelete.Iconimage = null;
            this.btnFertDelete.Iconimage_right = null;
            this.btnFertDelete.Iconimage_right_Selected = null;
            this.btnFertDelete.Iconimage_Selected = null;
            this.btnFertDelete.IconMarginLeft = 0;
            this.btnFertDelete.IconMarginRight = 0;
            this.btnFertDelete.IconRightVisible = true;
            this.btnFertDelete.IconRightZoom = 0D;
            this.btnFertDelete.IconVisible = true;
            this.btnFertDelete.IconZoom = 90D;
            this.btnFertDelete.IsTab = false;
            this.btnFertDelete.Location = new System.Drawing.Point(329, 232);
            this.btnFertDelete.Margin = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.btnFertDelete.Name = "btnFertDelete";
            this.btnFertDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFertDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnFertDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFertDelete.selected = false;
            this.btnFertDelete.Size = new System.Drawing.Size(94, 36);
            this.btnFertDelete.TabIndex = 3;
            this.btnFertDelete.Text = "DELETE";
            this.btnFertDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFertDelete.Textcolor = System.Drawing.Color.White;
            this.btnFertDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFertDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 140);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 24);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Unit Price";
            // 
            // btnFertUpdate
            // 
            this.btnFertUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFertUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFertUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFertUpdate.BorderRadius = 0;
            this.btnFertUpdate.ButtonText = "UPDATE";
            this.btnFertUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFertUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnFertUpdate.Enabled = false;
            this.btnFertUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFertUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFertUpdate.Iconimage = null;
            this.btnFertUpdate.Iconimage_right = null;
            this.btnFertUpdate.Iconimage_right_Selected = null;
            this.btnFertUpdate.Iconimage_Selected = null;
            this.btnFertUpdate.IconMarginLeft = 0;
            this.btnFertUpdate.IconMarginRight = 0;
            this.btnFertUpdate.IconRightVisible = true;
            this.btnFertUpdate.IconRightZoom = 0D;
            this.btnFertUpdate.IconVisible = true;
            this.btnFertUpdate.IconZoom = 90D;
            this.btnFertUpdate.IsTab = false;
            this.btnFertUpdate.Location = new System.Drawing.Point(187, 232);
            this.btnFertUpdate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnFertUpdate.Name = "btnFertUpdate";
            this.btnFertUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFertUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnFertUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFertUpdate.selected = false;
            this.btnFertUpdate.Size = new System.Drawing.Size(94, 36);
            this.btnFertUpdate.TabIndex = 3;
            this.btnFertUpdate.Text = "UPDATE";
            this.btnFertUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFertUpdate.Textcolor = System.Drawing.Color.White;
            this.btnFertUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFertUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFertSave
            // 
            this.btnFertSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFertSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFertSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFertSave.BorderRadius = 0;
            this.btnFertSave.ButtonText = "SAVE";
            this.btnFertSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFertSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnFertSave.Enabled = false;
            this.btnFertSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFertSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFertSave.Iconimage = null;
            this.btnFertSave.Iconimage_right = null;
            this.btnFertSave.Iconimage_right_Selected = null;
            this.btnFertSave.Iconimage_Selected = null;
            this.btnFertSave.IconMarginLeft = 0;
            this.btnFertSave.IconMarginRight = 0;
            this.btnFertSave.IconRightVisible = true;
            this.btnFertSave.IconRightZoom = 0D;
            this.btnFertSave.IconVisible = true;
            this.btnFertSave.IconZoom = 90D;
            this.btnFertSave.IsTab = false;
            this.btnFertSave.Location = new System.Drawing.Point(44, 232);
            this.btnFertSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnFertSave.Name = "btnFertSave";
            this.btnFertSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFertSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnFertSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFertSave.selected = false;
            this.btnFertSave.Size = new System.Drawing.Size(94, 36);
            this.btnFertSave.TabIndex = 3;
            this.btnFertSave.Text = "SAVE";
            this.btnFertSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFertSave.Textcolor = System.Drawing.Color.White;
            this.btnFertSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFertSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFerName
            // 
            this.txtFerName.Enabled = false;
            this.txtFerName.Location = new System.Drawing.Point(223, 52);
            this.txtFerName.Name = "txtFerName";
            this.txtFerName.Size = new System.Drawing.Size(223, 29);
            this.txtFerName.TabIndex = 2;
            // 
            // txtFerUPrice
            // 
            this.txtFerUPrice.Enabled = false;
            this.txtFerUPrice.Location = new System.Drawing.Point(223, 136);
            this.txtFerUPrice.Name = "txtFerUPrice";
            this.txtFerUPrice.Size = new System.Drawing.Size(223, 29);
            this.txtFerUPrice.TabIndex = 2;
            this.txtFerUPrice.TextChanged += new System.EventHandler(this.txtFerUPrice_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuppDelete);
            this.groupBox1.Controls.Add(this.btnSuppUpdate);
            this.groupBox1.Controls.Add(this.btnSuppSave);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel10);
            this.groupBox1.Controls.Add(this.txtSuppTp);
            this.groupBox1.Controls.Add(this.txtSuppAddress);
            this.groupBox1.Controls.Add(this.txtSuppName);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel7);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(40, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 256);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSuppDelete
            // 
            this.btnSuppDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuppDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuppDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuppDelete.BorderRadius = 0;
            this.btnSuppDelete.ButtonText = "DELETE";
            this.btnSuppDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuppDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuppDelete.Iconimage = null;
            this.btnSuppDelete.Iconimage_right = null;
            this.btnSuppDelete.Iconimage_right_Selected = null;
            this.btnSuppDelete.Iconimage_Selected = null;
            this.btnSuppDelete.IconMarginLeft = 0;
            this.btnSuppDelete.IconMarginRight = 0;
            this.btnSuppDelete.IconRightVisible = true;
            this.btnSuppDelete.IconRightZoom = 0D;
            this.btnSuppDelete.IconVisible = true;
            this.btnSuppDelete.IconZoom = 90D;
            this.btnSuppDelete.IsTab = false;
            this.btnSuppDelete.Location = new System.Drawing.Point(330, 206);
            this.btnSuppDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnSuppDelete.Name = "btnSuppDelete";
            this.btnSuppDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuppDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnSuppDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuppDelete.selected = false;
            this.btnSuppDelete.Size = new System.Drawing.Size(94, 36);
            this.btnSuppDelete.TabIndex = 11;
            this.btnSuppDelete.Text = "DELETE";
            this.btnSuppDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuppDelete.Textcolor = System.Drawing.Color.White;
            this.btnSuppDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppDelete.Click += new System.EventHandler(this.btnSuppDelete_Click);
            // 
            // btnSuppUpdate
            // 
            this.btnSuppUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuppUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuppUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuppUpdate.BorderRadius = 0;
            this.btnSuppUpdate.ButtonText = "UPDATE";
            this.btnSuppUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuppUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuppUpdate.Iconimage = null;
            this.btnSuppUpdate.Iconimage_right = null;
            this.btnSuppUpdate.Iconimage_right_Selected = null;
            this.btnSuppUpdate.Iconimage_Selected = null;
            this.btnSuppUpdate.IconMarginLeft = 0;
            this.btnSuppUpdate.IconMarginRight = 0;
            this.btnSuppUpdate.IconRightVisible = true;
            this.btnSuppUpdate.IconRightZoom = 0D;
            this.btnSuppUpdate.IconVisible = true;
            this.btnSuppUpdate.IconZoom = 90D;
            this.btnSuppUpdate.IsTab = false;
            this.btnSuppUpdate.Location = new System.Drawing.Point(187, 206);
            this.btnSuppUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnSuppUpdate.Name = "btnSuppUpdate";
            this.btnSuppUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuppUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnSuppUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuppUpdate.selected = false;
            this.btnSuppUpdate.Size = new System.Drawing.Size(94, 36);
            this.btnSuppUpdate.TabIndex = 10;
            this.btnSuppUpdate.Text = "UPDATE";
            this.btnSuppUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuppUpdate.Textcolor = System.Drawing.Color.White;
            this.btnSuppUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppUpdate.Click += new System.EventHandler(this.btnSuppUpdate_Click);
            // 
            // btnSuppSave
            // 
            this.btnSuppSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuppSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuppSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuppSave.BorderRadius = 0;
            this.btnSuppSave.ButtonText = "SAVE";
            this.btnSuppSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuppSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuppSave.Iconimage = null;
            this.btnSuppSave.Iconimage_right = null;
            this.btnSuppSave.Iconimage_right_Selected = null;
            this.btnSuppSave.Iconimage_Selected = null;
            this.btnSuppSave.IconMarginLeft = 0;
            this.btnSuppSave.IconMarginRight = 0;
            this.btnSuppSave.IconRightVisible = true;
            this.btnSuppSave.IconRightZoom = 0D;
            this.btnSuppSave.IconVisible = true;
            this.btnSuppSave.IconZoom = 90D;
            this.btnSuppSave.IsTab = false;
            this.btnSuppSave.Location = new System.Drawing.Point(44, 206);
            this.btnSuppSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSuppSave.Name = "btnSuppSave";
            this.btnSuppSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuppSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(92)))), ((int)(((byte)(58)))));
            this.btnSuppSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuppSave.selected = false;
            this.btnSuppSave.Size = new System.Drawing.Size(94, 36);
            this.btnSuppSave.TabIndex = 9;
            this.btnSuppSave.Text = "SAVE";
            this.btnSuppSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuppSave.Textcolor = System.Drawing.Color.White;
            this.btnSuppSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppSave.Click += new System.EventHandler(this.sup_save_Click);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(9, 158);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(196, 24);
            this.bunifuCustomLabel10.TabIndex = 8;
            this.bunifuCustomLabel10.Text = "Supplier Telephone";
            // 
            // txtSuppTp
            // 
            this.txtSuppTp.Location = new System.Drawing.Point(213, 151);
            this.txtSuppTp.Name = "txtSuppTp";
            this.txtSuppTp.Size = new System.Drawing.Size(223, 29);
            this.txtSuppTp.TabIndex = 7;
            this.txtSuppTp.TextChanged += new System.EventHandler(this.txtSuppTp_TextChanged);
            // 
            // txtSuppAddress
            // 
            this.txtSuppAddress.Location = new System.Drawing.Point(213, 99);
            this.txtSuppAddress.Name = "txtSuppAddress";
            this.txtSuppAddress.Size = new System.Drawing.Size(223, 29);
            this.txtSuppAddress.TabIndex = 7;
            // 
            // txtSuppName
            // 
            this.txtSuppName.Location = new System.Drawing.Point(213, 47);
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.Size = new System.Drawing.Size(223, 29);
            this.txtSuppName.TabIndex = 7;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(16, 206);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(0, 24);
            this.bunifuCustomLabel9.TabIndex = 4;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(19, 105);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(171, 24);
            this.bunifuCustomLabel7.TabIndex = 4;
            this.bunifuCustomLabel7.Text = "Supplier Address";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(19, 52);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(149, 24);
            this.bunifuCustomLabel6.TabIndex = 4;
            this.bunifuCustomLabel6.Text = "Supplier Name";
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
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Iconcolor = System.Drawing.Color.Thistle;
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
            this.btnClose.Location = new System.Drawing.Point(1091, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHovercolor = System.Drawing.Color.Red;
            this.btnClose.OnHoverTextColor = System.Drawing.Color.Thistle;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(76, 42);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(56, 180);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(0, 24);
            this.bunifuCustomLabel5.TabIndex = 1;
            // 
            // FertilizerSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 633);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FertilizerSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.FertilizerSupplier_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnFertDelete;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnFertUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnFertSave;
        private System.Windows.Forms.TextBox txtFerName;
        private System.Windows.Forms.TextBox txtFerUPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSuppName;
        private System.Windows.Forms.TextBox txtFerTotalAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox txtFerQuan;
        private System.Windows.Forms.TextBox txtSuppTp;
        private System.Windows.Forms.TextBox txtSuppAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvFertilizer;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppplier_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn fertilizer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fertilizer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn official_unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuppDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuppUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuppSave;
    }
}