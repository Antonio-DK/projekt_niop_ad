using System;
using System.Windows.Forms;

namespace projekt_niop_ad
{
    public partial class WaveLengthForm : Form
    {
        public WaveLengthForm()
        {
            InitializeComponent();
        }

        private void btnCalculateWavelength_Click(object sender, EventArgs e)
        {
            try
            {
                // Brzina svjetlosti (konstanta)
                double c = 3e8; // 3 × 10^8 m/s

                // Učitaj frekvenciju
                if (!double.TryParse(txtFrequency.Text, out double frequency) || frequency <= 0)
                {
                    MessageBox.Show("Molimo unesite valjanu frekvenciju (pozitivni broj).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Izračun valne duljine
                double wavelength = c / frequency;
                lblWavelengthResult.Text = $"Valna duljina: {wavelength:F2} m";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

