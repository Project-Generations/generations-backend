using Generations.PokemonManager.Models;

namespace Generations.DA.Entities.Pokemon
{
    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Item ConvertItemsEntity(Items itemsEntity)
        {
            Item item = new()
            {
                Name = itemsEntity.Name,
            };

            return item;
        }
    }
}
