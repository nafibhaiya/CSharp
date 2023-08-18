using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GarmentsManagementSystem
{
    public partial class FormWarehouseManager : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        private DataAccess Da { get; set; }

        private FormLogin Fl { get; set; }
       

        public FormWarehouseManager()
        {
            InitializeComponent();
           

            // Initializing MaterialSkin
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.Amber900, Primary.Amber800, Accent.Amber200, TextShade.WHITE);

            // Raw materials Combo box Category (Filter)
            ArrayList RawCategory = new ArrayList { "Fabrics", "Buttons", "Threads", "Miscellaneous" };
            this.cmbRawMaterialsCategoryInput.DataSource = RawCategory;

            this.Da = new DataAccess();
            // Finished Product Combo box Category (Filter)
            ArrayList FinishedCategory = new ArrayList { "T-Shirts", "Bottoms weares", "Outerwears", "Workwears" };
            this.cmbFinishedProductCategoryInput.DataSource = FinishedCategory;


            // Populate Grid view for raw material and finished product on load
            this.PopulateGridViewRawMeterials();
            this.PopulateGridViewFinishedProduct();

        }

        // Taking Manager Name from Login Form
        public FormWarehouseManager(string info, FormLogin fl) : this()
        {
            this.Fl = fl;
            this.Text += info;
        }


        // Form Closed Event
        private void FormWarehouseManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged Out");
            this.Fl.Show();
        }


        // Raw Materials Items
        ArrayList fabrics = new ArrayList { "Cotton", "Polyester", "Wool" };
        ArrayList buttons = new ArrayList { "Jeans buttons", "Rivets for reinforcement" };
        ArrayList threads = new ArrayList { "Sewing thread", "Embroidery thread", "Yarn for knitted" };
        ArrayList miscellaneous = new ArrayList { "Hangers", "Garment bags" };


        // Finished Product Items
        ArrayList tShirts = new ArrayList { "Basic T-shirts", "Polo shirts", "Sweaters" };
        ArrayList pants = new ArrayList { "Jeans", "Pants", "Shorts" };
        ArrayList outerwears = new ArrayList { "Jackets", "Coats", "Blazers", "Hoodies" };
        ArrayList workwears = new ArrayList { "Business suits", "Work shirts", "Chef uniforms" };


        // Raw materials Combo box Products items filter
        private void cmbRawMaterialsCategoryInput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var categoryChoose = this.cmbRawMaterialsCategoryInput.Text.ToLower();

            try
            {
                switch (categoryChoose)
                {
                    case "fabrics":
                        this.cmbRawProductNameInput.DataSource = fabrics;
                        break;
                    case "buttons":
                        this.cmbRawProductNameInput.DataSource = buttons;
                        break;
                    case "threads":
                        this.cmbRawProductNameInput.DataSource = threads;
                        break;
                    case "miscellaneous":
                        this.cmbRawProductNameInput.DataSource = miscellaneous;
                        break;
                }


            }
            catch (Exception err)
            {
                MessageBox.Show("Invalid Category Choose" + err.Message);
            }
        }


        // Finished Product Combo box Products items filter
        private void cmbFinishedProductCategoryInput_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var categoryChoose = this.cmbFinishedProductCategoryInput.Text.ToLower();

            try
            {
                switch (categoryChoose)
                {
                    case "t-shirts":
                        this.cmbFinishedProductNameInput.DataSource = tShirts;
                        break;
                    case "bottoms weares":
                        this.cmbFinishedProductNameInput.DataSource = pants;
                        break;
                    case "outerwears":
                        this.cmbFinishedProductNameInput.DataSource = outerwears;
                        break;
                    case "workwears":
                        this.cmbFinishedProductNameInput.DataSource = workwears;
                        break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Invalid Category Choose" + err.Message);
            }

        }


        // Changing Theme to dark and light mode
        private void switchTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (switchTheme.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

                this.dgvFinishedProductShow.DefaultCellStyle.BackColor = Color.Black;
                this.dgvFinishedProductShow.DefaultCellStyle.ForeColor = Color.White;
                this.dgvFinishedProductShow.BackgroundColor = Color.Black;


                this.dgvRawMaterialsShow.DefaultCellStyle.BackColor = Color.Black;
                this.dgvRawMaterialsShow.DefaultCellStyle.ForeColor = Color.White;
                this.dgvRawMaterialsShow.BackgroundColor = Color.Black;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                this.dgvFinishedProductShow.DefaultCellStyle.BackColor = Color.White;
                this.dgvFinishedProductShow.DefaultCellStyle.ForeColor = Color.Black;
                this.dgvFinishedProductShow.BackgroundColor = Color.White;


                this.dgvRawMaterialsShow.DefaultCellStyle.BackColor = Color.White;
                this.dgvRawMaterialsShow.DefaultCellStyle.ForeColor = Color.Black;
                this.dgvRawMaterialsShow.BackgroundColor = Color.White;
            }
        }



        // Creating Method for population raw and finished product in grid view
        private void PopulateGridViewRawMeterials(string sql = "select * from RawMeterialInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvRawMaterialsShow.AutoGenerateColumns = false;
            this.dgvRawMaterialsShow.DataSource = ds.Tables[0];
        }

        private void PopulateGridViewFinishedProduct(string sql = "select * from FinishedProductInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvFinishedProductShow.AutoGenerateColumns = false;
            this.dgvFinishedProductShow.DataSource = ds.Tables[0];
        }


        // Creating clear method 
        private void ClearAllRawMeterialInput()
        {
            this.txtRawMaterialsId.Clear();
            this.cmbRawMaterialsCategoryInput.SelectedIndex = -1;
            this.cmbRawProductNameInput.SelectedIndex = -1;
            this.txtRawQuantityInput.Clear();
            this.txtRawCostInput.Clear();
            this.dtpRawMaterialReceiveDate.Text = "";


            this.txtSearchRawMaterial.Clear();
            this.dgvRawMaterialsShow.ClearSelection();
        }


        // Checking form validation
        private bool IsValidToSaveRawMeterial()
        {
            if (String.IsNullOrEmpty(this.cmbRawMaterialsCategoryInput.Text) ||
               String.IsNullOrEmpty(this.cmbRawProductNameInput.Text) || String.IsNullOrEmpty(this.txtRawQuantityInput.Text) ||
               String.IsNullOrEmpty(this.txtRawCostInput.Text) )
            {
                return false;
            }
            else
                return true;
        }

        // Save and update raw materials

      
        private void btnSaveRawMaterials_Click(object sender, EventArgs e)
        {
            

            try
            {
                string RId = this.AutoRawId();
                if (!this.IsValidToSaveRawMeterial())
                {
                    MessageBox.Show("Empty fields are not allowed. Please fill all the information");
                    return;
                }

                var query = "select * from RawMeterialInfo where RawId = '" + this.txtRawMaterialsId.Text + "';";

                var dt = this.Da.ExecuteQuery(query);
                if (dt.Tables[0].Rows.Count == 1)
                {
                    //update raw materials
                    var sql = @"update RawMeterialInfo
                                set 
                                RawCategory = '" + this.cmbRawMaterialsCategoryInput.Text + @"',
                                RawProductName = '" + this.cmbRawProductNameInput.Text + @"',
                                RawQuantity = " + this.txtRawQuantityInput.Text + @",
                                RawCost = " + this.txtRawCostInput.Text + @",
                                RawDate = '" + DateTime.Parse(this.dtpRawMaterialReceiveDate.Text) + @"'
                                where RawId = '" + this.txtRawMaterialsId.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated properly.");
                    else
                        MessageBox.Show("Failure While updating the data");
                }
                else
                {
                    //insert raw materials
                    var sql = "insert into RawMeterialInfo values('" + RId + "', '" + this.cmbRawMaterialsCategoryInput.Text + "', '" + this.cmbRawProductNameInput.Text + "', " + this.txtRawQuantityInput.Text + ", " + this.txtRawCostInput.Text + ", '" + DateTime.Parse(this.dtpRawMaterialReceiveDate.Text) + "'); ";
                    var count = this.Da.ExecuteDMLQuery(sql);
                    

                    if (count == 1)
                        MessageBox.Show("Data saved properly.");
                    else
                        MessageBox.Show("Failure While saving the data");

                }

                this.PopulateGridViewRawMeterials();
                this.ClearAllRawMeterialInput();
          
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured due to invalid input.\nError Info:" + exc.Message);
            }

        }


        // Deleting Raw materials
        private void btnDeleteRawMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvRawMaterialsShow.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Row first to delete the data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var id = this.dgvRawMaterialsShow.CurrentRow.Cells[0].Value.ToString();
                var ProductName = this.dgvRawMaterialsShow.CurrentRow.Cells[2].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {ProductName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                var sql = "delete from RawMeterialInfo where RawId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(ProductName + " removed properly.");
                else
                    MessageBox.Show("Failure While removing the data");

                this.PopulateGridViewRawMeterials();
                this.ClearAllRawMeterialInput();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured due to invalid choice.\nError Info:" + exc.Message);
            }
        }

        // Double click event to auto enter the row items from table
        private void dgvRawMaterialsShow_DoubleClick(object sender, EventArgs e)
        {
            this.txtRawMaterialsId.Text = this.dgvRawMaterialsShow.CurrentRow.Cells[0].Value.ToString();
            this.cmbRawMaterialsCategoryInput.Text = this.dgvRawMaterialsShow.CurrentRow.Cells[1].Value.ToString();
            this.cmbRawProductNameInput.Text = this.dgvRawMaterialsShow.CurrentRow.Cells[2].Value.ToString();
            this.txtRawQuantityInput.Text = this.dgvRawMaterialsShow.CurrentRow.Cells[3].Value.ToString();
            this.txtRawCostInput.Text = this.dgvRawMaterialsShow.CurrentRow.Cells[4].Value.ToString();
            this.dtpRawMaterialReceiveDate.Text = this.dgvRawMaterialsShow.CurrentRow.Cells[5].Value.ToString();
        }


        // Raw material search using category name
        private void txtSearchRawMaterial_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from RawMeterialInfo where Rawcategory like '" + this.txtSearchRawMaterial.Text + "%';";
            this.PopulateGridViewRawMeterials(sql);
        }



        // Auto id creation
        private string AutoRawId()
        {
            var dt = Da.ExecuteQuery(@"Select * from RawMeterialInfo order by RawId Desc;");
            string lastId = dt.Tables[0].Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            string newId = "R-" + (++newIdNum).ToString();
            return newId;
        }

        private string AutoFinishedId()
        {
            var dt = Da.ExecuteQuery(@"Select * from FinishedProductInfo order by FinishedProductId Desc;");
            string lastId = dt.Tables[0].Rows[0][0].ToString();
            string[] id = lastId.Split('-');
            int newIdNum = Convert.ToInt32(id[1]);
            string newId = "F-" + (++newIdNum).ToString();
            return newId;
        }




        //*****************************Finished Product CRUD Operation*********************************


        // Clearing all finished product input
        private void ClearAllFinishedProduct()
        {
            this.txtFinishedProductId.Clear();
            this.cmbFinishedProductCategoryInput.SelectedIndex = -1;
            this.cmbFinishedProductNameInput.SelectedIndex = -1;
            this.txtFinishedProductQuantityInput.Clear();
            this.txtFinishedProductCostInput.Clear();
            this.dtpManufacturedDateInput.Text = "";


            this.txtFinishedProductSearch.Clear();
            this.dgvFinishedProductShow.ClearSelection();
        }


        // Checking validity of finished products inputto save
        private bool IsValidToSaveFinishedProduct()
        {
            if (String.IsNullOrEmpty(this.cmbFinishedProductCategoryInput.Text) ||
               String.IsNullOrEmpty(this.cmbFinishedProductNameInput.Text) || String.IsNullOrEmpty(this.txtFinishedProductQuantityInput.Text) ||
               String.IsNullOrEmpty(this.txtFinishedProductCostInput.Text))
            {
                return false;
            }
            else
                return true;
        }


        // Saving finished products

        private void btnFinishedProductSave_Click(object sender, EventArgs e)
        {


            try
            {
                string FId = this.AutoFinishedId();
                if (!this.IsValidToSaveFinishedProduct())
                {
                    MessageBox.Show("Empty fields are not allowed. Please fill all the information");
                    return;
                }

                var query = "select * from FinishedProductInfo where FinishedProductId = '" + this.txtFinishedProductId.Text + "';";

                var dt = this.Da.ExecuteQuery(query);
                if (dt.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update FinishedProductInfo
                                set 
                                FinishedCatagory = '" + this.cmbFinishedProductCategoryInput.Text + @"',
                                FinishedProductName = '" + this.cmbFinishedProductNameInput.Text + @"',
                                FinishedQuantity = " + this.txtFinishedProductQuantityInput.Text + @",
                                FinishedCost = '" + this.txtFinishedProductCostInput.Text + @"',
                                FinishDate = '" + DateTime.Parse(this.dtpManufacturedDateInput.Text) + @"'
                                where FinishedProductId = '" + this.txtFinishedProductId.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated properly.");
                    else
                        MessageBox.Show("Failure While updating the data");
                }
                else
                {
                    //insert
                    var sql = "insert into FinishedProductInfo values('" + FId + "', '" + this.cmbFinishedProductCategoryInput.Text + "', '" + this.cmbFinishedProductNameInput.Text + "', " + this.txtFinishedProductQuantityInput.Text + ", " + this.txtFinishedProductCostInput.Text + ", '" + DateTime.Parse(this.dtpManufacturedDateInput.Text) + "'); ";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data saved properly.");
                    else
                        MessageBox.Show("Failure While saving the data");

                }

                this.PopulateGridViewFinishedProduct();
                this.ClearAllFinishedProduct();
           
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured due to invalid input.\nError Info:" + exc.Message);
            }
        }


        // Deleting finished product
        private void btnFinishedProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvFinishedProductShow.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a Row first to delete the data", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var id = this.dgvFinishedProductShow.CurrentRow.Cells[0].Value.ToString();
                var ProductName = this.dgvFinishedProductShow.CurrentRow.Cells[2].Value.ToString();

                DialogResult result = MessageBox.Show($"Are you sure you want to delete {ProductName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                var sql = "delete from FinishedProductInfo where FinishedProductId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(ProductName + " removed properly.");
                else
                    MessageBox.Show("Failure While removing the data");

                this.PopulateGridViewFinishedProduct();
                this.ClearAllFinishedProduct();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured due to invalid choice.\nError Info:" + exc.Message);
            }
        }

        // Double click event to auto input the data inside input field to update
        private void dgvFinishedProductShow_DoubleClick(object sender, EventArgs e)
        {
            this.txtFinishedProductId.Text = this.dgvFinishedProductShow.CurrentRow.Cells[0].Value.ToString();
            this.cmbFinishedProductCategoryInput.Text = this.dgvFinishedProductShow.CurrentRow.Cells[1].Value.ToString();
            this.cmbFinishedProductNameInput.Text = this.dgvFinishedProductShow.CurrentRow.Cells["ProductName"].Value.ToString();
            this.txtFinishedProductQuantityInput.Text = this.dgvFinishedProductShow.CurrentRow.Cells[3].Value.ToString();
            this.txtFinishedProductCostInput.Text = this.dgvFinishedProductShow.CurrentRow.Cells[4].Value.ToString();
            this.dtpManufacturedDateInput.Text = this.dgvFinishedProductShow.CurrentRow.Cells[5].Value.ToString();
        }


        // Logged out
        private void btnManagerLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged Out");
            this.Fl.Show();
        }

        // Search product by category name
        private void txtFinishedProductSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from FinishedProductInfo where FinishedCatagory like '" + this.txtFinishedProductSearch.Text + "%';";
            this.PopulateGridViewFinishedProduct(sql);
        }

        private void FormWarehouseManager_Load(object sender, EventArgs e)
        {
            this.dgvFinishedProductShow.ClearSelection();
            this.dgvRawMaterialsShow.ClearSelection();
            
            
        }
    }

}
