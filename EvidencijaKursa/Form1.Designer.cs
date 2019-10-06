namespace EvidencijaKursa
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
            this.header = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.panelUnos = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSifra = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOcena = new System.Windows.Forms.TextBox();
            this.lblOcena = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNazivKursa = new System.Windows.Forms.TextBox();
            this.txtNazivJezika = new System.Windows.Forms.TextBox();
            this.txtMejl = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.lblNazivKursa = new System.Windows.Forms.Label();
            this.lblNazivJezika = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSve = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.panelUnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.header.Controls.Add(this.lblNaslov);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(800, 73);
            this.header.TabIndex = 0;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNaslov.Location = new System.Drawing.Point(150, 20);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(470, 33);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "TAG licencirani TELC ispitni centar";
            // 
            // panelUnos
            // 
            this.panelUnos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelUnos.Controls.Add(this.dateTimePicker1);
            this.panelUnos.Controls.Add(this.btnSifra);
            this.panelUnos.Controls.Add(this.btnSave);
            this.panelUnos.Controls.Add(this.txtOcena);
            this.panelUnos.Controls.Add(this.lblOcena);
            this.panelUnos.Controls.Add(this.txtSifra);
            this.panelUnos.Controls.Add(this.txtNazivKursa);
            this.panelUnos.Controls.Add(this.txtNazivJezika);
            this.panelUnos.Controls.Add(this.txtMejl);
            this.panelUnos.Controls.Add(this.txtPrezime);
            this.panelUnos.Controls.Add(this.txtIme);
            this.panelUnos.Controls.Add(this.lblSifra);
            this.panelUnos.Controls.Add(this.lblNazivKursa);
            this.panelUnos.Controls.Add(this.lblNazivJezika);
            this.panelUnos.Controls.Add(this.lblDatum);
            this.panelUnos.Controls.Add(this.lblMail);
            this.panelUnos.Controls.Add(this.lblPrezime);
            this.panelUnos.Controls.Add(this.lblIme);
            this.panelUnos.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUnos.Location = new System.Drawing.Point(0, 73);
            this.panelUnos.Name = "panelUnos";
            this.panelUnos.Size = new System.Drawing.Size(383, 377);
            this.panelUnos.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // btnSifra
            // 
            this.btnSifra.Location = new System.Drawing.Point(116, 324);
            this.btnSifra.Name = "btnSifra";
            this.btnSifra.Size = new System.Drawing.Size(75, 23);
            this.btnSifra.TabIndex = 16;
            this.btnSifra.Text = "Sifra";
            this.btnSifra.UseVisualStyleBackColor = true;
            this.btnSifra.Click += new System.EventHandler(this.BtnSifra_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Snimi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtOcena
            // 
            this.txtOcena.Location = new System.Drawing.Point(156, 211);
            this.txtOcena.Name = "txtOcena";
            this.txtOcena.Size = new System.Drawing.Size(100, 20);
            this.txtOcena.TabIndex = 14;
            // 
            // lblOcena
            // 
            this.lblOcena.AutoSize = true;
            this.lblOcena.Location = new System.Drawing.Point(9, 211);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(39, 13);
            this.lblOcena.TabIndex = 13;
            this.lblOcena.Text = "Ocena";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(156, 170);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(100, 20);
            this.txtSifra.TabIndex = 12;
            // 
            // txtNazivKursa
            // 
            this.txtNazivKursa.Location = new System.Drawing.Point(156, 139);
            this.txtNazivKursa.Name = "txtNazivKursa";
            this.txtNazivKursa.Size = new System.Drawing.Size(100, 20);
            this.txtNazivKursa.TabIndex = 11;
            // 
            // txtNazivJezika
            // 
            this.txtNazivJezika.Location = new System.Drawing.Point(156, 110);
            this.txtNazivJezika.Name = "txtNazivJezika";
            this.txtNazivJezika.Size = new System.Drawing.Size(100, 20);
            this.txtNazivJezika.TabIndex = 10;
            // 
            // txtMejl
            // 
            this.txtMejl.Location = new System.Drawing.Point(156, 69);
            this.txtMejl.Name = "txtMejl";
            this.txtMejl.Size = new System.Drawing.Size(100, 20);
            this.txtMejl.TabIndex = 9;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(156, 43);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 8;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(156, 17);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 7;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(12, 170);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(28, 13);
            this.lblSifra.TabIndex = 6;
            this.lblSifra.Text = "Sifra";
            // 
            // lblNazivKursa
            // 
            this.lblNazivKursa.AutoSize = true;
            this.lblNazivKursa.Location = new System.Drawing.Point(9, 139);
            this.lblNazivKursa.Name = "lblNazivKursa";
            this.lblNazivKursa.Size = new System.Drawing.Size(64, 13);
            this.lblNazivKursa.TabIndex = 5;
            this.lblNazivKursa.Text = "Naziv Kursa";
            // 
            // lblNazivJezika
            // 
            this.lblNazivJezika.AutoSize = true;
            this.lblNazivJezika.Location = new System.Drawing.Point(9, 110);
            this.lblNazivJezika.Name = "lblNazivJezika";
            this.lblNazivJezika.Size = new System.Drawing.Size(67, 13);
            this.lblNazivJezika.TabIndex = 4;
            this.lblNazivJezika.Text = "Naziv Jezika";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(9, 261);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(88, 13);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Datum Polaganja";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 72);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "E-mail";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 43);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 1;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(12, 17);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(389, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 287);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            // 
            // btnSve
            // 
            this.btnSve.Location = new System.Drawing.Point(502, 397);
            this.btnSve.Name = "btnSve";
            this.btnSve.Size = new System.Drawing.Size(75, 23);
            this.btnSve.TabIndex = 3;
            this.btnSve.Text = "Prikazi Sve ";
            this.btnSve.UseVisualStyleBackColor = true;
            this.btnSve.Click += new System.EventHandler(this.BtnSve_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(608, 397);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Ispravi";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(713, 397);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(75, 23);
            this.btnFiltriraj.TabIndex = 5;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.BtnFiltriraj_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(399, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Obrisi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSve);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelUnos);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAG Licencirani TELC ispitni centar";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panelUnos.ResumeLayout(false);
            this.panelUnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Panel panelUnos;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOcena;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNazivKursa;
        private System.Windows.Forms.TextBox txtNazivJezika;
        private System.Windows.Forms.TextBox txtMejl;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Label lblNazivKursa;
        private System.Windows.Forms.Label lblNazivJezika;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSve;
        private System.Windows.Forms.Button btnSifra;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnDelete;
    }
}

