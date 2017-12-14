using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPB2_LUIZ_MANOEL.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public enum Tipo
        {
            1 = Aberto,


        }


    }
}