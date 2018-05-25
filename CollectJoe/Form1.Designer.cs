namespace CollectJoe
{
    partial class frmField
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlField = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnScoreList = new System.Windows.Forms.Button();
            this.lblPunktestand = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.gpxPoints = new System.Windows.Forms.GroupBox();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.gpxTime = new System.Windows.Forms.GroupBox();
            this.lblZeit = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.gpxPoints.SuspendLayout();
            this.gpxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlField
            // 
            this.pnlField.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlField.Location = new System.Drawing.Point(13, 13);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(644, 334);
            this.pnlField.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 358);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spiel starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(542, 358);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(115, 30);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Einstellungen";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            // 
            // btnScoreList
            // 
            this.btnScoreList.Location = new System.Drawing.Point(419, 358);
            this.btnScoreList.Name = "btnScoreList";
            this.btnScoreList.Size = new System.Drawing.Size(115, 30);
            this.btnScoreList.TabIndex = 2;
            this.btnScoreList.Text = "Rangliste anzeigen";
            this.btnScoreList.UseVisualStyleBackColor = true;
            this.btnScoreList.Click += new System.EventHandler(this.BtnScoreList_Click);
            // 
            // lblPunktestand
            // 
            this.lblPunktestand.AutoSize = true;
            this.lblPunktestand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunktestand.Location = new System.Drawing.Point(6, 11);
            this.lblPunktestand.Name = "lblPunktestand";
            this.lblPunktestand.Size = new System.Drawing.Size(82, 13);
            this.lblPunktestand.TabIndex = 4;
            this.lblPunktestand.Text = "Punktestand:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(89, 11);
            this.lblPoints.MaximumSize = new System.Drawing.Size(65, 13);
            this.lblPoints.MinimumSize = new System.Drawing.Size(65, 13);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(65, 13);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "0 P.";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gpxPoints
            // 
            this.gpxPoints.Controls.Add(this.lblPunktestand);
            this.gpxPoints.Controls.Add(this.lblPoints);
            this.gpxPoints.Location = new System.Drawing.Point(140, 356);
            this.gpxPoints.Name = "gpxPoints";
            this.gpxPoints.Size = new System.Drawing.Size(158, 30);
            this.gpxPoints.TabIndex = 6;
            this.gpxPoints.TabStop = false;
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 1000;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // gpxTime
            // 
            this.gpxTime.Controls.Add(this.lblZeit);
            this.gpxTime.Controls.Add(this.lblTime);
            this.gpxTime.Location = new System.Drawing.Point(310, 356);
            this.gpxTime.Name = "gpxTime";
            this.gpxTime.Size = new System.Drawing.Size(97, 30);
            this.gpxTime.TabIndex = 7;
            this.gpxTime.TabStop = false;
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeit.Location = new System.Drawing.Point(6, 11);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(33, 13);
            this.lblZeit.TabIndex = 4;
            this.lblZeit.Text = "Zeit:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(40, 11);
            this.lblTime.MaximumSize = new System.Drawing.Size(60, 13);
            this.lblTime.MinimumSize = new System.Drawing.Size(45, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "120 Sek.";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 401);
            this.Controls.Add(this.gpxTime);
            this.Controls.Add(this.gpxPoints);
            this.Controls.Add(this.btnScoreList);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlField);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(685, 440);
            this.MinimumSize = new System.Drawing.Size(685, 440);
            this.Name = "frmField";
            this.Text = "CollectJoe";
            this.gpxPoints.ResumeLayout(false);
            this.gpxPoints.PerformLayout();
            this.gpxTime.ResumeLayout(false);
            this.gpxTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlField;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnScoreList;
        private System.Windows.Forms.Label lblPunktestand;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.GroupBox gpxPoints;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.GroupBox gpxTime;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Label lblTime;
    }
}

