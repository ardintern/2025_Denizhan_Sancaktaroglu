using DokumantasyonProje.E_Fatura_Servisi;
using DokumantasyonProje.E_Fatura_Sorgulama_Servisi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokumantasyonProje
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            InvoiceServiceMainPage inboxForm = new InvoiceServiceMainPage(); // Yeni formu oluştur
            inboxForm.Show(); // Yeni formu aç
            this.Hide(); // İstersen ana formu gizle
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceSorguServiceMainPage inboxForm = new InvoiceSorguServiceMainPage(); // Yeni formu oluştur
            inboxForm.Show();
            this.Hide();
        }
    }
}
