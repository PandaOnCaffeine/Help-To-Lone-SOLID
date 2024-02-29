using Help_To_Lone_SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_To_Lone_SOLID.Classes
{
    internal class Wizard : IWizard
    {
        public Wizard() { }

        // With The IWizard Interface this class has to implement these methods
        public void Heal() { }
        public void Die() { }
        public void Fight() { }
        public void Teleport(int x, int y) { }
        public void ThrowFrostNova() { }
        public void ThrowMagicMisile() { }
    }
}
