using System;
using System.Linq;
using System.Collections.Generic;

using GameAPI.Interfaces;
using System.Data;
using GameAPI.Structs;
using static GameAPI.Interfaces.IEntity;

namespace GameAPI
{
    public class Entity : IEntity
    {
        string name;

        int level;
        float xp;

        float hp;
        float maxHp;

        int ap;
        int maxAp;
        int apRechargeRate;

        //float speed;

        List<IItem> items;
        List<IWeapon> Weapons => (List<IWeapon>)items.Where(item => item is IWeapon);

        EquipmentSlots slots;

        public Entity()
        {

        }

        public void Heal(float amount)
        {
            hp += amount;

            if (hp > maxHp)
                hp = maxHp;
        }

        public void Hurt(float amount)
        {
            hp -= amount;

            /// Catch exception in game loop
            /// Share exp between everyone in fight
            if (hp <= 0)
                throw new Exception("Is ded");
        }

        public void UseItem(int index)
        {
            Use(items[index]);
        }
        public void UseItem(string name)
        {
            Use(items.Find(i => i.Name == name));
        }
        private void Use(IItem item)
        {
            switch (item)
            {
                case IWeapon:
                    //Equip
                    break;
                case IArmour:
                    //Equip
                    break;
                case IConsumable:
                    //Consume
                    break;
                case IEquipable:
                    //Equip?
                    break;
                case IItem:
                    //Read tooltip?
                    break;
            }
        }
    }
}
