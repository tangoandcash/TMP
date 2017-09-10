using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NIPQuest.Models
{
    public class LogInfo
    {
        [Key]
        public int LogId { get; set; }
        public string NumberNIP { get; set; }
        public string logDate { get; set; }
        public string Connection { get; set; }
        public string Accept { get; set; }
        public string Accept_Encoding { get; set; }
        public string Accept_Language { get; set; }
        public string Cookie { get; set; }
        public string Host { get; set; }
        public string Referer { get; set; }
        public string User_Agent { get; set; }
    }
}