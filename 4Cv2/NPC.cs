using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Cv2
{
    public class NPC : Postac
    {
        private uint mnoznkiAttac;
        private uint ochrona;

        public NPC(uint mnoznkiAttac, uint ochrona)
        {
            this.mnoznkiAttac = mnoznkiAttac;
            this.ochrona = ochrona;
        }

        public NPC(string nazwa, uint hp, uint baseAttac, uint mnoznkiAttac, uint ochrona) : base(nazwa, hp, baseAttac)
        {
            this.mnoznkiAttac = mnoznkiAttac;
            this.ochrona = ochrona;
        }

        public new void getDamage(uint damage)
        {
            base.getDamage(damage/ochrona);
        }

        public uint attac()
        {
            return mnoznkiAttac * base.getBaseAttac();
        }

        public string chat()
        {
            return "Witaj!";
        }

        public uint getHp()
        {
            return base.hp;
        }

    }
}
