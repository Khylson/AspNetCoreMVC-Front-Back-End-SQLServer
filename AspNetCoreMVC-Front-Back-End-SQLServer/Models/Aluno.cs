using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using AspNetCoreMVC_Front_Back_End_SQLServer.Models;


namespace AspNetCoreMVC_Front_Back_End_SQLServer.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        public int Id_aluno { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobreome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string E_mail { get; set; }
        public int Id_esc { get; set; }
        public object[] Id { get; internal set; }
    }
}