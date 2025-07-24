using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    public partial class InvoiceSorguServiceMainPage : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            MainPage showInform = new MainPage();
            showInform.Show();
            this.Hide();
        }
        public InvoiceSorguServiceMainPage()
        {
            InitializeComponent();
        }

        private void btnQueryUsers_Click(object sender, EventArgs e)
        {
            queryUser showInform = new queryUser();
            showInform.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            queryGbList showInform = new queryGbList();
            showInform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            queryLastInvoiceIdAndDate showInform = new queryLastInvoiceIdAndDate();
            showInform.Show();
            this.Hide();
        }

        private void btnCreditCount_Click(object sender, EventArgs e)
        {
            queryOutboxDoc showInform = new queryOutboxDoc();
            showInform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            queryOutboxDocDate showInform = new queryOutboxDocDate();
            showInform.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            queryOutboxDocReceivedDate showInform = new queryOutboxDocReceivedDate();
            showInform.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            queryOutboxDocLocalId showInform = new queryOutboxDocLocalId();
            showInform.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            queryOutboxDocGUIDList showInform = new queryOutboxDocGUIDList();
            showInform.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            queryInboxDoc showInform = new queryInboxDoc();
            showInform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            queryInboxDocDate showInform = new queryInboxDocDate();
            showInform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            queryInboxDocReceivedDate showInform = new queryInboxDocReceivedDate();
            showInform.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            queryInboxDocGUIDList showInform = new queryInboxDocGUIDList();
            showInform.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            queryPKList showInform = new queryPKList();
            showInform.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            setTakenFromEntegrator showInform = new setTakenFromEntegrator();
            showInform.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            queryEnvelope showInform = new queryEnvelope();
            showInform.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            queryAppResponseOfOutboxDoc showInform = new queryAppResponseOfOutboxDoc();
            showInform.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            queryAppResponseOfInboxDoc showInform = new queryAppResponseOfInboxDoc();
            showInform.Show();
            this.Hide();
        }
    }
}
