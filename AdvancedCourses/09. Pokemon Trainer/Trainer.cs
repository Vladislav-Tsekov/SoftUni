using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> PokemonsCollection { get; set; }
        public Trainer(string name, List<Pokemon> pokeCollection)
        {
            Name = name;
            PokemonsCollection = pokeCollection;
        }
        public Trainer(string name)
        {
            Name = name;
        }
    }
}
