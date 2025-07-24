using DokumantasyonProje.query_servis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class queryInboxDocDate : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceSorguServiceMainPage mainPage = new InvoiceSorguServiceMainPage();
            mainPage.Show();
            this.Hide();
        }
        private void queryInboxDocDate_Load(object sender, EventArgs e)
        {
            // Form_Load içinde:
            comboBoxDocType.Items.Add("1");
            comboBoxDocType.Items.Add("2");
            comboBoxDocType.SelectedIndex = 0; // Aynı şekilde

            comboBoxWithXML.Items.Add("XML");
            comboBoxWithXML.Items.Add("PDF");
            comboBoxWithXML.Items.Add("HTML");
            comboBoxWithXML.Items.Add("NONE");
            comboBoxWithXML.SelectedIndex = 0; // Aynı şekilde

            comboBoxQueried.Items.Add("YES");
            comboBoxQueried.Items.Add("NO");
            comboBoxQueried.Items.Add("ALL");
            comboBoxQueried.SelectedIndex = 2; // Aynı şekilde

            comboBoxTakenFromEntegrator.Items.Add("YES");
            comboBoxTakenFromEntegrator.Items.Add("NO");
            comboBoxTakenFromEntegrator.Items.Add("ALL");
            comboBoxTakenFromEntegrator.SelectedIndex = 2; // Varsayılan olarak "YES" seçildi
        }

        public queryInboxDocDate()
        {
            InitializeComponent();
        }

        private void btnQueryInboxDocDate_Click(object sender, EventArgs e)
        {
            var client = new QueryDocumentWSClient();

            using (var scope = new OperationContextScope(client.InnerChannel))
            {

                var username = "admin_008678";
                var password = "FFb8rB(Z";
                //0370368198
                //09c9f178-7c75-4c6d-9e0d-227a22a1a740 sadece bu çalışıyor

                var prop = new HttpRequestMessageProperty();
                prop.Headers.Add("Username", username); //test kullanıcı
                prop.Headers.Add("Password", password);
                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;

                string documentType = comboBoxDocType.SelectedItem.ToString();
                string withXML = comboBoxWithXML.SelectedItem.ToString();
                string queried = comboBoxQueried.SelectedItem.ToString();
                string startDate = dateTimeStart.Value.ToString("yyyy-MM-dd");
                string finishDate = dateTimeEnd.Value.ToString("yyyy-MM-dd");
                string minRecordId = textBoxMinRecordId.Text.Trim();
                string takenFromEntegrator = comboBoxTakenFromEntegrator.SelectedItem.ToString();

                var outdocdate = client.QueryInboxDocumentsWithDocumentDate(startDate, finishDate, documentType, queried, withXML, takenFromEntegrator, minRecordId);

                string mesaj = "Hata durumu: " + outdocdate.queryState.ToString() + Environment.NewLine +
                    "Açıklama: " + outdocdate.stateExplanation + Environment.NewLine +
                    "Belge sayısı: " + outdocdate.documentsCount;

                MessageBox.Show(mesaj, "Sonuç");

                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                try
                {
                    switch (withXML)
                    {
                        case "XML":

                            string folderPath = Path.Combine(desktopPath, "Belgelerim_XML");
                            Directory.CreateDirectory(folderPath); // Klasör yoksa oluştur

                            for (int i = 0; i < outdocdate.documents.Length; i++)
                            {
                                var doc = outdocdate.documents[i];

                                // Belge içindeki XML içerik hangi property'de? Bulmak için reflection kullan
                                var props = doc.GetType().GetProperties();
                                foreach (var propa in props)
                                {
                                    if (propa.PropertyType == typeof(byte[]))
                                    {
                                        var contentBytes = (byte[])propa.GetValue(doc);
                                        if (contentBytes != null && contentBytes.Length > 0)
                                        {
                                            string xmlContent = System.Text.Encoding.UTF8.GetString(contentBytes);
                                            string fileName = $"{startDate}-{finishDate}.Faturalar_{i + 1}.xml";
                                            string filePath = Path.Combine(folderPath, fileName);

                                            System.IO.File.WriteAllText(filePath, xmlContent);
                                        }
                                    }
                                    else if (propa.PropertyType == typeof(string))
                                    {
                                        string strVal = propa.GetValue(doc) as string;
                                        if (!string.IsNullOrWhiteSpace(strVal) && strVal.TrimStart().StartsWith("<"))
                                        {
                                            string fileName = $"{startDate}-{finishDate}.Faturalar_{i + 1}.xml";
                                            string filePath = Path.Combine(folderPath, fileName);

                                            System.IO.File.WriteAllText(filePath, strVal);
                                        }
                                    }
                                }
                            }

                            MessageBox.Show("XML dosyaları masaüstüne kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;

                        case "PDF":

                            string pdfFolderPath = Path.Combine(desktopPath, "Belgelerim_PDF");
                            Directory.CreateDirectory(pdfFolderPath); // Klasör yoksa oluştur

                            for (int i = 0; i < outdocdate.documents.Length; i++)
                            {
                                var doc = outdocdate.documents[i];
                                var props = doc.GetType().GetProperties();

                                foreach (var propa in props)
                                {
                                    if (propa.PropertyType == typeof(byte[]))
                                    {
                                        var byteContent = (byte[])propa.GetValue(doc);
                                        if (byteContent != null && byteContent.Length > 0)
                                        {
                                            string fileName = $"{startDate}-{finishDate}.Faturalar_{i + 1}.pdf ";
                                            string filePath = Path.Combine(pdfFolderPath, fileName);

                                            File.WriteAllBytes(filePath, byteContent); // PDF için binary yazım!
                                        }
                                    }
                                }
                            }

                            MessageBox.Show("PDF dosyaları masaüstündeki 'Belgelerim' klasörüne kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case "HTML":

                            string htmlFolderPath = Path.Combine(desktopPath, "Belgelerim_HTML");
                            Directory.CreateDirectory(htmlFolderPath); // Klasör yoksa oluştur

                            for (int i = 0; i < outdocdate.documents.Length; i++)
                            {
                                var doc = outdocdate.documents[i];
                                var props = doc.GetType().GetProperties();

                                foreach (var propa in props)
                                {
                                    if (propa.PropertyType == typeof(byte[]))
                                    {
                                        var byteContent = (byte[])propa.GetValue(doc);
                                        if (byteContent != null && byteContent.Length > 0)
                                        {
                                            string htmlContent = System.Text.Encoding.UTF8.GetString(byteContent);
                                            string fileName = $"{startDate}-{finishDate}.Faturalar_{i + 1}.html";
                                            string filePath = Path.Combine(htmlFolderPath, fileName);

                                            File.WriteAllText(filePath, htmlContent);
                                        }
                                    }
                                    else if (propa.PropertyType == typeof(string))
                                    {
                                        string strVal = propa.GetValue(doc) as string;
                                        if (!string.IsNullOrWhiteSpace(strVal) && strVal.TrimStart().StartsWith("<!DOCTYPE html"))
                                        {
                                            string fileName = $"{startDate}-{finishDate}.Faturalar_{i + 1}.html";
                                            string filePath = Path.Combine(htmlFolderPath, fileName);

                                            File.WriteAllText(filePath, strVal);
                                        }
                                    }
                                }
                            }

                            MessageBox.Show("HTML dosyaları masaüstündeki 'Belgelerim' klasörüne kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case "NONE":

                            MessageBox.Show("Herhangi bir içerik tipi seçilmediği için dosya kaydedilmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        default:
                            MessageBox.Show("Seçim yapınız.");
                            break;
                        }
                }
                catch
                {
                    string mesaj2 = "Hata durumu: " + outdocdate.queryState.ToString() + Environment.NewLine +
                         "Açıklama: " + outdocdate.stateExplanation + Environment.NewLine;

                     MessageBox.Show(mesaj2, "Sonuç");
                }
            }
        }
    }
}
