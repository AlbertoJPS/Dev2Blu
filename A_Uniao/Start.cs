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
        public static bool _JaPopulado = false;

        // usar listas staticas
        //public static List<Planeta> _ListaDePlanetas = new List<Planeta>();
        //public static List<Nave> _ListaDeNaves = new List<Nave>();
        //public static List<Missao> _ListaMissoes = new List<Missao>();
        //public static List<Astronauta> _ListaDeAstronautas = new List<Astronauta>();

        public static void Main(string[] args)
        {
            Console.WriteLine("\n\nSistema Central Iniciado\n\n");
            Console.ReadLine();
            List<Planeta> listaDePlanetas = new();
            List<Nave> listaDeNaves = new();
            List<Missao> listaMissoes = new();
            List<Astronauta> listaDeAstronautas = new();





            PopularBanco.PopularTudo(listaDePlanetas, listaDeNaves, listaMissoes, listaDeAstronautas, _JaPopulado);


            Menus.ExibirMenuInicial(listaDePlanetas, listaDeNaves, listaMissoes, listaDeAstronautas);
        }
       
    }
}
