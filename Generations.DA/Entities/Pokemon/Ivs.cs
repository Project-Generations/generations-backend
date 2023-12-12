using Generations.PokemonManager.Models;

namespace Generations.DA.Entities.Pokemon
{
    public class Ivs
    {
        public int Id { get; set; }
        public int HpValue { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public int SpecialAttackValue { get; set; }
        public int SpecialDefenseValue { get; set; }
        public int SpeedValue { get; set; }

        public IvSpread ConvertIvsEntity(Ivs ivsEntity)
        {
            IvSpread ivSpread = new()
            {
                HpValue = ivsEntity.HpValue,
                AttackValue = ivsEntity.AttackValue,
                DefenseValue = ivsEntity.DefenseValue,
                SpecialAttackValue = ivsEntity.SpecialAttackValue,
                SpecialDefenseValue = ivsEntity.SpecialDefenseValue,
                SpeedValue = ivsEntity.SpeedValue,
            };

            return ivSpread;
        }
    }
}
