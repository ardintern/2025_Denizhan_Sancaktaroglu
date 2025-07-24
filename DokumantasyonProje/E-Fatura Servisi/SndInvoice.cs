using DokumantasyonProje.fatura_servis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DokumantasyonProje.E_Fatura_Servisi
{
    public partial class SndInvoice : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceServiceMainPage showInbox = new InvoiceServiceMainPage(); // Yeni formu oluştur
            showInbox.Show(); // Yeni formu aç
            this.Hide(); // İstersen ana formu gizle
        }
        public SndInvoice()
        {
            InitializeComponent();
        }

        private void btnSndInvoice_Click(object sender, EventArgs e)
        {
            var client = new InvoiceWSClient();

            using (var scope = new OperationContextScope(client.InnerChannel))
            {

                var username = "admin_008678";
                var password = "FFb8rB(Z";

                var prop = new HttpRequestMessageProperty();
                prop.Headers.Add("Username", username); //test kullanıcı 
                prop.Headers.Add("Password", password);  //test şifresi 
                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;


                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Faturalar", "faturas.xml");
                string xmlDoc = File.ReadAllText(filePath);
                var xml = XDocument.Parse(xmlDoc);

                // 1. UUID'yi çek
                string uuidFormXml = Guid.NewGuid().ToString();

                // 2. Rastgele documentId oluştur
                string prefix = "TST";
                string year = DateTime.Now.Year.ToString(); // Örn: 2025

                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 999999999); // 1 ila 999.999.999 arası (9 hane)
                string paddedNumber = randomNumber.ToString("D9"); // 9 hane sıfır dolgu

                string autoDocumentId = $"{prefix}{year}{paddedNumber}";

                // 3. XML içindeki <ID> alanını güncelle
                var idElement = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "ID");
                if (idElement != null)
                {
                    idElement.Value = autoDocumentId;
                }

                // 4. (Opsiyonel) UUID'yi de tekrar yazmak istersen
                var uuidElement = xml.Descendants().FirstOrDefault(x => x.Name.LocalName == "UUID");
                if (uuidElement != null)
                {
                    uuidElement.Value = uuidFormXml;
                }

                // 5. Güncellenmiş XML'i tekrar string'e çevir
                string updatedXmlContent = xml.ToString();

                // 6. Güncellenmiş XML'i tekrar dosyaya yaz
                File.WriteAllText(filePath, updatedXmlContent);

                // 7. InputDocument nesnesiyle devam et
                var inputDocument = new InputDocument
                {
                    xmlContent = updatedXmlContent,
                    documentDate = DateTime.Now.ToString("yyyy-MM-dd"),
                    documentUUID = uuidFormXml,
                    sourceUrn = "urn:mail:defaultgb@univera.com.tr",
                    destinationUrn = "urn:mail:defaultpkhotmail@hotmail.com",
                    localId = "1",
                    documentId = autoDocumentId, // artık otomatik
                    documentNoPrefix = "EEE",
                    submitForApproval = true,
                    note = "aa"
                };

                var inputDocumentList = new InputDocument[] { inputDocument };

                var resultList = client.sendInvoice(inputDocumentList);

                // 8. Sonuç mesajı
                string mesaj = "Hata kodu (boşsa çalışıyor): " + resultList.Select(i => i.cause).FirstOrDefault() + Environment.NewLine +
                               "Kod: " + resultList.Select(i => i.code).FirstOrDefault() + Environment.NewLine +
                               "Açıklama: " + resultList.Select(i => i.explanation).FirstOrDefault() + Environment.NewLine +
                               "Fatura UUID: " + resultList.Select(i => i.documentUUID).FirstOrDefault();

                MessageBox.Show(mesaj, "Fatura Gönderme Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}

