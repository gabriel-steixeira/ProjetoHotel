using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ProjetoHotel.Models
{
    public class Reserva
    {
        public List<Cliente> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        //public Reserva(List<Cliente> hospedes, Suite suite, int diasReservados)
        //{
        //    Hospedes = hospedes;
        //    Suite = suite;
        //    DiasReservados = diasReservados;
        //}

        public void CadastrarHospedes (List<Cliente> hospedes)
        {
            Hospedes = hospedes;
        }

        public void CadastrarSuite (Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes () 
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria () 
        { 
            return DiasReservados * Suite.ValorDiaria; 
        }
    }
}