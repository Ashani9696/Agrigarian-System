using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrigarian
{
    public partial class Login : Form
    {
        DatabaseManager dbObj = new DatabaseManager();
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Enter Username and Password");
            }
            else if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Enter Username");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Enter Password");
            }
            else
            {
                string query;
                DataTable dt = new DataTable();
                query = "SELECT * FROM Manager WHERE man_uname = '" + txtUsername.Text + "' AND man_pw = '" + txtPassword.Text + "'";
                dt = dbObj.getData(query);

                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show(dt.Rows[1]["manager_name"].ToString());
                    Main objMain = new Main();
                    this.Hide();
                    objMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please check your username and password");
                }
            }
        }

        private void lnklblMangerReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dbObj.getData("SELECT * FROM Manager");
            if (!(dt.Rows.Count == 2))
            {
                ManagerDetails obj = new ManagerDetails();
                this.Hide();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cant create account!!!");
            }
        }
    }

}
