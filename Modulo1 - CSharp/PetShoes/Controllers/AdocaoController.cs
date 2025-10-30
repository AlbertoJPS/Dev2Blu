using Microsoft.AspNetCore.Mvc;
using PetShoes.Model.Adocao;

namespace PetShoes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdocaoController : Controller
    {
        private static List<AdocaoResponseModel> Adocoes = new List<AdocaoResponseModel>();

        [HttpGet("")]
        public IEnumerable<AdocaoResponseModel> GetAdocoes()
        {
            return Adocoes;
        }

        [HttpPost("")]
        public IActionResult AdotarAnimal(AdocaoRequestModel adocaoRequest)
        {
            var adotante = AdotanteController.Adotantes.FirstOrDefault(a => a.Id == adocaoRequest.AdotanteId);
            if (adotante == null)
            {
                return NotFound("Adotante não encontrado.");
            }

            var animal = AnimaisController.Animais.FirstOrDefault(a => a.Id == adocaoRequest.AnimalId);
            if (animal == null)
            {
                return NotFound("Animal não encontrado ou já adotado.");
            }

            var adocao = new AdocaoResponseModel()
            {
                Id = Guid.NewGuid(),
                Adotante = adotante,
                Animal = animal,
                DataAdocao = DateTime.UtcNow
            };

            adotante.AnimaisAdotados.Add(animal);
            AnimaisController.Animais.Remove(animal);
            Adocoes.Add(adocao);

            return Ok(adocao);
        }
    }
}