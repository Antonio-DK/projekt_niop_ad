namespace projekt_niop_ad
{
    partial class WaveLengthForm
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
            this.lblSpeedOfLight = new System.Windows.Forms.Label();
            this.txtSpeedOfLight = new System.Windows.Forms.TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.btnCalculateWavelength = new System.Windows.Forms.Button();
            this.lblWavelengthResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSpeedOfLight
            // 
            this.lblSpeedOfLight.AutoSize = true;
            this.lblSpeedOfLight.Location = new System.Drawing.Point(47, 40);
            this.lblSpeedOfLight.Name = "lblSpeedOfLight";
            this.lblSpeedOfLight.Size = new System.Drawing.Size(127, 13);
            this.lblSpeedOfLight.TabIndex = 0;
            this.lblSpeedOfLight.Text = "Brzina svjetlosti (c) [m/s]: ";
            // 
            // txtSpeedOfLight
            // 
            this.txtSpeedOfLight.Location = new System.Drawing.Point(50, 80);
            this.txtSpeedOfLight.Name = "txtSpeedOfLight";
            this.txtSpeedOfLight.Size = new System.Drawing.Size(100, 20);
            this.txtSpeedOfLight.TabIndex = 1;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(251, 40);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(102, 13);
            this.lblFrequency.TabIndex = 2;
            this.lblFrequency.Text = "Frekvencija (f) [Hz]: ";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(254, 80);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtFrequency.TabIndex = 3;
            // 
            // btnCalculateWavelength
            // 
            this.btnCalculateWavelength.Location = new System.Drawing.Point(412, 77);
            this.btnCalculateWavelength.Name = "btnCalculateWavelength";
            this.btnCalculateWavelength.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateWavelength.TabIndex = 4;
            this.btnCalculateWavelength.Text = "Izračunaj";
            this.btnCalculateWavelength.UseVisualStyleBackColor = true;
            this.btnCalculateWavelength.Click += new System.EventHandler(this.btnCalculateWavelength_Click);
            // 
            // lblWavelengthResult
            // 
            this.lblWavelengthResult.AutoSize = true;
            this.lblWavelengthResult.Location = new System.Drawing.Point(414, 151);
            this.lblWavelengthResult.Name = "lblWavelengthResult";
            this.lblWavelengthResult.Size = new System.Drawing.Size(73, 13);
            this.lblWavelengthResult.TabIndex = 5;
            this.lblWavelengthResult.Text = "                      ";
            // 
            // WaveLengthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWavelengthResult);
            this.Controls.Add(this.btnCalculateWavelength);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.txtSpeedOfLight);
            this.Controls.Add(this.lblSpeedOfLight);
            this.Name = "WaveLengthForm";
            this.Text = "WaveLengthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpeedOfLight;
        private System.Windows.Forms.TextBox txtSpeedOfLight;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Button btnCalculateWavelength;
        private System.Windows.Forms.Label lblWavelengthResult;
    }
}