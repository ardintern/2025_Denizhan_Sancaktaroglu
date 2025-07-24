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
    public partial class queryLastInvoiceIdAndDate : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceSorguServiceMainPage showInform = new InvoiceSorguServiceMainPage();
            showInform.Show();
            this.Hide();
        }

        public queryLastInvoiceIdAndDate()
        {
            InitializeComponent();
        }

        private void btnGetLastInIdDate_Click(object sender, EventArgs e)
        {
            var client = new QueryDocumentWSClient();

            using (var scope = new OperationContextScope(client.InnerChannel))
            {

                var username = "admin_008678";
                var password = "FFb8rB(Z";
                //0370368198
                //b221fa2c-ef66-482d-b18d-ea27dd8e9aa5

                var prop = new HttpRequestMessageProperty();
                prop.Headers.Add("Username", username); //test kullanıcı 
                prop.Headers.Add("Password", password);  //test şifresi 
                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;

                string source_id = textBoxsource_id.Text.Trim(); //tc no
                List<string> documentIdPrefix = new List<string> { }; // süslü parantez içine { "TST", "DHN" } gibi yazılabilir.
                documentIdPrefix.Add(textBoxdocumentIdPrefix.Text.Trim());

                var result = client.GetLastInvoiceIdAndDate(source_id, documentIdPrefix.ToArray());

                try
                {
                    string mesaj = "Sorgu (kod 0 başarılı / 99 hata) : " + result.queryState.ToString() + Environment.NewLine +
                    "Açıklama: " + result.stateExplanation.ToString() + Environment.NewLine +
                    "Döküman sayısı: " + result.documentsCount.ToString() + Environment.NewLine +
                    "Listedeki en yüksek Id: " + result.maxRecordIdinList.ToString();

                    MessageBox.Show(mesaj, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    string mesaj = "Sorgu (kod 0 başarılı / 99 hata) : " + result.queryState.ToString() + Environment.NewLine +
                    "Açıklama: " + result.stateExplanation.ToString() + Environment.NewLine;

                    MessageBox.Show(mesaj, "Hata");
                }
            }
        }
    }
}
