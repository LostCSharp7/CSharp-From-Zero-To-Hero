using System.Security.Cryptography.X509Certificates;

namespace BootCamp.Chapter.Items
{
    public class Weapon:Item
    {
        //private string _name;
        //private decimal _price;
        //private float _weight;
        private readonly decimal _attack;
        public override decimal GetAttack()
        {
            return _attack;
        }

        private readonly decimal _defence;
        public override decimal GetDefence()
        {
            return _defence;
        }


        public Weapon(string name, decimal price, float weight, decimal attack, decimal defence) : base(name, price, weight)
        {
            //_name = name;
            //_price = price;
            //_weight = weight;
            _attack = attack;
            _defence = defence;
        }
    }
}
