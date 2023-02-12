using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_653450279_6
{
    internal class Groudon : Pokemon
    {
        public Groudon()
        {
            this.name = "Groudon";
            Random random = new Random();
            this.HP = random.Next(310, 404);
            this._image = Properties.Resources._383;
            this.Attack = random.Next(274, 438);
            this.Defense = random.Next(256, 416);
            this.Speed = random.Next(166, 306);
        }
    }
}
