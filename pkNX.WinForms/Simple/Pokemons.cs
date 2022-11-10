using System;
using System.Linq;

namespace pkNX.WinForms.Simple
{
    public class PokemonDetail
    {
        public readonly int SpeciesId;
        public readonly string Name;

        public PokemonDetail(int numb, string pokeName)
        {
            SpeciesId = numb;
            Name = pokeName;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    public static class Species
    {
        public static readonly string[] spe = Properties.Resources.species_zh.Split('\n');
        private static readonly int DefaultSpecis = 1;
        private static readonly int BugEgg = 900;

        public static PokemonDetail[] GetSpes()
        {
            var sp = spe.Select((z, i) => new PokemonDetail(i + 1, z)).ToList();
            sp.Add(new PokemonDetail(BugEgg, "Bug蛋"));
            return sp.ToArray();
        }

        public static string GetSpeciesName(int indx)
        {
            if (indx == BugEgg)
            {
                return "Bug蛋";
            }
            else
            {
                return spe[indx < spe.Length ? indx - 1 : DefaultSpecis];
            }
        }
    }
}
