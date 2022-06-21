using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAPI.Interfaces
{
    interface IEntity
    {
        public void Heal(float amount);
        public void Hurt(float amount);

        public void UseItem(int index);
        public void UseItem(string name);
    }
}
