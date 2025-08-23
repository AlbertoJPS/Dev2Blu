using Aula19.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19
{
    public class Carro : IMotorizado, ILambidavel
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public double Temperatura { get; set; }

        public Carro(string marca, string modelo, string cor, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            Temperatura = 0.0; // Inicializa a temperatura
        }

        public void Acelerar()
        {
            Console.WriteLine($"O {Modelo} está acelerando normalmente :)");
        }

        public void Acelerar(int pedal)
        {
            if (pedal <= 5)
            {
                Console.WriteLine($"O {Modelo} está acelerando lentamente");
            }
            else if (pedal <= 100)
            {
                Acelerar();
            }
            else
            {
                Console.WriteLine($"O {Modelo} está acelerando loucamente :P");
            }
        }

        public void Desligar()
        {
            Console.WriteLine($"O {Modelo} está desligando.");
        }

        public void Ligar()
        {
            Console.WriteLine($"O {Modelo} está ligando.");
        }

        public void Lambidavel(List<Carro> carros)
        {
            var carrosOrdenados = carros.Where(c => c.Modelo.Contains("-1")).ToList();

            //var carrosOrdenados = carros.EnsureCapacity(carros.Count);

            //var carrosOrdenados = carros.Average(c => c.Ano) > 2010
            //    ? carros.Where(c => c.Ano > 2010).OrderBy(c => c.Ano).ToList()
            //    : carros.Where(c => c.Ano <= 2010).OrderBy(c => c.Ano).ToList();

            //var carrosOrdenados = carros.OrderBy(c => c.Ano).ToList();

            //Console.WriteLine(carrosOrdenados);

            Console.WriteLine("\nCarros ordenados por ano:");
            foreach (var carro in carrosOrdenados)
            {
                Console.WriteLine($"Marca: {carro.Marca}, Modelo: {carro.Modelo}, Cor: {carro.Cor}, Ano: {carro.Ano}");
            }
        }
    }
}
