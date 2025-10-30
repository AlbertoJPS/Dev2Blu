using Microsoft.AspNetCore.Mvc;
using PetShoes.Model.Animais;
using PetShoes.Model.Ninhada;
using System.Collections.Generic;
using System.Linq;

namespace PetShoes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NinhadaController : Controller
    {
        // Lista para "salvar" as ninhadas criadas
        private static List<NinhadaResponseModel> Ninhadas = new List<NinhadaResponseModel>();

        [HttpGet("{maeId}")]
        public IActionResult GetNinhadaPorMae(Guid maeId)
        {
            // Encontra a ninhada cuja mãe tem o ID correspondente
            var ninhada = Ninhadas.FirstOrDefault(n => n.Mae.Id == maeId);
            if (ninhada == null)
            {
                return NotFound("Ninhada não encontrada para a mãe especificada.");
            }
            return Ok(ninhada);
        }

        [HttpPost]
        public IActionResult PostNinhada(NinhadaRequestModel ninhadaRequest)
        {
            var mae = AnimaisController.Animais.FirstOrDefault(a => a.Id == ninhadaRequest.MaeId);
            if (mae == null)
            {
                return NotFound("Animal (mãe) não encontrado.");
            }

            var listaFilhotes = new List<AnimalResponseModel>();

            foreach (var filhoteRequest in ninhadaRequest.Filhotes)
            {
                var novoFilhote = new AnimalResponseModel
                {
                    Id = Guid.NewGuid(),
                    Nome = filhoteRequest.Nome,
                    Cor = filhoteRequest.Cor,
                    IdadeEmMeses = filhoteRequest.IdadeEmMeses,
                    MaeId = ninhadaRequest.MaeId
                };

                listaFilhotes.Add(novoFilhote);
                AnimaisController.Animais.Add(novoFilhote);
            }

            var novaNinhada = new NinhadaResponseModel
            {
                Id = Guid.NewGuid(),
                Mae = mae,
                Filhotes = listaFilhotes
            };

            Ninhadas.Add(novaNinhada);

            return Ok(novaNinhada);
        }
    }
}