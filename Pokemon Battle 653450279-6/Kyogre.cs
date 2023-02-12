using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_653450279_6
{
    internal class Kyogre : Pokemon
    {
        public Kyogre()
        {
            this.name = "Kyogre";
            Random random = new Random();
            this.HP = random.Next(310, 414);
            this._image = Properties.Resources.Kyogre;
            this.Attack = random.Next(184, 328);
            this.Defense = random.Next(166, 306);
            this.Speed = random.Next(166, 306);
        }
    }
}
