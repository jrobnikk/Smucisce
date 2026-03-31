namespace Faza_1___Jernej_Robnik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.labelCena1 = new System.Windows.Forms.Label();
            this.labelCena = new System.Windows.Forms.Label();
            this.btnVrni = new System.Windows.Forms.Button();
            this.labelIzposojeno = new System.Windows.Forms.Label();
            this.btnIzposodi = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelDni = new System.Windows.Forms.Label();
            this.comboBoxOprema = new System.Windows.Forms.ComboBox();
            this.opremaLabel = new System.Windows.Forms.Label();
            this.labelIzposoja = new System.Windows.Forms.Label();
            this.labelProge = new System.Windows.Forms.Label();
            this.labelVlecnice = new System.Windows.Forms.Label();
            this.listProge = new System.Windows.Forms.ListBox();
            this.listVlecnice = new System.Windows.Forms.ListBox();
            this.labelNacin = new System.Windows.Forms.Label();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.labelVlecnice1 = new System.Windows.Forms.Label();
            this.listBoxVlecnice = new System.Windows.Forms.ListBox();
            this.labelProge1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelNadzor = new System.Windows.Forms.Label();
            this.btnZazeni = new System.Windows.Forms.Button();
            this.btnUstavi = new System.Windows.Forms.Button();
            this.btnOdpri = new System.Windows.Forms.Button();
            this.btnZapri = new System.Windows.Forms.Button();
            this.labelPretok = new System.Windows.Forms.Label();
            this.listIzposoja = new System.Windows.Forms.ListBox();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(484, 220);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "Uporabnik";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click_1);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(484, 258);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(943, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Odjava";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.listIzposoja);
            this.groupBoxUser.Controls.Add(this.labelCena1);
            this.groupBoxUser.Controls.Add(this.labelCena);
            this.groupBoxUser.Controls.Add(this.btnVrni);
            this.groupBoxUser.Controls.Add(this.labelIzposojeno);
            this.groupBoxUser.Controls.Add(this.btnIzposodi);
            this.groupBoxUser.Controls.Add(this.numericUpDown1);
            this.groupBoxUser.Controls.Add(this.labelDni);
            this.groupBoxUser.Controls.Add(this.comboBoxOprema);
            this.groupBoxUser.Controls.Add(this.opremaLabel);
            this.groupBoxUser.Controls.Add(this.labelIzposoja);
            this.groupBoxUser.Controls.Add(this.labelProge);
            this.groupBoxUser.Controls.Add(this.labelVlecnice);
            this.groupBoxUser.Controls.Add(this.listProge);
            this.groupBoxUser.Controls.Add(this.listVlecnice);
            this.groupBoxUser.Location = new System.Drawing.Point(100, 54);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(846, 448);
            this.groupBoxUser.TabIndex = 3;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Visible = false;
            // 
            // labelCena1
            // 
            this.labelCena1.AutoSize = true;
            this.labelCena1.Location = new System.Drawing.Point(615, 105);
            this.labelCena1.Name = "labelCena1";
            this.labelCena1.Size = new System.Drawing.Size(35, 13);
            this.labelCena1.TabIndex = 14;
            this.labelCena1.Text = "label1";
            // 
            // labelCena
            // 
            this.labelCena.AutoSize = true;
            this.labelCena.Location = new System.Drawing.Point(561, 105);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(35, 13);
            this.labelCena.TabIndex = 13;
            this.labelCena.Text = "Cena:";
            // 
            // btnVrni
            // 
            this.btnVrni.Location = new System.Drawing.Point(615, 376);
            this.btnVrni.Name = "btnVrni";
            this.btnVrni.Size = new System.Drawing.Size(75, 23);
            this.btnVrni.TabIndex = 12;
            this.btnVrni.Text = "Vrni";
            this.btnVrni.UseVisualStyleBackColor = true;
            // 
            // labelIzposojeno
            // 
            this.labelIzposojeno.AutoSize = true;
            this.labelIzposojeno.Location = new System.Drawing.Point(561, 190);
            this.labelIzposojeno.Name = "labelIzposojeno";
            this.labelIzposojeno.Size = new System.Drawing.Size(61, 13);
            this.labelIzposojeno.TabIndex = 10;
            this.labelIzposojeno.Text = "Izposojeno:";
            // 
            // btnIzposodi
            // 
            this.btnIzposodi.Location = new System.Drawing.Point(615, 142);
            this.btnIzposodi.Name = "btnIzposodi";
            this.btnIzposodi.Size = new System.Drawing.Size(75, 23);
            this.btnIzposodi.TabIndex = 9;
            this.btnIzposodi.Text = "Izposodi";
            this.btnIzposodi.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(615, 73);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(558, 75);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(29, 13);
            this.labelDni.TabIndex = 7;
            this.labelDni.Text = "Dni: ";
            // 
            // comboBoxOprema
            // 
            this.comboBoxOprema.FormattingEnabled = true;
            this.comboBoxOprema.Location = new System.Drawing.Point(615, 44);
            this.comboBoxOprema.Name = "comboBoxOprema";
            this.comboBoxOprema.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOprema.TabIndex = 6;
            // 
            // opremaLabel
            // 
            this.opremaLabel.AutoSize = true;
            this.opremaLabel.Location = new System.Drawing.Point(558, 44);
            this.opremaLabel.Name = "opremaLabel";
            this.opremaLabel.Size = new System.Drawing.Size(50, 13);
            this.opremaLabel.TabIndex = 5;
            this.opremaLabel.Text = "Oprema: ";
            // 
            // labelIzposoja
            // 
            this.labelIzposoja.AutoSize = true;
            this.labelIzposoja.Location = new System.Drawing.Point(558, 10);
            this.labelIzposoja.Name = "labelIzposoja";
            this.labelIzposoja.Size = new System.Drawing.Size(49, 13);
            this.labelIzposoja.TabIndex = 4;
            this.labelIzposoja.Text = "Izposoja:";
            // 
            // labelProge
            // 
            this.labelProge.AutoSize = true;
            this.labelProge.Location = new System.Drawing.Point(292, 10);
            this.labelProge.Name = "labelProge";
            this.labelProge.Size = new System.Drawing.Size(38, 13);
            this.labelProge.TabIndex = 3;
            this.labelProge.Text = "Proge:";
            // 
            // labelVlecnice
            // 
            this.labelVlecnice.AutoSize = true;
            this.labelVlecnice.Location = new System.Drawing.Point(45, 10);
            this.labelVlecnice.Name = "labelVlecnice";
            this.labelVlecnice.Size = new System.Drawing.Size(51, 13);
            this.labelVlecnice.TabIndex = 2;
            this.labelVlecnice.Text = "Vlečnice:";
            // 
            // listProge
            // 
            this.listProge.FormattingEnabled = true;
            this.listProge.Location = new System.Drawing.Point(292, 44);
            this.listProge.Name = "listProge";
            this.listProge.Size = new System.Drawing.Size(182, 355);
            this.listProge.TabIndex = 1;
            // 
            // listVlecnice
            // 
            this.listVlecnice.FormattingEnabled = true;
            this.listVlecnice.Location = new System.Drawing.Point(45, 44);
            this.listVlecnice.Name = "listVlecnice";
            this.listVlecnice.Size = new System.Drawing.Size(161, 355);
            this.listVlecnice.TabIndex = 0;
            // 
            // labelNacin
            // 
            this.labelNacin.AutoSize = true;
            this.labelNacin.Location = new System.Drawing.Point(849, 17);
            this.labelNacin.Name = "labelNacin";
            this.labelNacin.Size = new System.Drawing.Size(41, 13);
            this.labelNacin.TabIndex = 4;
            this.labelNacin.Text = "Nacin: ";
            this.labelNacin.Visible = false;
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.labelPretok);
            this.groupBoxAdmin.Controls.Add(this.btnZapri);
            this.groupBoxAdmin.Controls.Add(this.btnOdpri);
            this.groupBoxAdmin.Controls.Add(this.btnUstavi);
            this.groupBoxAdmin.Controls.Add(this.btnZazeni);
            this.groupBoxAdmin.Controls.Add(this.labelNadzor);
            this.groupBoxAdmin.Controls.Add(this.listBox1);
            this.groupBoxAdmin.Controls.Add(this.labelProge1);
            this.groupBoxAdmin.Controls.Add(this.listBoxVlecnice);
            this.groupBoxAdmin.Controls.Add(this.labelVlecnice1);
            this.groupBoxAdmin.Location = new System.Drawing.Point(100, 54);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Size = new System.Drawing.Size(846, 448);
            this.groupBoxAdmin.TabIndex = 5;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Visible = false;
            // 
            // labelVlecnice1
            // 
            this.labelVlecnice1.AutoSize = true;
            this.labelVlecnice1.Location = new System.Drawing.Point(44, 20);
            this.labelVlecnice1.Name = "labelVlecnice1";
            this.labelVlecnice1.Size = new System.Drawing.Size(51, 13);
            this.labelVlecnice1.TabIndex = 0;
            this.labelVlecnice1.Text = "Vlečnice:";
            // 
            // listBoxVlecnice
            // 
            this.listBoxVlecnice.FormattingEnabled = true;
            this.listBoxVlecnice.Location = new System.Drawing.Point(23, 61);
            this.listBoxVlecnice.Name = "listBoxVlecnice";
            this.listBoxVlecnice.Size = new System.Drawing.Size(188, 355);
            this.listBoxVlecnice.TabIndex = 1;
            // 
            // labelProge1
            // 
            this.labelProge1.AutoSize = true;
            this.labelProge1.Location = new System.Drawing.Point(291, 20);
            this.labelProge1.Name = "labelProge1";
            this.labelProge1.Size = new System.Drawing.Size(38, 13);
            this.labelProge1.TabIndex = 2;
            this.labelProge1.Text = "Proge:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(294, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 355);
            this.listBox1.TabIndex = 3;
            // 
            // labelNadzor
            // 
            this.labelNadzor.AutoSize = true;
            this.labelNadzor.Location = new System.Drawing.Point(562, 20);
            this.labelNadzor.Name = "labelNadzor";
            this.labelNadzor.Size = new System.Drawing.Size(44, 13);
            this.labelNadzor.TabIndex = 4;
            this.labelNadzor.Text = "Nadzor:";
            // 
            // btnZazeni
            // 
            this.btnZazeni.Location = new System.Drawing.Point(643, 61);
            this.btnZazeni.Name = "btnZazeni";
            this.btnZazeni.Size = new System.Drawing.Size(75, 23);
            this.btnZazeni.TabIndex = 5;
            this.btnZazeni.Text = "Zaženi";
            this.btnZazeni.UseVisualStyleBackColor = true;
            // 
            // btnUstavi
            // 
            this.btnUstavi.Location = new System.Drawing.Point(643, 90);
            this.btnUstavi.Name = "btnUstavi";
            this.btnUstavi.Size = new System.Drawing.Size(75, 23);
            this.btnUstavi.TabIndex = 6;
            this.btnUstavi.Text = "Ustavi";
            this.btnUstavi.UseVisualStyleBackColor = true;
            // 
            // btnOdpri
            // 
            this.btnOdpri.Location = new System.Drawing.Point(643, 206);
            this.btnOdpri.Name = "btnOdpri";
            this.btnOdpri.Size = new System.Drawing.Size(75, 23);
            this.btnOdpri.TabIndex = 7;
            this.btnOdpri.Text = "Odpri progo";
            this.btnOdpri.UseVisualStyleBackColor = true;
            // 
            // btnZapri
            // 
            this.btnZapri.Location = new System.Drawing.Point(643, 236);
            this.btnZapri.Name = "btnZapri";
            this.btnZapri.Size = new System.Drawing.Size(75, 23);
            this.btnZapri.TabIndex = 8;
            this.btnZapri.Text = "Zapri progo";
            this.btnZapri.UseVisualStyleBackColor = true;
            // 
            // labelPretok
            // 
            this.labelPretok.AutoSize = true;
            this.labelPretok.Location = new System.Drawing.Point(643, 350);
            this.labelPretok.Name = "labelPretok";
            this.labelPretok.Size = new System.Drawing.Size(44, 13);
            this.labelPretok.TabIndex = 9;
            this.labelPretok.Text = "Pretok: ";
            // 
            // listIzposoja
            // 
            this.listIzposoja.FormattingEnabled = true;
            this.listIzposoja.Location = new System.Drawing.Point(589, 206);
            this.listIzposoja.Name = "listIzposoja";
            this.listIzposoja.Size = new System.Drawing.Size(120, 95);
            this.listIzposoja.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 550);
            this.Controls.Add(this.groupBoxAdmin);
            this.Controls.Add(this.labelNacin);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnUser);
            this.Name = "Form1";
            this.Text = "Smucisce";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label labelIzposojeno;
        private System.Windows.Forms.Button btnIzposodi;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.ComboBox comboBoxOprema;
        private System.Windows.Forms.Label opremaLabel;
        private System.Windows.Forms.Label labelIzposoja;
        private System.Windows.Forms.Label labelProge;
        private System.Windows.Forms.Label labelVlecnice;
        private System.Windows.Forms.ListBox listProge;
        private System.Windows.Forms.ListBox listVlecnice;
        private System.Windows.Forms.Label labelNacin;
        private System.Windows.Forms.Label labelCena1;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.Button btnVrni;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.Label labelPretok;
        private System.Windows.Forms.Button btnZapri;
        private System.Windows.Forms.Button btnOdpri;
        private System.Windows.Forms.Button btnUstavi;
        private System.Windows.Forms.Button btnZazeni;
        private System.Windows.Forms.Label labelNadzor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelProge1;
        private System.Windows.Forms.ListBox listBoxVlecnice;
        private System.Windows.Forms.Label labelVlecnice1;
        private System.Windows.Forms.ListBox listIzposoja;
    }
}

