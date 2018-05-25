namespace CollectJoe
{
    partial class frmOptions
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
            this.lblEinstellungen = new System.Windows.Forms.Label();
            this.gpxField = new System.Windows.Forms.GroupBox();
            this.nudVertical = new System.Windows.Forms.NumericUpDown();
            this.nudHorizontal = new System.Windows.Forms.NumericUpDown();
            this.lblBoxenVertikal = new System.Windows.Forms.Label();
            this.lblBoxenHorizontal = new System.Windows.Forms.Label();
            this.gxpRating = new System.Windows.Forms.GroupBox();
            this.nudBoxType3 = new System.Windows.Forms.NumericUpDown();
            this.lbl3Boxtyp = new System.Windows.Forms.Label();
            this.nudBoxType2 = new System.Windows.Forms.NumericUpDown();
            this.nudBoxType1 = new System.Windows.Forms.NumericUpDown();
            this.lbl2Boxtyp = new System.Windows.Forms.Label();
            this.lbl1Boxtyp = new System.Windows.Forms.Label();
            this.gpxColors = new System.Windows.Forms.GroupBox();
            this.btnColorBoxType3 = new System.Windows.Forms.Button();
            this.btnColorBoxType2 = new System.Windows.Forms.Button();
            this.btnColorBoxType1 = new System.Windows.Forms.Button();
            this.btnColorField = new System.Windows.Forms.Button();
            this.btnColorBox = new System.Windows.Forms.Button();
            this.lbl3BoxtypC = new System.Windows.Forms.Label();
            this.lbl2BoxtypC = new System.Windows.Forms.Label();
            this.lbl1BoxtypC = new System.Windows.Forms.Label();
            this.lblSpielfeld = new System.Windows.Forms.Label();
            this.lblBoxen = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.gpxField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontal)).BeginInit();
            this.gxpRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxType3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxType1)).BeginInit();
            this.gpxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEinstellungen
            // 
            this.lblEinstellungen.AutoSize = true;
            this.lblEinstellungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEinstellungen.Location = new System.Drawing.Point(12, 16);
            this.lblEinstellungen.Name = "lblEinstellungen";
            this.lblEinstellungen.Size = new System.Drawing.Size(142, 25);
            this.lblEinstellungen.TabIndex = 0;
            this.lblEinstellungen.Text = "Einstellungen";
            // 
            // gpxField
            // 
            this.gpxField.Controls.Add(this.nudVertical);
            this.gpxField.Controls.Add(this.nudHorizontal);
            this.gpxField.Controls.Add(this.lblBoxenVertikal);
            this.gpxField.Controls.Add(this.lblBoxenHorizontal);
            this.gpxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxField.Location = new System.Drawing.Point(17, 50);
            this.gpxField.Name = "gpxField";
            this.gpxField.Size = new System.Drawing.Size(270, 94);
            this.gpxField.TabIndex = 1;
            this.gpxField.TabStop = false;
            this.gpxField.Text = "Spielfeld";
            // 
            // nudVertical
            // 
            this.nudVertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudVertical.Location = new System.Drawing.Point(133, 60);
            this.nudVertical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudVertical.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVertical.Name = "nudVertical";
            this.nudVertical.Size = new System.Drawing.Size(117, 20);
            this.nudVertical.TabIndex = 2;
            this.nudVertical.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudVertical.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudHorizontal
            // 
            this.nudHorizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHorizontal.Location = new System.Drawing.Point(133, 33);
            this.nudHorizontal.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudHorizontal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHorizontal.Name = "nudHorizontal";
            this.nudHorizontal.Size = new System.Drawing.Size(117, 20);
            this.nudHorizontal.TabIndex = 1;
            this.nudHorizontal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudHorizontal.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblBoxenVertikal
            // 
            this.lblBoxenVertikal.AutoSize = true;
            this.lblBoxenVertikal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxenVertikal.Location = new System.Drawing.Point(18, 62);
            this.lblBoxenVertikal.Name = "lblBoxenVertikal";
            this.lblBoxenVertikal.Size = new System.Drawing.Size(77, 13);
            this.lblBoxenVertikal.TabIndex = 1;
            this.lblBoxenVertikal.Text = "Boxen vertikal:";
            // 
            // lblBoxenHorizontal
            // 
            this.lblBoxenHorizontal.AutoSize = true;
            this.lblBoxenHorizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxenHorizontal.Location = new System.Drawing.Point(18, 35);
            this.lblBoxenHorizontal.Name = "lblBoxenHorizontal";
            this.lblBoxenHorizontal.Size = new System.Drawing.Size(88, 13);
            this.lblBoxenHorizontal.TabIndex = 0;
            this.lblBoxenHorizontal.Text = "Boxen horizontal:";
            // 
            // gxpRating
            // 
            this.gxpRating.Controls.Add(this.nudBoxType3);
            this.gxpRating.Controls.Add(this.lbl3Boxtyp);
            this.gxpRating.Controls.Add(this.nudBoxType2);
            this.gxpRating.Controls.Add(this.nudBoxType1);
            this.gxpRating.Controls.Add(this.lbl2Boxtyp);
            this.gxpRating.Controls.Add(this.lbl1Boxtyp);
            this.gxpRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gxpRating.Location = new System.Drawing.Point(17, 159);
            this.gxpRating.Name = "gxpRating";
            this.gxpRating.Size = new System.Drawing.Size(270, 121);
            this.gxpRating.TabIndex = 2;
            this.gxpRating.TabStop = false;
            this.gxpRating.Text = "Wertungen";
            // 
            // nudBoxType3
            // 
            this.nudBoxType3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBoxType3.Location = new System.Drawing.Point(133, 87);
            this.nudBoxType3.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudBoxType3.Name = "nudBoxType3";
            this.nudBoxType3.Size = new System.Drawing.Size(117, 20);
            this.nudBoxType3.TabIndex = 5;
            this.nudBoxType3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBoxType3.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            // 
            // lbl3Boxtyp
            // 
            this.lbl3Boxtyp.AutoSize = true;
            this.lbl3Boxtyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Boxtyp.Location = new System.Drawing.Point(18, 89);
            this.lbl3Boxtyp.Name = "lbl3Boxtyp";
            this.lbl3Boxtyp.Size = new System.Drawing.Size(54, 13);
            this.lbl3Boxtyp.TabIndex = 10;
            this.lbl3Boxtyp.Text = "3. Boxtyp:";
            // 
            // nudBoxType2
            // 
            this.nudBoxType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBoxType2.Location = new System.Drawing.Point(133, 61);
            this.nudBoxType2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudBoxType2.Name = "nudBoxType2";
            this.nudBoxType2.Size = new System.Drawing.Size(117, 20);
            this.nudBoxType2.TabIndex = 4;
            this.nudBoxType2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBoxType2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudBoxType1
            // 
            this.nudBoxType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBoxType1.Location = new System.Drawing.Point(133, 34);
            this.nudBoxType1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudBoxType1.Name = "nudBoxType1";
            this.nudBoxType1.Size = new System.Drawing.Size(117, 20);
            this.nudBoxType1.TabIndex = 3;
            this.nudBoxType1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBoxType1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl2Boxtyp
            // 
            this.lbl2Boxtyp.AutoSize = true;
            this.lbl2Boxtyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Boxtyp.Location = new System.Drawing.Point(18, 63);
            this.lbl2Boxtyp.Name = "lbl2Boxtyp";
            this.lbl2Boxtyp.Size = new System.Drawing.Size(54, 13);
            this.lbl2Boxtyp.TabIndex = 7;
            this.lbl2Boxtyp.Text = "2. Boxtyp:";
            // 
            // lbl1Boxtyp
            // 
            this.lbl1Boxtyp.AutoSize = true;
            this.lbl1Boxtyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Boxtyp.Location = new System.Drawing.Point(18, 36);
            this.lbl1Boxtyp.Name = "lbl1Boxtyp";
            this.lbl1Boxtyp.Size = new System.Drawing.Size(54, 13);
            this.lbl1Boxtyp.TabIndex = 6;
            this.lbl1Boxtyp.Text = "1. Boxtyp:";
            // 
            // gpxColors
            // 
            this.gpxColors.Controls.Add(this.btnColorBoxType3);
            this.gpxColors.Controls.Add(this.btnColorBoxType2);
            this.gpxColors.Controls.Add(this.btnColorBoxType1);
            this.gpxColors.Controls.Add(this.btnColorField);
            this.gpxColors.Controls.Add(this.btnColorBox);
            this.gpxColors.Controls.Add(this.lbl3BoxtypC);
            this.gpxColors.Controls.Add(this.lbl2BoxtypC);
            this.gpxColors.Controls.Add(this.lbl1BoxtypC);
            this.gpxColors.Controls.Add(this.lblSpielfeld);
            this.gpxColors.Controls.Add(this.lblBoxen);
            this.gpxColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxColors.Location = new System.Drawing.Point(306, 50);
            this.gpxColors.Name = "gpxColors";
            this.gpxColors.Size = new System.Drawing.Size(200, 230);
            this.gpxColors.TabIndex = 2;
            this.gpxColors.TabStop = false;
            this.gpxColors.Text = "Farben";
            // 
            // btnColorBoxType3
            // 
            this.btnColorBoxType3.BackColor = System.Drawing.Color.Red;
            this.btnColorBoxType3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorBoxType3.Location = new System.Drawing.Point(88, 193);
            this.btnColorBoxType3.Name = "btnColorBoxType3";
            this.btnColorBoxType3.Size = new System.Drawing.Size(94, 23);
            this.btnColorBoxType3.TabIndex = 10;
            this.btnColorBoxType3.UseVisualStyleBackColor = false;
            this.btnColorBoxType3.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnColorBoxType2
            // 
            this.btnColorBoxType2.BackColor = System.Drawing.Color.Green;
            this.btnColorBoxType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorBoxType2.Location = new System.Drawing.Point(88, 167);
            this.btnColorBoxType2.Name = "btnColorBoxType2";
            this.btnColorBoxType2.Size = new System.Drawing.Size(94, 23);
            this.btnColorBoxType2.TabIndex = 9;
            this.btnColorBoxType2.UseVisualStyleBackColor = false;
            this.btnColorBoxType2.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnColorBoxType1
            // 
            this.btnColorBoxType1.BackColor = System.Drawing.Color.Blue;
            this.btnColorBoxType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorBoxType1.Location = new System.Drawing.Point(88, 140);
            this.btnColorBoxType1.Name = "btnColorBoxType1";
            this.btnColorBoxType1.Size = new System.Drawing.Size(94, 23);
            this.btnColorBoxType1.TabIndex = 8;
            this.btnColorBoxType1.UseVisualStyleBackColor = false;
            this.btnColorBoxType1.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnColorField
            // 
            this.btnColorField.BackColor = System.Drawing.Color.ForestGreen;
            this.btnColorField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorField.Location = new System.Drawing.Point(88, 57);
            this.btnColorField.Name = "btnColorField";
            this.btnColorField.Size = new System.Drawing.Size(94, 23);
            this.btnColorField.TabIndex = 7;
            this.btnColorField.UseVisualStyleBackColor = false;
            this.btnColorField.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // btnColorBox
            // 
            this.btnColorBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnColorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorBox.Location = new System.Drawing.Point(88, 30);
            this.btnColorBox.Name = "btnColorBox";
            this.btnColorBox.Size = new System.Drawing.Size(94, 23);
            this.btnColorBox.TabIndex = 6;
            this.btnColorBox.UseVisualStyleBackColor = false;
            this.btnColorBox.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // lbl3BoxtypC
            // 
            this.lbl3BoxtypC.AutoSize = true;
            this.lbl3BoxtypC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3BoxtypC.Location = new System.Drawing.Point(15, 198);
            this.lbl3BoxtypC.Name = "lbl3BoxtypC";
            this.lbl3BoxtypC.Size = new System.Drawing.Size(54, 13);
            this.lbl3BoxtypC.TabIndex = 13;
            this.lbl3BoxtypC.Text = "3. Boxtyp:";
            // 
            // lbl2BoxtypC
            // 
            this.lbl2BoxtypC.AutoSize = true;
            this.lbl2BoxtypC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2BoxtypC.Location = new System.Drawing.Point(15, 172);
            this.lbl2BoxtypC.Name = "lbl2BoxtypC";
            this.lbl2BoxtypC.Size = new System.Drawing.Size(54, 13);
            this.lbl2BoxtypC.TabIndex = 12;
            this.lbl2BoxtypC.Text = "2. Boxtyp:";
            // 
            // lbl1BoxtypC
            // 
            this.lbl1BoxtypC.AutoSize = true;
            this.lbl1BoxtypC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1BoxtypC.Location = new System.Drawing.Point(15, 145);
            this.lbl1BoxtypC.Name = "lbl1BoxtypC";
            this.lbl1BoxtypC.Size = new System.Drawing.Size(54, 13);
            this.lbl1BoxtypC.TabIndex = 11;
            this.lbl1BoxtypC.Text = "1. Boxtyp:";
            // 
            // lblSpielfeld
            // 
            this.lblSpielfeld.AutoSize = true;
            this.lblSpielfeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpielfeld.Location = new System.Drawing.Point(15, 62);
            this.lblSpielfeld.Name = "lblSpielfeld";
            this.lblSpielfeld.Size = new System.Drawing.Size(50, 13);
            this.lblSpielfeld.TabIndex = 3;
            this.lblSpielfeld.Text = "Spielfeld:";
            // 
            // lblBoxen
            // 
            this.lblBoxen.AutoSize = true;
            this.lblBoxen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxen.Location = new System.Drawing.Point(15, 35);
            this.lblBoxen.Name = "lblBoxen";
            this.lblBoxen.Size = new System.Drawing.Size(40, 13);
            this.lblBoxen.TabIndex = 2;
            this.lblBoxen.Text = "Boxen:";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(17, 290);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(115, 30);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Übernehmen";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnUse_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(391, 290);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(115, 30);
            this.btnAdvanced.TabIndex = 12;
            this.btnAdvanced.Text = "Erweitert";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 330);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gxpRating);
            this.Controls.Add(this.gpxColors);
            this.Controls.Add(this.gpxField);
            this.Controls.Add(this.lblEinstellungen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.Text = "Optionen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOptions_FormClosing);
            this.gpxField.ResumeLayout(false);
            this.gpxField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHorizontal)).EndInit();
            this.gxpRating.ResumeLayout(false);
            this.gxpRating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxType3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxType1)).EndInit();
            this.gpxColors.ResumeLayout(false);
            this.gpxColors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEinstellungen;
        private System.Windows.Forms.GroupBox gpxField;
        private System.Windows.Forms.GroupBox gxpRating;
        private System.Windows.Forms.GroupBox gpxColors;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblBoxenHorizontal;
        private System.Windows.Forms.Label lblBoxenVertikal;
        private System.Windows.Forms.NumericUpDown nudHorizontal;
        private System.Windows.Forms.NumericUpDown nudVertical;
        private System.Windows.Forms.NumericUpDown nudBoxType3;
        private System.Windows.Forms.Label lbl3Boxtyp;
        private System.Windows.Forms.NumericUpDown nudBoxType2;
        private System.Windows.Forms.NumericUpDown nudBoxType1;
        private System.Windows.Forms.Label lbl2Boxtyp;
        private System.Windows.Forms.Label lbl1Boxtyp;
        private System.Windows.Forms.Label lbl3BoxtypC;
        private System.Windows.Forms.Label lbl2BoxtypC;
        private System.Windows.Forms.Label lbl1BoxtypC;
        private System.Windows.Forms.Label lblSpielfeld;
        private System.Windows.Forms.Label lblBoxen;
        private System.Windows.Forms.Button btnColorBoxType3;
        private System.Windows.Forms.Button btnColorBoxType2;
        private System.Windows.Forms.Button btnColorBoxType1;
        private System.Windows.Forms.Button btnColorField;
        private System.Windows.Forms.Button btnColorBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnAdvanced;
    }
}