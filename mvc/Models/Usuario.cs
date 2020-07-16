using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Nome")]
        public string nome { get; set; }
        [DisplayName("Senha")]
        public string senha { get; set; }
        
    }
}