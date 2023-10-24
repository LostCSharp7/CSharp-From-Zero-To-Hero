using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp.Chapter
{
    public class Person
    {
        string _name;
        float[] _balances;

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name; 
        }

        public void SetAndParseBalances(string[] balances)
        {
            float balance;
            _balances = new float[balances.Length - 1];

            for (int j = 1; j < balances.Length; ++j)
            {

                bool tryFloat = float.TryParse(balances[j], NumberStyles.Currency, CultureInfo.CreateSpecificCulture("en-GB"), out balance);
                if (!tryFloat) continue;
                _balances[j - 1] = balance;
            }
        }

        public float? FindHighestBalanceEver()
        {
            if(_balances == null || _balances.Length == 0) 
            {
                return null;
            }
            if(_balances.Length == 1) 
            {
                return _balances[0];
            }
            float HighestLastBalance = _balances[0];
            for(int i = 1; i < _balances.Length; ++i)
            {
                float number = _balances[i];
                if(number > HighestLastBalance)
                {
                    HighestLastBalance = number;
                }
            }
            return HighestLastBalance;
        }

        public float? FindBiggestLossEver()
        {
            if(_balances == null || _balances.Length==0)
            {
                return null;
            }
            if( _balances.Length == 1)
            {
                return null;
            }

            float BiggestLoss = 0;
            for(int i = 1; i < _balances.Length; ++i)
            {
                float numberdiff = _balances[i] - _balances[i - 1];
                if(numberdiff < BiggestLoss)
                {
                    BiggestLoss = numberdiff;
                }
            }
            return BiggestLoss;
        }

        public float? RetrieveCurrentMoney()
        {
            if (_balances == null || _balances.Length == 0)
            {
                return null;
            }
            if (_balances.Length == 1)
            {
                return _balances[0];
            }

            return _balances[^1];
        }
    }
}
