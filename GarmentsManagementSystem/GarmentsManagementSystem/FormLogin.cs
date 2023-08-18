using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GarmentsManagementSystem
{
    public partial class FormLogin : MaterialForm
    {
        private DataAccess Da { get; set; }
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public FormLogin()
        {

            InitializeComponent();
            this.Da = new DataAccess();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.Amber900, Primary.Amber800, Accent.Amber200, TextShade.WHITE);

        }


        // Login Operation
        private void btnLoginButton_Click(object sender, EventArgs e)
        {

            // Form validation for user login (User ID and Password)
            if (this.txtLoginUserId.Text == "")
            {
                this.lblErrorUserId.Text = "Please Enter User ID";
                this.lblErrorUserId.ForeColor = Color.Red;
            }
            else
            {
                this.lblErrorUserId.Text = "";

            }
            if (this.txtLoginPassword.Text == "")
            {
                this.lblErrorPassword.Text = "Please Enter Password";
                this.lblErrorPassword.ForeColor = Color.Red;
            }
            else
            {
                this.lblErrorPassword.Text = "";

            }


            var sql = "select * from Admin_info where A_id = '" + this.txtLoginUserId.Text + "' and A_Password = '" + this.txtLoginPassword.Text + "';";
            var dt = this.Da.ExecuteQuery(sql);

            var quary = "select * from Manager_info where M_id = '" + this.txtLoginUserId.Text + "' and M_Password = '" + this.txtLoginPassword.Text + "';";
            var dtm = this.Da.ExecuteQuery(quary);

            //admin login operation
            if (dt.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Logging in...");

                String name = dt.Tables[0].Rows[0][1].ToString();
                String id = dt.Tables[0].Rows[0][0].ToString();
                if (dt.Tables[0].Rows[0][4].ToString() == "Admin")
                {
                    this.Hide();
                    new FormAdmin(name,id,Mid,this).Show();
                }

            }


            //Manager Login operation

            else if (dtm.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Logging in...");
                String name = dtm.Tables[0].Rows[0][1].ToString();
                if (dtm.Tables[0].Rows[0][4].ToString() == "Manager")
                {
                    this.Hide();
                    new FormWarehouseManager(name, this).Show();
                }

            }
            else
            {
                MessageBox.Show("Invalid User", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtLoginUserId.Clear();
                this.txtLoginPassword.Clear();
            }

        }

        private string Mid;
        // Forgot password reset request to admin
        private void lblResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var quary = "select * from Manager_info where M_id = '" + this.txtLoginUserId.Text + "';";
                var dtM = this.Da.ExecuteQuery(quary);

                if (txtLoginUserId.Text == "")
                {
                    MessageBox.Show("Please Enter an user id to request for password reset!", "Enter User ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dtM.Tables[0].Rows.Count == 1)
                    {
                        string id = dtM.Tables[0].Rows[0][0].ToString();

                        Mid = id;
                        MessageBox.Show("Request send successfully to the admin.");

                    }
                }
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
          
        }

     
    }
}
