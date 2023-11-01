namespace BootCamp.Chapter
{
    public class Item
    {
        private string _name;
        public string GetName()
        {
            return _name;
        }

        private decimal _price;
        public decimal GetPrice()
        {
            return _price;
        }

        private float _weight;
        public float GetWeight()
        {
            return _weight;
        }
        public virtual decimal GetDefence() 
        {
            return 0;
        }

        public virtual decimal GetAttack()
        {
            return 0;
        }

        public Item(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
    }
}