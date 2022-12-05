using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Storm : Spell
    {
        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }

        public override string Announce()
        {
            return $"{Caster} cast a {(IsStrong ? "strong" : "weak")} {Essence} storm!";
        }
    }

}
