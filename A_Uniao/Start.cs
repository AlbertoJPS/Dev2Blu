using Sistema_Central.BancoSimulado;
using Sistema_Central.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sistema_Central
{
    public class Start
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\nSistema Central Iniciado\n\n");

            List<Planeta> listaDePlanetas = new();
            PopularBanco.PopularPlanetas(listaDePlanetas);
            List<Nave> listaDeNaves = new();
            PopularBanco.PopularNaves(listaDeNaves);

        }
    }
}
