﻿using System.Xml.Linq;

namespace BootCamp.Chapter
{
    public class Shop
    {
        private decimal _money;
        public decimal GetMoney()
        {
            return _money;
        }

        private Inventory _inventory;

        public Shop()
        {
            _inventory = new Inventory();
        }

        public Shop(decimal money)
        {
            _inventory = new Inventory();
            _money = money;
        }

        public Item[] GetItems()
        {
            return _inventory.GetItems();
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            _inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            Item item = _inventory.GetItems(name);
            if (string.IsNullOrEmpty(item.GetName()))
            {
                return;
            }
            _inventory.RemoveItem(item);
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            if (item != null)
            {
                if (_money >= item.GetPrice())
                {
                    _money -= item.GetPrice();
                    _inventory.AddItem(item);
                    return item.GetPrice();
                }
               
            }
            return 0;
        }

        /// <summary>
        /// Sell item from a shop.
        /// Shop increases it's money.
        /// No money is increased if item does not exist.
        /// </summary>
        /// <returns>
        /// Item sold.
        /// Null, if no item is sold.
        /// </returns>
        public Item Sell(string name)
        {
            Item item = _inventory.GetItems(name);
            if(!string.IsNullOrEmpty(item.GetName())) 
            {
                _money += item.GetPrice();
                _inventory.RemoveItem(item);
                return item;
            }
            return null;
        }
    }
}