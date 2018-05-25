namespace CollectJoe
{
    partial class frmEditScore
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
            this.lblEintragen = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblDeinName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDeinePunktzahl = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEintragen
            // 
            this.lblEintragen.AutoSize = true;
            this.lblEintragen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEintragen.Location = new System.Drawing.Point(12, 16);
            this.lblEintragen.Name = "lblEintragen";
            this.lblEintragen.Size = new System.Drawing.Size(104, 25);
            this.lblEintragen.TabIndex = 2;
            this.lblEintragen.Text = "Eintragen";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(100, 55);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(27, 20);
            this.lblPoints.TabIndex = 3;
            this.lblPoints.Text = "50";
            // 
            // lblDeinName
            // 
            this.lblDeinName.AutoSize = true;
            this.lblDeinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeinName.Location = new System.Drawing.Point(14, 92);
            this.lblDeinName.Name = "lblDeinName";
            this.lblDeinName.Size = new System.Drawing.Size(63, 13);
            this.lblDeinName.TabIndex = 7;
            this.lblDeinName.Text = "Dein Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(112, 20);
            this.txtName.TabIndex = 8;
            // 
            // lblDeinePunktzahl
            // 
            this.lblDeinePunktzahl.AutoSize = true;
            this.lblDeinePunktzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeinePunktzahl.Location = new System.Drawing.Point(12, 60);
            this.lblDeinePunktzahl.Name = "lblDeinePunktzahl";
            this.lblDeinePunktzahl.Size = new System.Drawing.Size(88, 13);
            this.lblDeinePunktzahl.TabIndex = 9;
            this.lblDeinePunktzahl.Text = "Deine Punktzahl:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 127);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(117, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmEditScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 174);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblDeinePunktzahl);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDeinName);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblEintragen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditScore";
            this.Text = "Resultat speichern";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditScore_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEintragen;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblDeinName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDeinePunktzahl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}