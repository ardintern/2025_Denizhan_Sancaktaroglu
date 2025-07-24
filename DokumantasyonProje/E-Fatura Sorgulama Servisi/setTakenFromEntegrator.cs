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
    public partial class setTakenFromEntegrator : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            InvoiceSorguServiceMainPage showInform = new InvoiceSorguServiceMainPage();
            showInform.Show();
            this.Hide();
        }

        public setTakenFromEntegrator()
        {
            InitializeComponent();
        }

        private void btnDocUUID_Click(object sender, EventArgs e)
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
                

                List<string> docUUID = new List<string> { } ;
                docUUID.Add(textBoxDocUUID.Text.Trim());

                var request = client.SetTakenFromEntegrator(docUUID.ToArray());

                string mesaj = "Sorgu (kod 0 başarılı / 99 hata): " + request.queryState.ToString() + Environment.NewLine +
                    "Mesaj: " + request.stateExplanation.ToString() + Environment.NewLine +
                    "UUID: " + request.documentsCount.ToString() + Environment.NewLine +
                    "Max record In List: " + request.maxRecordIdinList.ToString();

                MessageBox.Show(mesaj, "Soo Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach(var doc in request.documents)
                {
                    string mesaj2 = "Döküman uuid: " + doc.document_uuid + Environment.NewLine +
                                    "emaik sent: " + doc.emailSent;

                    MessageBox.Show(mesaj2, "Sonuç");
                }
            }
        }
    }
}
