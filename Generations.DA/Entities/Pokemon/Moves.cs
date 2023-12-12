using Generations.PokemonManager.Models;

namespace Generations.DA.Entities.Pokemon
{
    public class Moves
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;

        public Move ConvertMovesEntity(Moves movesEntity)
        {
            Move move = new()
            {
                Name = movesEntity.Name,
                Category = movesEntity.Category,
            };

            return move;
        }
    }
}
