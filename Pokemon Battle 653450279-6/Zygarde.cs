using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_653450279_6
{
    internal class Zygarde : Pokemon
    {
        public Zygarde()
        {
            this.name = "Zygarde";
            Random random = new Random();
            this.HP = random.Next(326, 420);
            this._image = Properties.Resources.Zygarde_removebg_preview;
            this.Attack = random.Next(184, 328);
            this.Defense = random.Next(222, 375);
            this.Speed = random.Next(175, 317);
        }
    }
}
