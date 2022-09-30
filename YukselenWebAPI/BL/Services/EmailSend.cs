using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using YukselenWebAPI.DAL.ViewModel;

namespace YukselenWebAPI.BL.Services
{
    public class EmailSend
    {
        private readonly IConfiguration _config;

        public EmailSend(IConfiguration config)
        {
            _config = config;
        }

        public void EmailSender(VM_Subdosha vM_Subdosha, object user)
        {
            SmtpClient smtpClient = new SmtpClient()
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = _config.GetValue<string>("EmailConfiguration:Host"),
                Port = _config.GetValue<int>("EmailConfiguration:Port"),
                Credentials = new NetworkCredential(_config.GetValue<string>("EmailConfiguration:Email"), _config.GetValue<string>("EmailConfiguration:Password"))                
            };          

            

            StringBuilder builder = new StringBuilder();
            builder.Append("<html>");
            builder.Append("<head><meta charset=\"utf-8\" /></head>");
            builder.Append("<body>");

            builder.Append("<table>");
            // AD - SOYAD
            builder.Append("<tr>");
            builder.Append("<td><b>AD - SOYAD : </b></td>");
            builder.Append("<td>" + user.GetType().GetProperty("Name").GetValue(user, null).ToString() + "</td>");
            builder.Append("</tr>");
            // EMAIL
            builder.Append("<tr>");
            builder.Append("<td><b>EMAIL : </b></td>");
            builder.Append("<td>" + user.GetType().GetProperty("Email").GetValue(user, null).ToString() + "</td>");
            builder.Append("</tr>");
            // PHONE
            builder.Append("<tr>");
            builder.Append("<td><b>TELEFON : </b></td>");
            builder.Append("<td>" + user.GetType().GetProperty("PhoneNumber").GetValue(user, null).ToString() + "</td>");
            builder.Append("</tr>");
            // BOY
            builder.Append("<tr>");
            builder.Append("<td><b>BOY : </b></td>");
            builder.Append("<td>" + int.Parse(user.GetType().GetProperty("UserLength").GetValue(user, null).ToString()) + " CM</td>");
            builder.Append("</tr>");
            // KİLO
            builder.Append("<tr>");
            builder.Append("<td><b>KİLO : </b></td>");
            builder.Append("<td>" + int.Parse(user.GetType().GetProperty("UserKilo").GetValue(user, null).ToString()) + " KG</td>");
            builder.Append("</tr>");
            // CİNSİYET
            builder.Append("<tr>");
            builder.Append("<td><b>CİNSİYET : </b></td>");
            builder.Append("<td>" + user.GetType().GetProperty("Gender").GetValue(user, null).ToString() + "</td>");
            builder.Append("</tr>");
            // DOĞUM TARİHİ
            builder.Append("<tr>");
            builder.Append("<td><b>DOĞUM TARİHİ : </b></td>");
            builder.Append("<td>" + user.GetType().GetProperty("BirthDate").GetValue(user, null).ToString() + "</td>");
            builder.Append("</tr>");

            builder.Append("<br />");
            builder.Append("<hr />");
            builder.Append("<br />");

            // DOSHA TESTİ START            
            builder.Append("<table style=\"width:100%;margin-bottom:20px;border-style:solid;border-width:1px 1px 1px 0;border-collapse:separate;border-color:#dddddd;\"><thead style=\"border-collapse:separate;\"><tr style=\"background-color: #337469;\"><th>BÜNYE ÖZELLİKLERİ</th>");

            builder.Append("<th>VATA</th>");
            builder.Append("<th>PITTA</th>");
            builder.Append("<th>KAPHA</th>");

            builder.Append("</tr></thead>");
            builder.Append("<tbody>");
            builder.Append("<tr>");
            builder.Append("<td style=\"background-color: #337469;\">YAPI</td>");
            builder.Append("<td style=\"color: #000000;\">İnce, uzun ve zayıf bir yapıya sahibim, eklemlerim belirgin ve ince kaslarım var.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_vata[0] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Kas gelişimim oldukça iyi, ortalama, simetrik, bir yapıya sahibim.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_pıtta[0] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Geniş, toplu ya da tıknaz bir yapıya sahibim. Vücut yapım geniş, iri ya da kalın.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_kapha[0] + "<label>" + "</td>");
            builder.Append("</tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"background-color: #337469;\">AĞIRLIK</td>");
            builder.Append("<td style=\"color: #000000;\">Düşük; Yemek yemeyi unutabiliyorum ve kilo kaybetmeye meyilliyim.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_vata[1] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Orta; Aklıma koyduğumda kolaylıkla kilo alabiliyor veya verebiliyorum.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_pıtta[1] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Ağır; Kolaylıkla kilo alıyorum, ancak kilo vermede zorluk yaşıyorum.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_kapha[1] + "<label>" + "</td>");
            builder.Append("</tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"background-color: #337469;\">GÖZLER</td>");
            builder.Append("<td style=\"color: #000000;\">Gözlerim küçük ve hareketli.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_vata[2] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Keskin bakışlara sahibim.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_pıtta[2] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Gözlerim oldukça büyük ve güzel.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_kapha[2] + "<label>" + "</td>");
            builder.Append("</tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"background-color: #337469;\">CİLT</td>");
            builder.Append("<td style=\"color: #000000;\">Cildim kuru, sert ya da ince.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_vata[3] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Cildim sıcak, pembemsi bir renge sahip ve tahriş olmaya eğimli.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_pıtta[3] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Kalın, nemli ve pürüzsüz bir cildim var.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_kapha[3] + "<label>" + "</td>");
            builder.Append("</tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"background-color: #337469;\">SAÇ</td>");
            builder.Append("<td style=\"color: #000000;\">Saçlarım kuru, kırılgan veya kabarık.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_vata[4] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Saçlarım erken seyrekleşmeye ya da beyazlamaya meyilli ve ince telli.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_pıtta[4] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Gür, kalın ve yağlı saçlarım var.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_kapha[4] + "<label>" + "</td>");
            builder.Append("</tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"background-color: #337469;\">EKLEMLER</td>");
            builder.Append("<td style=\"color: #000000;\">Eklemlerim ince, belirgin ve çıtlamaya meyilli.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_vata[5] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Gevşek ve esnek eklemlerim var.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_pıtta[5] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Eklemlerim büyük, kaslı ve kuvvetli.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_kapha[5] + "<label>" + "</td>");
            builder.Append("</tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"background-color: #337469;\">UYKU DÜZENİ</td>");
            builder.Append("<td style=\"color: #000000;\">Uykum oldukça hafif, kolayca uyanıyorum.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_vata[6] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Kısmen deliksiz uyuduğum söylenebilir, genellikle kendimi dinlenmiş hissetmek için sekiz saatten daha az uyumam yetiyor.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_pıtta[6] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Derin ve uzun uyuyorum. Sabahları uyanmam zaman alıyor.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_kapha[6] + "<label>" + "</td>");
            builder.Append("</tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"background-color: #337469;\">VÜCUT SICAKLIĞI</td>");
            builder.Append("<td style=\"color: #000000;\">Genellikle ellerim ve ayaklarım soğuk oluyor ve sıcak ortamları tercih ediyorum.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_vata[7] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Mevsimden bağımsız olarak genellikle kendimi sıcak hissediyorum ve daha soğuk ortamları tercih ediyorum.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_pıtta[7] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Muhtelif ısı derecelerine kolaylıkla uyum sağlayabiliyorum ancak, soğuk ve nemli havayı sevmiyorum.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_kapha[7] + "<label>" + "</td>");
            builder.Append("</tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"background-color: #337469;\">MİZAÇ</td>");
            builder.Append("<td style=\"color: #000000;\">Yaratılıştan oldukça enerjik ve heyecan doluyum. Değişimi seviyorum.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_vata[8] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Amaca yönelik hareket ederim ve etkileyici bir mizacım var. İnsanları ikna etmeyi seviyorum.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_pıtta[8] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Geçinilmesi kolay bir kişiyim ve insanları ya da olayları olduğu gibi kabul ederim. Destek olmayı seviyorum.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_kapha[8] + "<label>" + "</td>");
            builder.Append("</tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"background-color: #337469;\">STRES ALTINDA</td>");
            builder.Append("<td style=\"color: #000000;\">Endişe ya da kaygı duyarım.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_vata[9] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">Asabi ve/veya saldırgan olurum.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_pıtta[9] + "<label>" + "</td>");
            builder.Append("<td style=\"color: #000000;\">İçime kapanırım ve/veya kendimi dış dünyadan soyutlarım.<br /><br />" + "<label style=\"font-weight:bold;\">" + vM_Subdosha.f1_kapha[9] + "<label>" + "</td>");
            builder.Append("</tr>");

            builder.Append("</tbody>");
            builder.Append("</table>");
            // DOSHA TESTİ END
            builder.Append("<br />");
            builder.Append("<br />");

            builder.Append("<table style=\"width:100%;margin-bottom:20px;border-style:solid;border-width:1px 1px 1px 0;border-collapse:separate;border-color:#dddddd;\">");
            builder.Append("<tr><td colspan=\"3\" style=\"color:red\"><b>VATA - ZİHİN </b></td></tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">1</td>");
            builder.Append("<td style=\"widht:65%\"><b>Zihin açıklığı ile ilgili sorun yaşıyorum ya da dikkatimi toplamakta güçlük çekiyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_zihin_1) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">2</td>");
            builder.Append("<td style=\"widht:65%\"><b>Kendimi sorumluluklarım altında ezilmiş, endişeli ya da kaygılı hissediyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_zihin_2) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">3</td>");
            builder.Append("<td style=\"widht:65%\"><b>Hayatım çalkantılı ve kargaşa içerisinde geçiyor.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_zihin_3) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">4</td>");
            builder.Append("<td style=\"widht:65%\"><b>Sürekli yeni projelere başlıyorum ancak bu işleri tamamlamakta zorluk çekiyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_zihin_4) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">5</td>");
            builder.Append("<td style=\"widht:65%\"><b>Uyumakta ya da kolay uyanmakta zorluk çekiyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_zihin_5) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">6</td>");
            builder.Append("<td style=\"widht:65%\"><b>Karar vermekte güçlük çekiyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_zihin_6) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">7</td>");
            builder.Append("<td style=\"widht:65%\"><b>Verdiğim sözleri tutmakta sorun yaşıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_zihin_7) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">8</td>");
            builder.Append("<td style=\"widht:65%\"><b>Sürekli olarak hareket etmediğimde kendimi huzursuz hissediyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_zihin_8) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">9</td>");
            builder.Append("<td style=\"widht:65%\"><b>Fevri ya da tutarsız hareket ediyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_zihin_9) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">10</td>");
            builder.Append("<td style=\"widht:65%\"><b>Normalden daha unutkanım.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_zihin_10) + "</td>");
            builder.Append("<tr>");

            builder.Append("</table>");

            // VATA BEDEN
            builder.Append("<table style=\"width:100%;margin-bottom:20px;border-style:solid;border-width:1px 1px 1px 0;border-collapse:separate;border-color:#dddddd;\">");
            builder.Append("<tr><td colspan=\"3\" style=\"color:red\"><b>VATA - BEDEN </b></td></tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">1</td>");
            builder.Append("<td style=\"widht:65%\"><b>Boğaz kuruluğu yaşıyorum, sıklıkla boğazımı temizleme ihtiyacı duyuyorum veya kuru öksürüğüm var.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_beden_1) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">2</td>");
            builder.Append("<td style=\"widht:65%\"><b>Yemekler sonrasında gaz, kramp ya da şişlik yaşıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_beden_2) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">3</td>");
            builder.Append("<td style=\"widht:65%\"><b>İştahım tutarsız.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_beden_3) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">4</td>");
            builder.Append("<td style=\"widht:65%\"><b>Kronik ağrı çekiyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_beden_4) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">5</td>");
            builder.Append("<td style=\"widht:65%\"><b>Kuru bir cildim var veya cildim pul pul dökülüyor.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_beden_5) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">6</td>");
            builder.Append("<td style=\"widht:65%\"><b>Dışkım kuru, veya sert ya da düzensiz tuvalete çıkıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_beden_6) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">7</td>");
            builder.Append("<td style=\"widht:65%\"><b>Erkekler için; Cinsel olarak tahrik olmakta, ereksiyonumu korumakta ya da orgazm yaşamakta sorun yaşıyorum.<br />Kadınlar için; Adet dönemim zorlu geçiyor, adetlerim düzensiz ya da vajinal kuruluk yaşıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_beden_7) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">8</td>");
            builder.Append("<td style=\"widht:65%\"><b>Hızlı bir şekilde kalktığımda başım dönüyor.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_beden_8) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">9</td>");
            builder.Append("<td style=\"widht:65%\"><b>Ellerim ve ayaklarım rahatsız edici seviyede soğuk.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_beden_9) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">10</td>");
            builder.Append("<td style=\"widht:65%\"><b>Kas çekilmesi, kramp ya da kalp çarpıntısı sorunu yaşıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f2_vata_beden_10) + "</td>");
            builder.Append("<tr>");

            builder.Append("</table>");
           

            // PITTA - ZİHİN
            builder.Append("<table style=\"width:100%;margin-bottom:20px;border-style:solid;border-width:1px 1px 1px 0;border-collapse:separate;border-color:#dddddd;\">");
            builder.Append("<tr><td colspan=\"3\" style=\"color:red\"><b>PITTA - ZİHİN </b></td></tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">1</td>");
            builder.Append("<td style=\"widht:65%\"><b>Hayatımdan memnun değilim.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_zihin_1) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">2</td>");
            builder.Append("<td style=\"widht:65%\"><b>Başka kişilere yargılayıcı ve eleştirel bir şekilde yaklaşıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_zihin_2) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">3</td>");
            builder.Append("<td style=\"widht:65%\"><b>Başka kişileri kıskanıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_zihin_3) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">4</td>");
            builder.Append("<td style=\"widht:65%\"><b>Başkalarına kolaylıkla öfkeleniyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_zihin_4) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">5</td>");
            builder.Append("<td style=\"widht:65%\"><b>Kendimi asabi ya da tahammülsüz hissediyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_zihin_5) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">6</td>");
            builder.Append("<td style=\"widht:65%\"><b>Bir projeye başladıktan sonra, bu projeyi takıntı haline getiriyorum, durmakta zorlanıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_zihin_6) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">7</td>");
            builder.Append("<td style=\"widht:65%\"><b>Dik kafalı hareket ediyorum, bana sorulmadığı halde fikrimi serbestçe beyan ediyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_zihin_7) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">8</td>");
            builder.Append("<td style=\"widht:65%\"><b>Başka kişilerin beni hüsrana uğrattığını düşünüyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_zihin_8) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">9</td>");
            builder.Append("<td style=\"widht:65%\"><b>Başka kişilere karşı üstün gelme ihtiyacı duyuyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_zihin_9) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">10</td>");
            builder.Append("<td style=\"widht:65%\"><b>Geçmiş olaylar üzerinde çok fazla düşünüyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_zihin_10) + "</td>");
            builder.Append("<tr>");

            builder.Append("</table>");

            // PITTA BEDEN
            builder.Append("<table style=\"width:100%;margin-bottom:20px;border-style:solid;border-width:1px 1px 1px 0;border-collapse:separate;border-color:#dddddd;\">");
            builder.Append("<tr><td colspan=\"3\" style=\"color:red\"><b>PITTA - BEDEN </b></td></tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">1</td>");
            builder.Append("<td style=\"widht:65%\"><b>Kendimi fazla sıcak hissediyorum ya da ani ateş basmaları yaşıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_beden_1) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">2</td>");
            builder.Append("<td style=\"widht:65%\"><b>Işığa karşı hassasiyet veya görüşte bozukluk ile birlikte baş ağrısı çekiyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_beden_2) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">3</td>");
            builder.Append("<td style=\"widht:65%\"><b>Gözlerim kaşınıyor, tahriş olmuş şekilde, kızarıyor ya da sulanıyor.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_beden_3) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">4</td>");
            builder.Append("<td style=\"widht:65%\"><b>Günde iki defadan daha fazla tuvalete çıkıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_beden_4) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">5</td>");
            builder.Append("<td style=\"widht:65%\"><b>İştahım fazla açık.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_beden_5) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">6</td>");
            builder.Append("<td style=\"widht:65%\"><b>Reflü/mide ekşimesi sıkıntısı yaşıyorum veya ülserim var.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_beden_6) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">7</td>");
            builder.Append("<td style=\"widht:65%\"><b>Fizyolojimde toksin birikimi (yiyeceklerden, havadan, sudan, alkolden, sigaradan ya da uyuşturucudan) olduğunu hissediyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_beden_7) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">8</td>");
            builder.Append("<td style=\"widht:65%\"><b>Bana bir çeşit karaciğer hastalığı tanısı konuldu.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_beden_8) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">9</td>");
            builder.Append("<td style=\"widht:65%\"><b>Bana yüksek tansiyon ya da koroner kalp hastalığı tanısı konuldu.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_beden_9) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">10</td>");
            builder.Append("<td style=\"widht:65%\"><b>Cildim kaşınıyor, tahriş olmuş halde, dökülmeye meyilli veya bana inflamatuvar bir deri hastalığı teşhisi konuldu.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f3_pıtta_beden_10) + "</td>");
            builder.Append("<tr>");

            builder.Append("</table>");

            // KAPHA - ZİHİN
            builder.Append("<table style=\"width:100%;margin-bottom:20px;border-style:solid;border-width:1px 1px 1px 0;border-collapse:separate;border-color:#dddddd;\">");
            builder.Append("<tr><td colspan=\"3\" style=\"color:red\"><b>KAPHA - ZİHİN </b></td></tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">1</td>");
            builder.Append("<td style=\"widht:65%\"><b>Anlaşmazlıklarla baş etmek için içime kapanıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_zihin_1) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">2</td>");
            builder.Append("<td style=\"widht:65%\"><b>Hayatımda sürekli bir dağınıklık hali var.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_zihin_2) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">3</td>");
            builder.Append("<td style=\"widht:65%\"><b>Rutinimi değiştirmeye karşı direnç gösteriyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_zihin_3) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">4</td>");
            builder.Append("<td style=\"widht:65%\"><b>Beni tatmin etmiyor olsa da bir ilişki, iş ya da durumdan ayrılmakta zorluk çekiyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_zihin_4) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">5</td>");
            builder.Append("<td style=\"widht:65%\"><b>Kısa süreli hafızam beni endişelendiriyor.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_zihin_5) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">6</td>");
            builder.Append("<td style=\"widht:65%\"><b>Fiziksel olarak daha aktif olmak istiyorum,ancak düzenli egzersiz yapmakta zorluk yaşıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_zihin_6) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">7</td>");
            builder.Append("<td style=\"widht:65%\"><b>Besinsel ihtiyaçtan daha çok, duygusal nedenlerden dolayı yemek yiyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_zihin_7) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">8</td>");
            builder.Append("<td style=\"widht:65%\"><b>Sabahları güne başlamakta zorluk çekiyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_zihin_8) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">9</td>");
            builder.Append("<td style=\"widht:65%\"><b>Zorluklarla baş etme konusunda becerilerim konusunda kendime güvenmiyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_zihin_9) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">10</td>");
            builder.Append("<td style=\"widht:65%\"><b>Geçmişi geride bırakmakta zorlanıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_zihin_10) + "</td>");
            builder.Append("<tr>");

            builder.Append("</table>");

            // KAPHA BEDEN
            builder.Append("<table style=\"width:100%;margin-bottom:20px;border-style:solid;border-width:1px 1px 1px 0;border-collapse:separate;border-color:#dddddd;\">");
            builder.Append("<tr><td colspan=\"3\" style=\"color:red\"><b>KAPHA - BEDEN </b></td></tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">1</td>");
            builder.Append("<td style=\"widht:65%\"><b>Ayak bileklerimde şişme eğilimi var.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_beden_1) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">2</td>");
            builder.Append("<td style=\"widht:65%\"><b>Sabahları ağırkanlı, halsiz ve uyuşuk oluyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_beden_2) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">3</td>");
            builder.Append("<td style=\"widht:65%\"><b>Çok fazla balgam ya da mukus üretiyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_beden_3) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">4</td>");
            builder.Append("<td style=\"widht:65%\"><b>Yemek yedikten sonra midem bulanıyor ya da uzun bir süre kendimi oldukça tok hissediyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_beden_4) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">5</td>");
            builder.Append("<td style=\"widht:65%\"><b>İdeal kilomun 5 kilodan daha fazla üzerindeyim.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_beden_5) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">6</td>");
            builder.Append("<td style=\"widht:65%\"><b>Kolesterolüm yüksek ya da aterosklerotik kalp hastalığım var.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_beden_6) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">7</td>");
            builder.Append("<td style=\"widht:65%\"><b>Astım ya da hırıltı nöbetleri yaşıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_beden_7) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">8</td>");
            builder.Append("<td style=\"widht:65%\"><b>Yemeklerden sonra kolaylıkla uyuyakalıyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_beden_8) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">9</td>");
            builder.Append("<td style=\"widht:65%\"><b>Kan şekerimin yükselme eğilimi var.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_beden_9) + "</td>");
            builder.Append("<tr>");

            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">10</td>");
            builder.Append("<td style=\"widht:65%\"><b>Sıklıkla sinüslerim tıkanıyor ya da solunum yolu enfeksiyonları geçiriyorum.<b></td>");
            builder.Append("<td style=\"widht:25%\">" + ValueReturn(vM_Subdosha.f4_kapha_beden_10) + "</td>");
            builder.Append("<tr>");

            builder.Append("</table>");

            // KİLO DURUMU
            builder.Append("<table  style=\"width:100%;margin-bottom:20px;border-style:solid;border-width:1px 1px 1px 0;border-collapse:separate;border-color:#dddddd;\">");
            builder.Append("<tr><td colspan=\"3\" style=\"color:red\"><b>KİLO</b></td></tr>");
            builder.Append("<br />");
            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">" + 1 + " - " + "</td>");
            builder.Append("<td style=\"widht:65%\"><b>ŞU ANDA<b></td>");
            builder.Append("<td style=\"widht:25%\">" + vM_Subdosha.f5_kilo_1 + "</td>");
            builder.Append("<tr>");
            builder.Append("</table>");

            // STRES
            builder.Append("<table  style=\"width:100%;margin-bottom:20px;border-style:solid;border-width:1px 1px 1px 0;border-collapse:separate;border-color:#dddddd;\">");
            builder.Append("<tr><td colspan=\"3\" style=\"color:red\"><b>STRES</b></td></tr>");
            builder.Append("<br />");
            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">" + 1 + " - " + "</td>");
            builder.Append("<td style=\"widht:65%\"><b>STRES ALTINDA OLDUĞUMDA<b></td>");
            builder.Append("<td style=\"widht:25%\">" + vM_Subdosha.f5_kilo_2 + "</td>");
            builder.Append("<tr>");
            builder.Append("</table>");

            // HEDEF
            builder.Append("<table  style=\"width:100%;margin-bottom:20px;border-style:solid;border-width:1px 1px 1px 0;border-collapse:separate;border-color:#dddddd;\">");
            builder.Append("<tr><td colspan=\"3\" style=\"color:red\"><b>HEDEF</b></td></tr>");
            builder.Append("<br />");
            builder.Append("<tr>");
            builder.Append("<td style=\"widht:10%\">" + 1 + " - " + "</td>");
            builder.Append("<td style=\"widht:65%\"><b>ŞUNU YAPMAK BENİM İÇİN KOLAY<b></td>");
            builder.Append("<td style=\"widht:25%\">" + vM_Subdosha.f5_kilo_3 + "</td>");
            builder.Append("<tr>");
            builder.Append("</table>");


            builder.Append("</body>");
            builder.Append("</html>");


            MailMessage message = new MailMessage();
            message.From = new MailAddress(_config.GetValue<string>("EmailConfiguration:Email"));
            message.To.Add(user.GetType().GetProperty("Email").GetValue(user, null).ToString());
            message.Subject = "YÜKSELEN ÇAĞ - AYURVEDİK ANKET";
            message.IsBodyHtml = true;
            message.Body = builder.ToString();

            
            smtpClient.Send(message);



            //smtpClient.Send(_config.GetValue<string>("EmailConfiguration:Email"), user.GetType().GetProperty("Email").GetValue(user, null).ToString(), "YÜKSELEN ÇAĞ - AYURVEDİK ANKET", msg.ToString());
        }

        public string ValueReturn(int value)
        {
            switch (value)
            {
                case 1:
                    return "Asla";
                case 3:
                    return "Bazen";
                case 5:
                    return "Sıklıkla";
                default:
                    return "Boş";
            }
        }

    }
}
