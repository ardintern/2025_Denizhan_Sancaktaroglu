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

namespace DokumantasyonProje.E_Fatura_Servisi
{
    public partial class CustomerPkList : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceServiceMainPage showInbox = new InvoiceServiceMainPage();
            showInbox.Show();
            this.Hide();
        }

        public CustomerPkList()
        {
            InitializeComponent();
        }

        private void btnGetPkList_Click(object sender, EventArgs e)
        {
            var client = new InvoiceWSClient();

            using (new OperationContextScope(client.InnerChannel))
            {

                var username = "admin_008678";
                var password = "FFb8rB(Z";

                var prop = new HttpRequestMessageProperty();
                prop.Headers.Add("Username", username); //test kullanıcı 
                prop.Headers.Add("Password", password);  //test şifresi 
                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;

                var pkList = client.getCustomerPKList();

                try 
                {
                    string mesaj =  "Tc kimlik: " + pkList.users.Select(i => i.vkn_tckn).FirstOrDefault() + Environment.NewLine +
                                    "Etiket: " + pkList.users.Select(i => i.etiket).FirstOrDefault() + Environment.NewLine;

                    MessageBox.Show(mesaj, "Pk List");
                }
                catch
                {
                    MessageBox.Show("Hata");
                }
            }
        }
    }
}
