using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Smucisce.Core;

namespace Faza_1___Jernej_Robnik
{
    public partial class Form1 : Form
    {
        private List<Vlecnica> vlecnice = new List<Vlecnica>();
        private Izposoja izposoja = new Izposoja();

        private enum Nacin { None, User, Admin }
        private Nacin trenutniNacin = Nacin.None;

        public Form1()
        {
            InitializeComponent();

            InicializirajPodatke();
            PoveziDogodke();

            PrikaziZacetniZaslon();
        }

        //zacetni zaslon
        private void PrikaziZacetniZaslon()
        {
            //trenutniNacin = Nacin.None;

            //groupBoxUser.Visible = false;
            //groupBoxAdmin.Visible = false;

            //btnUser.Visible = true;
            //btnAdmin.Visible = true;
            //labelNacin.Visible = false;
            //btnLogout.Visible = false;

            //labelNacin.Text = "";
        }

        //preklop nacina
        private void NastaviNacin(Nacin nacin)
        {
            trenutniNacin = nacin;

            bool admin = nacin == Nacin.Admin;
            bool user = nacin == Nacin.User;

            labelNacin.Text = $"Način: {nacin}";

            OsveziVlecnice();
            OsveziIzposojo();
        }

        //podatki
        private void InicializirajPodatke()
        {
            Proga p1 = new Proga("Modra lisica", 1200, TezavnostProge.Lahka);
            Proga p2 = new Proga("Rdeči greben", 1800, TezavnostProge.Srednja);

            Vlecnica v1 = new Sedeznica("Sedeznica A", 120, 4);
            v1.DodajProgo(p1);
            v1.DodajProgo(p2);

            Vlecnica v2 = new VlecnicaSidro("Sidro B", 300);
            v2.DodajProgo(p1);

            vlecnice.Add(v1);
            vlecnice.Add(v2);

            izposoja.DodajOprema(new Smuci(170, 15, "Elan", true));
            izposoja.DodajOprema(new Smuci(180, 15, "Atomic", true));
            izposoja.DodajOprema(new Snowboard(160, 18, "Burton", "Freestyle"));
            izposoja.DodajOprema(new Snowboard(155, 18, "Nitro", "All-mountain"));
        }

        private void PoveziDogodke()
        {
            izposoja.OpremaIzposojena += Izposoja_OpremaIzposojena;
            izposoja.OpremaVrnjena += Izposoja_OpremaVrnjena;

            foreach (var v in vlecnice)
                v.StatusSpremenjen += Vlecnica_StatusSpremenjen;
        }

        //osvezevanje
        private void OsveziVlecnice()
        {
            listVlecnice.Items.Clear();

            foreach (var v in vlecnice)
                listVlecnice.Items.Add(v);
        }

        private void OsveziIzposojo()
        {
            comboBoxOprema.Items.Clear();

            foreach (var o in izposoja.ProstaOprema)
                comboBoxOprema.Items.Add(o);

            labelCena.Text = $"Prihodek: {Izposoja.SkupniPrihodek} €";
        }

        //listi
        private void listVlecnice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVlecnice.SelectedItem is Vlecnica v)
            {
                listProge.Items.Clear();

                foreach (var p in v.Proge)
                    listProge.Items.Add(p);
            }
        }

        //izposoja
        private void buttonIzposodi_Click(object sender, EventArgs e)
        {
            if (comboBoxOprema.SelectedItem is Oprema o)
            {
                int dni = (int)numericUpDown1.Value;
                izposoja.Izposodi(o, dni);
            }
        }

        private void buttonVrni_Click(object sender, EventArgs e)
        {
            if (listIzposoja.SelectedItem is Oprema o)
            {
                izposoja.Vrni(o);
            }
        }

        private void Izposoja_OpremaIzposojena(object sender, Oprema o)
        {
            listIzposoja.Items.Add(o);
            OsveziIzposojo();
        }

        private void Izposoja_OpremaVrnjena(object sender, Oprema o)
        {
            listIzposoja.Items.Remove(o);
            OsveziIzposojo();
        }

        //admin
        private void btnZazeni_Click(object sender, EventArgs e)
        {
            if (listVlecnice.SelectedItem is Vlecnica v)
                v.Zazeni();
        }

        private void btnUstavi_Click(object sender, EventArgs e)
        {
            if (listVlecnice.SelectedItem is Vlecnica v)
                v.Ustavi();
        }

        private void btnOdpriProgo_Click(object sender, EventArgs e)
        {
            if (listProge.SelectedItem is Proga p)
                p.NastaviObratovanje(true);
        }

        private void btnZapriProgo_Click(object sender, EventArgs e)
        {
            if (listProge.SelectedItem is Proga p)
                p.NastaviObratovanje(false);
        }

        private void Vlecnica_StatusSpremenjen(object sender, bool e)
        {
            OsveziVlecnice();
        }

        //gumbi
        private void btnUser_Click(object sender, EventArgs e)
        {
            groupBoxUser.Visible = true;
            btnAdmin.Visible = false;
            btnUser.Visible = false;
            labelNacin.Text = "Uporabnik";
            labelNacin.Visible = true;
            btnLogout.Visible = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            NastaviNacin(Nacin.Admin);
            groupBoxAdmin.Visible = true;
            btnAdmin.Visible = false;
            btnUser.Visible = false;
            labelNacin.Text = "Admin";
            labelNacin.Visible = true;
            btnLogout.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PrikaziZacetniZaslon();
        }

        private void btnUser_Click_1(object sender, EventArgs e)
        {

        }
    }
}