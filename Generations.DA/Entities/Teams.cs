using Generations.DA.Entities.Pokemon;
using System.ComponentModel.DataAnnotations;

namespace Generations.DA.Entities
{
    public class Teams
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Format { get; set; } = string.Empty;
        public ICollection<CreatedPokemons> Team { get; set; } = new List<CreatedPokemons>();
    }
}
