using System;
using System.Collections.Generic;
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

            PoveziDogodke();

            listVlecnice.SelectedIndexChanged += listVlecnice_SelectedIndexChanged;
            listBoxVlecnice.SelectedIndexChanged += listBoxVlecnice_SelectedIndexChanged;

            btnUser.Click += btnUser_Click;
            btnAdmin.Click += btnAdmin_Click;
            btnLogout.Click += btnLogout_Click;

            btnIzposodi.Click += btnIzposodi_Click;
            btnVrni.Click += btnVrni_Click;

            btnZazeni.Click += btnZazeni_Click;
            btnUstavi.Click += btnUstavi_Click;
            btnOdpri.Click += btnOdpri_Click;
            btnZapri.Click += btnZapri_Click;

            InicializirajPodatke();
            PrikaziZacetniZaslon();
        }

        private void PrikaziZacetniZaslon()
        {
            trenutniNacin = Nacin.None;

            groupBoxUser.Visible = false;
            groupBoxAdmin.Visible = false;

            btnUser.Visible = true;
            btnAdmin.Visible = true;

            labelNacin.Visible = false;
            btnLogout.Visible = false;
        }

        private void NastaviNacin(Nacin nacin)
        {
            trenutniNacin = nacin;

            groupBoxUser.Visible = nacin == Nacin.User;
            groupBoxAdmin.Visible = nacin == Nacin.Admin;

            labelNacin.Visible = true;
            labelNacin.Text = nacin == Nacin.User ? "Način: User" : "Način: Admin";

            btnUser.Visible = false;
            btnAdmin.Visible = false;
            btnLogout.Visible = true;

            OsveziVlecnice();
        }
        private void OsveziVlecnice()
        {
            listVlecnice.Items.Clear();
            listBoxVlecnice.Items.Clear();

            foreach (var v in vlecnice)
            {
                listVlecnice.Items.Add(v);
                listBoxVlecnice.Items.Add(v);
            }
        }
        private void OsveziProge(Vlecnica v)
        {
            listProge.Items.Clear();
            listBox1.Items.Clear();

            foreach (var p in v.Proge)
            {
                listProge.Items.Add(p);
                listBox1.Items.Add(p);
            }
        }

        private void InicializirajPodatke()
        {
            Proga p1 = new Proga("Proga 1", 1200, TezavnostProge.Lahka);
            Proga p2 = new Proga("Proga 2", 1500, TezavnostProge.Srednja);
            Proga p3 = new Proga("Proga 3", 900, TezavnostProge.Tezka);
            Proga p4 = new Proga("Proga 4", 1000, TezavnostProge.Lahka);
            Proga p5 = new Proga("Proga 5", 1700, TezavnostProge.Srednja);

            Vlecnica v1 = new Sedeznica("Sedežnica 1", 200, 4);
            Vlecnica v2 = new Sedeznica("Sedežnica 2", 180, 6);
            Vlecnica v3 = new VlecnicaSidro("Sidro 1", 300);
            Vlecnica v4 = new VlecnicaSidro("Sidro 2", 250);

            v1.DodajProgo(p1);
            v1.DodajProgo(p2);

            v2.DodajProgo(p3);

            v3.DodajProgo(p4);

            v4.DodajProgo(p5);

            vlecnice.Add(v1);
            vlecnice.Add(v2);
            vlecnice.Add(v3);
            vlecnice.Add(v4);

            foreach (var v in vlecnice)
            {
                listVlecnice.Items.Add(v);
                listBoxVlecnice.Items.Add(v);
            }

            izposoja.DodajOprema(new Smuci(170, 15, "Elan", true));
            izposoja.DodajOprema(new Smuci(180, 16, "Atomic", true));
            izposoja.DodajOprema(new Snowboard(160, 18, "Burton", "Freestyle"));
            izposoja.DodajOprema(new Snowboard(158, 18, "Nitro", "All-Mountain"));
            izposoja.DodajOprema(new Smuci(165, 14, "Fischer", true));

            foreach (var o in izposoja.ProstaOprema)
                comboBoxOprema.Items.Add(o);

        }

        private void PoveziDogodke()
        {
            izposoja.OpremaIzposojena += Izposoja_OpremaIzposojena;
            izposoja.OpremaVrnjena += Izposoja_OpremaVrnjena;

            foreach (var v in vlecnice)
                v.StatusSpremenjen += Vlecnica_StatusSpremenjen;
        }

 

        private void OsveziIzposojo()
        {
            comboBoxOprema.Items.Clear();

            foreach (var o in izposoja.ProstaOprema)
                comboBoxOprema.Items.Add(o);

            labelPrihodek.Text = $"Prihodek: {Izposoja.SkupniPrihodek} €";
        }

        private void listVlecnice_SelectedIndexChanged(object sender, EventArgs e)
        {
            listProge.Items.Clear();

            if (listVlecnice.SelectedItem is Vlecnica v)
            {
                foreach (Proga p in v.Proge)
                {
                    listProge.Items.Add(p);
                }
            }

        }

        private void listBoxVlecnice_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (listBoxVlecnice.SelectedItem is Vlecnica v)
            {
                foreach (Proga p in v.Proge)
                {
                    listBox1.Items.Add(p);
                }
            }
        }

        private void btnIzposodi_Click(object sender, EventArgs e)
        {
            if (comboBoxOprema.SelectedItem == null) return;

            Oprema o = (Oprema)comboBoxOprema.SelectedItem;
            int dni = (int)numericUpDown1.Value;

            izposoja.Izposodi(o, dni);

            comboBoxOprema.Items.Remove(o);
            listIzposoja.Items.Add(o);

            OsveziIzposojo();
        }

        private void btnVrni_Click(object sender, EventArgs e)
        {
            if (listIzposoja.SelectedItem == null) return;

            Oprema o = (Oprema)listIzposoja.SelectedItem;

            izposoja.Vrni(o);

            listIzposoja.Items.Remove(o);
            comboBoxOprema.Items.Add(o);

            OsveziIzposojo();
        }

        private void Izposoja_OpremaIzposojena(object sender, Oprema o)
        {
            OsveziIzposojo();
        }

        private void Izposoja_OpremaVrnjena(object sender, Oprema o)
        {
            listIzposoja.Items.Remove(o);
            OsveziIzposojo();
        }

        private void btnZazeni_Click(object sender, EventArgs e)
        {
            if (listBoxVlecnice.SelectedItem == null) return;

            Vlecnica v = (Vlecnica)listBoxVlecnice.SelectedItem;
            v.Zazeni();

            OsveziVlecnice();
        }

        private void btnUstavi_Click(object sender, EventArgs e)
        {
            if (listBoxVlecnice.SelectedItem == null) return;

            Vlecnica v = (Vlecnica)listBoxVlecnice.SelectedItem;
            v.Ustavi();

            OsveziVlecnice();
        }

        private void btnOdpri_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Proga p = (Proga)listBox1.SelectedItem;
            p.NastaviObratovanje(true);

            if (listBoxVlecnice.SelectedItem is Vlecnica v)
                OsveziProge(v);
        }

        private void btnZapri_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Proga p = (Proga)listBox1.SelectedItem;
            p.NastaviObratovanje(false);

            if (listBoxVlecnice.SelectedItem is Vlecnica v)
                OsveziProge(v);
        }

        private void Vlecnica_StatusSpremenjen(object sender, bool e)
        {
            OsveziVlecnice();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            NastaviNacin(Nacin.User);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            NastaviNacin(Nacin.Admin);
            groupBoxAdmin.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PrikaziZacetniZaslon();
            groupBoxAdmin.Visible = false;
            groupBoxUser.Visible = false;
            labelNacin.Visible = false;
            btnLogout.Visible = false;
            btnUser.Visible = true;
            btnAdmin.Visible = true;
        }
    }
}