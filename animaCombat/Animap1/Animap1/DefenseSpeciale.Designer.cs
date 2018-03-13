namespace Animap1
{
    partial class DefenseSpeciale
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
            this.cbResisterAuxCoups = new System.Windows.Forms.CheckBox();
            this.cbEcarter = new System.Windows.Forms.CheckBox();
            this.cbDefTotale = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbResisterAuxCoups
            // 
            this.cbResisterAuxCoups.AutoSize = true;
            this.cbResisterAuxCoups.Location = new System.Drawing.Point(34, 86);
            this.cbResisterAuxCoups.Name = "cbResisterAuxCoups";
            this.cbResisterAuxCoups.Size = new System.Drawing.Size(116, 17);
            this.cbResisterAuxCoups.TabIndex = 5;
            this.cbResisterAuxCoups.Text = "Résister aux coups";
            this.cbResisterAuxCoups.UseVisualStyleBackColor = true;
            // 
            // cbEcarter
            // 
            this.cbEcarter.AutoSize = true;
            this.cbEcarter.Location = new System.Drawing.Point(34, 63);
            this.cbEcarter.Name = "cbEcarter";
            this.cbEcarter.Size = new System.Drawing.Size(60, 17);
            this.cbEcarter.TabIndex = 4;
            this.cbEcarter.Text = "Ecarter";
            this.cbEcarter.UseVisualStyleBackColor = true;
            // 
            // cbDefTotale
            // 
            this.cbDefTotale.AutoSize = true;
            this.cbDefTotale.Location = new System.Drawing.Point(34, 40);
            this.cbDefTotale.Name = "cbDefTotale";
            this.cbDefTotale.Size = new System.Drawing.Size(89, 17);
            this.cbDefTotale.TabIndex = 3;
            this.cbDefTotale.Text = "Défense total";
            this.cbDefTotale.UseVisualStyleBackColor = true;
            // 
            // DefenseSpeciale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 166);
            this.Controls.Add(this.cbResisterAuxCoups);
            this.Controls.Add(this.cbEcarter);
            this.Controls.Add(this.cbDefTotale);
            this.Name = "DefenseSpeciale";
            this.Text = "DefenseSpeciale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbResisterAuxCoups;
        private System.Windows.Forms.CheckBox cbEcarter;
        private System.Windows.Forms.CheckBox cbDefTotale;
    }
}