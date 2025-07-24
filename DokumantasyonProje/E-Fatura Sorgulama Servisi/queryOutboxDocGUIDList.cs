using DokumantasyonProje.query_servis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    public partial class queryOutboxDocGUIDList : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceSorguServiceMainPage showInform = new InvoiceSorguServiceMainPage();
            showInform.Show();
            this.Hide();
        }
        private void queryOutboxDocGUIDList_Load(object sender, EventArgs e)
        {
            // Form_Load içinde:
            comboBoxDocType.Items.Add("1");
            comboBoxDocType.Items.Add("2");
            comboBoxDocType.SelectedIndex = 0; // Aynı şekilde
        }

        public queryOutboxDocGUIDList()
        {
            InitializeComponent();
        }

        private void btnQueryOutboxDocLocalId_Click(object sender, EventArgs e)
        {
            var client = new QueryDocumentWSClient();

            using (var scope = new OperationContextScope(client.InnerChannel))
            {
                var username = "admin_008678";
                var password = "FFb8rB(Z";
                //0370368198
                //b221fa2c-ef66-482d-b18d-ea27dd8e9ab5 - guid numarası

                var prop = new HttpRequestMessageProperty();
                prop.Headers.Add("Username", username); //test kullanıcı
                prop.Headers.Add("Password", password);
                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;


                string documentType = comboBoxDocType.SelectedItem.ToString();
                List<string> guidList = new List<string> { };
                
                string yeniguid = textBoxGUID.Text.ToString();
                guidList.Add(yeniguid);

                var outdocguid = client.QueryOutboxDocumentsWithWithGUIDList(guidList.ToArray(), documentType);

                try
                {

                    string mesaj = "Hata durumu: " + outdocguid.queryState.ToString() + Environment.NewLine +
                                   "Toplam kayıt sayısı: " + outdocguid.stateExplanation.ToString() + Environment.NewLine +
                                   "Hata durumu: " + outdocguid.documentsCount.ToString() + Environment.NewLine +
                                   "Hata durumu: " + outdocguid.maxRecordIdinList.ToString();

                    MessageBox.Show(mesaj, "Hata");


                    StringBuilder sb = new StringBuilder();

                    if (outdocguid != null)
                    {
                        foreach(var doc in outdocguid.documents)
                        {
                            sb.AppendLine($"Durum Açıklaması: {doc.state_explanation}");
                            sb.AppendLine($"UUID: {doc.document_uuid}");
                            sb.AppendLine($"ID: {doc.document_id}");
                            sb.AppendLine($"Envelope UUID: {doc.envelope_uuid}");
                            sb.AppendLine($"Document Profile: {doc.document_profile}");
                            sb.AppendLine($"Oluşturulma Zamanı: {doc.system_creation_time}");
                            sb.AppendLine($"Tarih: {doc.document_issue_date}");
                            sb.AppendLine($"Source ID: {doc.source_id}");
                            sb.AppendLine($"Destination ID: {doc.destination_id}");
                            sb.AppendLine($"Source Urn: {doc.source_urn}");
                            sb.AppendLine($"Source Title: {doc.source_title}");
                            sb.AppendLine($"Destination Urn: {doc.destination_urn}");
                            sb.AppendLine($"Para Birimi: {doc.currency_code}");
                            sb.AppendLine($"Ödenecek Tutar: {doc.invoice_total}");
                            sb.AppendLine($"Durum Kodu: {doc.state_code}");

                            sb.AppendLine(new string ('-', 100));
                        }
                        
                    }

                    string path = Path.Combine(Path.GetTempPath(), "SorguSonucu.txt");
                    File.WriteAllText(path, sb.ToString(), Encoding.UTF8);

                    Process.Start("notepad.exe", path);

                }
                catch
                {
                    string mesaj = "Hata durumu: " + outdocguid.queryState.ToString() + Environment.NewLine +
                                   "Açıklama: " + outdocguid.stateExplanation.ToString() + Environment.NewLine;

                    MessageBox.Show(mesaj, "Hata");
                }
            }
        }
    }
}
