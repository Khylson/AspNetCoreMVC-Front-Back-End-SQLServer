using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMVC_Front_Back_End_SQLServer.Models;

namespace AspNetCoreMVC_Front_Back_End_SQLServer.Models
{
    [Table("Escola")]
    public class Escola
    {
        [Key]
        public int Id_esc { get; set; }
        [Required]
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
    }
}