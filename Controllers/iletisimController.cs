using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using orcun.Models;
using System.Net.Mail;
using System.Net;

namespace orcun.Controllers;

public class iletisimController : Controller
{
    [HttpGet]
    public IActionResult iletisim()
    {
        return View();
    }
    [HttpPost]
    public IActionResult iletisim(string ad, string soyad, string mail, string ulas)
    {

        MailMessage posta = new MailMessage();
        posta.From = new MailAddress("mailAdress", "Orçun ÖZDEMİR");
        posta.To.Add(new MailAddress(mail, "title"));
        posta.Subject = ad + " " + soyad.ToUpper();
        posta.Body = $"Talebiniz adı: {ad}\n {soyad.ToUpper()}\n E-posta adresi: {mail}\n ve Ulaşma nedeni: {ulas.ToUpper()} ile işleme alınmıştır. Teşekkür ederiz.";
        //posta.Body=$"Talebiniz adı: {ad}\n {soyad.ToUpper()}\n E-posta adresi: {mail}\n ve Sorununuz: {sorun.ToUpper()} ile işleme alınmıştır. Teşekkür ederiz!";
        posta.IsBodyHtml = true;
        using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
        {
            try
            {
                smtpClient.Credentials = new System.Net.NetworkCredential("mailAdress", "appPass");
                smtpClient.EnableSsl = true;
                smtpClient.Send(posta);
                return Content("Talebiniz alınmıştır.");
            }

            catch
            {
                return Content("Bir sorun ile karşılaşıldı lütfen bilgileri kontrol edip tekrar deneyiniz.");
            }

        }
    }
}

