using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokumantasyonProje.E_Fatura_Servisi
{
    public partial class InvoiceServiceMainPage : Form
    {
        public InvoiceServiceMainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage inboxForm = new MainPage(); // Yeni formu oluştur
            inboxForm.Show(); // Yeni formu aç
            this.Hide(); // İstersen ana formu gizle
        }

        private void btnSendInvoice_Click(object sender, EventArgs e)
        {
            SndInvoice inboxForm = new SndInvoice(); // Yeni formu oluştur
            inboxForm.Show(); // Yeni formu aç
            this.Hide(); // İstersen ana formu gizles
        }

        private void btnCreditCount_Click(object sender, EventArgs e)
        {
            CreditCount inboxForm = new CreditCount(); // Yeni formu oluştur
            inboxForm.Show(); // Yeni formu aç
            this.Hide(); // İstersen ana formu gizle
        }

        private void btnGetGbList_Click(object sender, EventArgs e)
        {
            CustomerGbList inboxForm = new CustomerGbList(); // Yeni formu oluştur
            inboxForm.Show(); // Yeni formu aç
            this.Hide(); // İstersen ana formu gizle
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreditSpace inboxForm = new CreditSpace();
            inboxForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CustomerPkList inboxForm = new CustomerPkList();
            inboxForm.Show();
            this.Hide();
        }
    }
}
