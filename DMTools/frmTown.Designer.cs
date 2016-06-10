namespace DMTools
{
    partial class frmTown
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
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblSizeFilter = new System.Windows.Forms.Label();
            this.lblBuildings = new System.Windows.Forms.Label();
            this.lbxAddBuilding = new System.Windows.Forms.ListBox();
            this.lbxReqBuilding = new System.Windows.Forms.ListBox();
            this.btnAddBuilding = new System.Windows.Forms.Button();
            this.btnRemoveBuilding = new System.Windows.Forms.Button();
            this.rtbTownInfo = new System.Windows.Forms.RichTextBox();
            this.pctTownMap = new System.Windows.Forms.PictureBox();
            this.btnCreateTown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctTownMap)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Farm",
            "Hamlet",
            "Village",
            "Town",
            "City"});
            this.cmbSize.Location = new System.Drawing.Point(62, 60);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 21);
            this.cmbSize.TabIndex = 2;
            // 
            // lblSizeFilter
            // 
            this.lblSizeFilter.AutoSize = true;
            this.lblSizeFilter.Location = new System.Drawing.Point(59, 33);
            this.lblSizeFilter.Name = "lblSizeFilter";
            this.lblSizeFilter.Size = new System.Drawing.Size(27, 13);
            this.lblSizeFilter.TabIndex = 3;
            this.lblSizeFilter.Text = "Size";
            // 
            // lblBuildings
            // 
            this.lblBuildings.AutoSize = true;
            this.lblBuildings.Location = new System.Drawing.Point(208, 33);
            this.lblBuildings.Name = "lblBuildings";
            this.lblBuildings.Size = new System.Drawing.Size(49, 13);
            this.lblBuildings.TabIndex = 4;
            this.lblBuildings.Text = "Buildings";
            // 
            // lbxAddBuilding
            // 
            this.lbxAddBuilding.FormattingEnabled = true;
            this.lbxAddBuilding.Location = new System.Drawing.Point(211, 60);
            this.lbxAddBuilding.Name = "lbxAddBuilding";
            this.lbxAddBuilding.Size = new System.Drawing.Size(120, 95);
            this.lbxAddBuilding.Sorted = true;
            this.lbxAddBuilding.TabIndex = 5;
            // 
            // lbxReqBuilding
            // 
            this.lbxReqBuilding.FormattingEnabled = true;
            this.lbxReqBuilding.Location = new System.Drawing.Point(449, 60);
            this.lbxReqBuilding.Name = "lbxReqBuilding";
            this.lbxReqBuilding.Size = new System.Drawing.Size(120, 95);
            this.lbxReqBuilding.TabIndex = 6;
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.Location = new System.Drawing.Point(353, 73);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(75, 23);
            this.btnAddBuilding.TabIndex = 7;
            this.btnAddBuilding.Text = ">>";
            this.btnAddBuilding.UseVisualStyleBackColor = true;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // btnRemoveBuilding
            // 
            this.btnRemoveBuilding.Location = new System.Drawing.Point(353, 102);
            this.btnRemoveBuilding.Name = "btnRemoveBuilding";
            this.btnRemoveBuilding.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveBuilding.TabIndex = 8;
            this.btnRemoveBuilding.Text = "<<";
            this.btnRemoveBuilding.UseVisualStyleBackColor = true;
            this.btnRemoveBuilding.Click += new System.EventHandler(this.btnRemoveBuilding_Click);
            // 
            // rtbTownInfo
            // 
            this.rtbTownInfo.Location = new System.Drawing.Point(840, 0);
            this.rtbTownInfo.Name = "rtbTownInfo";
            this.rtbTownInfo.Size = new System.Drawing.Size(206, 716);
            this.rtbTownInfo.TabIndex = 9;
            this.rtbTownInfo.Text = "";
            // 
            // pctTownMap
            // 
            this.pctTownMap.Location = new System.Drawing.Point(1, 210);
            this.pctTownMap.Name = "pctTownMap";
            this.pctTownMap.Size = new System.Drawing.Size(833, 506);
            this.pctTownMap.TabIndex = 10;
            this.pctTownMap.TabStop = false;
            // 
            // btnCreateTown
            // 
            this.btnCreateTown.Location = new System.Drawing.Point(601, 92);
            this.btnCreateTown.Name = "btnCreateTown";
            this.btnCreateTown.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTown.TabIndex = 11;
            this.btnCreateTown.Text = "Create";
            this.btnCreateTown.UseVisualStyleBackColor = true;
            // 
            // frmTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 716);
            this.Controls.Add(this.btnCreateTown);
            this.Controls.Add(this.pctTownMap);
            this.Controls.Add(this.rtbTownInfo);
            this.Controls.Add(this.btnRemoveBuilding);
            this.Controls.Add(this.btnAddBuilding);
            this.Controls.Add(this.lbxReqBuilding);
            this.Controls.Add(this.lbxAddBuilding);
            this.Controls.Add(this.lblBuildings);
            this.Controls.Add(this.lblSizeFilter);
            this.Controls.Add(this.cmbSize);
            this.Name = "frmTown";
            this.Text = "Town Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pctTownMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label lblSizeFilter;
        private System.Windows.Forms.Label lblBuildings;
        private System.Windows.Forms.ListBox lbxAddBuilding;
        private System.Windows.Forms.ListBox lbxReqBuilding;
        private System.Windows.Forms.Button btnAddBuilding;
        private System.Windows.Forms.Button btnRemoveBuilding;
        private System.Windows.Forms.RichTextBox rtbTownInfo;
        private System.Windows.Forms.PictureBox pctTownMap;
        private System.Windows.Forms.Button btnCreateTown;
    }
}