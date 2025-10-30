using Microsoft.AspNetCore.Mvc;
using PetShoes.Model.Adotantes;
using PetShoes.Model.Animais;

namespace PetShoes.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AdotanteController : Controller
    {
        public static List<AdotanteResponseModel> Adotantes = new List<AdotanteResponseModel>() {
            new AdotanteResponseModel()
            {
                Id = Guid.NewGuid(),
                Nome = "Alberto JP Santos",
                Telefone = "(47) 992607019",
                Email = "teste@test.com.br",
                DataNascimento = new DateTime(1994, 8, 23),
                Documento = "12345678912"
            }
        };

        [HttpGet("")]
        public IEnumerable<AdotanteResponseModel> GetAdotantes()
        {
            return Adotantes;
        }

        [HttpPost("")]
        public Guid PostAdotantes(AdotanteRequestModel adotanteRequest)
        {
            var auxGuid = Guid.NewGuid();
            Adotantes.Add(new AdotanteResponseModel()
            {
                Id = auxGuid,
                Nome = adotanteRequest.Nome,
                Telefone = adotanteRequest.Telefone,
                Email = adotanteRequest.Email,
                DataNascimento = adotanteRequest.DataNascimento,
                Documento = adotanteRequest.Documento
            });

            return auxGuid;
        }

        [HttpPut("{id}")]
        public AdotanteResponseModel PutAdotante(Guid id, AdotanteRequestModel adotanteRequest)
        {
            var adotante = Adotantes.First(adotanteBusca => adotanteBusca.Id == id);

            adotante.Nome = adotanteRequest.Nome;
            adotante.Telefone = adotanteRequest.Telefone;
            adotante.Email = adotanteRequest.Email;
            adotante.DataNascimento = adotanteRequest.DataNascimento;
            adotante.Documento = adotanteRequest.Documento;

            return adotante;
        }

        [HttpDelete("{id}")]
        public bool DeleteAdotante(Guid id)
        {
            var adotante = Adotantes.First(adotanteBusca => adotanteBusca.Id == id);
            Adotantes.Remove(adotante);

            return true;
        }
    }
}
