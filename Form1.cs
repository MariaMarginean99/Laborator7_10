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
using System.Collections;

namespace EvidentaAgendaForms
{
    public partial class Form1 : Form
    {
        IStocareData adminPersoane;
        List<string> grupuriSelectate = new List<string>();
        public Form1()
        {
            InitializeComponent();
            adminPersoane = StocareFactory.GetAdministratorStocare();
        }

        
        private CodEroare Validare(string nume, string prenume, string numar, string mail)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (nume == string.Empty)
            {
                rezultatValidare|= CodEroare.NUME_INCORECT;
            }
            if (prenume == string.Empty)
            {
                rezultatValidare|= CodEroare.PRENUME_INCORECT;
            }
            if (numar == string.Empty)
            {
                rezultatValidare |= CodEroare.NUMAR_INCORECT;
            }
            if (mail == string.Empty)
            {
                rezultatValidare |= CodEroare.MAIL_INCORECT;
            }
           
           /* if (GetReteaSelectat() == Grupuri.InexistentG)
            {
                rezultatValidare |= CodEroare.NO_GROUPS;
            }*/
            int reteaSelectat = 0;
            foreach (var control in gbRetele.Controls)
            {
                RadioButton rdb = null;
                try
                {
                    rdb = (RadioButton)control;
                }
                catch { }

                if (rdb != null && rdb.Checked == true)
                    reteaSelectat = 1;
            }
            if (reteaSelectat==0)
            {
                rezultatValidare |= CodEroare.NO_RETELE;
            }

            return rezultatValidare;
        }
        private void MarcheazaControaleCuDateIncorecte(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.NUME_INCORECT) == CodEroare.NUME_INCORECT)
            {
                lblNume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PRENUME_INCORECT) == CodEroare.PRENUME_INCORECT)
            {
                lblPrenume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.NUMAR_INCORECT) == CodEroare.NUMAR_INCORECT)
            {
                lblNumar.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.MAIL_INCORECT) == CodEroare.MAIL_INCORECT)
            {
                lblMail.ForeColor = Color.Red;
            }
             if ((codValidare & CodEroare.NO_GROUPS) == CodEroare.NO_GROUPS)
             {
                    lblGrupuri.ForeColor = Color.Red;
             }
            if ((codValidare & CodEroare.NO_RETELE) == CodEroare.NO_RETELE)
            {
                lblRetele.ForeColor = Color.Red;
            }

        }
        private void ResetareControale()
        {
            txtNume.Text = txtPrenume.Text = txtMail.Text = txtNumar.Text = string.Empty;
            rdbOrange.Checked = false;
            rdbVodafone.Checked = false;
            rdbTelekom.Checked = false;
            rdbRDS.Checked = false;
            ckbFamily.Checked = false;
            ckbFriends.Checked = false;
            ckbWork.Checked = false;
            ckbTennisTeam.Checked = false;
            ListaPersoane.Text = string.Empty;
            comboText1.Text = string.Empty;
        }
        private void ResetCuloareEtichete()
        {
            lblNume.ForeColor = Color.Black;
            lblPrenume.ForeColor = Color.Black;
            lblNumar.ForeColor = Color.Black;
            lblMail.ForeColor = Color.Black;
            lblRetele.ForeColor = Color.Black;
            lblGrupuri.ForeColor = Color.Black;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private Retele GetReteaSelectat()
        {
            if (rdbOrange.Checked)
            {
                Console.WriteLine("Orange" + rdbOrange.Checked);
                return Retele.Orange;
                
            }
            if (rdbVodafone.Checked)
            {
                Console.WriteLine("Vodafone" + rdbVodafone.Checked);
                return Retele.Vodafone;
            }
            if (rdbTelekom.Checked)
            {
                Console.WriteLine("Telekom" + rdbTelekom.Checked);
                return Retele.Telekom;
            }
            if (rdbRDS.Checked)
            {
                Console.WriteLine("RDS" + rdbRDS.Checked);
                return Retele.RDS;
            }
            return Retele.InexistentR;
        }

        private void ckbGrupuri_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
            //sau
            //CheckBox checkBoxControl = (CheckBox)sender;  //operator cast

            string grupSelectat = checkBoxControl.Text;

            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                grupuriSelectate.Add(grupSelectat);
            else
                grupuriSelectate.Remove(grupSelectat);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 b = new Form3();
            b.Show();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();
            CodEroare codValidare = Validare(txtNume.Text, txtPrenume.Text, txtNumar.Text, txtMail.Text);
            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                Persoana p = new Persoana(txtNume.Text, txtPrenume.Text, txtNumar.Text, txtMail.Text);

                p.Tara = comboText1.Text;
                p.ReteaMobila = GetReteaSelectat();
                //set Discipline
                p.Groups = new List<string>();
                p.Groups.AddRange(grupuriSelectate);
                

                adminPersoane.AddPersoane(p);
                lblMesaj.Text = "Persoana a fost adaugata";

                //resetarea controalelor pentru a introduce datele unui student nou
                ResetareControale();

            }
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            ListaPersoane.Items.Clear();
            var antetTabel = String.Format("{0,-5}{1,10}{2,20}\n", "Nume Prenume", "Numar", "Retea");
            ListaPersoane.Items.Add(antetTabel);
            List<Persoana> persoane = adminPersoane.Get_Persoane();
            foreach (Persoana p in persoane)
            {
                var linieTabel = string.Format("\n{0,-5}{1,15}{2,20}", p.NumeComplet, p.numar, p.ReteaMobila.ToString());
                ListaPersoane.Items.Add(linieTabel);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTip_Click_1(object sender, EventArgs e)
        {
            CodEroare valideaza = Validare(txtNume.Text, txtPrenume.Text, txtNumar.Text, txtMail.Text);
            if (valideaza != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(valideaza);
            }
            else
            {
                if (txtNumar.Text[0] == '0')
                    if (txtNumar.Text[1] == '2' || txtNumar.Text[1] == '3')
                        lblMesaj.Text = "Fix";
                    else if (txtNumar.Text[1] == '7')
                    { lblMesaj.Text = "Mobil"; }
                    else
                        lblMesaj.Text = "Numar incorect";
                else
                    lblMesaj.Text = "Numar incorect";
            }
        }

       private void ListaPersoane_SelectedIndexChanged(object sender, EventArgs e)
        {
             Persoana p = adminPersoane.GetPersoana(ListaPersoane.SelectedIndex);

             if (p != null)
             {
                //idLabel.Text = s.IdStudent.ToString();
                comboText1.Text = p.Tara;

                 txtNume.Text = p.nume;
                 txtPrenume.Text = p.prenume;
                 txtNumar.Text = p.numar;
                 txtMail.Text = p.mail;

                 foreach (var grup in gbGrupuri.Controls)
                 {
                     if (grup is CheckBox)
                     {
                         var grupBox = grup as CheckBox;
                         foreach (String dis in p.Groups)
                             if (grupBox.Text.Equals(dis))
                                grupBox.Checked = true;
                     }
                 }
                 foreach (var retele in gbRetele.Controls)
                 {
                     if (retele is RadioButton)
                     {
                         var reteleBox = retele as RadioButton;

                         if (reteleBox.Text.Equals(p.ReteaMobila.ToString()))
                            reteleBox.Checked = true;
                     }
                 }

             }
        }
    }
}
