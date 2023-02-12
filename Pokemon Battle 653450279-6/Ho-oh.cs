using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_653450279_6
{
    internal class Ho_oh : Pokemon
    {
        public Ho_oh()
        {
            this.name = "Ho-oh";
            Random random = new Random();
            this.HP = random.Next(300, 400);
            this._image = Properties.Resources._19c5ff62fb10c20e9ed08fde7f31225b_removebg_preview;
            this.Attack = random.Next(250, 500);
            this.Defense = random.Next(166, 250);
            this.Speed = random.Next(166, 306);
        }
    }
}
