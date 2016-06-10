namespace DMTools
{
    partial class frmHome
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
            this.btnNPC = new System.Windows.Forms.Button();
            this.btnTowns = new System.Windows.Forms.Button();
            this.btnEncounters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNPC
            // 
            this.btnNPC.Location = new System.Drawing.Point(37, 30);
            this.btnNPC.Name = "btnNPC";
            this.btnNPC.Size = new System.Drawing.Size(75, 23);
            this.btnNPC.TabIndex = 0;
            this.btnNPC.Text = "NPC\'s";
            this.btnNPC.UseVisualStyleBackColor = true;
            // 
            // btnTowns
            // 
            this.btnTowns.Location = new System.Drawing.Point(37, 82);
            this.btnTowns.Name = "btnTowns";
            this.btnTowns.Size = new System.Drawing.Size(75, 23);
            this.btnTowns.TabIndex = 1;
            this.btnTowns.Text = "Towns";
            this.btnTowns.UseMnemonic = false;
            this.btnTowns.UseVisualStyleBackColor = true;
            this.btnTowns.Click += new System.EventHandler(this.btnTowns_Click);
            // 
            // btnEncounters
            // 
            this.btnEncounters.Location = new System.Drawing.Point(37, 162);
            this.btnEncounters.Name = "btnEncounters";
            this.btnEncounters.Size = new System.Drawing.Size(75, 23);
            this.btnEncounters.TabIndex = 2;
            this.btnEncounters.Text = "Encounters";
            this.btnEncounters.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 641);
            this.Controls.Add(this.btnEncounters);
            this.Controls.Add(this.btnTowns);
            this.Controls.Add(this.btnNPC);
            this.Name = "frmHome";
            this.Text = "DM Tools";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNPC;
        private System.Windows.Forms.Button btnTowns;
        private System.Windows.Forms.Button btnEncounters;
    }
}

