using System;
using System.Windows.Forms;

namespace projekt_niop_ad
{
    public partial class HeatTransferForm : Form
    {
        public HeatTransferForm()
        {
            InitializeComponent();
        }

        private void btnCalculateHeat_Click(object sender, EventArgs e)
        {
            try
            {
                // Učitaj masu
                if (!double.TryParse(txtMass.Text, out double mass) || mass <= 0)
                {
                    MessageBox.Show("Molimo unesite valjanu masu (pozitivni broj).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Učitaj specifični toplinski kapacitet
                if (!double.TryParse(txtHeatCapacity.Text, out double specificHeat) || specificHeat <= 0)
                {
                    MessageBox.Show("Molimo unesite valjani specifični toplinski kapacitet (pozitivni broj).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Učitaj promjenu temperature
                if (!double.TryParse(txtTemperatureChange.Text, out double deltaT))
                {
                    MessageBox.Show("Molimo unesite valjanu promjenu temperature (broj).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Izračun prijenosa topline
                double heatTransfer = mass * specificHeat * deltaT;
                lblHeatResult.Text = $"Prijenos topline: {heatTransfer:F2} J";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
