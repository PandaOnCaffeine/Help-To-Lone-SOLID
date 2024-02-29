using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_To_Lone_SOLID.Interfaces
{
    internal interface IBarbarian : ICharacter
    {
        void Bash();
        void Cleave();
        void Slash();
    }
}
