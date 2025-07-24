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

namespace DokumantasyonProje.E_Fatura_Servisi
{
    public partial class CustomerGbList : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceServiceMainPage inboxForm = new InvoiceServiceMainPage();
            inboxForm.Show();
            this.Hide();
        }

        public CustomerGbList()
        {
            InitializeComponent();
        }

        private void btnGetGbList_Click(object sender, EventArgs e)
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



                //OperationContext.Current.OutgoingMessageHeaders.Add(new CustomHeader());

                var gblist = client.getCustomerGBList();

                var tckn = gblist.users.Select(i => i.vkn_tckn).FirstOrDefault();
                var etk = gblist.users.Select(i => i.etiket).FirstOrDefault();

                try
                {
                    string mesaj = "Tc no: " + tckn + Environment.NewLine +
                                    "Etiket: " + etk;
                    
                    MessageBox.Show(mesaj, "Gb List");
                }
                
                catch 
                { 
                    MessageBox.Show("Hata");
                }
            }
        }
    }
}
