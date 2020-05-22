using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidentaAgendaForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtPass.PasswordChar = '•';
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            
            if ((txtUser.Text == "Maria") && (txtPass.Text == "1324"))
            {
                lblMesaj.Text = "";
                lblUser.ForeColor = Color.Black;
                lblPass.ForeColor = Color.Black;

                this.Hide();
                Form3 f = new Form3();
                f.Show();
            }
            else
            {
                lblMesaj.Text = "Username sau password gresite!";
                txtPass.Text=txtUser.Text = string.Empty;
                lblUser.ForeColor = Color.Red;
                lblPass.ForeColor = Color.Red;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
