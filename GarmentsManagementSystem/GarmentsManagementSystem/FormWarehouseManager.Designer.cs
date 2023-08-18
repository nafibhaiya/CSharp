namespace GarmentsManagementSystem
{
    partial class FormWarehouseManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWarehouseManager));
            this.pnlWarehouse = new System.Windows.Forms.Panel();
            this.imgWarehouseImage = new System.Windows.Forms.ImageList(this.components);
            this.finishedProduct = new System.Windows.Forms.TabPage();
            this.pnlFinishedProductShow = new System.Windows.Forms.Panel();
            this.pnlFinishedProductSearch = new System.Windows.Forms.Panel();
            this.txtFinishedProductSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.dgvFinishedProductShow = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFinishedProductInput = new System.Windows.Forms.Panel();
            this.lblManufacturedDate = new System.Windows.Forms.Label();
            this.dtpManufacturedDateInput = new System.Windows.Forms.DateTimePicker();
            this.btnFinishedProductDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnFinishedProductSave = new MaterialSkin.Controls.MaterialButton();
            this.txtFinishedProductId = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFinishedProductCostInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFinishedProductQuantityInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbFinishedProductNameInput = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbFinishedProductCategoryInput = new MaterialSkin.Controls.MaterialComboBox();
            this.lblFinishedTitle = new System.Windows.Forms.Label();
            this.rawMaterials = new System.Windows.Forms.TabPage();
            this.pnlRawMaterialShow = new System.Windows.Forms.Panel();
            this.dgvRawMaterialsShow = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRawMaterialSearch = new System.Windows.Forms.Panel();
            this.txtSearchRawMaterial = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlRawMaterialInput = new System.Windows.Forms.Panel();
            this.btnManagerLogOut = new MaterialSkin.Controls.MaterialButton();
            this.txtRawMaterialsId = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRawCostInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblReceiveDate = new System.Windows.Forms.Label();
            this.dtpRawMaterialReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteRawMaterial = new MaterialSkin.Controls.MaterialButton();
            this.switchTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.btnSaveRawMaterials = new MaterialSkin.Controls.MaterialButton();
            this.txtRawQuantityInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbRawProductNameInput = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbRawMaterialsCategoryInput = new MaterialSkin.Controls.MaterialComboBox();
            this.lblRawMaterial = new System.Windows.Forms.Label();
            this.tabWarehouseManager = new MaterialSkin.Controls.MaterialTabControl();
            this.finishedProduct.SuspendLayout();
            this.pnlFinishedProductShow.SuspendLayout();
            this.pnlFinishedProductSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinishedProductShow)).BeginInit();
            this.pnlFinishedProductInput.SuspendLayout();
            this.rawMaterials.SuspendLayout();
            this.pnlRawMaterialShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterialsShow)).BeginInit();
            this.pnlRawMaterialSearch.SuspendLayout();
            this.pnlRawMaterialInput.SuspendLayout();
            this.tabWarehouseManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWarehouse
            // 
            this.pnlWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWarehouse.Location = new System.Drawing.Point(3, 64);
            this.pnlWarehouse.Name = "pnlWarehouse";
            this.pnlWarehouse.Size = new System.Drawing.Size(1173, 717);
            this.pnlWarehouse.TabIndex = 0;
            // 
            // imgWarehouseImage
            // 
            this.imgWarehouseImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgWarehouseImage.ImageStream")));
            this.imgWarehouseImage.TransparentColor = System.Drawing.Color.Transparent;
            this.imgWarehouseImage.Images.SetKeyName(0, "raw materials.png");
            this.imgWarehouseImage.Images.SetKeyName(1, "finished product.png");
            // 
            // finishedProduct
            // 
            this.finishedProduct.Controls.Add(this.pnlFinishedProductShow);
            this.finishedProduct.Controls.Add(this.pnlFinishedProductInput);
            this.finishedProduct.ImageKey = "finished product.png";
            this.finishedProduct.Location = new System.Drawing.Point(4, 53);
            this.finishedProduct.Name = "finishedProduct";
            this.finishedProduct.Padding = new System.Windows.Forms.Padding(3);
            this.finishedProduct.Size = new System.Drawing.Size(1165, 660);
            this.finishedProduct.TabIndex = 1;
            this.finishedProduct.Text = "Finished Products";
            this.finishedProduct.UseVisualStyleBackColor = true;
            // 
            // pnlFinishedProductShow
            // 
            this.pnlFinishedProductShow.Controls.Add(this.pnlFinishedProductSearch);
            this.pnlFinishedProductShow.Controls.Add(this.dgvFinishedProductShow);
            this.pnlFinishedProductShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFinishedProductShow.Location = new System.Drawing.Point(428, 3);
            this.pnlFinishedProductShow.Name = "pnlFinishedProductShow";
            this.pnlFinishedProductShow.Size = new System.Drawing.Size(734, 654);
            this.pnlFinishedProductShow.TabIndex = 1;
            // 
            // pnlFinishedProductSearch
            // 
            this.pnlFinishedProductSearch.Controls.Add(this.txtFinishedProductSearch);
            this.pnlFinishedProductSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFinishedProductSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlFinishedProductSearch.Name = "pnlFinishedProductSearch";
            this.pnlFinishedProductSearch.Size = new System.Drawing.Size(734, 48);
            this.pnlFinishedProductSearch.TabIndex = 4;
            // 
            // txtFinishedProductSearch
            // 
            this.txtFinishedProductSearch.AnimateReadOnly = false;
            this.txtFinishedProductSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFinishedProductSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFinishedProductSearch.Depth = 0;
            this.txtFinishedProductSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFinishedProductSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinishedProductSearch.HideSelection = true;
            this.txtFinishedProductSearch.Hint = "Search Finished Product by category name";
            this.txtFinishedProductSearch.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtFinishedProductSearch.LeadingIcon")));
            this.txtFinishedProductSearch.Location = new System.Drawing.Point(0, 0);
            this.txtFinishedProductSearch.MaxLength = 32767;
            this.txtFinishedProductSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFinishedProductSearch.Name = "txtFinishedProductSearch";
            this.txtFinishedProductSearch.PasswordChar = '\0';
            this.txtFinishedProductSearch.PrefixSuffixText = null;
            this.txtFinishedProductSearch.ReadOnly = false;
            this.txtFinishedProductSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFinishedProductSearch.SelectedText = "";
            this.txtFinishedProductSearch.SelectionLength = 0;
            this.txtFinishedProductSearch.SelectionStart = 0;
            this.txtFinishedProductSearch.ShortcutsEnabled = true;
            this.txtFinishedProductSearch.Size = new System.Drawing.Size(734, 48);
            this.txtFinishedProductSearch.TabIndex = 16;
            this.txtFinishedProductSearch.TabStop = false;
            this.txtFinishedProductSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFinishedProductSearch.TrailingIcon = null;
            this.txtFinishedProductSearch.UseSystemPasswordChar = false;
            this.txtFinishedProductSearch.TextChanged += new System.EventHandler(this.txtFinishedProductSearch_TextChanged);
            // 
            // dgvFinishedProductShow
            // 
            this.dgvFinishedProductShow.AllowUserToAddRows = false;
            this.dgvFinishedProductShow.AllowUserToDeleteRows = false;
            this.dgvFinishedProductShow.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvFinishedProductShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinishedProductShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Category,
            this.ProductName,
            this.Quantity,
            this.TotalCost,
            this.ManufacturedDate});
            this.dgvFinishedProductShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFinishedProductShow.GridColor = System.Drawing.Color.DimGray;
            this.dgvFinishedProductShow.Location = new System.Drawing.Point(0, -7);
            this.dgvFinishedProductShow.Name = "dgvFinishedProductShow";
            this.dgvFinishedProductShow.ReadOnly = true;
            this.dgvFinishedProductShow.RowHeadersWidth = 51;
            this.dgvFinishedProductShow.RowTemplate.Height = 24;
            this.dgvFinishedProductShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinishedProductShow.Size = new System.Drawing.Size(734, 661);
            this.dgvFinishedProductShow.TabIndex = 3;
            this.dgvFinishedProductShow.DoubleClick += new System.EventHandler(this.dgvFinishedProductShow_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "FinishedProductId";
            this.Id.HeaderText = "Product Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "FinishedCatagory";
            this.Category.HeaderText = "Product Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "FinishedProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "FinishedQuantity";
            this.Quantity.HeaderText = "Product Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 125;
            // 
            // TotalCost
            // 
            this.TotalCost.DataPropertyName = "FinishedCost";
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.MinimumWidth = 6;
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Width = 125;
            // 
            // ManufacturedDate
            // 
            this.ManufacturedDate.DataPropertyName = "FinishDate";
            this.ManufacturedDate.HeaderText = "Manufactured Date";
            this.ManufacturedDate.MinimumWidth = 6;
            this.ManufacturedDate.Name = "ManufacturedDate";
            this.ManufacturedDate.ReadOnly = true;
            this.ManufacturedDate.Width = 125;
            // 
            // pnlFinishedProductInput
            // 
            this.pnlFinishedProductInput.BackColor = System.Drawing.Color.Snow;
            this.pnlFinishedProductInput.Controls.Add(this.lblManufacturedDate);
            this.pnlFinishedProductInput.Controls.Add(this.dtpManufacturedDateInput);
            this.pnlFinishedProductInput.Controls.Add(this.btnFinishedProductDelete);
            this.pnlFinishedProductInput.Controls.Add(this.btnFinishedProductSave);
            this.pnlFinishedProductInput.Controls.Add(this.txtFinishedProductId);
            this.pnlFinishedProductInput.Controls.Add(this.txtFinishedProductCostInput);
            this.pnlFinishedProductInput.Controls.Add(this.txtFinishedProductQuantityInput);
            this.pnlFinishedProductInput.Controls.Add(this.cmbFinishedProductNameInput);
            this.pnlFinishedProductInput.Controls.Add(this.cmbFinishedProductCategoryInput);
            this.pnlFinishedProductInput.Controls.Add(this.lblFinishedTitle);
            this.pnlFinishedProductInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFinishedProductInput.Location = new System.Drawing.Point(3, 3);
            this.pnlFinishedProductInput.Name = "pnlFinishedProductInput";
            this.pnlFinishedProductInput.Size = new System.Drawing.Size(434, 654);
            this.pnlFinishedProductInput.TabIndex = 0;
            // 
            // lblManufacturedDate
            // 
            this.lblManufacturedDate.AutoSize = true;
            this.lblManufacturedDate.Location = new System.Drawing.Point(50, 456);
            this.lblManufacturedDate.Name = "lblManufacturedDate";
            this.lblManufacturedDate.Size = new System.Drawing.Size(178, 25);
            this.lblManufacturedDate.TabIndex = 28;
            this.lblManufacturedDate.Text = "Manufactured Date";
            // 
            // dtpManufacturedDateInput
            // 
            this.dtpManufacturedDateInput.CustomFormat = "";
            this.dtpManufacturedDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpManufacturedDateInput.Location = new System.Drawing.Point(234, 456);
            this.dtpManufacturedDateInput.Name = "dtpManufacturedDateInput";
            this.dtpManufacturedDateInput.Size = new System.Drawing.Size(164, 30);
            this.dtpManufacturedDateInput.TabIndex = 29;
            // 
            // btnFinishedProductDelete
            // 
            this.btnFinishedProductDelete.AutoSize = false;
            this.btnFinishedProductDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinishedProductDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFinishedProductDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinishedProductDelete.Depth = 0;
            this.btnFinishedProductDelete.HighEmphasis = true;
            this.btnFinishedProductDelete.Icon = null;
            this.btnFinishedProductDelete.Location = new System.Drawing.Point(141, 519);
            this.btnFinishedProductDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinishedProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinishedProductDelete.Name = "btnFinishedProductDelete";
            this.btnFinishedProductDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinishedProductDelete.Size = new System.Drawing.Size(73, 36);
            this.btnFinishedProductDelete.TabIndex = 31;
            this.btnFinishedProductDelete.Text = "DELETE";
            this.btnFinishedProductDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinishedProductDelete.UseAccentColor = false;
            this.btnFinishedProductDelete.UseVisualStyleBackColor = false;
            this.btnFinishedProductDelete.Click += new System.EventHandler(this.btnFinishedProductDelete_Click);
            // 
            // btnFinishedProductSave
            // 
            this.btnFinishedProductSave.AutoSize = false;
            this.btnFinishedProductSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinishedProductSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinishedProductSave.Depth = 0;
            this.btnFinishedProductSave.HighEmphasis = true;
            this.btnFinishedProductSave.Icon = null;
            this.btnFinishedProductSave.Location = new System.Drawing.Point(56, 519);
            this.btnFinishedProductSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinishedProductSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinishedProductSave.Name = "btnFinishedProductSave";
            this.btnFinishedProductSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinishedProductSave.Size = new System.Drawing.Size(64, 36);
            this.btnFinishedProductSave.TabIndex = 30;
            this.btnFinishedProductSave.Text = "SAVE";
            this.btnFinishedProductSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinishedProductSave.UseAccentColor = false;
            this.btnFinishedProductSave.UseVisualStyleBackColor = true;
            this.btnFinishedProductSave.Click += new System.EventHandler(this.btnFinishedProductSave_Click);
            // 
            // txtFinishedProductId
            // 
            this.txtFinishedProductId.AnimateReadOnly = false;
            this.txtFinishedProductId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFinishedProductId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFinishedProductId.Depth = 0;
            this.txtFinishedProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFinishedProductId.HideSelection = true;
            this.txtFinishedProductId.Hint = "Product Id";
            this.txtFinishedProductId.LeadingIcon = null;
            this.txtFinishedProductId.Location = new System.Drawing.Point(56, 95);
            this.txtFinishedProductId.MaxLength = 32767;
            this.txtFinishedProductId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFinishedProductId.Name = "txtFinishedProductId";
            this.txtFinishedProductId.PasswordChar = '\0';
            this.txtFinishedProductId.PrefixSuffixText = null;
            this.txtFinishedProductId.ReadOnly = true;
            this.txtFinishedProductId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFinishedProductId.SelectedText = "";
            this.txtFinishedProductId.SelectionLength = 0;
            this.txtFinishedProductId.SelectionStart = 0;
            this.txtFinishedProductId.ShortcutsEnabled = true;
            this.txtFinishedProductId.Size = new System.Drawing.Size(161, 48);
            this.txtFinishedProductId.TabIndex = 27;
            this.txtFinishedProductId.TabStop = false;
            this.txtFinishedProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFinishedProductId.TrailingIcon = null;
            this.txtFinishedProductId.UseSystemPasswordChar = false;
            // 
            // txtFinishedProductCostInput
            // 
            this.txtFinishedProductCostInput.AnimateReadOnly = false;
            this.txtFinishedProductCostInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFinishedProductCostInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFinishedProductCostInput.Depth = 0;
            this.txtFinishedProductCostInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFinishedProductCostInput.HideSelection = true;
            this.txtFinishedProductCostInput.Hint = "Total Cost";
            this.txtFinishedProductCostInput.LeadingIcon = null;
            this.txtFinishedProductCostInput.Location = new System.Drawing.Point(56, 382);
            this.txtFinishedProductCostInput.MaxLength = 32767;
            this.txtFinishedProductCostInput.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFinishedProductCostInput.Name = "txtFinishedProductCostInput";
            this.txtFinishedProductCostInput.PasswordChar = '\0';
            this.txtFinishedProductCostInput.PrefixSuffixText = null;
            this.txtFinishedProductCostInput.ReadOnly = false;
            this.txtFinishedProductCostInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFinishedProductCostInput.SelectedText = "";
            this.txtFinishedProductCostInput.SelectionLength = 0;
            this.txtFinishedProductCostInput.SelectionStart = 0;
            this.txtFinishedProductCostInput.ShortcutsEnabled = true;
            this.txtFinishedProductCostInput.Size = new System.Drawing.Size(161, 48);
            this.txtFinishedProductCostInput.TabIndex = 25;
            this.txtFinishedProductCostInput.TabStop = false;
            this.txtFinishedProductCostInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFinishedProductCostInput.TrailingIcon = null;
            this.txtFinishedProductCostInput.UseSystemPasswordChar = false;
            // 
            // txtFinishedProductQuantityInput
            // 
            this.txtFinishedProductQuantityInput.AnimateReadOnly = false;
            this.txtFinishedProductQuantityInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFinishedProductQuantityInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFinishedProductQuantityInput.Depth = 0;
            this.txtFinishedProductQuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFinishedProductQuantityInput.HideSelection = true;
            this.txtFinishedProductQuantityInput.Hint = "Enter quantity";
            this.txtFinishedProductQuantityInput.LeadingIcon = null;
            this.txtFinishedProductQuantityInput.Location = new System.Drawing.Point(56, 308);
            this.txtFinishedProductQuantityInput.MaxLength = 32767;
            this.txtFinishedProductQuantityInput.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFinishedProductQuantityInput.Name = "txtFinishedProductQuantityInput";
            this.txtFinishedProductQuantityInput.PasswordChar = '\0';
            this.txtFinishedProductQuantityInput.PrefixSuffixText = null;
            this.txtFinishedProductQuantityInput.ReadOnly = false;
            this.txtFinishedProductQuantityInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFinishedProductQuantityInput.SelectedText = "";
            this.txtFinishedProductQuantityInput.SelectionLength = 0;
            this.txtFinishedProductQuantityInput.SelectionStart = 0;
            this.txtFinishedProductQuantityInput.ShortcutsEnabled = true;
            this.txtFinishedProductQuantityInput.Size = new System.Drawing.Size(161, 48);
            this.txtFinishedProductQuantityInput.TabIndex = 24;
            this.txtFinishedProductQuantityInput.TabStop = false;
            this.txtFinishedProductQuantityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFinishedProductQuantityInput.TrailingIcon = null;
            this.txtFinishedProductQuantityInput.UseSystemPasswordChar = false;
            // 
            // cmbFinishedProductNameInput
            // 
            this.cmbFinishedProductNameInput.AutoResize = false;
            this.cmbFinishedProductNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbFinishedProductNameInput.Depth = 0;
            this.cmbFinishedProductNameInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbFinishedProductNameInput.DropDownHeight = 174;
            this.cmbFinishedProductNameInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinishedProductNameInput.DropDownWidth = 121;
            this.cmbFinishedProductNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbFinishedProductNameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbFinishedProductNameInput.FormattingEnabled = true;
            this.cmbFinishedProductNameInput.Hint = "Choose Product";
            this.cmbFinishedProductNameInput.IntegralHeight = false;
            this.cmbFinishedProductNameInput.ItemHeight = 43;
            this.cmbFinishedProductNameInput.Items.AddRange(new object[] {
            "None"});
            this.cmbFinishedProductNameInput.Location = new System.Drawing.Point(56, 240);
            this.cmbFinishedProductNameInput.MaxDropDownItems = 4;
            this.cmbFinishedProductNameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbFinishedProductNameInput.Name = "cmbFinishedProductNameInput";
            this.cmbFinishedProductNameInput.Size = new System.Drawing.Size(161, 49);
            this.cmbFinishedProductNameInput.StartIndex = 0;
            this.cmbFinishedProductNameInput.TabIndex = 26;
            // 
            // cmbFinishedProductCategoryInput
            // 
            this.cmbFinishedProductCategoryInput.AutoResize = false;
            this.cmbFinishedProductCategoryInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbFinishedProductCategoryInput.Depth = 0;
            this.cmbFinishedProductCategoryInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbFinishedProductCategoryInput.DropDownHeight = 432;
            this.cmbFinishedProductCategoryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinishedProductCategoryInput.DropDownWidth = 121;
            this.cmbFinishedProductCategoryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbFinishedProductCategoryInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbFinishedProductCategoryInput.FormattingEnabled = true;
            this.cmbFinishedProductCategoryInput.Hint = "Choose Category";
            this.cmbFinishedProductCategoryInput.IntegralHeight = false;
            this.cmbFinishedProductCategoryInput.ItemHeight = 43;
            this.cmbFinishedProductCategoryInput.Items.AddRange(new object[] {
            "None"});
            this.cmbFinishedProductCategoryInput.Location = new System.Drawing.Point(56, 167);
            this.cmbFinishedProductCategoryInput.MaxDropDownItems = 10;
            this.cmbFinishedProductCategoryInput.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbFinishedProductCategoryInput.Name = "cmbFinishedProductCategoryInput";
            this.cmbFinishedProductCategoryInput.Size = new System.Drawing.Size(161, 49);
            this.cmbFinishedProductCategoryInput.StartIndex = 0;
            this.cmbFinishedProductCategoryInput.TabIndex = 23;
            this.cmbFinishedProductCategoryInput.SelectionChangeCommitted += new System.EventHandler(this.cmbFinishedProductCategoryInput_SelectionChangeCommitted);
            // 
            // lblFinishedTitle
            // 
            this.lblFinishedTitle.AutoSize = true;
            this.lblFinishedTitle.Location = new System.Drawing.Point(135, 22);
            this.lblFinishedTitle.Name = "lblFinishedTitle";
            this.lblFinishedTitle.Size = new System.Drawing.Size(209, 25);
            this.lblFinishedTitle.TabIndex = 1;
            this.lblFinishedTitle.Text = "Enter Finished Product";
            // 
            // rawMaterials
            // 
            this.rawMaterials.BackColor = System.Drawing.Color.LightGray;
            this.rawMaterials.Controls.Add(this.pnlRawMaterialShow);
            this.rawMaterials.Controls.Add(this.pnlRawMaterialInput);
            this.rawMaterials.ImageKey = "raw materials.png";
            this.rawMaterials.Location = new System.Drawing.Point(4, 53);
            this.rawMaterials.Name = "rawMaterials";
            this.rawMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.rawMaterials.Size = new System.Drawing.Size(1165, 660);
            this.rawMaterials.TabIndex = 0;
            this.rawMaterials.Text = "Raw Materials";
            // 
            // pnlRawMaterialShow
            // 
            this.pnlRawMaterialShow.BackColor = System.Drawing.Color.White;
            this.pnlRawMaterialShow.Controls.Add(this.dgvRawMaterialsShow);
            this.pnlRawMaterialShow.Controls.Add(this.pnlRawMaterialSearch);
            this.pnlRawMaterialShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRawMaterialShow.Location = new System.Drawing.Point(411, 3);
            this.pnlRawMaterialShow.Name = "pnlRawMaterialShow";
            this.pnlRawMaterialShow.Size = new System.Drawing.Size(751, 654);
            this.pnlRawMaterialShow.TabIndex = 1;
            // 
            // dgvRawMaterialsShow
            // 
            this.dgvRawMaterialsShow.AllowUserToAddRows = false;
            this.dgvRawMaterialsShow.AllowUserToDeleteRows = false;
            this.dgvRawMaterialsShow.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvRawMaterialsShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterialsShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductCategory,
            this.MaterialName,
            this.MaterialQuantity,
            this.MaterialCost,
            this.MaterialReceivedDate});
            this.dgvRawMaterialsShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRawMaterialsShow.GridColor = System.Drawing.Color.DimGray;
            this.dgvRawMaterialsShow.Location = new System.Drawing.Point(0, 52);
            this.dgvRawMaterialsShow.Name = "dgvRawMaterialsShow";
            this.dgvRawMaterialsShow.ReadOnly = true;
            this.dgvRawMaterialsShow.RowHeadersWidth = 51;
            this.dgvRawMaterialsShow.RowTemplate.Height = 24;
            this.dgvRawMaterialsShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMaterialsShow.Size = new System.Drawing.Size(751, 634);
            this.dgvRawMaterialsShow.TabIndex = 1;
            this.dgvRawMaterialsShow.DoubleClick += new System.EventHandler(this.dgvRawMaterialsShow_DoubleClick);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "RawId";
            this.ProductId.HeaderText = "Material Id";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 125;
            // 
            // ProductCategory
            // 
            this.ProductCategory.DataPropertyName = "RawCategory";
            this.ProductCategory.HeaderText = "Material Category";
            this.ProductCategory.MinimumWidth = 6;
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            this.ProductCategory.Width = 125;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "RawProductName";
            this.MaterialName.HeaderText = "Material Name";
            this.MaterialName.MinimumWidth = 6;
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            this.MaterialName.Width = 125;
            // 
            // MaterialQuantity
            // 
            this.MaterialQuantity.DataPropertyName = "RawQuantity";
            this.MaterialQuantity.HeaderText = "Material Quantity";
            this.MaterialQuantity.MinimumWidth = 6;
            this.MaterialQuantity.Name = "MaterialQuantity";
            this.MaterialQuantity.ReadOnly = true;
            this.MaterialQuantity.Width = 125;
            // 
            // MaterialCost
            // 
            this.MaterialCost.DataPropertyName = "RawCost";
            this.MaterialCost.HeaderText = "Material Cost";
            this.MaterialCost.MinimumWidth = 6;
            this.MaterialCost.Name = "MaterialCost";
            this.MaterialCost.ReadOnly = true;
            this.MaterialCost.Width = 125;
            // 
            // MaterialReceivedDate
            // 
            this.MaterialReceivedDate.DataPropertyName = "RawDate";
            this.MaterialReceivedDate.HeaderText = "Received Date";
            this.MaterialReceivedDate.MinimumWidth = 6;
            this.MaterialReceivedDate.Name = "MaterialReceivedDate";
            this.MaterialReceivedDate.ReadOnly = true;
            this.MaterialReceivedDate.Width = 125;
            // 
            // pnlRawMaterialSearch
            // 
            this.pnlRawMaterialSearch.Controls.Add(this.txtSearchRawMaterial);
            this.pnlRawMaterialSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRawMaterialSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlRawMaterialSearch.Name = "pnlRawMaterialSearch";
            this.pnlRawMaterialSearch.Size = new System.Drawing.Size(751, 52);
            this.pnlRawMaterialSearch.TabIndex = 0;
            // 
            // txtSearchRawMaterial
            // 
            this.txtSearchRawMaterial.AnimateReadOnly = false;
            this.txtSearchRawMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearchRawMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchRawMaterial.Depth = 0;
            this.txtSearchRawMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchRawMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRawMaterial.HideSelection = true;
            this.txtSearchRawMaterial.Hint = "Search raw materials by category name";
            this.txtSearchRawMaterial.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtSearchRawMaterial.LeadingIcon")));
            this.txtSearchRawMaterial.Location = new System.Drawing.Point(0, 0);
            this.txtSearchRawMaterial.MaxLength = 32767;
            this.txtSearchRawMaterial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchRawMaterial.Name = "txtSearchRawMaterial";
            this.txtSearchRawMaterial.PasswordChar = '\0';
            this.txtSearchRawMaterial.PrefixSuffixText = null;
            this.txtSearchRawMaterial.ReadOnly = false;
            this.txtSearchRawMaterial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchRawMaterial.SelectedText = "";
            this.txtSearchRawMaterial.SelectionLength = 0;
            this.txtSearchRawMaterial.SelectionStart = 0;
            this.txtSearchRawMaterial.ShortcutsEnabled = true;
            this.txtSearchRawMaterial.Size = new System.Drawing.Size(751, 48);
            this.txtSearchRawMaterial.TabIndex = 22;
            this.txtSearchRawMaterial.TabStop = false;
            this.txtSearchRawMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchRawMaterial.TrailingIcon = null;
            this.txtSearchRawMaterial.UseSystemPasswordChar = false;
            this.txtSearchRawMaterial.TextChanged += new System.EventHandler(this.txtSearchRawMaterial_TextChanged);
            // 
            // pnlRawMaterialInput
            // 
            this.pnlRawMaterialInput.BackColor = System.Drawing.Color.Snow;
            this.pnlRawMaterialInput.Controls.Add(this.btnManagerLogOut);
            this.pnlRawMaterialInput.Controls.Add(this.txtRawMaterialsId);
            this.pnlRawMaterialInput.Controls.Add(this.txtRawCostInput);
            this.pnlRawMaterialInput.Controls.Add(this.lblReceiveDate);
            this.pnlRawMaterialInput.Controls.Add(this.dtpRawMaterialReceiveDate);
            this.pnlRawMaterialInput.Controls.Add(this.btnDeleteRawMaterial);
            this.pnlRawMaterialInput.Controls.Add(this.switchTheme);
            this.pnlRawMaterialInput.Controls.Add(this.btnSaveRawMaterials);
            this.pnlRawMaterialInput.Controls.Add(this.txtRawQuantityInput);
            this.pnlRawMaterialInput.Controls.Add(this.cmbRawProductNameInput);
            this.pnlRawMaterialInput.Controls.Add(this.cmbRawMaterialsCategoryInput);
            this.pnlRawMaterialInput.Controls.Add(this.lblRawMaterial);
            this.pnlRawMaterialInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRawMaterialInput.Location = new System.Drawing.Point(3, 3);
            this.pnlRawMaterialInput.Name = "pnlRawMaterialInput";
            this.pnlRawMaterialInput.Size = new System.Drawing.Size(408, 654);
            this.pnlRawMaterialInput.TabIndex = 0;
            // 
            // btnManagerLogOut
            // 
            this.btnManagerLogOut.AutoSize = false;
            this.btnManagerLogOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManagerLogOut.BackColor = System.Drawing.Color.RosyBrown;
            this.btnManagerLogOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnManagerLogOut.Depth = 0;
            this.btnManagerLogOut.HighEmphasis = true;
            this.btnManagerLogOut.Icon = null;
            this.btnManagerLogOut.Location = new System.Drawing.Point(233, 516);
            this.btnManagerLogOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnManagerLogOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnManagerLogOut.Name = "btnManagerLogOut";
            this.btnManagerLogOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnManagerLogOut.Size = new System.Drawing.Size(109, 36);
            this.btnManagerLogOut.TabIndex = 34;
            this.btnManagerLogOut.Text = "LOG OUT";
            this.btnManagerLogOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnManagerLogOut.UseAccentColor = false;
            this.btnManagerLogOut.UseVisualStyleBackColor = false;
            this.btnManagerLogOut.Click += new System.EventHandler(this.btnManagerLogOut_Click);
            // 
            // txtRawMaterialsId
            // 
            this.txtRawMaterialsId.AnimateReadOnly = false;
            this.txtRawMaterialsId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRawMaterialsId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRawMaterialsId.Depth = 0;
            this.txtRawMaterialsId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRawMaterialsId.HideSelection = true;
            this.txtRawMaterialsId.Hint = "Automated Product Id";
            this.txtRawMaterialsId.LeadingIcon = null;
            this.txtRawMaterialsId.Location = new System.Drawing.Point(49, 76);
            this.txtRawMaterialsId.MaxLength = 32767;
            this.txtRawMaterialsId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRawMaterialsId.Name = "txtRawMaterialsId";
            this.txtRawMaterialsId.PasswordChar = '\0';
            this.txtRawMaterialsId.PrefixSuffixText = null;
            this.txtRawMaterialsId.ReadOnly = true;
            this.txtRawMaterialsId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRawMaterialsId.SelectedText = "";
            this.txtRawMaterialsId.SelectionLength = 0;
            this.txtRawMaterialsId.SelectionStart = 0;
            this.txtRawMaterialsId.ShortcutsEnabled = true;
            this.txtRawMaterialsId.Size = new System.Drawing.Size(161, 48);
            this.txtRawMaterialsId.TabIndex = 22;
            this.txtRawMaterialsId.TabStop = false;
            this.txtRawMaterialsId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRawMaterialsId.TrailingIcon = null;
            this.txtRawMaterialsId.UseSystemPasswordChar = false;
            // 
            // txtRawCostInput
            // 
            this.txtRawCostInput.AnimateReadOnly = false;
            this.txtRawCostInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRawCostInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRawCostInput.Depth = 0;
            this.txtRawCostInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRawCostInput.HideSelection = true;
            this.txtRawCostInput.Hint = "Total Cost";
            this.txtRawCostInput.LeadingIcon = null;
            this.txtRawCostInput.Location = new System.Drawing.Point(49, 363);
            this.txtRawCostInput.MaxLength = 32767;
            this.txtRawCostInput.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRawCostInput.Name = "txtRawCostInput";
            this.txtRawCostInput.PasswordChar = '\0';
            this.txtRawCostInput.PrefixSuffixText = null;
            this.txtRawCostInput.ReadOnly = false;
            this.txtRawCostInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRawCostInput.SelectedText = "";
            this.txtRawCostInput.SelectionLength = 0;
            this.txtRawCostInput.SelectionStart = 0;
            this.txtRawCostInput.ShortcutsEnabled = true;
            this.txtRawCostInput.Size = new System.Drawing.Size(161, 48);
            this.txtRawCostInput.TabIndex = 2;
            this.txtRawCostInput.TabStop = false;
            this.txtRawCostInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRawCostInput.TrailingIcon = null;
            this.txtRawCostInput.UseSystemPasswordChar = false;
            // 
            // lblReceiveDate
            // 
            this.lblReceiveDate.AutoSize = true;
            this.lblReceiveDate.Location = new System.Drawing.Point(43, 438);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(128, 25);
            this.lblReceiveDate.TabIndex = 15;
            this.lblReceiveDate.Text = "Receive Date";
            // 
            // dtpRawMaterialReceiveDate
            // 
            this.dtpRawMaterialReceiveDate.CustomFormat = "";
            this.dtpRawMaterialReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRawMaterialReceiveDate.Location = new System.Drawing.Point(178, 438);
            this.dtpRawMaterialReceiveDate.Name = "dtpRawMaterialReceiveDate";
            this.dtpRawMaterialReceiveDate.Size = new System.Drawing.Size(164, 30);
            this.dtpRawMaterialReceiveDate.TabIndex = 18;
            // 
            // btnDeleteRawMaterial
            // 
            this.btnDeleteRawMaterial.AutoSize = false;
            this.btnDeleteRawMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteRawMaterial.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDeleteRawMaterial.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteRawMaterial.Depth = 0;
            this.btnDeleteRawMaterial.HighEmphasis = true;
            this.btnDeleteRawMaterial.Icon = null;
            this.btnDeleteRawMaterial.Location = new System.Drawing.Point(137, 516);
            this.btnDeleteRawMaterial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteRawMaterial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteRawMaterial.Name = "btnDeleteRawMaterial";
            this.btnDeleteRawMaterial.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteRawMaterial.Size = new System.Drawing.Size(73, 36);
            this.btnDeleteRawMaterial.TabIndex = 20;
            this.btnDeleteRawMaterial.Text = "DELETE";
            this.btnDeleteRawMaterial.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteRawMaterial.UseAccentColor = false;
            this.btnDeleteRawMaterial.UseVisualStyleBackColor = false;
            this.btnDeleteRawMaterial.Click += new System.EventHandler(this.btnDeleteRawMaterial_Click);
            // 
            // switchTheme
            // 
            this.switchTheme.BackColor = System.Drawing.Color.Transparent;
            this.switchTheme.Depth = 0;
            this.switchTheme.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.switchTheme.Location = new System.Drawing.Point(0, 611);
            this.switchTheme.Margin = new System.Windows.Forms.Padding(0);
            this.switchTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchTheme.Name = "switchTheme";
            this.switchTheme.Ripple = true;
            this.switchTheme.Size = new System.Drawing.Size(408, 43);
            this.switchTheme.TabIndex = 21;
            this.switchTheme.Text = "Dark Mode";
            this.switchTheme.UseVisualStyleBackColor = false;
            this.switchTheme.CheckedChanged += new System.EventHandler(this.switchTheme_CheckedChanged);
            // 
            // btnSaveRawMaterials
            // 
            this.btnSaveRawMaterials.AutoSize = false;
            this.btnSaveRawMaterials.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveRawMaterials.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveRawMaterials.Depth = 0;
            this.btnSaveRawMaterials.HighEmphasis = true;
            this.btnSaveRawMaterials.Icon = null;
            this.btnSaveRawMaterials.Location = new System.Drawing.Point(49, 516);
            this.btnSaveRawMaterials.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveRawMaterials.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveRawMaterials.Name = "btnSaveRawMaterials";
            this.btnSaveRawMaterials.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveRawMaterials.Size = new System.Drawing.Size(64, 36);
            this.btnSaveRawMaterials.TabIndex = 19;
            this.btnSaveRawMaterials.Text = "SAVE";
            this.btnSaveRawMaterials.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveRawMaterials.UseAccentColor = false;
            this.btnSaveRawMaterials.UseVisualStyleBackColor = true;
            this.btnSaveRawMaterials.Click += new System.EventHandler(this.btnSaveRawMaterials_Click);
            // 
            // txtRawQuantityInput
            // 
            this.txtRawQuantityInput.AnimateReadOnly = false;
            this.txtRawQuantityInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRawQuantityInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRawQuantityInput.Depth = 0;
            this.txtRawQuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRawQuantityInput.HideSelection = true;
            this.txtRawQuantityInput.Hint = "Enter quantity";
            this.txtRawQuantityInput.LeadingIcon = null;
            this.txtRawQuantityInput.Location = new System.Drawing.Point(49, 289);
            this.txtRawQuantityInput.MaxLength = 32767;
            this.txtRawQuantityInput.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRawQuantityInput.Name = "txtRawQuantityInput";
            this.txtRawQuantityInput.PasswordChar = '\0';
            this.txtRawQuantityInput.PrefixSuffixText = null;
            this.txtRawQuantityInput.ReadOnly = false;
            this.txtRawQuantityInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRawQuantityInput.SelectedText = "";
            this.txtRawQuantityInput.SelectionLength = 0;
            this.txtRawQuantityInput.SelectionStart = 0;
            this.txtRawQuantityInput.ShortcutsEnabled = true;
            this.txtRawQuantityInput.Size = new System.Drawing.Size(161, 48);
            this.txtRawQuantityInput.TabIndex = 1;
            this.txtRawQuantityInput.TabStop = false;
            this.txtRawQuantityInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRawQuantityInput.TrailingIcon = null;
            this.txtRawQuantityInput.UseSystemPasswordChar = false;
            // 
            // cmbRawProductNameInput
            // 
            this.cmbRawProductNameInput.AutoResize = false;
            this.cmbRawProductNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRawProductNameInput.Depth = 0;
            this.cmbRawProductNameInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRawProductNameInput.DropDownHeight = 174;
            this.cmbRawProductNameInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRawProductNameInput.DropDownWidth = 121;
            this.cmbRawProductNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRawProductNameInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbRawProductNameInput.FormattingEnabled = true;
            this.cmbRawProductNameInput.Hint = "Choose Product";
            this.cmbRawProductNameInput.IntegralHeight = false;
            this.cmbRawProductNameInput.ItemHeight = 43;
            this.cmbRawProductNameInput.Items.AddRange(new object[] {
            "None"});
            this.cmbRawProductNameInput.Location = new System.Drawing.Point(49, 221);
            this.cmbRawProductNameInput.MaxDropDownItems = 4;
            this.cmbRawProductNameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRawProductNameInput.Name = "cmbRawProductNameInput";
            this.cmbRawProductNameInput.Size = new System.Drawing.Size(161, 49);
            this.cmbRawProductNameInput.StartIndex = 0;
            this.cmbRawProductNameInput.TabIndex = 3;
            // 
            // cmbRawMaterialsCategoryInput
            // 
            this.cmbRawMaterialsCategoryInput.AutoResize = false;
            this.cmbRawMaterialsCategoryInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbRawMaterialsCategoryInput.Depth = 0;
            this.cmbRawMaterialsCategoryInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbRawMaterialsCategoryInput.DropDownHeight = 432;
            this.cmbRawMaterialsCategoryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRawMaterialsCategoryInput.DropDownWidth = 121;
            this.cmbRawMaterialsCategoryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbRawMaterialsCategoryInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbRawMaterialsCategoryInput.FormattingEnabled = true;
            this.cmbRawMaterialsCategoryInput.Hint = "Choose Category";
            this.cmbRawMaterialsCategoryInput.IntegralHeight = false;
            this.cmbRawMaterialsCategoryInput.ItemHeight = 43;
            this.cmbRawMaterialsCategoryInput.Items.AddRange(new object[] {
            "None"});
            this.cmbRawMaterialsCategoryInput.Location = new System.Drawing.Point(49, 148);
            this.cmbRawMaterialsCategoryInput.MaxDropDownItems = 10;
            this.cmbRawMaterialsCategoryInput.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRawMaterialsCategoryInput.Name = "cmbRawMaterialsCategoryInput";
            this.cmbRawMaterialsCategoryInput.Size = new System.Drawing.Size(161, 49);
            this.cmbRawMaterialsCategoryInput.StartIndex = 0;
            this.cmbRawMaterialsCategoryInput.TabIndex = 0;
            this.cmbRawMaterialsCategoryInput.SelectionChangeCommitted += new System.EventHandler(this.cmbRawMaterialsCategoryInput_SelectionChangeCommitted);
            // 
            // lblRawMaterial
            // 
            this.lblRawMaterial.AutoSize = true;
            this.lblRawMaterial.Location = new System.Drawing.Point(131, 17);
            this.lblRawMaterial.Name = "lblRawMaterial";
            this.lblRawMaterial.Size = new System.Drawing.Size(185, 25);
            this.lblRawMaterial.TabIndex = 0;
            this.lblRawMaterial.Text = "Enter Raw Materials";
            // 
            // tabWarehouseManager
            // 
            this.tabWarehouseManager.Controls.Add(this.rawMaterials);
            this.tabWarehouseManager.Controls.Add(this.finishedProduct);
            this.tabWarehouseManager.Depth = 0;
            this.tabWarehouseManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWarehouseManager.ImageList = this.imgWarehouseImage;
            this.tabWarehouseManager.Location = new System.Drawing.Point(3, 64);
            this.tabWarehouseManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabWarehouseManager.Multiline = true;
            this.tabWarehouseManager.Name = "tabWarehouseManager";
            this.tabWarehouseManager.Padding = new System.Drawing.Point(10, 10);
            this.tabWarehouseManager.SelectedIndex = 0;
            this.tabWarehouseManager.Size = new System.Drawing.Size(1173, 717);
            this.tabWarehouseManager.TabIndex = 0;
            // 
            // FormWarehouseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 784);
            this.Controls.Add(this.tabWarehouseManager);
            this.Controls.Add(this.pnlWarehouse);
            this.DrawerTabControl = this.tabWarehouseManager;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.MaximizeBox = false;
            this.Name = "FormWarehouseManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Warehouse Manager ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWarehouseManager_FormClosed);
            this.Load += new System.EventHandler(this.FormWarehouseManager_Load);
            this.finishedProduct.ResumeLayout(false);
            this.pnlFinishedProductShow.ResumeLayout(false);
            this.pnlFinishedProductSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinishedProductShow)).EndInit();
            this.pnlFinishedProductInput.ResumeLayout(false);
            this.pnlFinishedProductInput.PerformLayout();
            this.rawMaterials.ResumeLayout(false);
            this.pnlRawMaterialShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterialsShow)).EndInit();
            this.pnlRawMaterialSearch.ResumeLayout(false);
            this.pnlRawMaterialInput.ResumeLayout(false);
            this.pnlRawMaterialInput.PerformLayout();
            this.tabWarehouseManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWarehouse;
        private System.Windows.Forms.ImageList imgWarehouseImage;
        private System.Windows.Forms.TabPage finishedProduct;
        private System.Windows.Forms.Panel pnlFinishedProductShow;
        private System.Windows.Forms.Panel pnlFinishedProductSearch;
        private MaterialSkin.Controls.MaterialTextBox2 txtFinishedProductSearch;
        private System.Windows.Forms.DataGridView dgvFinishedProductShow;
        private System.Windows.Forms.Panel pnlFinishedProductInput;
        private System.Windows.Forms.Label lblFinishedTitle;
        private System.Windows.Forms.TabPage rawMaterials;
        private System.Windows.Forms.Panel pnlRawMaterialShow;
        private System.Windows.Forms.DataGridView dgvRawMaterialsShow;
        private System.Windows.Forms.Panel pnlRawMaterialSearch;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearchRawMaterial;
        private System.Windows.Forms.Panel pnlRawMaterialInput;
        private MaterialSkin.Controls.MaterialTextBox2 txtRawMaterialsId;
        private MaterialSkin.Controls.MaterialTextBox2 txtRawCostInput;
        private System.Windows.Forms.Label lblReceiveDate;
        private System.Windows.Forms.DateTimePicker dtpRawMaterialReceiveDate;
        private MaterialSkin.Controls.MaterialButton btnDeleteRawMaterial;
        private MaterialSkin.Controls.MaterialSwitch switchTheme;
        private MaterialSkin.Controls.MaterialButton btnSaveRawMaterials;
        private MaterialSkin.Controls.MaterialTextBox2 txtRawQuantityInput;
        private MaterialSkin.Controls.MaterialComboBox cmbRawProductNameInput;
        private MaterialSkin.Controls.MaterialComboBox cmbRawMaterialsCategoryInput;
        private System.Windows.Forms.Label lblRawMaterial;
        private MaterialSkin.Controls.MaterialTabControl tabWarehouseManager;
        private System.Windows.Forms.Label lblManufacturedDate;
        private System.Windows.Forms.DateTimePicker dtpManufacturedDateInput;
        private MaterialSkin.Controls.MaterialButton btnFinishedProductDelete;
        private MaterialSkin.Controls.MaterialButton btnFinishedProductSave;
        private MaterialSkin.Controls.MaterialTextBox2 txtFinishedProductId;
        private MaterialSkin.Controls.MaterialTextBox2 txtFinishedProductCostInput;
        private MaterialSkin.Controls.MaterialTextBox2 txtFinishedProductQuantityInput;
        private MaterialSkin.Controls.MaterialComboBox cmbFinishedProductNameInput;
        private MaterialSkin.Controls.MaterialComboBox cmbFinishedProductCategoryInput;
        private MaterialSkin.Controls.MaterialButton btnManagerLogOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialReceivedDate;
    }
}