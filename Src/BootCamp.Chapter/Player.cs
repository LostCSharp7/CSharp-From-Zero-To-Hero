using BootCamp.Chapter.Items;
using System;
using System.Linq;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Task: simulate a player who has an inventory.
    /// Player can add or remove items from inventory.
    ///
    /// Extra task: player has equipement and maximum weight he/she can carry.
    /// Player should not be able to take items if already at maximum weight.
    /// Player should expose TotalAttack, TotalDefense stats.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Everyone can carry this much weight at least.
        /// </summary>
        private const int baseCarryWeight = 30;

        private string _name;
        private int _hp;

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        private int _strenght;

        /// <summary>
        /// Player items. There can be multiple of items with same name.
        /// </summary>
        private Inventory _inventory;
        /// <summary>
        /// Needed only for the extra task.
        /// </summary>
        private Equipment _equipment;

        public Player(int strength)
        {
            _strenght = strength;
            _inventory = new Inventory();
            _equipment = new Equipment();
        }

        public int GetMaxWeight()
        {
            return (baseCarryWeight + _strenght * 10);
        }

        public decimal GetTotalttack()
        {
            return _equipment.GetTotalAttack();
        }

        public decimal GetTotalDefense()
        {
            return _equipment.GetTotalDefense();
        }

        /// <summary>
        /// Gets all items from player's inventory
        /// </summary>
        public Item[] GetItems()
        {
            return _inventory.GetItems();
        }

        /// <summary>
        /// Adds item to player's inventory
        /// </summary>
        public void AddItem(Item item)
        {
            _inventory.AddItem(item);
        }

        public void Remove(Item item)
        {
            _inventory.RemoveItem(item);
        }

        /// <summary>
        /// Gets items with matching name.
        /// </summary>
        /// <param name="name"></param>
        public Item[] GetItems(string name)
        {
            Item[] items = _inventory.GetItems();
            Item[] MatchedItems = new Item[0];
            if (string.IsNullOrEmpty(name))
            {
                return MatchedItems;
            }
            
            foreach(Item item in items)
            {
                if(string.Compare(item.GetName(), name) ==0)
                {
                    if(MatchedItems.Length == 0)
                    {
                        MatchedItems = new Item[1] { item };
                    }

                    MatchedItems.Append(item);
                }
            }
            return MatchedItems;
        }

        #region Extra challenge: Equipment
        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.

        private bool CheckIfMaxWtReched(float ItemWt)
        {
            
            if((_equipment.GetTotalWeight() + ItemWt) <= GetMaxWeight())
            {
                return false;
            }
            return true;
        }

        public void Equip(Headpiece head)
        {
            if(CheckIfMaxWtReched(head.GetWeight()))
            {
                Console.WriteLine($"Maximum weight Reached, cannot equip item: {head.GetName()}");
                return; 
            }
            _equipment.SetHead(head);
        }

        public void Equip(Chestpiece chest)
        {
            if (CheckIfMaxWtReched(chest.GetWeight()))
            {
                Console.WriteLine($"Maximum weight Reached, cannot equip item: {chest.GetName()}");
                return;
            }
            _equipment.SetChest(chest);
        }

        public void Equip(Shoulderpiece Shoulder, bool isLeft)
        {
            if (CheckIfMaxWtReched(Shoulder.GetWeight()))
            {
                Console.WriteLine($"Maximum weight Reached, cannot equip item: {Shoulder.GetName()}");
                return;
            }
            if (isLeft) _equipment.SetLeftShoulder(Shoulder);
            else _equipment.SetRightShoulder(Shoulder);
        }

        public void Equip(Legspiece leg)
        {
            if (CheckIfMaxWtReched(leg.GetWeight()))
            {
                Console.WriteLine($"Maximum weight Reached, cannot equip item: {leg.GetName()}");
                return;
            }
            _equipment.SetLeg(leg);
        }

        public void Equip(Armpiece Arm, bool isLeft)
        {
            if (CheckIfMaxWtReched(Arm.GetWeight()))
            {
                Console.WriteLine($"Maximum weight Reached, cannot equip item: {Arm.GetName()}");
                return;
            }
            if (isLeft) _equipment.SetLeftArmp(Arm);
            else _equipment.SetRightArm(Arm);
        }

        public void Equip(Gloves glove)
        {
            if (CheckIfMaxWtReched(glove.GetWeight()))
            {
                Console.WriteLine($"Maximum weight Reached, cannot equip item: {glove.GetName()}");
                return;
            }
            _equipment.SetGloves(glove);
        }
        #endregion
    }
}
