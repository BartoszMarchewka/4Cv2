using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Cv2
{
    public class Postac
    {
        public string Nazwa;
        protected uint hp;
        private uint baseAttac;

        public Postac()
        {
            Nazwa = "Brak nazwy";
            hp = 100;
            baseAttac = 10;
        }

        public Postac(string nazwa, uint hp, uint baseAttac)
        {
            Nazwa = nazwa;
            this.hp = hp;
            this.baseAttac = baseAttac;
        }

        protected void getDamage(uint damage)
        {
            if (hp < damage)
                hp = 0;
            else
                hp -= damage;
        }

        protected uint getBaseAttac()
        {
            return baseAttac;
        }
    }
}
