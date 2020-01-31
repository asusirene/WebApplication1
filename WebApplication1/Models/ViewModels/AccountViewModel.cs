using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class AccountViewModel
    {
        public string Category { get; set; }
        public DateTime LogDate { get; set; }
        public int Money { get; set; }
    }
}