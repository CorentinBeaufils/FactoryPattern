using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtomFactory
{
    public interface IAtom
    {
        string Name { get; }
        string Symbole { get; }
        double Mass { get; }

        void DisplayInfo();
    }

    public class Carbon : IAtom
    {
        public string Name => "Carbone";
        public string Symbole => "C";
        public double Mass => 12.01074;

        public void DisplayInfo()
        {
            Console.WriteLine($"Nom: {Name}, Symbole: {Symbole}, Masse: {Mass}");
        }
    }

    public class Hydrogen : IAtom
    {
        public string Name => "Hydrogen";

        public string Symbole => "H";

        public double Mass => 1.00794;

        public void DisplayInfo()
        {
            Console.WriteLine($"Nom: {Name}, Symbole: {Symbole}, Masse: {Mass}");
        }
    }

    public static class AFactory
    {
        public static IAtom CreateAtom(string AtomType)
        {
            switch (AtomType.ToLower())
            {
                case "carbon":
                    return new Carbon();
                case "hydrogen":
                    return new Hydrogen();
                // Ajoutez d'autres types d'atomes au besoin
                default:
                    throw new ArgumentException("Type d'atome non pris en charge");
            }
        }
    }
}
