using DokumantasyonProje.query_servis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Security.Policy;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokumantasyonProje.E_Fatura_Sorgulama_Servisi
{
    public partial class queryOutboxDoc : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceSorguServiceMainPage showInform = new InvoiceSorguServiceMainPage();
            showInform.Show();
            this.Hide();
        }

        public queryOutboxDoc()
        {
            InitializeComponent();
        }

        private void queryOutboxDoc_Load (object sender, EventArgs e)
        {
            // Form_Load içinde:
            comboBoxParamType.Items.Add("Document_UUID");
            comboBoxParamType.Items.Add("Document_ID");
            comboBoxParamType.Items.Add("Envelope_UUID");
            comboBoxParamType.SelectedIndex = 0; // Varsayılan olarak ilk öğeyi seç

            comboBoxWithXML.Items.Add("XML");
            comboBoxWithXML.Items.Add("PDF");
            comboBoxWithXML.Items.Add("HTML");
            comboBoxWithXML.Items.Add("NONE");
            comboBoxWithXML.SelectedIndex = 0; // Aynı şekilde

        }

        private void btnQueryOutboxDoc_Click(object sender, EventArgs e)
        {
            var client = new QueryDocumentWSClient();

            using (var scope = new OperationContextScope(client.InnerChannel))
            {

                var username = "admin_008678";
                var password = "FFb8rB(Z";
                //0370368198
                //b221fa2c-ef66-482d-b18d-ea27dd8e9ab5

                var prop = new HttpRequestMessageProperty();
                prop.Headers.Add("Username", username); //test kullanıcı
                prop.Headers.Add("Password", password);
                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;

                string paramType = comboBoxParamType.SelectedItem?.ToString() ?? "";
                string withXML = comboBoxWithXML.SelectedItem?.ToString() ?? "";
                string parameter = textBoxParameter.Text.Trim();


                var outdoc = client.QueryOutboxDocument(paramType, parameter, withXML);

                try
                {
                    string mesaj = "Sorgu (kod 0 başarılı / 99 hata) : " + outdoc.queryState.ToString() + Environment.NewLine +
                        "Açıklama: " + outdoc.stateExplanation.ToString() + Environment.NewLine +
                        "Döküman sayısı: " + outdoc.documentsCount.ToString() + Environment.NewLine +
                        "Listedeki en yüksek Id: " + outdoc.maxRecordIdinList.ToString();

                    MessageBox.Show(mesaj, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    switch (withXML)
                    {
                        case "XML":

                            for (int i = 0; i < outdoc.documents.Length; i++)
                            {
                                var doc = outdoc.documents[i];

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
                                            string fileName = $"belge_{i + 1}.xml";
                                            string filePath = Path.Combine(desktopPath, fileName);

                                            System.IO.File.WriteAllText(filePath, xmlContent);
                                        }
                                    }
                                    else if (propa.PropertyType == typeof(string))
                                    {
                                        string strVal = propa.GetValue(doc) as string;
                                        if (!string.IsNullOrWhiteSpace(strVal) && strVal.TrimStart().StartsWith("<"))
                                        {
                                            string fileName = $"belge_{i + 1}.xml";
                                            string filePath = Path.Combine(desktopPath, fileName);

                                            System.IO.File.WriteAllText(filePath, strVal);
                                        }
                                    }
                                }
                            }

                            MessageBox.Show("XML dosyaları masaüstüne kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;

                        case "HTML":

                            for (int i = 0; i < outdoc.documents.Length; i++)
                            {
                                var doc = outdoc.documents[i];

                                var props = doc.GetType().GetProperties();
                                foreach (var propa in props)
                                {
                                    if (propa.PropertyType == typeof(byte[]))
                                    {
                                        var byteContent = (byte[])propa.GetValue(doc);
                                        if (byteContent != null && byteContent.Length > 0)
                                        {
                                            string htmlContent = System.Text.Encoding.UTF8.GetString(byteContent);
                                            string fileName = $"belge_{i + 1}.html";
                                            string filePath = Path.Combine(desktopPath, fileName);

                                            File.WriteAllText(filePath, htmlContent);
                                        }
                                    }
                                    else if (propa.PropertyType == typeof(string))
                                    {
                                        string strVal = propa.GetValue(doc) as string;
                                        if (!string.IsNullOrWhiteSpace(strVal) && strVal.TrimStart().StartsWith("<!DOCTYPE html"))
                                        {
                                            string fileName = $"belge_{i + 1}.html";
                                            string filePath = Path.Combine(desktopPath, fileName);

                                            File.WriteAllText(filePath, strVal);
                                        }
                                    }
                                }
                            }

                            MessageBox.Show("HTML dosyaları masaüstüne kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;

                        case "PDF":

                            for (int i = 0; i < outdoc.documents.Length; i++)
                            {
                                var doc = outdoc.documents[i];

                                var props = doc.GetType().GetProperties();
                                foreach (var propa in props)
                                {
                                    if (propa.PropertyType == typeof(byte[]))
                                    {
                                        var byteContent = (byte[])propa.GetValue(doc);
                                        if (byteContent != null && byteContent.Length > 0)
                                        {
                                            string fileName = $"belge_{i + 1}.pdf";
                                            string filePath = Path.Combine(desktopPath, fileName);

                                            File.WriteAllBytes(filePath, byteContent); // PDF binary olduğu için WriteAllBytes!
                                        }
                                    }
                                }
                            }

                            MessageBox.Show("PDF dosyaları masaüstüne kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;

                        case "NONE":

                            MessageBox.Show("Herhangi bir içerik tipi seçilmediği için dosya kaydedilmedi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            break;

                        default:

                            MessageBox.Show("Birini seçiniz.");
                            break;
                    }
                }
                catch
                {
                    string mesaj = "Sorgu (kod 0 başarılı / 99 hata) : " + outdoc.queryState.ToString() + Environment.NewLine +
                        "Açıklama: " + outdoc.stateExplanation.ToString() + Environment.NewLine;

                    MessageBox.Show(mesaj, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
