namespace GarmentsManagementSystem
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.printInvoiceDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewInvoice = new System.Windows.Forms.PrintPreviewDialog();
            this.printFinishedDocument = new System.Drawing.Printing.PrintDocument();
            this.printFinishedPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.FinishedProduct = new System.Windows.Forms.TabPage();
            this.pnlFinishedProductData = new System.Windows.Forms.Panel();
            this.dgvFinishedProductShow = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManufacturedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFinishedProductSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlFinishedProductShow = new System.Windows.Forms.Panel();
            this.btnPrintFinishedProduct = new MaterialSkin.Controls.MaterialButton();
            this.btnFinishedProductDelete = new MaterialSkin.Controls.MaterialButton();
            this.btnFinishedProductSave = new MaterialSkin.Controls.MaterialButton();
            this.lblManufacturedDate = new System.Windows.Forms.Label();
            this.dtpManufacturedDateInput = new System.Windows.Forms.DateTimePicker();
            this.txtFinishedProductId = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFinishedProductCostInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFinishedProductQuantityInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbFinishedProductNameInput = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbFinishedProductCategoryInput = new MaterialSkin.Controls.MaterialComboBox();
            this.lblFinishedTitle = new System.Windows.Forms.Label();
            this.RawMaterials = new System.Windows.Forms.TabPage();
            this.dgvRawMaterialsShow = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRawMaterialsShow = new System.Windows.Forms.Panel();
            this.pnlAdminRawMaterial = new System.Windows.Forms.Panel();
            this.txtSearchRawMaterial = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlRawMaterialInput = new System.Windows.Forms.Panel();
            this.btnPrintRawMaterialInvoice = new MaterialSkin.Controls.MaterialButton();
            this.btnDeleteRawMaterial = new MaterialSkin.Controls.MaterialButton();
            this.txtRawMaterialsId = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRawCostInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblReceiveDate = new System.Windows.Forms.Label();
            this.dtpRawMaterialReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.btnSaveRawMaterials = new MaterialSkin.Controls.MaterialButton();
            this.txtRawQuantityInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbRawProductNameInput = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbRawMaterialsCategoryInput = new MaterialSkin.Controls.MaterialComboBox();
            this.lblRawMaterial = new System.Windows.Forms.Label();
            this.EmployeeAdd = new System.Windows.Forms.TabPage();
            this.txtSearchEmployee = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlEmployeeInput = new System.Windows.Forms.Panel();
            this.lblPasswordReset = new System.Windows.Forms.Label();
            this.btnLogOutAdmin = new MaterialSkin.Controls.MaterialButton();
            this.switchThemeChangeEmployee = new MaterialSkin.Controls.MaterialSwitch();
            this.btnDeleteEmployeeInfo = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveEmployeeInfo = new MaterialSkin.Controls.MaterialButton();
            this.lblEmployeeInput = new System.Windows.Forms.Label();
            this.pnlEmployeeGender = new System.Windows.Forms.Panel();
            this.lblEmployeeGender = new System.Windows.Forms.Label();
            this.rdbEmployeeFemale = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbEmployeeMale = new MaterialSkin.Controls.MaterialRadioButton();
            this.cmbEmployeeRole = new MaterialSkin.Controls.MaterialComboBox();
            this.txtEmployeeAddress = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.dtpJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmployeeSalary = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtEmployeePassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtEmployeeName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtEmployeeId = new MaterialSkin.Controls.MaterialTextBox2();
            this.pnlEmployeeShow = new System.Windows.Forms.Panel();
            this.dgvEmployeeInformationShow = new System.Windows.Forms.DataGridView();
            this.M_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Joining_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEmployeeInformation = new MaterialSkin.Controls.MaterialTabControl();
            this.FinishedProduct.SuspendLayout();
            this.pnlFinishedProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinishedProductShow)).BeginInit();
            this.pnlFinishedProductShow.SuspendLayout();
            this.RawMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterialsShow)).BeginInit();
            this.pnlAdminRawMaterial.SuspendLayout();
            this.pnlRawMaterialInput.SuspendLayout();
            this.EmployeeAdd.SuspendLayout();
            this.pnlEmployeeInput.SuspendLayout();
            this.pnlEmployeeGender.SuspendLayout();
            this.pnlEmployeeShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInformationShow)).BeginInit();
            this.tabEmployeeInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "employee.png");
            this.imageList1.Images.SetKeyName(2, "raw materials.png");
            this.imageList1.Images.SetKeyName(3, "finished product.png");
            // 
            // printInvoiceDocument
            // 
            this.printInvoiceDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInvoiceDocument_PrintPage);
            // 
            // printPreviewInvoice
            // 
            this.printPreviewInvoice.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewInvoice.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewInvoice.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewInvoice.Enabled = true;
            this.printPreviewInvoice.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewInvoice.Icon")));
            this.printPreviewInvoice.Name = "printPreviewInvoice";
            this.printPreviewInvoice.Visible = false;
            // 
            // printFinishedDocument
            // 
            this.printFinishedDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printFinishedDocument_PrintPage);
            // 
            // printFinishedPreviewDialog
            // 
            this.printFinishedPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printFinishedPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printFinishedPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printFinishedPreviewDialog.Enabled = true;
            this.printFinishedPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printFinishedPreviewDialog.Icon")));
            this.printFinishedPreviewDialog.Name = "printFinishedPreviewDialog";
            this.printFinishedPreviewDialog.Visible = false;
            // 
            // FinishedProduct
            // 
            this.FinishedProduct.BackColor = System.Drawing.Color.White;
            this.FinishedProduct.Controls.Add(this.pnlFinishedProductData);
            this.FinishedProduct.Controls.Add(this.pnlFinishedProductShow);
            this.FinishedProduct.ImageKey = "finished product.png";
            this.FinishedProduct.Location = new System.Drawing.Point(4, 53);
            this.FinishedProduct.Name = "FinishedProduct";
            this.FinishedProduct.Size = new System.Drawing.Size(1414, 776);
            this.FinishedProduct.TabIndex = 2;
            this.FinishedProduct.Text = "Finished Product";
            // 
            // pnlFinishedProductData
            // 
            this.pnlFinishedProductData.Controls.Add(this.dgvFinishedProductShow);
            this.pnlFinishedProductData.Controls.Add(this.txtFinishedProductSearch);
            this.pnlFinishedProductData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFinishedProductData.Location = new System.Drawing.Point(420, 0);
            this.pnlFinishedProductData.Name = "pnlFinishedProductData";
            this.pnlFinishedProductData.Size = new System.Drawing.Size(994, 776);
            this.pnlFinishedProductData.TabIndex = 1;
            // 
            // dgvFinishedProductShow
            // 
            this.dgvFinishedProductShow.AllowUserToAddRows = false;
            this.dgvFinishedProductShow.AllowUserToDeleteRows = false;
            this.dgvFinishedProductShow.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvFinishedProductShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinishedProductShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Category,
            this.ProductName,
            this.Quantity,
            this.TotalCost,
            this.ManufacturedDate});
            this.dgvFinishedProductShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFinishedProductShow.GridColor = System.Drawing.Color.DimGray;
            this.dgvFinishedProductShow.Location = new System.Drawing.Point(0, 48);
            this.dgvFinishedProductShow.Name = "dgvFinishedProductShow";
            this.dgvFinishedProductShow.ReadOnly = true;
            this.dgvFinishedProductShow.RowHeadersWidth = 51;
            this.dgvFinishedProductShow.RowTemplate.Height = 24;
            this.dgvFinishedProductShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinishedProductShow.Size = new System.Drawing.Size(994, 728);
            this.dgvFinishedProductShow.TabIndex = 18;
            this.dgvFinishedProductShow.DoubleClick += new System.EventHandler(this.dgvFinishedProductShow_DoubleClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FinishedProductId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "FinishedCatagory";
            this.Category.HeaderText = "Product Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 200;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "FinishedProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "FinishedQuantity";
            this.Quantity.HeaderText = "Product Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
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
            // txtFinishedProductSearch
            // 
            this.txtFinishedProductSearch.AnimateReadOnly = false;
            this.txtFinishedProductSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFinishedProductSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFinishedProductSearch.Depth = 0;
            this.txtFinishedProductSearch.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.txtFinishedProductSearch.Size = new System.Drawing.Size(994, 48);
            this.txtFinishedProductSearch.TabIndex = 17;
            this.txtFinishedProductSearch.TabStop = false;
            this.txtFinishedProductSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFinishedProductSearch.TrailingIcon = null;
            this.txtFinishedProductSearch.UseSystemPasswordChar = false;
            this.txtFinishedProductSearch.TextChanged += new System.EventHandler(this.txtFinishedProductSearch_TextChanged);
            // 
            // pnlFinishedProductShow
            // 
            this.pnlFinishedProductShow.BackColor = System.Drawing.Color.Snow;
            this.pnlFinishedProductShow.Controls.Add(this.btnPrintFinishedProduct);
            this.pnlFinishedProductShow.Controls.Add(this.btnFinishedProductDelete);
            this.pnlFinishedProductShow.Controls.Add(this.btnFinishedProductSave);
            this.pnlFinishedProductShow.Controls.Add(this.lblManufacturedDate);
            this.pnlFinishedProductShow.Controls.Add(this.dtpManufacturedDateInput);
            this.pnlFinishedProductShow.Controls.Add(this.txtFinishedProductId);
            this.pnlFinishedProductShow.Controls.Add(this.txtFinishedProductCostInput);
            this.pnlFinishedProductShow.Controls.Add(this.txtFinishedProductQuantityInput);
            this.pnlFinishedProductShow.Controls.Add(this.cmbFinishedProductNameInput);
            this.pnlFinishedProductShow.Controls.Add(this.cmbFinishedProductCategoryInput);
            this.pnlFinishedProductShow.Controls.Add(this.lblFinishedTitle);
            this.pnlFinishedProductShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFinishedProductShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFinishedProductShow.Location = new System.Drawing.Point(0, 0);
            this.pnlFinishedProductShow.Name = "pnlFinishedProductShow";
            this.pnlFinishedProductShow.Size = new System.Drawing.Size(420, 776);
            this.pnlFinishedProductShow.TabIndex = 0;
            // 
            // btnPrintFinishedProduct
            // 
            this.btnPrintFinishedProduct.AutoSize = false;
            this.btnPrintFinishedProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintFinishedProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintFinishedProduct.Depth = 0;
            this.btnPrintFinishedProduct.HighEmphasis = true;
            this.btnPrintFinishedProduct.Icon = null;
            this.btnPrintFinishedProduct.Location = new System.Drawing.Point(261, 518);
            this.btnPrintFinishedProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintFinishedProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintFinishedProduct.Name = "btnPrintFinishedProduct";
            this.btnPrintFinishedProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintFinishedProduct.Size = new System.Drawing.Size(75, 36);
            this.btnPrintFinishedProduct.TabIndex = 46;
            this.btnPrintFinishedProduct.Text = "PRINT";
            this.btnPrintFinishedProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintFinishedProduct.UseAccentColor = false;
            this.btnPrintFinishedProduct.UseVisualStyleBackColor = true;
            this.btnPrintFinishedProduct.Click += new System.EventHandler(this.btnPrintFinishedProduct_Click);
            // 
            // btnFinishedProductDelete
            // 
            this.btnFinishedProductDelete.AutoSize = false;
            this.btnFinishedProductDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinishedProductDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinishedProductDelete.Depth = 0;
            this.btnFinishedProductDelete.HighEmphasis = true;
            this.btnFinishedProductDelete.Icon = null;
            this.btnFinishedProductDelete.Location = new System.Drawing.Point(153, 518);
            this.btnFinishedProductDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinishedProductDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinishedProductDelete.Name = "btnFinishedProductDelete";
            this.btnFinishedProductDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinishedProductDelete.Size = new System.Drawing.Size(84, 36);
            this.btnFinishedProductDelete.TabIndex = 45;
            this.btnFinishedProductDelete.Text = "DELETE";
            this.btnFinishedProductDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinishedProductDelete.UseAccentColor = false;
            this.btnFinishedProductDelete.UseVisualStyleBackColor = true;
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
            this.btnFinishedProductSave.Location = new System.Drawing.Point(58, 518);
            this.btnFinishedProductSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinishedProductSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinishedProductSave.Name = "btnFinishedProductSave";
            this.btnFinishedProductSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinishedProductSave.Size = new System.Drawing.Size(75, 36);
            this.btnFinishedProductSave.TabIndex = 44;
            this.btnFinishedProductSave.Text = "SAVE";
            this.btnFinishedProductSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinishedProductSave.UseAccentColor = false;
            this.btnFinishedProductSave.UseVisualStyleBackColor = true;
            this.btnFinishedProductSave.Click += new System.EventHandler(this.btnFinishedProductSave_Click);
            // 
            // lblManufacturedDate
            // 
            this.lblManufacturedDate.AutoSize = true;
            this.lblManufacturedDate.Location = new System.Drawing.Point(52, 471);
            this.lblManufacturedDate.Name = "lblManufacturedDate";
            this.lblManufacturedDate.Size = new System.Drawing.Size(152, 20);
            this.lblManufacturedDate.TabIndex = 39;
            this.lblManufacturedDate.Text = "Manufactured Date";
            // 
            // dtpManufacturedDateInput
            // 
            this.dtpManufacturedDateInput.CustomFormat = "";
            this.dtpManufacturedDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpManufacturedDateInput.Location = new System.Drawing.Point(229, 471);
            this.dtpManufacturedDateInput.Name = "dtpManufacturedDateInput";
            this.dtpManufacturedDateInput.Size = new System.Drawing.Size(167, 27);
            this.dtpManufacturedDateInput.TabIndex = 40;
            // 
            // txtFinishedProductId
            // 
            this.txtFinishedProductId.AnimateReadOnly = false;
            this.txtFinishedProductId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFinishedProductId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFinishedProductId.Depth = 0;
            this.txtFinishedProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFinishedProductId.HideSelection = true;
            this.txtFinishedProductId.Hint = "Automated Product Id";
            this.txtFinishedProductId.LeadingIcon = null;
            this.txtFinishedProductId.Location = new System.Drawing.Point(58, 110);
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
            this.txtFinishedProductId.Size = new System.Drawing.Size(179, 48);
            this.txtFinishedProductId.TabIndex = 38;
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
            this.txtFinishedProductCostInput.Location = new System.Drawing.Point(58, 397);
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
            this.txtFinishedProductCostInput.Size = new System.Drawing.Size(179, 48);
            this.txtFinishedProductCostInput.TabIndex = 36;
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
            this.txtFinishedProductQuantityInput.Location = new System.Drawing.Point(58, 323);
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
            this.txtFinishedProductQuantityInput.Size = new System.Drawing.Size(179, 48);
            this.txtFinishedProductQuantityInput.TabIndex = 35;
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
            this.cmbFinishedProductNameInput.Location = new System.Drawing.Point(58, 255);
            this.cmbFinishedProductNameInput.MaxDropDownItems = 4;
            this.cmbFinishedProductNameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbFinishedProductNameInput.Name = "cmbFinishedProductNameInput";
            this.cmbFinishedProductNameInput.Size = new System.Drawing.Size(179, 49);
            this.cmbFinishedProductNameInput.StartIndex = 0;
            this.cmbFinishedProductNameInput.TabIndex = 37;
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
            this.cmbFinishedProductCategoryInput.Location = new System.Drawing.Point(58, 182);
            this.cmbFinishedProductCategoryInput.MaxDropDownItems = 10;
            this.cmbFinishedProductCategoryInput.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbFinishedProductCategoryInput.Name = "cmbFinishedProductCategoryInput";
            this.cmbFinishedProductCategoryInput.Size = new System.Drawing.Size(179, 49);
            this.cmbFinishedProductCategoryInput.StartIndex = 0;
            this.cmbFinishedProductCategoryInput.TabIndex = 34;
            this.cmbFinishedProductCategoryInput.SelectionChangeCommitted += new System.EventHandler(this.cmbFinishedProductCategoryInput_SelectionChangeCommitted_1);
            // 
            // lblFinishedTitle
            // 
            this.lblFinishedTitle.AutoSize = true;
            this.lblFinishedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishedTitle.Location = new System.Drawing.Point(124, 28);
            this.lblFinishedTitle.Name = "lblFinishedTitle";
            this.lblFinishedTitle.Size = new System.Drawing.Size(258, 29);
            this.lblFinishedTitle.TabIndex = 33;
            this.lblFinishedTitle.Text = "Enter Finished Product";
            // 
            // RawMaterials
            // 
            this.RawMaterials.Controls.Add(this.dgvRawMaterialsShow);
            this.RawMaterials.Controls.Add(this.pnlRawMaterialsShow);
            this.RawMaterials.Controls.Add(this.pnlAdminRawMaterial);
            this.RawMaterials.Controls.Add(this.pnlRawMaterialInput);
            this.RawMaterials.ImageKey = "raw materials.png";
            this.RawMaterials.Location = new System.Drawing.Point(4, 53);
            this.RawMaterials.Name = "RawMaterials";
            this.RawMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.RawMaterials.Size = new System.Drawing.Size(1414, 776);
            this.RawMaterials.TabIndex = 1;
            this.RawMaterials.Text = "Raw Materials";
            this.RawMaterials.UseVisualStyleBackColor = true;
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
            this.dgvRawMaterialsShow.Location = new System.Drawing.Point(396, 58);
            this.dgvRawMaterialsShow.Name = "dgvRawMaterialsShow";
            this.dgvRawMaterialsShow.ReadOnly = true;
            this.dgvRawMaterialsShow.RowHeadersWidth = 51;
            this.dgvRawMaterialsShow.RowTemplate.Height = 24;
            this.dgvRawMaterialsShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMaterialsShow.Size = new System.Drawing.Size(1015, 710);
            this.dgvRawMaterialsShow.TabIndex = 2;
            this.dgvRawMaterialsShow.DoubleClick += new System.EventHandler(this.dgvRawMaterialsShow_DoubleClick);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "RawId";
            this.ProductId.HeaderText = "Material Id";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 150;
            // 
            // ProductCategory
            // 
            this.ProductCategory.DataPropertyName = "RawCategory";
            this.ProductCategory.HeaderText = "Material Category";
            this.ProductCategory.MinimumWidth = 6;
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            this.ProductCategory.Width = 160;
            // 
            // MaterialName
            // 
            this.MaterialName.DataPropertyName = "RawProductName";
            this.MaterialName.HeaderText = "Material Name";
            this.MaterialName.MinimumWidth = 6;
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            this.MaterialName.Width = 160;
            // 
            // MaterialQuantity
            // 
            this.MaterialQuantity.DataPropertyName = "RawQuantity";
            this.MaterialQuantity.HeaderText = "Material Quantity";
            this.MaterialQuantity.MinimumWidth = 6;
            this.MaterialQuantity.Name = "MaterialQuantity";
            this.MaterialQuantity.ReadOnly = true;
            this.MaterialQuantity.Width = 170;
            // 
            // MaterialCost
            // 
            this.MaterialCost.DataPropertyName = "RawCost";
            this.MaterialCost.HeaderText = "Material Cost";
            this.MaterialCost.MinimumWidth = 6;
            this.MaterialCost.Name = "MaterialCost";
            this.MaterialCost.ReadOnly = true;
            this.MaterialCost.Width = 150;
            // 
            // MaterialReceivedDate
            // 
            this.MaterialReceivedDate.DataPropertyName = "RawDate";
            this.MaterialReceivedDate.HeaderText = "Received Date";
            this.MaterialReceivedDate.MinimumWidth = 6;
            this.MaterialReceivedDate.Name = "MaterialReceivedDate";
            this.MaterialReceivedDate.ReadOnly = true;
            this.MaterialReceivedDate.Width = 170;
            // 
            // pnlRawMaterialsShow
            // 
            this.pnlRawMaterialsShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRawMaterialsShow.Location = new System.Drawing.Point(396, 110);
            this.pnlRawMaterialsShow.Name = "pnlRawMaterialsShow";
            this.pnlRawMaterialsShow.Size = new System.Drawing.Size(1015, 663);
            this.pnlRawMaterialsShow.TabIndex = 3;
            // 
            // pnlAdminRawMaterial
            // 
            this.pnlAdminRawMaterial.BackColor = System.Drawing.Color.White;
            this.pnlAdminRawMaterial.Controls.Add(this.txtSearchRawMaterial);
            this.pnlAdminRawMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdminRawMaterial.Location = new System.Drawing.Point(396, 3);
            this.pnlAdminRawMaterial.Name = "pnlAdminRawMaterial";
            this.pnlAdminRawMaterial.Size = new System.Drawing.Size(1015, 55);
            this.pnlAdminRawMaterial.TabIndex = 2;
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
            this.txtSearchRawMaterial.Size = new System.Drawing.Size(1015, 48);
            this.txtSearchRawMaterial.TabIndex = 23;
            this.txtSearchRawMaterial.TabStop = false;
            this.txtSearchRawMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchRawMaterial.TrailingIcon = null;
            this.txtSearchRawMaterial.UseSystemPasswordChar = false;
            this.txtSearchRawMaterial.TextChanged += new System.EventHandler(this.txtSearchRawMaterial_TextChanged);
            // 
            // pnlRawMaterialInput
            // 
            this.pnlRawMaterialInput.BackColor = System.Drawing.Color.Snow;
            this.pnlRawMaterialInput.Controls.Add(this.btnPrintRawMaterialInvoice);
            this.pnlRawMaterialInput.Controls.Add(this.btnDeleteRawMaterial);
            this.pnlRawMaterialInput.Controls.Add(this.txtRawMaterialsId);
            this.pnlRawMaterialInput.Controls.Add(this.txtRawCostInput);
            this.pnlRawMaterialInput.Controls.Add(this.lblReceiveDate);
            this.pnlRawMaterialInput.Controls.Add(this.dtpRawMaterialReceiveDate);
            this.pnlRawMaterialInput.Controls.Add(this.btnSaveRawMaterials);
            this.pnlRawMaterialInput.Controls.Add(this.txtRawQuantityInput);
            this.pnlRawMaterialInput.Controls.Add(this.cmbRawProductNameInput);
            this.pnlRawMaterialInput.Controls.Add(this.cmbRawMaterialsCategoryInput);
            this.pnlRawMaterialInput.Controls.Add(this.lblRawMaterial);
            this.pnlRawMaterialInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRawMaterialInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRawMaterialInput.Location = new System.Drawing.Point(3, 3);
            this.pnlRawMaterialInput.Name = "pnlRawMaterialInput";
            this.pnlRawMaterialInput.Size = new System.Drawing.Size(393, 770);
            this.pnlRawMaterialInput.TabIndex = 1;
            // 
            // btnPrintRawMaterialInvoice
            // 
            this.btnPrintRawMaterialInvoice.AutoSize = false;
            this.btnPrintRawMaterialInvoice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintRawMaterialInvoice.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintRawMaterialInvoice.Depth = 0;
            this.btnPrintRawMaterialInvoice.HighEmphasis = true;
            this.btnPrintRawMaterialInvoice.Icon = null;
            this.btnPrintRawMaterialInvoice.Location = new System.Drawing.Point(244, 516);
            this.btnPrintRawMaterialInvoice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrintRawMaterialInvoice.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintRawMaterialInvoice.Name = "btnPrintRawMaterialInvoice";
            this.btnPrintRawMaterialInvoice.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintRawMaterialInvoice.Size = new System.Drawing.Size(75, 36);
            this.btnPrintRawMaterialInvoice.TabIndex = 24;
            this.btnPrintRawMaterialInvoice.Text = "PRINT";
            this.btnPrintRawMaterialInvoice.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintRawMaterialInvoice.UseAccentColor = false;
            this.btnPrintRawMaterialInvoice.UseVisualStyleBackColor = true;
            this.btnPrintRawMaterialInvoice.Click += new System.EventHandler(this.btnPrintRawMaterialInvoice_Click);
            // 
            // btnDeleteRawMaterial
            // 
            this.btnDeleteRawMaterial.AutoSize = false;
            this.btnDeleteRawMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteRawMaterial.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteRawMaterial.Depth = 0;
            this.btnDeleteRawMaterial.HighEmphasis = true;
            this.btnDeleteRawMaterial.Icon = null;
            this.btnDeleteRawMaterial.Location = new System.Drawing.Point(137, 516);
            this.btnDeleteRawMaterial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteRawMaterial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteRawMaterial.Name = "btnDeleteRawMaterial";
            this.btnDeleteRawMaterial.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteRawMaterial.Size = new System.Drawing.Size(83, 36);
            this.btnDeleteRawMaterial.TabIndex = 23;
            this.btnDeleteRawMaterial.Text = "DELETE";
            this.btnDeleteRawMaterial.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteRawMaterial.UseAccentColor = false;
            this.btnDeleteRawMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteRawMaterial.Click += new System.EventHandler(this.btnDeleteRawMaterial_Click);
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
            this.txtRawMaterialsId.Location = new System.Drawing.Point(49, 79);
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
            this.txtRawMaterialsId.Size = new System.Drawing.Size(243, 48);
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
            this.txtRawCostInput.Location = new System.Drawing.Point(49, 354);
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
            this.txtRawCostInput.Size = new System.Drawing.Size(243, 48);
            this.txtRawCostInput.TabIndex = 2;
            this.txtRawCostInput.TabStop = false;
            this.txtRawCostInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRawCostInput.TrailingIcon = null;
            this.txtRawCostInput.UseSystemPasswordChar = false;
            // 
            // lblReceiveDate
            // 
            this.lblReceiveDate.AutoSize = true;
            this.lblReceiveDate.Location = new System.Drawing.Point(47, 439);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(110, 20);
            this.lblReceiveDate.TabIndex = 15;
            this.lblReceiveDate.Text = "Receive Date";
            // 
            // dtpRawMaterialReceiveDate
            // 
            this.dtpRawMaterialReceiveDate.CustomFormat = "";
            this.dtpRawMaterialReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRawMaterialReceiveDate.Location = new System.Drawing.Point(173, 435);
            this.dtpRawMaterialReceiveDate.Name = "dtpRawMaterialReceiveDate";
            this.dtpRawMaterialReceiveDate.Size = new System.Drawing.Size(164, 27);
            this.dtpRawMaterialReceiveDate.TabIndex = 18;
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
            this.txtRawQuantityInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawQuantityInput.HideSelection = true;
            this.txtRawQuantityInput.Hint = "Enter quantity";
            this.txtRawQuantityInput.LeadingIcon = null;
            this.txtRawQuantityInput.Location = new System.Drawing.Point(49, 283);
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
            this.txtRawQuantityInput.Size = new System.Drawing.Size(243, 48);
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
            this.cmbRawProductNameInput.Location = new System.Drawing.Point(49, 215);
            this.cmbRawProductNameInput.MaxDropDownItems = 4;
            this.cmbRawProductNameInput.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRawProductNameInput.Name = "cmbRawProductNameInput";
            this.cmbRawProductNameInput.Size = new System.Drawing.Size(243, 49);
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
            this.cmbRawMaterialsCategoryInput.Location = new System.Drawing.Point(49, 146);
            this.cmbRawMaterialsCategoryInput.MaxDropDownItems = 10;
            this.cmbRawMaterialsCategoryInput.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbRawMaterialsCategoryInput.Name = "cmbRawMaterialsCategoryInput";
            this.cmbRawMaterialsCategoryInput.Size = new System.Drawing.Size(243, 49);
            this.cmbRawMaterialsCategoryInput.StartIndex = 0;
            this.cmbRawMaterialsCategoryInput.TabIndex = 0;
            this.cmbRawMaterialsCategoryInput.SelectionChangeCommitted += new System.EventHandler(this.cmbRawMaterialsCategoryInput_SelectionChangeCommitted);
            // 
            // lblRawMaterial
            // 
            this.lblRawMaterial.AutoSize = true;
            this.lblRawMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawMaterial.Location = new System.Drawing.Point(131, 17);
            this.lblRawMaterial.Name = "lblRawMaterial";
            this.lblRawMaterial.Size = new System.Drawing.Size(185, 25);
            this.lblRawMaterial.TabIndex = 0;
            this.lblRawMaterial.Text = "Enter Raw Materials";
            // 
            // EmployeeAdd
            // 
            this.EmployeeAdd.AutoScroll = true;
            this.EmployeeAdd.Controls.Add(this.txtSearchEmployee);
            this.EmployeeAdd.Controls.Add(this.pnlEmployeeInput);
            this.EmployeeAdd.Controls.Add(this.pnlEmployeeShow);
            this.EmployeeAdd.ImageKey = "employee.png";
            this.EmployeeAdd.Location = new System.Drawing.Point(4, 53);
            this.EmployeeAdd.Name = "EmployeeAdd";
            this.EmployeeAdd.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeAdd.Size = new System.Drawing.Size(1414, 776);
            this.EmployeeAdd.TabIndex = 0;
            this.EmployeeAdd.Text = "Employee Add";
            this.EmployeeAdd.UseVisualStyleBackColor = true;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.AnimateReadOnly = false;
            this.txtSearchEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearchEmployee.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearchEmployee.Depth = 0;
            this.txtSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmployee.HideSelection = true;
            this.txtSearchEmployee.Hint = "Search employee by name";
            this.txtSearchEmployee.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtSearchEmployee.LeadingIcon")));
            this.txtSearchEmployee.Location = new System.Drawing.Point(521, 0);
            this.txtSearchEmployee.MaxLength = 32767;
            this.txtSearchEmployee.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.PasswordChar = '\0';
            this.txtSearchEmployee.PrefixSuffixText = null;
            this.txtSearchEmployee.ReadOnly = false;
            this.txtSearchEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearchEmployee.SelectedText = "";
            this.txtSearchEmployee.SelectionLength = 0;
            this.txtSearchEmployee.SelectionStart = 0;
            this.txtSearchEmployee.ShortcutsEnabled = true;
            this.txtSearchEmployee.Size = new System.Drawing.Size(946, 48);
            this.txtSearchEmployee.TabIndex = 3;
            this.txtSearchEmployee.TabStop = false;
            this.txtSearchEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearchEmployee.TrailingIcon = null;
            this.txtSearchEmployee.UseSystemPasswordChar = false;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // pnlEmployeeInput
            // 
            this.pnlEmployeeInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlEmployeeInput.Controls.Add(this.lblPasswordReset);
            this.pnlEmployeeInput.Controls.Add(this.btnLogOutAdmin);
            this.pnlEmployeeInput.Controls.Add(this.switchThemeChangeEmployee);
            this.pnlEmployeeInput.Controls.Add(this.btnDeleteEmployeeInfo);
            this.pnlEmployeeInput.Controls.Add(this.btnSaveEmployeeInfo);
            this.pnlEmployeeInput.Controls.Add(this.lblEmployeeInput);
            this.pnlEmployeeInput.Controls.Add(this.pnlEmployeeGender);
            this.pnlEmployeeInput.Controls.Add(this.cmbEmployeeRole);
            this.pnlEmployeeInput.Controls.Add(this.txtEmployeeAddress);
            this.pnlEmployeeInput.Controls.Add(this.lblJoiningDate);
            this.pnlEmployeeInput.Controls.Add(this.dtpJoiningDate);
            this.pnlEmployeeInput.Controls.Add(this.txtEmployeeSalary);
            this.pnlEmployeeInput.Controls.Add(this.txtEmployeePassword);
            this.pnlEmployeeInput.Controls.Add(this.txtEmployeeName);
            this.pnlEmployeeInput.Controls.Add(this.txtEmployeeId);
            this.pnlEmployeeInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEmployeeInput.Location = new System.Drawing.Point(3, 3);
            this.pnlEmployeeInput.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEmployeeInput.Name = "pnlEmployeeInput";
            this.pnlEmployeeInput.Size = new System.Drawing.Size(518, 749);
            this.pnlEmployeeInput.TabIndex = 5;
            // 
            // lblPasswordReset
            // 
            this.lblPasswordReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordReset.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordReset.Location = new System.Drawing.Point(56, 47);
            this.lblPasswordReset.Name = "lblPasswordReset";
            this.lblPasswordReset.Size = new System.Drawing.Size(425, 28);
            this.lblPasswordReset.TabIndex = 6;
            this.lblPasswordReset.Text = "Please reset password of ";
            this.lblPasswordReset.Click += new System.EventHandler(this.lblPasswordReset_Click);
            // 
            // btnLogOutAdmin
            // 
            this.btnLogOutAdmin.AutoSize = false;
            this.btnLogOutAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogOutAdmin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogOutAdmin.Depth = 0;
            this.btnLogOutAdmin.HighEmphasis = true;
            this.btnLogOutAdmin.Icon = null;
            this.btnLogOutAdmin.Location = new System.Drawing.Point(246, 658);
            this.btnLogOutAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogOutAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogOutAdmin.Name = "btnLogOutAdmin";
            this.btnLogOutAdmin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogOutAdmin.Size = new System.Drawing.Size(130, 36);
            this.btnLogOutAdmin.TabIndex = 23;
            this.btnLogOutAdmin.Text = "LOG OUT";
            this.btnLogOutAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogOutAdmin.UseAccentColor = false;
            this.btnLogOutAdmin.UseVisualStyleBackColor = true;
            this.btnLogOutAdmin.Click += new System.EventHandler(this.btnLogOutAdmin_Click);
            // 
            // switchThemeChangeEmployee
            // 
            this.switchThemeChangeEmployee.BackColor = System.Drawing.Color.Transparent;
            this.switchThemeChangeEmployee.Depth = 0;
            this.switchThemeChangeEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchThemeChangeEmployee.Location = new System.Drawing.Point(43, 709);
            this.switchThemeChangeEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.switchThemeChangeEmployee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchThemeChangeEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchThemeChangeEmployee.Name = "switchThemeChangeEmployee";
            this.switchThemeChangeEmployee.Ripple = true;
            this.switchThemeChangeEmployee.Size = new System.Drawing.Size(234, 47);
            this.switchThemeChangeEmployee.TabIndex = 22;
            this.switchThemeChangeEmployee.Text = "Dark Mode";
            this.switchThemeChangeEmployee.UseVisualStyleBackColor = false;
            this.switchThemeChangeEmployee.CheckedChanged += new System.EventHandler(this.switchThemeChangeEmployee_CheckedChanged);
            // 
            // btnDeleteEmployeeInfo
            // 
            this.btnDeleteEmployeeInfo.AutoSize = false;
            this.btnDeleteEmployeeInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteEmployeeInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeleteEmployeeInfo.Depth = 0;
            this.btnDeleteEmployeeInfo.HighEmphasis = true;
            this.btnDeleteEmployeeInfo.Icon = null;
            this.btnDeleteEmployeeInfo.Location = new System.Drawing.Point(147, 658);
            this.btnDeleteEmployeeInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteEmployeeInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeleteEmployeeInfo.Name = "btnDeleteEmployeeInfo";
            this.btnDeleteEmployeeInfo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeleteEmployeeInfo.Size = new System.Drawing.Size(79, 36);
            this.btnDeleteEmployeeInfo.TabIndex = 10;
            this.btnDeleteEmployeeInfo.Text = "DELETE";
            this.btnDeleteEmployeeInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeleteEmployeeInfo.UseAccentColor = false;
            this.btnDeleteEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnDeleteEmployeeInfo.Click += new System.EventHandler(this.btnDeleteEmployeeInfo_Click);
            // 
            // btnSaveEmployeeInfo
            // 
            this.btnSaveEmployeeInfo.AutoSize = false;
            this.btnSaveEmployeeInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveEmployeeInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveEmployeeInfo.Depth = 0;
            this.btnSaveEmployeeInfo.HighEmphasis = true;
            this.btnSaveEmployeeInfo.Icon = null;
            this.btnSaveEmployeeInfo.Location = new System.Drawing.Point(53, 658);
            this.btnSaveEmployeeInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveEmployeeInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveEmployeeInfo.Name = "btnSaveEmployeeInfo";
            this.btnSaveEmployeeInfo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSaveEmployeeInfo.Size = new System.Drawing.Size(75, 36);
            this.btnSaveEmployeeInfo.TabIndex = 9;
            this.btnSaveEmployeeInfo.Text = "SAVE";
            this.btnSaveEmployeeInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveEmployeeInfo.UseAccentColor = false;
            this.btnSaveEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnSaveEmployeeInfo.Click += new System.EventHandler(this.btnSaveEmployeeInfo_Click);
            // 
            // lblEmployeeInput
            // 
            this.lblEmployeeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeInput.Location = new System.Drawing.Point(121, 11);
            this.lblEmployeeInput.Name = "lblEmployeeInput";
            this.lblEmployeeInput.Size = new System.Drawing.Size(306, 48);
            this.lblEmployeeInput.TabIndex = 8;
            this.lblEmployeeInput.Text = "Employee Information Input";
            // 
            // pnlEmployeeGender
            // 
            this.pnlEmployeeGender.Controls.Add(this.lblEmployeeGender);
            this.pnlEmployeeGender.Controls.Add(this.rdbEmployeeFemale);
            this.pnlEmployeeGender.Controls.Add(this.rdbEmployeeMale);
            this.pnlEmployeeGender.Location = new System.Drawing.Point(53, 573);
            this.pnlEmployeeGender.Name = "pnlEmployeeGender";
            this.pnlEmployeeGender.Size = new System.Drawing.Size(425, 66);
            this.pnlEmployeeGender.TabIndex = 7;
            // 
            // lblEmployeeGender
            // 
            this.lblEmployeeGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeGender.Location = new System.Drawing.Point(2, 26);
            this.lblEmployeeGender.Name = "lblEmployeeGender";
            this.lblEmployeeGender.Size = new System.Drawing.Size(78, 33);
            this.lblEmployeeGender.TabIndex = 8;
            this.lblEmployeeGender.Text = "Gender";
            // 
            // rdbEmployeeFemale
            // 
            this.rdbEmployeeFemale.AutoSize = true;
            this.rdbEmployeeFemale.Depth = 0;
            this.rdbEmployeeFemale.Location = new System.Drawing.Point(104, 13);
            this.rdbEmployeeFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rdbEmployeeFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbEmployeeFemale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbEmployeeFemale.Name = "rdbEmployeeFemale";
            this.rdbEmployeeFemale.Ripple = true;
            this.rdbEmployeeFemale.Size = new System.Drawing.Size(87, 37);
            this.rdbEmployeeFemale.TabIndex = 6;
            this.rdbEmployeeFemale.TabStop = true;
            this.rdbEmployeeFemale.Text = "Female";
            this.rdbEmployeeFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbEmployeeFemale.UseVisualStyleBackColor = true;
            // 
            // rdbEmployeeMale
            // 
            this.rdbEmployeeMale.AutoSize = true;
            this.rdbEmployeeMale.Depth = 0;
            this.rdbEmployeeMale.Location = new System.Drawing.Point(218, 13);
            this.rdbEmployeeMale.Margin = new System.Windows.Forms.Padding(0);
            this.rdbEmployeeMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbEmployeeMale.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbEmployeeMale.Name = "rdbEmployeeMale";
            this.rdbEmployeeMale.Ripple = true;
            this.rdbEmployeeMale.Size = new System.Drawing.Size(70, 37);
            this.rdbEmployeeMale.TabIndex = 7;
            this.rdbEmployeeMale.TabStop = true;
            this.rdbEmployeeMale.Text = "Male";
            this.rdbEmployeeMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbEmployeeMale.UseVisualStyleBackColor = true;
            // 
            // cmbEmployeeRole
            // 
            this.cmbEmployeeRole.AutoResize = false;
            this.cmbEmployeeRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmployeeRole.Depth = 0;
            this.cmbEmployeeRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmployeeRole.DropDownHeight = 174;
            this.cmbEmployeeRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeRole.DropDownWidth = 121;
            this.cmbEmployeeRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEmployeeRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmployeeRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmployeeRole.FormattingEnabled = true;
            this.cmbEmployeeRole.Hint = "Choose Employee Role";
            this.cmbEmployeeRole.IntegralHeight = false;
            this.cmbEmployeeRole.ItemHeight = 43;
            this.cmbEmployeeRole.Items.AddRange(new object[] {
            "Admin",
            "Manager"});
            this.cmbEmployeeRole.Location = new System.Drawing.Point(53, 506);
            this.cmbEmployeeRole.MaxDropDownItems = 4;
            this.cmbEmployeeRole.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmployeeRole.Name = "cmbEmployeeRole";
            this.cmbEmployeeRole.Size = new System.Drawing.Size(425, 49);
            this.cmbEmployeeRole.Sorted = true;
            this.cmbEmployeeRole.StartIndex = 0;
            this.cmbEmployeeRole.TabIndex = 6;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.AnimateReadOnly = false;
            this.txtEmployeeAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmployeeAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmployeeAddress.Depth = 0;
            this.txtEmployeeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeeAddress.HideSelection = true;
            this.txtEmployeeAddress.Hint = "Enter Employee Address";
            this.txtEmployeeAddress.LeadingIcon = null;
            this.txtEmployeeAddress.Location = new System.Drawing.Point(56, 430);
            this.txtEmployeeAddress.MaxLength = 32767;
            this.txtEmployeeAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.PasswordChar = '\0';
            this.txtEmployeeAddress.PrefixSuffixText = null;
            this.txtEmployeeAddress.ReadOnly = false;
            this.txtEmployeeAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmployeeAddress.SelectedText = "";
            this.txtEmployeeAddress.SelectionLength = 0;
            this.txtEmployeeAddress.SelectionStart = 0;
            this.txtEmployeeAddress.ShortcutsEnabled = true;
            this.txtEmployeeAddress.Size = new System.Drawing.Size(425, 48);
            this.txtEmployeeAddress.TabIndex = 5;
            this.txtEmployeeAddress.TabStop = false;
            this.txtEmployeeAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeAddress.TrailingIcon = null;
            this.txtEmployeeAddress.UseSystemPasswordChar = false;
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoiningDate.Location = new System.Drawing.Point(52, 367);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(122, 33);
            this.lblJoiningDate.TabIndex = 5;
            this.lblJoiningDate.Text = "Joining Date";
            // 
            // dtpJoiningDate
            // 
            this.dtpJoiningDate.CustomFormat = "";
            this.dtpJoiningDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJoiningDate.Location = new System.Drawing.Point(180, 364);
            this.dtpJoiningDate.Name = "dtpJoiningDate";
            this.dtpJoiningDate.Size = new System.Drawing.Size(298, 27);
            this.dtpJoiningDate.TabIndex = 4;
            this.dtpJoiningDate.Value = new System.DateTime(2023, 8, 11, 0, 0, 0, 0);
            // 
            // txtEmployeeSalary
            // 
            this.txtEmployeeSalary.AnimateReadOnly = false;
            this.txtEmployeeSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmployeeSalary.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmployeeSalary.Depth = 0;
            this.txtEmployeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeeSalary.HideSelection = true;
            this.txtEmployeeSalary.Hint = "Enter Employee Salary";
            this.txtEmployeeSalary.LeadingIcon = null;
            this.txtEmployeeSalary.Location = new System.Drawing.Point(53, 285);
            this.txtEmployeeSalary.MaxLength = 32767;
            this.txtEmployeeSalary.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmployeeSalary.Name = "txtEmployeeSalary";
            this.txtEmployeeSalary.PasswordChar = '\0';
            this.txtEmployeeSalary.PrefixSuffixText = null;
            this.txtEmployeeSalary.ReadOnly = false;
            this.txtEmployeeSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmployeeSalary.SelectedText = "";
            this.txtEmployeeSalary.SelectionLength = 0;
            this.txtEmployeeSalary.SelectionStart = 0;
            this.txtEmployeeSalary.ShortcutsEnabled = true;
            this.txtEmployeeSalary.Size = new System.Drawing.Size(425, 48);
            this.txtEmployeeSalary.TabIndex = 3;
            this.txtEmployeeSalary.TabStop = false;
            this.txtEmployeeSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeSalary.TrailingIcon = null;
            this.txtEmployeeSalary.UseSystemPasswordChar = false;
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.AnimateReadOnly = false;
            this.txtEmployeePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmployeePassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmployeePassword.Depth = 0;
            this.txtEmployeePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeePassword.HideSelection = true;
            this.txtEmployeePassword.Hint = "Enter Employee Password";
            this.txtEmployeePassword.LeadingIcon = null;
            this.txtEmployeePassword.Location = new System.Drawing.Point(53, 214);
            this.txtEmployeePassword.MaxLength = 32767;
            this.txtEmployeePassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.PasswordChar = '●';
            this.txtEmployeePassword.PrefixSuffixText = null;
            this.txtEmployeePassword.ReadOnly = false;
            this.txtEmployeePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmployeePassword.SelectedText = "";
            this.txtEmployeePassword.SelectionLength = 0;
            this.txtEmployeePassword.SelectionStart = 0;
            this.txtEmployeePassword.ShortcutsEnabled = true;
            this.txtEmployeePassword.Size = new System.Drawing.Size(425, 48);
            this.txtEmployeePassword.TabIndex = 2;
            this.txtEmployeePassword.TabStop = false;
            this.txtEmployeePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeePassword.TrailingIcon = null;
            this.txtEmployeePassword.UseSystemPasswordChar = true;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.AnimateReadOnly = false;
            this.txtEmployeeName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmployeeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmployeeName.Depth = 0;
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmployeeName.HideSelection = true;
            this.txtEmployeeName.Hint = "Enter Employee Name";
            this.txtEmployeeName.LeadingIcon = null;
            this.txtEmployeeName.Location = new System.Drawing.Point(53, 147);
            this.txtEmployeeName.MaxLength = 32767;
            this.txtEmployeeName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.PrefixSuffixText = null;
            this.txtEmployeeName.ReadOnly = false;
            this.txtEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.SelectionLength = 0;
            this.txtEmployeeName.SelectionStart = 0;
            this.txtEmployeeName.ShortcutsEnabled = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(425, 48);
            this.txtEmployeeName.TabIndex = 1;
            this.txtEmployeeName.TabStop = false;
            this.txtEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeName.TrailingIcon = null;
            this.txtEmployeeName.UseSystemPasswordChar = false;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.AnimateReadOnly = false;
            this.txtEmployeeId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmployeeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmployeeId.Depth = 0;
            this.txtEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.HideSelection = true;
            this.txtEmployeeId.Hint = "Automated Employee Id";
            this.txtEmployeeId.LeadingIcon = null;
            this.txtEmployeeId.Location = new System.Drawing.Point(56, 80);
            this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmployeeId.MaxLength = 32767;
            this.txtEmployeeId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.PasswordChar = '\0';
            this.txtEmployeeId.PrefixSuffixText = null;
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmployeeId.SelectedText = "";
            this.txtEmployeeId.SelectionLength = 0;
            this.txtEmployeeId.SelectionStart = 0;
            this.txtEmployeeId.ShortcutsEnabled = true;
            this.txtEmployeeId.Size = new System.Drawing.Size(425, 48);
            this.txtEmployeeId.TabIndex = 0;
            this.txtEmployeeId.TabStop = false;
            this.txtEmployeeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmployeeId.TrailingIcon = null;
            this.txtEmployeeId.UseSystemPasswordChar = false;
            // 
            // pnlEmployeeShow
            // 
            this.pnlEmployeeShow.Controls.Add(this.dgvEmployeeInformationShow);
            this.pnlEmployeeShow.Location = new System.Drawing.Point(522, 4);
            this.pnlEmployeeShow.Name = "pnlEmployeeShow";
            this.pnlEmployeeShow.Size = new System.Drawing.Size(941, 748);
            this.pnlEmployeeShow.TabIndex = 0;
            // 
            // dgvEmployeeInformationShow
            // 
            this.dgvEmployeeInformationShow.AllowUserToAddRows = false;
            this.dgvEmployeeInformationShow.AllowUserToDeleteRows = false;
            this.dgvEmployeeInformationShow.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEmployeeInformationShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInformationShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_id,
            this.M_Name,
            this.M_Password,
            this.M_Salary,
            this.M_Joining_Date,
            this.M_Address,
            this.M_Role,
            this.M_Gender,
            this.Admin_Id});
            this.dgvEmployeeInformationShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmployeeInformationShow.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvEmployeeInformationShow.Location = new System.Drawing.Point(0, 46);
            this.dgvEmployeeInformationShow.Name = "dgvEmployeeInformationShow";
            this.dgvEmployeeInformationShow.ReadOnly = true;
            this.dgvEmployeeInformationShow.RowHeadersWidth = 51;
            this.dgvEmployeeInformationShow.RowTemplate.Height = 24;
            this.dgvEmployeeInformationShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeInformationShow.Size = new System.Drawing.Size(941, 702);
            this.dgvEmployeeInformationShow.TabIndex = 0;
            this.dgvEmployeeInformationShow.DoubleClick += new System.EventHandler(this.dgvEmployeeInformationShow_DoubleClick_1);
            // 
            // M_id
            // 
            this.M_id.DataPropertyName = "M_id";
            this.M_id.HeaderText = "Id";
            this.M_id.MinimumWidth = 6;
            this.M_id.Name = "M_id";
            this.M_id.ReadOnly = true;
            this.M_id.Width = 70;
            // 
            // M_Name
            // 
            this.M_Name.DataPropertyName = "M_Name";
            this.M_Name.HeaderText = "Name";
            this.M_Name.MinimumWidth = 6;
            this.M_Name.Name = "M_Name";
            this.M_Name.ReadOnly = true;
            this.M_Name.Width = 125;
            // 
            // M_Password
            // 
            this.M_Password.DataPropertyName = "M_Password";
            this.M_Password.HeaderText = "Password";
            this.M_Password.MinimumWidth = 6;
            this.M_Password.Name = "M_Password";
            this.M_Password.ReadOnly = true;
            this.M_Password.Width = 125;
            // 
            // M_Salary
            // 
            this.M_Salary.DataPropertyName = "M_Salary";
            this.M_Salary.HeaderText = "Salary";
            this.M_Salary.MinimumWidth = 6;
            this.M_Salary.Name = "M_Salary";
            this.M_Salary.ReadOnly = true;
            this.M_Salary.Width = 125;
            // 
            // M_Joining_Date
            // 
            this.M_Joining_Date.DataPropertyName = "M_Joining_Date";
            this.M_Joining_Date.HeaderText = "Joining Date";
            this.M_Joining_Date.MinimumWidth = 6;
            this.M_Joining_Date.Name = "M_Joining_Date";
            this.M_Joining_Date.ReadOnly = true;
            this.M_Joining_Date.Width = 125;
            // 
            // M_Address
            // 
            this.M_Address.DataPropertyName = "M_Address";
            this.M_Address.HeaderText = "Address";
            this.M_Address.MinimumWidth = 6;
            this.M_Address.Name = "M_Address";
            this.M_Address.ReadOnly = true;
            this.M_Address.Width = 125;
            // 
            // M_Role
            // 
            this.M_Role.DataPropertyName = "M_Role";
            this.M_Role.HeaderText = "Role";
            this.M_Role.MinimumWidth = 6;
            this.M_Role.Name = "M_Role";
            this.M_Role.ReadOnly = true;
            this.M_Role.Width = 125;
            // 
            // M_Gender
            // 
            this.M_Gender.DataPropertyName = "M_Gender";
            this.M_Gender.HeaderText = "Gender";
            this.M_Gender.MinimumWidth = 6;
            this.M_Gender.Name = "M_Gender";
            this.M_Gender.ReadOnly = true;
            this.M_Gender.Width = 125;
            // 
            // Admin_Id
            // 
            this.Admin_Id.DataPropertyName = "A_Id";
            this.Admin_Id.HeaderText = "Admin Id";
            this.Admin_Id.MinimumWidth = 6;
            this.Admin_Id.Name = "Admin_Id";
            this.Admin_Id.ReadOnly = true;
            this.Admin_Id.Width = 125;
            // 
            // tabEmployeeInformation
            // 
            this.tabEmployeeInformation.Controls.Add(this.EmployeeAdd);
            this.tabEmployeeInformation.Controls.Add(this.RawMaterials);
            this.tabEmployeeInformation.Controls.Add(this.FinishedProduct);
            this.tabEmployeeInformation.Depth = 0;
            this.tabEmployeeInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEmployeeInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEmployeeInformation.ImageList = this.imageList1;
            this.tabEmployeeInformation.Location = new System.Drawing.Point(3, 64);
            this.tabEmployeeInformation.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabEmployeeInformation.Multiline = true;
            this.tabEmployeeInformation.Name = "tabEmployeeInformation";
            this.tabEmployeeInformation.Padding = new System.Drawing.Point(10, 10);
            this.tabEmployeeInformation.SelectedIndex = 0;
            this.tabEmployeeInformation.Size = new System.Drawing.Size(1422, 833);
            this.tabEmployeeInformation.TabIndex = 0;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 900);
            this.Controls.Add(this.tabEmployeeInformation);
            this.DrawerTabControl = this.tabEmployeeInformation;
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Admin ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.FinishedProduct.ResumeLayout(false);
            this.pnlFinishedProductData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinishedProductShow)).EndInit();
            this.pnlFinishedProductShow.ResumeLayout(false);
            this.pnlFinishedProductShow.PerformLayout();
            this.RawMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterialsShow)).EndInit();
            this.pnlAdminRawMaterial.ResumeLayout(false);
            this.pnlRawMaterialInput.ResumeLayout(false);
            this.pnlRawMaterialInput.PerformLayout();
            this.EmployeeAdd.ResumeLayout(false);
            this.pnlEmployeeInput.ResumeLayout(false);
            this.pnlEmployeeGender.ResumeLayout(false);
            this.pnlEmployeeGender.PerformLayout();
            this.pnlEmployeeShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInformationShow)).EndInit();
            this.tabEmployeeInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Drawing.Printing.PrintDocument printInvoiceDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewInvoice;
        private System.Drawing.Printing.PrintDocument printFinishedDocument;
        private System.Windows.Forms.PrintPreviewDialog printFinishedPreviewDialog;
        private System.Windows.Forms.TabPage FinishedProduct;
        private System.Windows.Forms.Panel pnlFinishedProductData;
        private System.Windows.Forms.DataGridView dgvFinishedProductShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufacturedDate;
        private MaterialSkin.Controls.MaterialTextBox2 txtFinishedProductSearch;
        private System.Windows.Forms.Panel pnlFinishedProductShow;
        private MaterialSkin.Controls.MaterialButton btnPrintFinishedProduct;
        private MaterialSkin.Controls.MaterialButton btnFinishedProductDelete;
        private MaterialSkin.Controls.MaterialButton btnFinishedProductSave;
        private System.Windows.Forms.Label lblManufacturedDate;
        private System.Windows.Forms.DateTimePicker dtpManufacturedDateInput;
        private MaterialSkin.Controls.MaterialTextBox2 txtFinishedProductId;
        private MaterialSkin.Controls.MaterialTextBox2 txtFinishedProductCostInput;
        private MaterialSkin.Controls.MaterialTextBox2 txtFinishedProductQuantityInput;
        private MaterialSkin.Controls.MaterialComboBox cmbFinishedProductNameInput;
        private MaterialSkin.Controls.MaterialComboBox cmbFinishedProductCategoryInput;
        private System.Windows.Forms.Label lblFinishedTitle;
        private System.Windows.Forms.TabPage RawMaterials;
        private System.Windows.Forms.DataGridView dgvRawMaterialsShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialReceivedDate;
        private System.Windows.Forms.Panel pnlRawMaterialsShow;
        private System.Windows.Forms.Panel pnlAdminRawMaterial;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearchRawMaterial;
        private System.Windows.Forms.Panel pnlRawMaterialInput;
        private MaterialSkin.Controls.MaterialButton btnPrintRawMaterialInvoice;
        private MaterialSkin.Controls.MaterialButton btnDeleteRawMaterial;
        private MaterialSkin.Controls.MaterialTextBox2 txtRawMaterialsId;
        private MaterialSkin.Controls.MaterialTextBox2 txtRawCostInput;
        private System.Windows.Forms.Label lblReceiveDate;
        private System.Windows.Forms.DateTimePicker dtpRawMaterialReceiveDate;
        private MaterialSkin.Controls.MaterialButton btnSaveRawMaterials;
        private MaterialSkin.Controls.MaterialTextBox2 txtRawQuantityInput;
        private MaterialSkin.Controls.MaterialComboBox cmbRawProductNameInput;
        private MaterialSkin.Controls.MaterialComboBox cmbRawMaterialsCategoryInput;
        private System.Windows.Forms.Label lblRawMaterial;
        private System.Windows.Forms.TabPage EmployeeAdd;
        private MaterialSkin.Controls.MaterialTextBox2 txtSearchEmployee;
        private System.Windows.Forms.Panel pnlEmployeeInput;
        private System.Windows.Forms.Label lblPasswordReset;
        private MaterialSkin.Controls.MaterialButton btnLogOutAdmin;
        private MaterialSkin.Controls.MaterialSwitch switchThemeChangeEmployee;
        private MaterialSkin.Controls.MaterialButton btnDeleteEmployeeInfo;
        private MaterialSkin.Controls.MaterialButton btnSaveEmployeeInfo;
        private System.Windows.Forms.Label lblEmployeeInput;
        private System.Windows.Forms.Panel pnlEmployeeGender;
        private System.Windows.Forms.Label lblEmployeeGender;
        private MaterialSkin.Controls.MaterialRadioButton rdbEmployeeFemale;
        private MaterialSkin.Controls.MaterialRadioButton rdbEmployeeMale;
        private MaterialSkin.Controls.MaterialComboBox cmbEmployeeRole;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmployeeAddress;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.DateTimePicker dtpJoiningDate;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmployeeSalary;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmployeePassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmployeeName;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmployeeId;
        private System.Windows.Forms.Panel pnlEmployeeShow;
        private System.Windows.Forms.DataGridView dgvEmployeeInformationShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Joining_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin_Id;
        private MaterialSkin.Controls.MaterialTabControl tabEmployeeInformation;
    }
}