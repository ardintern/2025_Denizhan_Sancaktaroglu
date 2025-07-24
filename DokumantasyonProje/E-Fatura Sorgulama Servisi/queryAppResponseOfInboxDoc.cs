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
    public partial class queryAppResponseOfInboxDoc : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceSorguServiceMainPage showInform = new InvoiceSorguServiceMainPage();
            showInform.Show();
            this.Hide();
        }
        private void queryInboxDoc_Load(object sender, EventArgs e)
        {
            comboBoxWithXML.Items.Add("YES");
            comboBoxWithXML.Items.Add("NO");
            comboBoxWithXML.SelectedIndex = 0; // Aynı şekilde
        }

        public queryAppResponseOfInboxDoc()
        {
            InitializeComponent();
        }

        private void btnQueryInboxDoc_Click(object sender, EventArgs e)
        {
            var client = new QueryDocumentWSClient();

            using (var scope = new OperationContextScope(client.InnerChannel))
            {

                var username = "admin_008678";
                var password = "FFb8rB(Z";
                //0370368198
                //09c9f178-7c75-4c6d-9e0d-227a22a1a740

                var prop = new HttpRequestMessageProperty();
                prop.Headers.Add("Username", username); //test kullanıcı
                prop.Headers.Add("Password", password);
                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;

                // Fix: QueryAppResponseOfInboxDocument expects a single string, not a string array
                var documentUUID = textBoxdocumentUUID.Text.Trim();

                var withXML = comboBoxWithXML.SelectedItem.ToString();

                var response = client.QueryAppResponseOfInboxDocument(documentUUID, withXML);

                string mesaj = "Sorgu (kod 0 başarılı / 99 hata): " + response.queryState.ToString() + Environment.NewLine +
                              "Sorgu mesajı: " + response.stateExplanation.ToString() + Environment.NewLine +
                              "Döküman sayısı: " + response.documentsCount.ToString() + Environment.NewLine +
                              "Max record in list: " + response.maxRecordIdinList.ToString() + Environment.NewLine;

                MessageBox.Show(mesaj, "Sorgu Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (var doc in response.documents)
                {
                    string mesaj2 = "Durum açıklaması: " + doc.state_explanation + Environment.NewLine +
                        "UUID : " + doc.document_uuid + Environment.NewLine +
                        "ID : " + doc.document_id + Environment.NewLine +
                        "Envelope UUID : " + doc.envelope_uuid + Environment.NewLine +
                        "Document Profile: " + doc.document_profile + Environment.NewLine +
                        "Oluşturulma Zamanı: " + doc.system_creation_time + Environment.NewLine +
                        "Tarih : " + doc.document_issue_date + Environment.NewLine +
                        "Source ID: " + doc.source_id + Environment.NewLine +
                        "Destination ID: " + doc.destination_id + Environment.NewLine +
                        "Source Urn: " + doc.source_urn + Environment.NewLine +
                        "Source Title: " + doc.source_title + Environment.NewLine +
                        "Destination Urn: " + doc.destination_urn + Environment.NewLine +
                        "Para Birimi: " + doc.currency_code + Environment.NewLine +
                        "Ödenecek Tutar: " + doc.invoice_total;

                    MessageBox.Show(mesaj2, "Sonuç");
                }
            }
        }
    }
}
