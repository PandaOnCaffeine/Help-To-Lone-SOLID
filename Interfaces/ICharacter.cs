using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_To_Lone_SOLID.Interfaces
{
    internal interface ICharacter
    {
        void Heal();
        void Die();
        void Fight();
    }
}
