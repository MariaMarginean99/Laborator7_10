using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;

namespace EvidentaAgendaForms
{
    public partial class Form4 : Form
    {
        IStocareData adminPersoane;
        List<string> grupuriSelectate = new List<string>();
        public Form4()
        {
            InitializeComponent();
            adminPersoane = StocareFactory.GetAdministratorStocare();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 b = new Form3();
            b.Show();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            Persoana p = adminPersoane.GetPersoana(txtNume.Text, txtPrenume.Text);
            DateTime data1= dtpCauta1.Value;
            DateTime data2 = dtpCauta2.Value;
            if (data1 <= p.DataActualizare && data2 >= p.DataActualizare)
            {
                if (p != null)
                {

                    lblMesaj.Text = string.Empty;
                    lblMesaj.Text = "Persoana este in agenda!";

                }
                else
                {
                    lblMesaj.Text = string.Empty;
                    lblMesaj.Text = "Persoana nu este in agenda!";
                }
                if (txtNume.Enabled == true && txtPrenume.Enabled == true)
                {
                    txtNume.Enabled = false;
                    txtPrenume.Enabled = false;

                }
                else
                {
                    txtNume.Enabled = true;
                    txtPrenume.Enabled = true;

                }
            }
            else
            {
                lblMesaj.Text = string.Empty;
                lblMesaj.Text = "Persoana nu este in agenda!";
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            Persoana p = adminPersoane.GetPersoana(txtNume.Text, txtPrenume.Text);
            if (p != null)
            {
               p.mail=txtMail.Text;
               p.numar=txtNumar.Text;
               p.DataActualizare = DateTime.Now;
                adminPersoane.UpdatePersoana(p);
                List<Persoana> persoane = adminPersoane.Get_Persoane();
                AdaugaPersoaneInControlDataGridView(persoane);
                
                txtNume.Enabled = true;
                txtPrenume.Enabled = true;
            }
            else
            {
                lblMesaj.Text = string.Empty;
                lblMesaj.Text = "Persoana inexistenta!";
            }
        }
        public void AdaugaPersoaneInControlDataGridView(List<Persoana> persoane)
        {
            //reset continut control DataGridView
            dataGridPersoane.DataSource = null;

            //!!!! Controlul de tip DataGridView are ca sursa de date lista de obiecte de tip Student !!!
            //dataGridStudenti.DataSource = studenti;
             
            //personalizare sursa de date
            dataGridPersoane.DataSource = persoane.Select(p => new {p.nume, p.prenume, p.numar,p.mail, p.DataActualizare }).ToList();
        }
    }
}
