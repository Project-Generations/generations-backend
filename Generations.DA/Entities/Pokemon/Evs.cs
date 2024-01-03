using Generations.PokemonManager.Models;

namespace Generations.DA.Entities.Pokemon
{
    public class Evs
    {
        public int Id { get; set; }
        public int HpValue { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }
        public int SpecialAttackValue { get; set; }
        public int SpecialDefenseValue { get; set; }
        public int SpeedValue { get; set; }

        public EvSpread ConvertEvsEntity(Evs evsEntity)
        {
            EvSpread evSpread = new()
            {
                HpValue = evsEntity.HpValue,
                AttackValue = evsEntity.AttackValue,
                DefenseValue = evsEntity.DefenseValue,
                SpecialAttackValue = evsEntity.SpecialAttackValue,
                SpecialDefenseValue = evsEntity.SpecialDefenseValue,
                SpeedValue = evsEntity.SpeedValue,
            };

            return evSpread;
        }
    }
}
