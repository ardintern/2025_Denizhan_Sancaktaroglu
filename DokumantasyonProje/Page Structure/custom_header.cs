using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DokumantasyonProje.Page_Structure
{
    public class CustomHeader : MessageHeader
    {
        public override string Name => "Security";
        public override string Namespace => "http://schemas.xmlsoap.org/ws/2002/12/secext";
        
        protected override void OnWriteHeaderContents(XmlDictionaryWriter writer, MessageVersion messageVersion)
        {
            var servis = new fatura_servis.InvoiceWSClient();


            using (var scope = new OperationContextScope(servis.InnerChannel))
                {
                var username = "admin_008678";
                var password = "FFb8rB(Z";

                var prop = new HttpRequestMessageProperty();
                prop.Headers.Add("Username", username); //test kullanıcı 
                prop.Headers.Add("Password", password);  //test şifresi 

                OperationContext context = OperationContext.Current;
                context.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = prop;
                }


        }
    }
}