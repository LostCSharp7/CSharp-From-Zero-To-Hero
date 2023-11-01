using BootCamp.Chapter.Items;
using System;
using System.Linq;
using System.Net.Sockets;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Extra assignment. 
    /// </summary>
    public class Equipment
    {
        private Weapon _weapon;
        private Item[] Equipments;
        public Equipment()
        {
            Equipments = Array.Empty<Item>();
        }
        
        public void AddEquipments(Item item)
        {
            if (Equipments.Length >= 1)
            {
                Array.Resize(ref Equipments, Equipments.Length + 1);
                Equipments[^1] = item;
            }
            else
            {
                Equipments = new Item[1] { item };
            }
        }
        public void SetWeapon(Weapon weapon)
        {
            if (weapon != null)
            {
                _weapon = weapon;
                AddEquipments(_weapon);
            }
        }

        private Headpiece _head;
        public void SetHead(Headpiece head)
        {
            if (head != null)
            {
                _head = head;
                AddEquipments(_head);
            }
        }

        private Chestpiece _chest;
        public void SetChest(Chestpiece chestpiece)
        {
            if (chestpiece != null)
            {
                _chest = chestpiece;
                AddEquipments(_chest);
            }
        }

        private Shoulderpiece _leftShoulder;
        public void SetLeftShoulder(Shoulderpiece should)
        {
            if (should != null)
            {
                _leftShoulder = should;
                AddEquipments(_leftShoulder);
            }

        }

        private Shoulderpiece _rightShoulder;
        public void SetRightShoulder(Shoulderpiece shoulder)
        {
            if (shoulder != null)
            {
                _rightShoulder = shoulder;
                AddEquipments(_rightShoulder);
            }
        }

        private Legspiece _legs;
        public void SetLeg(Legspiece legs)
        {
            if (legs != null)
            {
                _legs = legs;
                AddEquipments(_legs);
            }
        }

        private Armpiece _leftArm;
        public void SetLeftArmp(Armpiece arm)
        {
            if (arm != null)
            {
                _leftArm = arm;
                AddEquipments(_leftArm);
            }
        }

        private Armpiece _rightArm;
        public void SetRightArm(Armpiece arm)
        {
            if (arm != null)
            {
                _rightArm = arm;
                AddEquipments(_rightArm);
            }
        }

        private Gloves _gloves;
        public void SetGloves(Gloves gloves)
        {
            if (gloves != null)
            {
                _gloves = gloves;
                AddEquipments(_gloves);
            }

        }

        /// <summary>
        /// Gets total weight of armour.
        /// </summary>
        /// <returns></returns>
        public float GetTotalWeight()
        {
            float Weight = 0.0f;
            foreach(Item item in Equipments)
            {
                Weight += item.GetWeight();
            }
            return Weight;
        }

        /// <summary>
        /// Returns sums of defense stat of all armour pieces.
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalDefense()
        {
            decimal Defense = 0;
            foreach (Item item in Equipments)
            {
                Defense += item.GetDefence();
            }
            return Defense;
        }

        /// <summary>
        /// Returns damage done by weapon.
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalAttack()
        {
            decimal attack = 0;
            foreach (Item item in Equipments)
            {
                attack += item.GetAttack();
            }
            return attack;
        }
    }
}
