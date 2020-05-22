using System;
using System.Collections.Generic;
namespace LibrarieModele
{
    
    public class Persoana
    {
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        
        public Retele ReteaMobila{ set; get; }
        public List <string> Groups { get; set; }
        public DateTime DataActualizare { get; set; }
        public string Tara { get; set; }

        //preprietati auto-implemented 
        public static int IdUltimPersoana { get; set; } = 0;
        public string nume { get; set; }
        public string prenume { get; set; }
        public string NumeComplet { get { return nume + " " + prenume; } }
        public string numar { get; set; }
        public string mail { get; set; }
        public int IdPersoana { get; set; }
        public string GrupAsString 
        {
            get
            {
                string pGrup = string.Empty;

                foreach (string grup in Groups)
                {
                    if (pGrup != string.Empty)
                    {
                        pGrup += SEPARATOR_SECUNDAR_FISIER;
                    }
                    pGrup += grup;
                }

                return pGrup;
            }
        }

        //constructor implicit(Tema laborator2)
        public Persoana()
        {

        }
        //constructor care primeste ca parametru un sir(Tema laborator3)
        public Persoana(string sir)
        {
            string[] cuvinte = sir.Split(',');
            //IdPersoana = Convert.ToInt32(cuvinte[0]);
            nume = cuvinte[0];
            prenume = cuvinte[1];
            numar = cuvinte[2];
            mail = cuvinte[3];
            ReteaMobila = (Retele)Enum.Parse(typeof(Retele),cuvinte[4]);
            Groups = new List<string>();
            Groups.AddRange(cuvinte[5].Split(' '));
            Tara = cuvinte[6];
            DataActualizare = Convert.ToDateTime(cuvinte[7]);
        }
        //constructor cu 3 parametrii(Tema laborator2)
        public Persoana(string _nume,string _prenume, string _numar, string _mail)
        {
            nume = _nume;
            prenume = _prenume;
            numar = _numar;
            mail = _mail;
            DataActualizare = DateTime.Now;
            IdUltimPersoana++;
            IdPersoana = IdUltimPersoana;
        }
        //constructor cu 4 parametrii(Tema laborator5)
        public Persoana(string _nume,string _prenume, string _numar, string _mail, Retele _retele)
        {
            nume = _nume;
            prenume = _prenume;
            numar = _numar;
            mail = _mail;
            ReteaMobila = _retele;
            IdUltimPersoana++;
            IdPersoana = IdUltimPersoana;
            DataActualizare = DateTime.Now;
        }
        public int NameCompare(Persoana p1)
        {
            return nume.CompareTo(p1.nume);
        }
        
        //Afiseaza datele despre o persoana(Tema laborator 4)
        public string PrintGroup()
        {
            string sir1 = string.Format("{1} {2} face parte din reteaua {0}", ReteaMobila, nume,prenume);
            return sir1;
        }
        public string ConversieLaSir_PentruFisier()
        {
            string sir1;
            if (nume == null || prenume == null || numar == null || mail == null) 
                sir1 = string.Format("Adaugati persoana in agenda prima data");
            else
                sir1 = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}" ,nume,prenume,numar, mail,ReteaMobila,GrupAsString,Tara,DataActualizare);
            //Console.WriteLine("Sir1 "+sir1);
            return sir1;
        }
        //Afisarea datelor despre o persoana plus grupul din care face parte
        public string ConversieLaSir()
        {
            string sir1;
            if (nume == null || prenume == null || numar == null || mail == null)
                sir1 = string.Format("Adaugati persoana in agenda prima data");
            else
                sir1 = string.Format("Persoana are numele: {0} {1}\nNumarul de telefon: {2}\nEmail-ul: {3}\nFace parte din reteaua {4}", nume, prenume, numar, mail, ReteaMobila);
            return sir1;
        }
        /// afisare forms
        public string PrintInfo()
        {
            string sir1;
            if (nume == null || prenume == null || numar == null || mail == null)
                sir1 = string.Format("Adaugati persoana in agenda prima data");
            else
                sir1 = string.Format("\nPersoana are numele: {0} {1}\nNumarul de telefon: {2}\nEmail-ul: {3}", nume, prenume, numar, mail);
            return sir1;
        }
        //afisare persoana(Tema laborator 2)
        public string Afisare()
        {
            if (nume == null || prenume == null || numar == null || mail == null)
                return string.Format("Adaugati persoana in agenda prima data");
            else
                return string.Format("\nPersoana are numele: {0} {1}\nNumarul de telefon: {2}\nEmail-ul: {3}", nume,prenume,numar, mail);
        }
    }
}
