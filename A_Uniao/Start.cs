using Sistema_Central.BancoSimulado;
using Sistema_Central.Entities;
using Sistema_Central.Utilitários;
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
        public static bool jaPopulado = false;
        public static void Main(string[] args)
        {
            Console.WriteLine("\n\nSistema Central Iniciado\n\n");
            Console.ReadLine();
            List<Planeta> listaDePlanetas = new();
            List<Nave> listaDeNaves = new();
            List<Missao> listaMissoes = new();
            List<Astronauta> listaDeAstronautas = new();

            PopularBanco.PopularTudo(listaDePlanetas, listaDeNaves, listaMissoes, listaDeAstronautas, jaPopulado);


            Menus.ExibirMenuInicial(listaDePlanetas, listaDeNaves, listaMissoes, listaDeAstronautas);
        }
       
    }
}
