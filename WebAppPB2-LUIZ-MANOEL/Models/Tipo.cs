using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPB2_LUIZ_MANOEL.Models
{
    public enum Tipo
    {
        Aberto = 1,
        [System.ComponentModel.DataAnnotations.Display(Name = "Em andamento")]
        Em_atendimento = 2,
        Fechado = 3

    }
}