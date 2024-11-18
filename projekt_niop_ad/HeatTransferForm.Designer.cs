namespace projekt_niop_ad
{
    partial class HeatTransferForm
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
            this.lblMass = new System.Windows.Forms.Label();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.lblHeatCapacity = new System.Windows.Forms.Label();
            this.txtHeatCapacity = new System.Windows.Forms.TextBox();
            this.lblTemperatureChange = new System.Windows.Forms.Label();
            this.txtTemperatureChange = new System.Windows.Forms.TextBox();
            this.btnCalculateHeat = new System.Windows.Forms.Button();
            this.lblHeatResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMass
            // 
            this.lblMass.AutoSize = true;
            this.lblMass.Location = new System.Drawing.Point(53, 58);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(77, 13);
            this.lblMass.TabIndex = 0;
            this.lblMass.Text = "Masa (m) [kg]: ";
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(56, 104);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(100, 20);
            this.txtMass.TabIndex = 1;
            // 
            // lblHeatCapacity
            // 
            this.lblHeatCapacity.AutoSize = true;
            this.lblHeatCapacity.Location = new System.Drawing.Point(220, 58);
            this.lblHeatCapacity.Name = "lblHeatCapacity";
            this.lblHeatCapacity.Size = new System.Drawing.Size(204, 13);
            this.lblHeatCapacity.TabIndex = 2;
            this.lblHeatCapacity.Text = "Specifični toplinski kapacitet (c) [J/kg°C]: ";
            // 
            // txtHeatCapacity
            // 
            this.txtHeatCapacity.Location = new System.Drawing.Point(223, 104);
            this.txtHeatCapacity.Name = "txtHeatCapacity";
            this.txtHeatCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtHeatCapacity.TabIndex = 3;
            // 
            // lblTemperatureChange
            // 
            this.lblTemperatureChange.AutoSize = true;
            this.lblTemperatureChange.Location = new System.Drawing.Point(440, 58);
            this.lblTemperatureChange.Name = "lblTemperatureChange";
            this.lblTemperatureChange.Size = new System.Drawing.Size(159, 13);
            this.lblTemperatureChange.TabIndex = 4;
            this.lblTemperatureChange.Text = "Promjena temperature (ΔT) [°C]: ";
            // 
            // txtTemperatureChange
            // 
            this.txtTemperatureChange.Location = new System.Drawing.Point(443, 104);
            this.txtTemperatureChange.Name = "txtTemperatureChange";
            this.txtTemperatureChange.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatureChange.TabIndex = 5;
            // 
            // btnCalculateHeat
            // 
            this.btnCalculateHeat.Location = new System.Drawing.Point(223, 190);
            this.btnCalculateHeat.Name = "btnCalculateHeat";
            this.btnCalculateHeat.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateHeat.TabIndex = 6;
            this.btnCalculateHeat.Text = "Izračunaj";
            this.btnCalculateHeat.UseVisualStyleBackColor = true;
            this.btnCalculateHeat.Click += new System.EventHandler(this.btnCalculateHeat_Click);
            // 
            // lblHeatResult
            // 
            this.lblHeatResult.AutoSize = true;
            this.lblHeatResult.Location = new System.Drawing.Point(320, 195);
            this.lblHeatResult.Name = "lblHeatResult";
            this.lblHeatResult.Size = new System.Drawing.Size(64, 13);
            this.lblHeatResult.TabIndex = 7;
            this.lblHeatResult.Text = "                   ";
            // 
            // HeatTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHeatResult);
            this.Controls.Add(this.btnCalculateHeat);
            this.Controls.Add(this.txtTemperatureChange);
            this.Controls.Add(this.lblTemperatureChange);
            this.Controls.Add(this.txtHeatCapacity);
            this.Controls.Add(this.lblHeatCapacity);
            this.Controls.Add(this.txtMass);
            this.Controls.Add(this.lblMass);
            this.Name = "HeatTransferForm";
            this.Text = "HeatTransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.Label lblHeatCapacity;
        private System.Windows.Forms.TextBox txtHeatCapacity;
        private System.Windows.Forms.Label lblTemperatureChange;
        private System.Windows.Forms.TextBox txtTemperatureChange;
        private System.Windows.Forms.Button btnCalculateHeat;
        private System.Windows.Forms.Label lblHeatResult;
    }
}