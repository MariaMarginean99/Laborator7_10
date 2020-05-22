namespace EvidentaAgendaForms
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridPersoane = new System.Windows.Forms.DataGridView();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNumar = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNumar = new System.Windows.Forms.Label();
            this.dtpCauta1 = new System.Windows.Forms.DateTimePicker();
            this.dtpCauta2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersoane)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1143, 607);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(162, 84);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(122, 26);
            this.txtPrenume.TabIndex = 35;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(162, 35);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(122, 26);
            this.txtNume.TabIndex = 34;
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrenume.Location = new System.Drawing.Point(40, 84);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(89, 22);
            this.lblPrenume.TabIndex = 33;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNume.Location = new System.Drawing.Point(40, 39);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(61, 22);
            this.lblNume.TabIndex = 32;
            this.lblNume.Text = "Nume";
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCauta.Location = new System.Drawing.Point(44, 261);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(114, 45);
            this.btnCauta.TabIndex = 41;
            this.btnCauta.Text = "Caută";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifica.Location = new System.Drawing.Point(44, 472);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(114, 45);
            this.btnModifica.TabIndex = 46;
            this.btnModifica.Text = "Modifică";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(1032, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 41);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridPersoane
            // 
            this.dataGridPersoane.ColumnHeadersHeight = 40;
            this.dataGridPersoane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridPersoane.GridColor = System.Drawing.Color.Thistle;
            this.dataGridPersoane.Location = new System.Drawing.Point(516, 32);
            this.dataGridPersoane.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPersoane.Name = "dataGridPersoane";
            this.dataGridPersoane.RowHeadersWidth = 62;
            this.dataGridPersoane.Size = new System.Drawing.Size(524, 274);
            this.dataGridPersoane.TabIndex = 49;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(40, 542);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 22);
            this.lblMesaj.TabIndex = 50;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(162, 402);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(122, 26);
            this.txtMail.TabIndex = 54;
            // 
            // txtNumar
            // 
            this.txtNumar.Location = new System.Drawing.Point(162, 348);
            this.txtNumar.Name = "txtNumar";
            this.txtNumar.Size = new System.Drawing.Size(122, 26);
            this.txtNumar.TabIndex = 53;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMail.Location = new System.Drawing.Point(40, 402);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(46, 22);
            this.lblMail.TabIndex = 52;
            this.lblMail.Text = "Mail";
            // 
            // lblNumar
            // 
            this.lblNumar.AutoSize = true;
            this.lblNumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumar.Location = new System.Drawing.Point(40, 348);
            this.lblNumar.Name = "lblNumar";
            this.lblNumar.Size = new System.Drawing.Size(68, 22);
            this.lblNumar.TabIndex = 51;
            this.lblNumar.Text = "Numar";
            // 
            // dtpCauta1
            // 
            this.dtpCauta1.Location = new System.Drawing.Point(29, 146);
            this.dtpCauta1.Name = "dtpCauta1";
            this.dtpCauta1.Size = new System.Drawing.Size(310, 26);
            this.dtpCauta1.TabIndex = 55;
            this.dtpCauta1.Value = new System.DateTime(2020, 5, 21, 21, 39, 23, 0);
            // 
            // dtpCauta2
            // 
            this.dtpCauta2.Location = new System.Drawing.Point(29, 206);
            this.dtpCauta2.Name = "dtpCauta2";
            this.dtpCauta2.Size = new System.Drawing.Size(310, 26);
            this.dtpCauta2.TabIndex = 56;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 609);
            this.Controls.Add(this.dtpCauta2);
            this.Controls.Add(this.dtpCauta1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNumar);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblNumar);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.dataGridPersoane);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Căutare Persoane";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersoane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridPersoane;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNumar;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNumar;
        private System.Windows.Forms.DateTimePicker dtpCauta1;
        private System.Windows.Forms.DateTimePicker dtpCauta2;
    }
}