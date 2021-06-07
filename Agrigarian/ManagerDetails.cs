using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agrigarian
{
    public partial class ManagerDetails : Form
    {

        DatabaseManager dObj = new DatabaseManager();
        private string id;
        private bool state = false;
        public ManagerDetails()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mname.Text) && string.IsNullOrEmpty(txt_NIC.Text) && string.IsNullOrEmpty(txt_tele.Text))
            {
                MessageBox.Show("Please Fill the fields");
            }
            else if(string.IsNullOrEmpty(txt_mname.Text))
            {
                MessageBox.Show("Please Enter the name");
            }
            else if (txt_mname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Name Cannot be Numbers");
            }
            else if (!((txt_NIC.Text.Count(char.IsDigit) == 9) && (txt_NIC.Text.EndsWith("X") || txt_NIC.Text.EndsWith("V")) && (txt_NIC.Text[2] != '4' && txt_NIC.Text[2] != '9')))
            {
                MessageBox.Show("Please Enter the NIC number");
            }
            else if (string.IsNullOrEmpty(txt_tele.Text))
            {
                MessageBox.Show("Please Enter the telephone number");
            }
            else if (!Regex.IsMatch(txt_tele.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                MessageBox.Show("Please Enter valid Telephone Number");
            }
            else
            {
                int i = dObj.insertUpdateDelete("INSERT INTO Manager VALUES('" + txt_mname.Text + "','" + txt_NIC.Text + "','"+txt_tele.Text+ "','" + txtMUsername.Text + "','" + txtPassword.Text + "')");

                if (i == 1)
                {
                    MessageBox.Show("Inserted Success");
                }
                else
                {
                    MessageBox.Show("Not inserted");
                }

            }

        }
    }
}
