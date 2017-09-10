using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NIPQuest.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string NIP { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
    }
}