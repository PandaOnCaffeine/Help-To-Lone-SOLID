using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_To_Lone_SOLID.Interfaces
{
    internal interface IWitch : ICharacter
    {
        void RaiseShield();
        void ShieldGlare();
        void Teleport(int x, int y);
    }
}
