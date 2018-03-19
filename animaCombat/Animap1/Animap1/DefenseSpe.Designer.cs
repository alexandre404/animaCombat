namespace Animap1
{
    partial class DefenseSpe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefenseSpe));
            this.CbdefTotal = new System.Windows.Forms.CheckBox();
            this.CbResitCoups = new System.Windows.Forms.CheckBox();
            this.CbEcarter = new System.Windows.Forms.CheckBox();
            this.BtOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbdefTotal
            // 
            this.CbdefTotal.AutoSize = true;
            this.CbdefTotal.Location = new System.Drawing.Point(129, 69);
            this.CbdefTotal.Name = "CbdefTotal";
            this.CbdefTotal.Size = new System.Drawing.Size(95, 17);
            this.CbdefTotal.TabIndex = 39;
            this.CbdefTotal.Text = "Défense totale";
            this.CbdefTotal.UseVisualStyleBackColor = true;
            // 
            // CbResitCoups
            // 
            this.CbResitCoups.AutoSize = true;
            this.CbResitCoups.Location = new System.Drawing.Point(129, 115);
            this.CbResitCoups.Name = "CbResitCoups";
            this.CbResitCoups.Size = new System.Drawing.Size(116, 17);
            this.CbResitCoups.TabIndex = 38;
            this.CbResitCoups.Text = "Résister aux coups";
            this.CbResitCoups.UseVisualStyleBackColor = true;
            // 
            // CbEcarter
            // 
            this.CbEcarter.AutoSize = true;
            this.CbEcarter.Location = new System.Drawing.Point(129, 92);
            this.CbEcarter.Name = "CbEcarter";
            this.CbEcarter.Size = new System.Drawing.Size(60, 17);
            this.CbEcarter.TabIndex = 37;
            this.CbEcarter.Text = "Ecarter";
            this.CbEcarter.UseVisualStyleBackColor = true;
            // 
            // BtOK
            // 
            this.BtOK.Location = new System.Drawing.Point(129, 138);
            this.BtOK.Name = "BtOK";
            this.BtOK.Size = new System.Drawing.Size(75, 23);
            this.BtOK.TabIndex = 40;
            this.BtOK.Text = "OK";
            this.BtOK.UseVisualStyleBackColor = true;
            // 
            // DefenseSpe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 211);
            this.Controls.Add(this.BtOK);
            this.Controls.Add(this.CbdefTotal);
            this.Controls.Add(this.CbResitCoups);
            this.Controls.Add(this.CbEcarter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefenseSpe";
            this.Text = "Défense Spéciale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CbdefTotal;
        private System.Windows.Forms.CheckBox CbResitCoups;
        private System.Windows.Forms.CheckBox CbEcarter;
        private System.Windows.Forms.Button BtOK;
    }
}