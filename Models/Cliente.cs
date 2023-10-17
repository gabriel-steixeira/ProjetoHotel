using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoHotel.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public Cliente(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}