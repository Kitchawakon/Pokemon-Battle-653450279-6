using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_653450279_6
{
    internal class Nihilego : Pokemon
    {
        public Nihilego()
        {
            this.name = "Nihilego";
            Random random = new Random();
            this.HP = random.Next(328, 422);
            this._image = Properties.Resources._793;
            this.Attack = random.Next(99, 225);
            this.Defense = random.Next(89, 212);
            this.Speed = random.Next(189, 335);
        }
    }
}
