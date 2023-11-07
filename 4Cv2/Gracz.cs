using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Cv2
{
    public class Gracz : Postac
    {
        private uint mnoznkiAttac;
        private uint ochrona;
        private uint money;
        private uint level;

        public Gracz(uint mnoznkiAttac, uint ochrona, uint money, uint level, string nazwa, uint hp, uint baseAttac) : base(nazwa, hp, baseAttac)
        {
            this.mnoznkiAttac = mnoznkiAttac;
            this.ochrona = ochrona;
            this.money = money;
            this.level = level;
        }
        public new void getDamage(uint damage)
        {
            base.getDamage(damage / ochrona);
        }

        public uint attac()
        {
            return mnoznkiAttac * base.getBaseAttac() * level;
        }

        public string getInfo()
        {
            string ret = $"Nazwa: {base.Nazwa}\nAttac: {attac()}\nMoney: {money}\nLevel: {level}\nOchrona: {ochrona}\nHP: {base.hp}";
            return ret ;

        }

        public void levelUp()
        {
            level += 1;
            mnoznkiAttac += 3;
        }


    }
}
