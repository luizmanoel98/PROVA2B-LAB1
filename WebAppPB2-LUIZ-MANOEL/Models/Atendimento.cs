using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPB2_LUIZ_MANOEL.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Campo obrigatorio!!!")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Tipo Tipo { get; set; }




    }
}