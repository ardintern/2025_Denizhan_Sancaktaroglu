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
    public partial class queryEnvelope : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceSorguServiceMainPage showInform = new InvoiceSorguServiceMainPage();
            showInform.Show();
            this.Hide();
        }

        public queryEnvelope()
        {
            InitializeComponent();
        }

        private void btnQueryEnvelope_Click(object sender, EventArgs e)
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
                prop.Headers.Add("Password", password);
                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;

                string envelopeUUID = textBoxEnvelopeUUID.Text.Trim();
                int processState = 1;
                int processResult = 1;
                string documentUUID = textBoxDocUUID.Text.Trim();
                string sourceId = "1";


                var request = client.QueryEnvelope(envelopeUUID, processState, processResult, documentUUID, sourceId);

                string mesaj = "Sorgu (kod 0 başarılı / 99 hata): " + request.queryState.ToString() + Environment.NewLine +
                              "Açıklama: " + request.stateExplanation + Environment.NewLine +
                              "Döküman sayısı: " + request.documentsCount.ToString() + Environment.NewLine +
                              "Maks record id in list: " + request.maxRecordIdinList.ToString();

                MessageBox.Show(mesaj, "Sorgu Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
