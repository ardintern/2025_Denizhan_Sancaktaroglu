using DokumantasyonProje.fatura_servis;
using DokumantasyonProje.Page_Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DokumantasyonProje.E_Fatura_Servisi
{
    public partial class CreditCount : Form
    {
        public CreditCount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceServiceMainPage inboxForm = new InvoiceServiceMainPage(); // Yeni formu oluştur
            inboxForm.Show(); // Yeni formu aç
            this.Hide(); // İstersen ana formu gizle
        }

        private void btnGetCredit_Click(object sender, EventArgs e)
        {
            var client = new InvoiceWSClient();

            using (var scope = new OperationContextScope(client.InnerChannel))
            {

                //OperationContext.Current.OutgoingMessageHeaders.Add(new CustomHeader());
                var username = "admin_008678";
                var password = "FFb8rB(Z";

                var prop = new HttpRequestMessageProperty();
                prop.Headers.Add("Username", username); //test kullanıcı 
                prop.Headers.Add("Password", password);  //test şifresi 
                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;

                try
                {
                    string vkn_tckn = txtVKN.Text.Trim();
                    var creditcount = client.getCustomerCreditCount(vkn_tckn);

                    string mesaj = "Hata Kodu: " + creditcount.code + Environment.NewLine +
                                    "Açıklama: " + creditcount.explanation + Environment.NewLine +
                                    "Toplam kredi sayınız: " + creditcount.totalCredit + Environment.NewLine +
                                    "Kalan kredi sayınız: " + creditcount.remainCredit;


                    MessageBox.Show(mesaj, "Kredi Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Hata");
                }

            }  
        }
    }
}
