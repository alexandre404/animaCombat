namespace Animap1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAtt = new System.Windows.Forms.TextBox();
            this.cbTaille = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.cbVol = new System.Windows.Forms.ComboBox();
            this.rbEsquive = new System.Windows.Forms.RadioButton();
            this.rbPare = new System.Windows.Forms.RadioButton();
            this.rbAttaque = new System.Windows.Forms.RadioButton();
            this.cbVision = new System.Windows.Forms.ComboBox();
            this.cbParalisie = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbCombattant = new System.Windows.Forms.CheckBox();
            this.CbEchec = new System.Windows.Forms.CheckBox();
            this.CbCharger = new System.Windows.Forms.CheckBox();
            this.cbReusite = new System.Windows.Forms.CheckBox();
            this.CbEnJoue = new System.Windows.Forms.CheckBox();
            this.CbPosiSuperieur = new System.Windows.Forms.CheckBox();
            this.CbSurpris = new System.Windows.Forms.CheckBox();
            this.CbRenverse = new System.Windows.Forms.CheckBox();
            this.CbDegainer = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEncaiss = new System.Windows.Forms.CheckBox();
            this.btAttSpe = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.NdAttaque = new System.Windows.Forms.NumericUpDown();
            this.NdDefense = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CbArme = new System.Windows.Forms.ComboBox();
            this.BtDefense = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NdAttaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NdDefense)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAtt
            // 
            this.txtAtt.Location = new System.Drawing.Point(93, 31);
            this.txtAtt.Name = "txtAtt";
            this.txtAtt.Size = new System.Drawing.Size(143, 20);
            this.txtAtt.TabIndex = 0;
            this.txtAtt.Text = "0";
            // 
            // cbTaille
            // 
            this.cbTaille.FormattingEnabled = true;
            this.cbTaille.Items.AddRange(new object[] {
            "minuscule",
            "petit",
            "taille normal",
            "grande"});
            this.cbTaille.Location = new System.Drawing.Point(22, 27);
            this.cbTaille.Name = "cbTaille";
            this.cbTaille.Size = new System.Drawing.Size(152, 21);
            this.cbTaille.TabIndex = 2;
            this.cbTaille.Text = "taille normal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valeur Att/Deff";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "dans le dos du personnage",
            "dans le flanc du personnage",
            "face au personnage"});
            this.cbPosition.Location = new System.Drawing.Point(22, 61);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(152, 21);
            this.cbPosition.TabIndex = 4;
            this.cbPosition.Text = "face au personnage";
            // 
            // cbVol
            // 
            this.cbVol.FormattingEnabled = true;
            this.cbVol.Items.AddRange(new object[] {
            "Perso en lévitation",
            "Perso en vol (7-14)",
            "Perso en vol (15+)",
            "Perso au sol"});
            this.cbVol.Location = new System.Drawing.Point(93, 111);
            this.cbVol.Name = "cbVol";
            this.cbVol.Size = new System.Drawing.Size(143, 21);
            this.cbVol.TabIndex = 5;
            this.cbVol.Text = "Perso au sol";
            // 
            // rbEsquive
            // 
            this.rbEsquive.AutoSize = true;
            this.rbEsquive.Location = new System.Drawing.Point(43, 209);
            this.rbEsquive.Name = "rbEsquive";
            this.rbEsquive.Size = new System.Drawing.Size(63, 17);
            this.rbEsquive.TabIndex = 6;
            this.rbEsquive.Text = "Esquive";
            this.rbEsquive.UseVisualStyleBackColor = true;
            // 
            // rbPare
            // 
            this.rbPare.AutoSize = true;
            this.rbPare.Location = new System.Drawing.Point(43, 186);
            this.rbPare.Name = "rbPare";
            this.rbPare.Size = new System.Drawing.Size(46, 17);
            this.rbPare.TabIndex = 7;
            this.rbPare.Text = "pare";
            this.rbPare.UseVisualStyleBackColor = true;
            // 
            // rbAttaque
            // 
            this.rbAttaque.AutoSize = true;
            this.rbAttaque.Checked = true;
            this.rbAttaque.Location = new System.Drawing.Point(43, 163);
            this.rbAttaque.Name = "rbAttaque";
            this.rbAttaque.Size = new System.Drawing.Size(61, 17);
            this.rbAttaque.TabIndex = 8;
            this.rbAttaque.TabStop = true;
            this.rbAttaque.Text = "attaque";
            this.rbAttaque.UseVisualStyleBackColor = true;
            // 
            // cbVision
            // 
            this.cbVision.FormattingEnabled = true;
            this.cbVision.Items.AddRange(new object[] {
            "Cécité partielle",
            "Cécité totale",
            "Vision normal"});
            this.cbVision.Location = new System.Drawing.Point(93, 57);
            this.cbVision.Name = "cbVision";
            this.cbVision.Size = new System.Drawing.Size(143, 21);
            this.cbVision.TabIndex = 10;
            this.cbVision.Text = "Vision normal";
            // 
            // cbParalisie
            // 
            this.cbParalisie.FormattingEnabled = true;
            this.cbParalisie.Items.AddRange(new object[] {
            "Paralysie légère",
            "Paralysie partielle",
            "Paralisie totale",
            "liberté de mouvement"});
            this.cbParalisie.Location = new System.Drawing.Point(93, 84);
            this.cbParalisie.Name = "cbParalisie";
            this.cbParalisie.Size = new System.Drawing.Size(143, 21);
            this.cbParalisie.TabIndex = 11;
            this.cbParalisie.Text = "liberté de mouvement";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbCombattant);
            this.groupBox1.Controls.Add(this.CbEchec);
            this.groupBox1.Controls.Add(this.CbCharger);
            this.groupBox1.Controls.Add(this.cbReusite);
            this.groupBox1.Controls.Add(this.cbVol);
            this.groupBox1.Controls.Add(this.CbEnJoue);
            this.groupBox1.Controls.Add(this.cbParalisie);
            this.groupBox1.Controls.Add(this.CbPosiSuperieur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbSurpris);
            this.groupBox1.Controls.Add(this.txtAtt);
            this.groupBox1.Controls.Add(this.CbRenverse);
            this.groupBox1.Controls.Add(this.cbVision);
            this.groupBox1.Controls.Add(this.CbDegainer);
            this.groupBox1.Location = new System.Drawing.Point(380, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 361);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnage";
            // 
            // CbCombattant
            // 
            this.CbCombattant.AutoSize = true;
            this.CbCombattant.Location = new System.Drawing.Point(93, 230);
            this.CbCombattant.Name = "CbCombattant";
            this.CbCombattant.Size = new System.Drawing.Size(188, 17);
            this.CbCombattant.TabIndex = 20;
            this.CbCombattant.Text = "Combattant dans un espace réduit";
            this.CbCombattant.UseVisualStyleBackColor = true;
            // 
            // CbEchec
            // 
            this.CbEchec.AutoSize = true;
            this.CbEchec.Location = new System.Drawing.Point(93, 322);
            this.CbEchec.Name = "CbEchec";
            this.CbEchec.Size = new System.Drawing.Size(95, 17);
            this.CbEchec.TabIndex = 26;
            this.CbEchec.Text = "Echec Critique";
            this.CbEchec.UseVisualStyleBackColor = true;
            // 
            // CbCharger
            // 
            this.CbCharger.AutoSize = true;
            this.CbCharger.Location = new System.Drawing.Point(93, 138);
            this.CbCharger.Name = "CbCharger";
            this.CbCharger.Size = new System.Drawing.Size(104, 17);
            this.CbCharger.TabIndex = 27;
            this.CbCharger.Text = "Vient de charger";
            this.CbCharger.UseVisualStyleBackColor = true;
            // 
            // cbReusite
            // 
            this.cbReusite.AutoSize = true;
            this.cbReusite.Location = new System.Drawing.Point(93, 299);
            this.cbReusite.Name = "cbReusite";
            this.cbReusite.Size = new System.Drawing.Size(104, 17);
            this.cbReusite.TabIndex = 25;
            this.cbReusite.Text = "Réussite critique";
            this.cbReusite.UseVisualStyleBackColor = true;
            // 
            // CbEnJoue
            // 
            this.CbEnJoue.AutoSize = true;
            this.CbEnJoue.Location = new System.Drawing.Point(93, 253);
            this.CbEnJoue.Name = "CbEnJoue";
            this.CbEnJoue.Size = new System.Drawing.Size(79, 17);
            this.CbEnJoue.TabIndex = 24;
            this.CbEnJoue.Text = "Est en joue";
            this.CbEnJoue.UseVisualStyleBackColor = true;
            // 
            // CbPosiSuperieur
            // 
            this.CbPosiSuperieur.AutoSize = true;
            this.CbPosiSuperieur.Location = new System.Drawing.Point(93, 276);
            this.CbPosiSuperieur.Name = "CbPosiSuperieur";
            this.CbPosiSuperieur.Size = new System.Drawing.Size(109, 17);
            this.CbPosiSuperieur.TabIndex = 23;
            this.CbPosiSuperieur.Text = "Position supérieur";
            this.CbPosiSuperieur.UseVisualStyleBackColor = true;
            // 
            // CbSurpris
            // 
            this.CbSurpris.AutoSize = true;
            this.CbSurpris.Location = new System.Drawing.Point(93, 207);
            this.CbSurpris.Name = "CbSurpris";
            this.CbSurpris.Size = new System.Drawing.Size(58, 17);
            this.CbSurpris.TabIndex = 22;
            this.CbSurpris.Text = "Surpris";
            this.CbSurpris.UseVisualStyleBackColor = true;
            // 
            // CbRenverse
            // 
            this.CbRenverse.AutoSize = true;
            this.CbRenverse.Location = new System.Drawing.Point(93, 184);
            this.CbRenverse.Name = "CbRenverse";
            this.CbRenverse.Size = new System.Drawing.Size(72, 17);
            this.CbRenverse.TabIndex = 21;
            this.CbRenverse.Text = "Renversé";
            this.CbRenverse.UseVisualStyleBackColor = true;
            // 
            // CbDegainer
            // 
            this.CbDegainer.AutoSize = true;
            this.CbDegainer.Location = new System.Drawing.Point(93, 161);
            this.CbDegainer.Name = "CbDegainer";
            this.CbDegainer.Size = new System.Drawing.Size(109, 17);
            this.CbDegainer.TabIndex = 19;
            this.CbDegainer.Text = "Vient de dégainer";
            this.CbDegainer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEncaiss);
            this.groupBox2.Controls.Add(this.cbTaille);
            this.groupBox2.Controls.Add(this.cbPosition);
            this.groupBox2.Location = new System.Drawing.Point(21, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 132);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adversaire";
            // 
            // cbEncaiss
            // 
            this.cbEncaiss.AutoSize = true;
            this.cbEncaiss.Location = new System.Drawing.Point(22, 88);
            this.cbEncaiss.Name = "cbEncaiss";
            this.cbEncaiss.Size = new System.Drawing.Size(92, 17);
            this.cbEncaiss.TabIndex = 5;
            this.cbEncaiss.Text = "Encaissement";
            this.cbEncaiss.UseVisualStyleBackColor = true;
            // 
            // btAttSpe
            // 
            this.btAttSpe.Location = new System.Drawing.Point(43, 337);
            this.btAttSpe.Name = "btAttSpe";
            this.btAttSpe.Size = new System.Drawing.Size(152, 23);
            this.btAttSpe.TabIndex = 16;
            this.btAttSpe.Text = "Attaque spécial";
            this.btAttSpe.UseVisualStyleBackColor = true;
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(43, 395);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(152, 20);
            this.txtResultat.TabIndex = 18;
            this.txtResultat.Text = "Résultat";
            this.txtResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResultat.Click += new System.EventHandler(this.TxtResultat_Click);
            // 
            // NdAttaque
            // 
            this.NdAttaque.Location = new System.Drawing.Point(156, 276);
            this.NdAttaque.Name = "NdAttaque";
            this.NdAttaque.Size = new System.Drawing.Size(39, 20);
            this.NdAttaque.TabIndex = 21;
            this.NdAttaque.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NdDefense
            // 
            this.NdDefense.Location = new System.Drawing.Point(156, 302);
            this.NdDefense.Name = "NdDefense";
            this.NdDefense.Size = new System.Drawing.Size(39, 20);
            this.NdDefense.TabIndex = 22;
            this.NdDefense.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombres d\'attaques";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombres de défenses";
            // 
            // CbArme
            // 
            this.CbArme.FormattingEnabled = true;
            this.CbArme.Items.AddRange(new object[] {
            "Arme petite",
            "Arme moyenne",
            "Arme grande"});
            this.CbArme.Location = new System.Drawing.Point(43, 232);
            this.CbArme.Name = "CbArme";
            this.CbArme.Size = new System.Drawing.Size(152, 21);
            this.CbArme.TabIndex = 25;
            this.CbArme.Text = "Arme moyenne";
            // 
            // BtDefense
            // 
            this.BtDefense.Location = new System.Drawing.Point(43, 366);
            this.BtDefense.Name = "BtDefense";
            this.BtDefense.Size = new System.Drawing.Size(152, 23);
            this.BtDefense.TabIndex = 26;
            this.BtDefense.Text = "Défense spécial";
            this.BtDefense.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 490);
            this.Controls.Add(this.BtDefense);
            this.Controls.Add(this.CbArme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NdDefense);
            this.Controls.Add(this.NdAttaque);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.btAttSpe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbPare);
            this.Controls.Add(this.rbEsquive);
            this.Controls.Add(this.rbAttaque);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NdAttaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NdDefense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAtt;
        private System.Windows.Forms.ComboBox cbTaille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.ComboBox cbVol;
        private System.Windows.Forms.RadioButton rbEsquive;
        private System.Windows.Forms.RadioButton rbPare;
        private System.Windows.Forms.RadioButton rbAttaque;
        private System.Windows.Forms.ComboBox cbVision;
        private System.Windows.Forms.ComboBox cbParalisie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAttSpe;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.CheckBox cbEncaiss;
        private System.Windows.Forms.CheckBox CbCombattant;
        private System.Windows.Forms.CheckBox CbEchec;
        private System.Windows.Forms.CheckBox CbCharger;
        private System.Windows.Forms.CheckBox cbReusite;
        private System.Windows.Forms.CheckBox CbEnJoue;
        private System.Windows.Forms.CheckBox CbPosiSuperieur;
        private System.Windows.Forms.CheckBox CbSurpris;
        private System.Windows.Forms.CheckBox CbRenverse;
        private System.Windows.Forms.CheckBox CbDegainer;
        private System.Windows.Forms.NumericUpDown NdAttaque;
        private System.Windows.Forms.NumericUpDown NdDefense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbArme;
        private System.Windows.Forms.Button BtDefense;
    }
}

