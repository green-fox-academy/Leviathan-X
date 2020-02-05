using System;
using System.Collections.Generic;
using System.Text;

namespace _06__Pokemon
{
    public enum PokemonType
    {
        Leaf,
        Electric,
        Fire,
        Water
    }
    class Pokemon
    {
        public String Name { get; private set; }
        public PokemonType Type { get; private set; }
        public PokemonType EffectiveAgainst { get; private set; }

        public Pokemon(String name, PokemonType type, PokemonType effectiveAgainst)
        {
            Name = name;
            Type = type;
            EffectiveAgainst = effectiveAgainst;
        }

        public bool IsEffectiveAgainst(Pokemon anotherPokemon)
        {
            return EffectiveAgainst == anotherPokemon.Type;
        }
    }
}
