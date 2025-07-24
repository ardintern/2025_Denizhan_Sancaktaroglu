using DokumantasyonProje.fatura_servis;
using DokumantasyonProje.query_servis;
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

namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    public partial class queryUser : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceSorguServiceMainPage showInform = new InvoiceSorguServiceMainPage();
            showInform.Show();
            this.Hide();
        }
        public queryUser()
        {
            InitializeComponent();
        }

        private void btnQueryUsers_Click(object sender, EventArgs e)
        {
            var client = new QueryDocumentWSClient();

            using (var scope = new OperationContextScope(client.InnerChannel))
            {

                //OperationContext.Current.OutgoingMessageHeaders.Add(new CustomHeader());
                var username = "admin_008678";
                var password = "FFb8rB(Z";
                //0370368198
                //6621610117	

                var prop = new HttpRequestMessageProperty();
                prop.Headers.Add("Username", username); //test kullanıcı 
                prop.Headers.Add("Password", password);  //test şifresi 
                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;

                string vkn_tckn = txtVKN.Text.Trim();
                string startDate = dateTimeStart.Value.ToString("yyyy-MM-dd");
                string finishDate = dateTimeEnd.Value.ToString("yyyy-MM-dd");

                string mesaj =
                    "VKN/TCKN: " + vkn_tckn + Environment.NewLine +
                    "Başlangıç Tarihi: " + startDate + Environment.NewLine +
                    "Bitiş Tarihi: " + finishDate;

                MessageBox.Show(mesaj, "Sorgu Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);


                var query = client.QueryUsers(startDate, finishDate, vkn_tckn);


                if (query.users != null)
                {
                    foreach (var user in query.users)
                    {
                        if (user != null)
                        {
                            string mesaj2 =
                            "TCKN: " + user.vkn_tckn + Environment.NewLine +
                            "Ad: " + user.unvan_ad + Environment.NewLine +
                            "Etiket: " + user.etiket + Environment.NewLine +
                            "Tip: " + user.tip + Environment.NewLine +
                            "İlk Kayıt Zamanı: " + (user.ilkKayitZamani?.ToString() ?? "Boş") + Environment.NewLine +
                            "Etiket Kayıt Zamanı: " + (user.etiketKayitZamani?.ToString() ?? "Boş") + Environment.NewLine +
                            "Etiket Kayıt Türü: " + user.etiketKayitTuru;

                            MessageBox.Show(mesaj2, "Kullanıcı Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı listesi boş veya null.");
                }
            }
        }
    }
}
