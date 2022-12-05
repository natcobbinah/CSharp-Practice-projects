using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    abstract class Spell
    {
        public string Essence
        {
            get; protected set;
        }

        public bool IsStrong
        {
            get; protected set;
        }

        public string Caster
        {
            get; protected set;
        }

        public abstract string Announce();
    }
}
