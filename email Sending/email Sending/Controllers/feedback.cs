using email_Sending.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using System.Net;
using System.Net.Mail;

namespace email_Sending.Controllers
{
    public class feedback : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(mail ee)
        {
            int id = ee.Id;
            string cusemail = ee.email;
          string cusmessage = ee.message;
            
            ViewBag.cusemail = cusemail;
            ViewBag.cusmessage = cusmessage;


            /////////////////////// email code ///////////////////
            ///
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("amna12khan26@gmail.com", "ravy hvfw tzoc ckde");

            //////create the email message
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("amna12khan26@gmail.com");
            msg.To.Add(cusemail.ToString());

            msg.Subject = "Feedback";
            msg.Body = cusmessage.ToString();

            client.Send(msg);

            ViewBag.message = "Mail Send Successfully";
            return View();
        }
    }
}
