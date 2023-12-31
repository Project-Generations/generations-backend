﻿using Generations.DA.Entities;
using Generations.DA.Entities.Pokemon;

namespace Generations.DA
{
    public class DbSeeder
    {
        public static void Initialize(DataContext context)
        {
            if (context.CreatedPokemons.Any())
            {
                return;
            }

            Evs testEvs = new()
            {
                HpValue = 6,
                AttackValue = 0,
                DefenseValue = 0,
                SpecialAttackValue = 252,
                SpecialDefenseValue = 0,
                SpeedValue = 252
            };
            Evs bulkEvs = new()
            {
                HpValue = 252,
                AttackValue = 0,
                DefenseValue = 252,
                SpecialAttackValue = 0,
                SpecialDefenseValue = 0,
                SpeedValue = 6
            };
            Ivs testIvs = new()
            {
                HpValue = 31,
                AttackValue = 0,
                DefenseValue = 31,
                SpecialAttackValue = 31,
                SpecialDefenseValue = 31,
                SpeedValue = 31
            };
            Items testItem = new()
            {
                Name = "Choice Specs",
            };
            CreatedPokemons articuno = new()
            {
                Name = "Articuno",
                Level = 100,
                Happiness = 255,
                Ability = "Pressure",
                IsShiny = false,
                Gender = "Genderless",
                Evs = testEvs,
                Ivs = testIvs,
                Item = testItem
            };
            CreatedPokemons zapdos = new()
            {
                Name = "Zapdos",
                Level = 100,
                Happiness = 255,
                Ability = "Pressure",
                IsShiny = false,
                Gender = "Genderless",
                Evs = testEvs,
                Ivs = testIvs,
                Item = testItem
            };
            CreatedPokemons moltres = new()
            {
                Name = "Moltres",
                Level = 100,
                Happiness = 255,
                Ability = "Pressure",
                IsShiny = true,
                Gender = "Genderless",
                Evs = testEvs,
                Ivs = testIvs,
                Item = testItem
            };

            CreatedPokemons zapdosBulky = new()
            {
                Name = "Zapdos",
                Level = 100,
                Happiness = 255,
                Ability = "Pressure",
                IsShiny = true,
                Gender = "Genderless",
                Evs = bulkEvs,
                Ivs = testIvs,
            };



            var teams = new Teams[]
        {
                new Teams
                {
                    Name = "Kantonian birds",
                    Format = "OU",
                    Team = { articuno, zapdos, moltres}
                },

                new Teams
                {
                    Name = "Zapdos bulky",
                    Format = "OU",
                    Team = { zapdosBulky }
                }
        };

            foreach (Teams team in teams)
            {
                context.Teams.Add(team);
            }
            context.SaveChanges();
        }
    }
}
