using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameAPI.Interfaces;

namespace GameAPI.Structs
{
    struct EquipmentSlots
    {
        public IArmour Head;
        public IArmour Arms;
        public IArmour Torso;
        public IArmour Legs;

        public IWeapon LeftArm;
        public IWeapon RightArm;

        public IEquipable Ring;
        public IEquipable Bracelet;
    }
}
