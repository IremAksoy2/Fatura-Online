using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OnlineFatura.Models
{
    public class Email
    {
        public string Ad { get; set; }
        public string email { get; set; }
        public string Mesaj { get; set; }

    }

    public class Message
    {
        public bool IsSuccess { get; set; }

        public string message { get; set; }
    }
}