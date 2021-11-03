using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAquasis.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string Nome { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Matricula { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string posição { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string estado { get; set; }
    }   
}
