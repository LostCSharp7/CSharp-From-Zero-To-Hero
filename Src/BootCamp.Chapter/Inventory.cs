using System;
using System.Linq;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        private Item[] _items;
        public Item[] GetItems()
        {
            return _items;
        }

        public Inventory()
        {
            _items = new Item[0];
        }

        public Item GetItems(string name)
        {
            if (_items != null && _items.Length > 0)
            {
                for (var i = 0; i < _items.Length; ++i)
                {
                    if ((string.Compare(_items[i].GetName(), name) == 0))
                    {
                        return _items[i];
                    }
                }
            }
            return new Item("", 0, 0.0f);
        }

        public void AddItem(Item item)
        {
            if (_items != null && _items.Length > 1)
            {
                _items.Append(item);
            }
            else
                _items = new Item[1] { item };

        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (_items != null && _items.Length > 0)
            {
                if (_items.Length == 1)
                {
                    _items = new Item[0];
                    return;
                }

                Item[] Items = new Item[_items.Length - 1];
                int j = 0;
                bool bFlag = false;
                for (var i = 0; i < _items.Length; ++i)
                {
                    if ((_items[i].GetWeight() == item.GetWeight()) && (_items[i].GetPrice() == item.GetPrice()) && (string.Compare(_items[i].GetName(), item.GetName()) == 0))
                    {
                        bFlag = true;
                        continue;
                    }
                    Items[j] = _items[i];
                    ++j;
                }
                if(!bFlag) 
                {
                    return;
                }
                _items = Items;
            }
        }
    }
}
