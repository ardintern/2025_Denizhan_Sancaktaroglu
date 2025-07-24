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
    public partial class queryPKList : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceSorguServiceMainPage showInform = new InvoiceSorguServiceMainPage();
            showInform.Show();
            this.Hide();
        }

        public queryPKList()
        {
            InitializeComponent();
        }

        private void btnQueryGetPKList_Click(object sender, EventArgs e)
        {

            var client = new QueryDocumentWSClient();

            using (var scope = new OperationContextScope(client.InnerChannel))
            {

                var username = "admin_008678";
                var password = "FFb8rB(Z";
                //0370368198

                var prop = new HttpRequestMessageProperty();
                prop.Headers.Add("Username", username); //test kullanıcı 
                prop.Headers.Add("Password", password);  //test şifresi 
                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;


                var result = client.GetNewUserPKList();

                try
                {
                    string fileName = result.fileName ?? "output.zip";
                    byte[] byteIcerik = result.fileContent;

                    if (byteIcerik != null && byteIcerik.Length > 0)
                    {
                        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        string fullPath = Path.Combine(desktopPath, fileName);

                        File.WriteAllBytes(fullPath, byteIcerik);

                        MessageBox.Show("Zip dosyası masaüstüne kaydedildi:\n" + fullPath, "Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Dosya içeriği boş.", "Uyarı");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "Hata");
                }

            }
        }
    }
}
