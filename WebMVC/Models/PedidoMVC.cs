using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class PedidoMVC
    {
        [Key]
        public int IdPedido { get; set; }
        [Display(Name ="Nome")]
        public string NomeMedicamento { get; set; }

        [Display(Name = "Quantidade")]
        [Required]
        public string QtdeMedicamento { get; set; }
        public string CodCliente { get; set; }
        public string DataEntrega { get; set; }
    }
}