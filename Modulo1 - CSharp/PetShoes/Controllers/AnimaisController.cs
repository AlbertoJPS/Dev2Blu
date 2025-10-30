using Microsoft.AspNetCore.Mvc;
using PetShoes.Model.Animais;

namespace PetShoes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimaisController : Controller
    {
        public static List<AnimalResponseModel> Animais = new List<AnimalResponseModel>() {
            new AnimalResponseModel()
            {
                Id = Guid.NewGuid(),
                Nome = "Prateado",
                Cor = "Cinza",
                IdadeEmMeses = 6,
            }
        };

        [HttpGet("")]
        public IEnumerable<AnimalResponseModel> GetAnimais()
        {
            return Animais;
        }

        [HttpPost("")]
        public Guid PostAnimais(AnimalRequestModel animalRequest)
        {
            var auxGuid = Guid.NewGuid();
            Animais.Add(new AnimalResponseModel()
            {
                Id = auxGuid,
                Nome = animalRequest.Nome,
                Cor = animalRequest.Cor,
                IdadeEmMeses = animalRequest.IdadeEmMeses
            });

            return auxGuid;
        }

        [HttpPut("{id}")]
        public AnimalResponseModel PutAnimal(Guid id, AnimalRequestModel animalRequest)
        {
            // Substituivel por foreach
            var animal = Animais.First(animalBusca => animalBusca.Id == id);

            animal.Nome = animalRequest.Nome;
            animal.Cor = animalRequest.Cor;
            animal.IdadeEmMeses = animalRequest.IdadeEmMeses;

            return animal;
        }

        [HttpDelete("{id}")]
        public bool DeleteAnimal(Guid id)
        {
            var animal = Animais.First(animalBusca => animalBusca.Id == id);
            Animais.Remove(animal);

            return true;
        }
    }
}