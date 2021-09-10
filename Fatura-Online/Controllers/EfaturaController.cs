using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using System.Web.UI.WebControls;
using OnlineFatura.Models;

namespace OnlineFatura.Controllers
{
    public class EfaturaController : Controller
    {
        // GET: Efatura
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kampanyalar()
        {
            return View();
        }
        public ActionResult Blog1()
        {
            return View();
        }
        public ActionResult Blog2()
        {
            return View();
        }
        public ActionResult Blog3()
        {
            return View();
        }
        public ActionResult iletisim()
        {
            return View();
        }

       public ActionResult Ozellikler()
        {
            return View();
        }

        public ActionResult KVKK()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Email model)
        {
            MailMessage mailim = new MailMessage();
            mailim.To.Add("bilgi@fatura-online.com");
            mailim.From = new MailAddress("bilgi@fatura-online.com");
            mailim.Subject = "ONline fatura Sitesinden Gelen Mesaj";
            mailim.Body = "Gönderen Kişi : " + model.Ad + " <br>Mail Adresi : " + model.email + " <br>Mesaj : " + model.Mesaj;
            mailim.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("bilgi@fatura-online.com", "Pewk118_");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mailim);
                TempData["mesaj"] = "Mesajınız iletilmiştir en kısa zamanda size dönüş sağlanacaktır";
            }
            catch (Exception ex)
            {
                TempData["mesaj"] = "Mail gönderilemedi. Hata nedeni :  " + ex.Message;
                throw;
            }

            //var fromAddress = new mailaddress("enterr.pc@gmail.com");
            //var toAddress = new mailaddress("enterr.pc@gmail.com");
            //string subject = "Bize ulaşın sayfasından mesaj var" + model.Baslik;
            //string body = "Sayın yetkili " + model.AdSoyad + "kişisinden gelen mesaj : " + model.Icerik;
            //using (var smtp = new SmtpClient
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587,
            //    EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(fromAddress.Address, "20112020enter")
            //})
            //{
            //    using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
            //    {
            //        smtp.Send(message);
            //    }
            //}



            return View();
        }











        //[HttpPost]
        //public JsonResult Index(Models.Email model)
        //{
        //    MailMessage mailim = new MailMessage();
        //    mailim.To.Add("bilgi@fatura-online.com");
        //    mailim.From = new MailAddress("bilgi@fatura-online.com");
        //    mailim.Subject = "Bize Ulaşın Sayfasından Mesajınız Var. ";
        //    mailim.Body = "Ad soyad:" + model.ad + " <br> Mail adresim:" + " " + model.email + " <br>Telefon Numaram:" + model.telefon + " <br>Konu:" + model.konu + " <br>Mesaj:" + model.mesaj;
        //    mailim.IsBodyHtml = true;



        //    SmtpClient smtp = new SmtpClient();
        //    smtp.Credentials = new NetworkCredential("bilgi@fatura-online.com", "Pewk118_");
        //    smtp.Port = 587;
        //    smtp.Host = "smtp.fatura-online.com";
        //    smtp.EnableSsl = false;


        //    try
        //    {
        //        smtp.Send(mailim);


        //    }
        //    catch (Exception)
        //    {

        //    }

        //    return Json("asdasd");
        //}


    }

}