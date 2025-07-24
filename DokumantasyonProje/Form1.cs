using DokumantasyonProje.fatura_servis;
using DokumantasyonProje.Page_Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DokumantasyonProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {

            
                // Servis istemcisini oluştur
                var client = new fatura_servis.InvoiceWSClient();

                // Kullanıcı adı/şifreyi header'a ekle
                using (new OperationContextScope(client.InnerChannel))
                {
                    OperationContext.Current.OutgoingMessageHeaders.Add(new CustomHeader());

                // txtVKN'den girilen değeri al (textbostan) ve servise gönder
                    var vkn = client.getCustomerGBList();
                    MessageBox.Show(vkn.queryState.ToString());
                    var credit_count = client.getCustomerCreditCount(vkn.users.Select(i => i.vkn_tckn).FirstOrDefault());
                    // Sonucu label'da göster

                    MessageBox.Show("code", credit_count.code.ToString());
                    MessageBox.Show("toplam kredi", credit_count.totalCredit.ToString());
                    MessageBox.Show("kalan kredi", credit_count.remainCredit.ToString());
                    MessageBox.Show("açıklama", credit_count.explanation.ToString());



                }
            }

        }
    }

