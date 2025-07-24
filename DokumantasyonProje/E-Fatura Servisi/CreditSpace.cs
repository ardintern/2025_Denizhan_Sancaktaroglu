using DokumantasyonProje.fatura_servis;
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
    public partial class CreditSpace : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceServiceMainPage showInbox = new InvoiceServiceMainPage();
            showInbox.Show();
            this.Hide();
        }

        public CreditSpace()
        {
            InitializeComponent();
        }

        private void btnGetCreditSpace_Click(object sender, EventArgs e)
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
                    string vkn_tckn = txtVKN.Text.Trim(); //Trim baştaki ve sondaki boşlukları siler.
                    var creditspace = client.getCustomerCreditSpace(vkn_tckn);

                    string mesaj = "Hata: " + creditspace.code + Environment.NewLine +
                                    "Açıklama: " + creditspace.explanation + Environment.NewLine +
                                    "Toplam kredi: " + creditspace.totalCredit + Environment.NewLine +
                                    "Kalan kredi: " + creditspace.remainCredit;


                    MessageBox.Show(mesaj, "CreditSpace");

                }
                catch
                {
                    MessageBox.Show("Hata");
                }
            }
        }
    }
}
