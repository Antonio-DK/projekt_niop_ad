using System;
using System.Windows.Forms;

namespace projekt_niop_ad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuWavelength_Click(object sender, EventArgs e)
        {
            // Kreiraj i otvori novu formu za izračun valne duljine
            WaveLengthForm wavelengthForm = new WaveLengthForm();
            wavelengthForm.Show();
        }

        private void menuHeatTransfer_Click(object sender, EventArgs e)
        {
            // Kreiraj i otvori novu formu za prijenos topline
            HeatTransferForm heatTransferForm = new HeatTransferForm();
            heatTransferForm.Show();
        }
    }
}