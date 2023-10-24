using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public class Checks
    {
        private static string FormatString(string strHigh)
        {
            //below block is for formatting the text to be written.
            int index = 0;
            int HoldIndex = 0;
            while (true)
            {
                index = strHigh.IndexOf(",", index);
                if (index > 0)
                {
                    HoldIndex = index;
                    ++index;
                    continue;
                }
                else break;
            }

            //To replace last found ',' with and replace the ',' with ", "
            if (HoldIndex > 0)
            {
                var sb = new StringBuilder(strHigh);
                sb.Remove(HoldIndex, 1);
                sb.Insert(HoldIndex, " and ");
                sb.Replace(",", ", ");
                strHigh = sb.ToString();
            }
            return strHigh;
        }

        public static Person[] ParseBalance(string[] peopleBalances)
        {
            //Series of objects for Person class.
            Person[] personArr = new Person[peopleBalances.Length];


            for (int i = 0; i < peopleBalances.Length; ++i)
            {
                string str = peopleBalances[i];
                //if the strings are empty we shall continue with next iteration
                if (str.Length == 0)
                    continue;

                //strings have balances, so split them with ','.
                string[] PersonDetails = str.Split(",", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                //Object creation for each person.
                Person person = new Person();
                person.SetName(PersonDetails[0]);
                person.SetAndParseBalances(PersonDetails);
                personArr[i] = person;
            }
            return personArr;

        }

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            string strHigh = "N/A.";
            var stringBuild = new string("");

            //If the balances are not having any items or null return N/A.
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return strHigh;
            }
            //Parse and create objects of Person
            var PersonArr = ParseBalance(peopleAndBalances);

            //Calculation of highest balance
            float? HighestBalanceEver = null;
            HighestBalanceEver = PersonArr[0].FindHighestBalanceEver();
            stringBuild = PersonArr[0].GetName();
            for (int i = 1; i< PersonArr.Length; ++i)
            { 
                float? highBal = PersonArr[i].FindHighestBalanceEver();
                if (highBal == null)
                    continue;
                if (highBal > HighestBalanceEver)
                {
                    HighestBalanceEver = highBal;
                    stringBuild = PersonArr[i].GetName();
                }
                else if (highBal == HighestBalanceEver)
                {
                    stringBuild = string.Concat(stringBuild, ",", PersonArr[i].GetName());

                    continue;
                }
            }

            //For the array of balances, if there are no balances then return N/A.
            if (HighestBalanceEver == null) return strHigh;

            strHigh = FormatString(stringBuild.ToString());

            //CultureInfo culture = new CultureInfo("en-GB");
            CultureInfo culture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            //https://learn.microsoft.com/en-us/dotnet/api/system.globalization.numberformatinfo.currencynegativepattern?view=net-7.0#remarks
            culture.NumberFormat.CurrencyNegativePattern = 1;
            culture.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = culture;

            return strHigh = string.Concat(strHigh, $" had the most money ever. {HighestBalanceEver:c0}.");

        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            string strHigh = "N/A.";
            var stringBuild = new string("");

            //If the balances are not having any items or null return N/A.
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return strHigh;
            }
            //Parse and create objects of Person
            var PersonArr = ParseBalance(peopleAndBalances);

            //Calculation of highest balance
            float? BiggestLoss = null;
            BiggestLoss = PersonArr[0].FindBiggestLossEver();
            stringBuild = PersonArr[0].GetName();
            for (int i = 1; i < PersonArr.Length; ++i)
            {
                float? bigLoss = PersonArr[i].FindBiggestLossEver();
                if (bigLoss == null || BiggestLoss == null)
                {
                    BiggestLoss = bigLoss;
                    continue;
                }
                if (bigLoss < BiggestLoss)
                {
                    BiggestLoss = bigLoss;
                    stringBuild = PersonArr[i].GetName();

                }
                else if(bigLoss == BiggestLoss)
                {
                    stringBuild = string.Concat(stringBuild, ",", PersonArr[i].GetName());
                    continue;
                }
            }

            //For the array of balances, if there are no balances then return N/A.
            if (BiggestLoss == null) return strHigh;

            strHigh = FormatString(stringBuild.ToString());
 
            CultureInfo culture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            culture.NumberFormat.CurrencyNegativePattern = 1;
            culture.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = culture;
            return strHigh = string.Concat(strHigh, $" lost the most money. {BiggestLoss:c0}.");
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            string strHigh = "N/A.";
            bool bFlag = false;
            var stringBuild = new string("");

            //If the balances are not having any items or null return N/A.
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return strHigh;
            }
            //Parse and create objects of Person
            var PersonArr = ParseBalance(peopleAndBalances);

            //Calculation of highest balance
            float? richestBal = null;
            richestBal = PersonArr[0].RetrieveCurrentMoney();
            stringBuild = PersonArr[0].GetName();
            for (int i = 1; i < PersonArr.Length; ++i)
            {
                float? richBal = PersonArr[i].RetrieveCurrentMoney();
                if (richBal == null)
                    continue;
                if (richBal > richestBal)
                {
                    richestBal = richBal;
                    stringBuild = PersonArr[i].GetName();
                }
                else if (richBal == richestBal)
                {
                    stringBuild = string.Concat(stringBuild.ToString(), ",", PersonArr[i].GetName());
                    bFlag = true;
                    continue;
                }

            }

            //For the array of balances, if there are no balances then return N/A.
            if (richestBal == null) return strHigh;

            strHigh = FormatString(stringBuild.ToString());
            CultureInfo culture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            culture.NumberFormat.CurrencyNegativePattern = 1;
            culture.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = culture;

            if (bFlag) return strHigh = string.Concat(strHigh, $" are the richest people. {richestBal:c0}.");
            return strHigh = string.Concat(strHigh, $" is the richest person. {richestBal:c0}.");
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {

            string strHigh = "N/A.";
            bool bFlag = false;
            var stringBuild = new string("");

            //If the balances are not having any items or null return N/A.
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return strHigh;
            }
            //Parse and create objects of Person
            var PersonArr = ParseBalance(peopleAndBalances);

            //Calculation of highest balance
            float? lowestBal = null;
            lowestBal = PersonArr[0].RetrieveCurrentMoney();
            stringBuild = PersonArr[0].GetName();
            for (int i = 1; i < PersonArr.Length; ++i)
            {
                float? lowBal = PersonArr[i].RetrieveCurrentMoney();
                if (lowBal == null)
                    continue;
                if (lowBal < lowestBal)
                {
                    lowestBal = lowBal;
                    stringBuild = PersonArr[i].GetName();

                }
                else if (lowBal == lowestBal)
                {
                    stringBuild = string.Concat(stringBuild, ",", PersonArr[i].GetName());
                    bFlag = true;
                    continue;
                }
            }

            //For the array of balances, if there are no balances then return N/A.
            if (lowestBal == null) return strHigh;

            strHigh = FormatString(stringBuild.ToString());
            CultureInfo culture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            culture.NumberFormat.CurrencyNegativePattern = 1;
            culture.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = culture;   
            if (bFlag) return strHigh = string.Concat(strHigh, $" have the least money. {lowestBal:c0}.");
            return strHigh = string.Concat(strHigh, $" has the least money. {lowestBal:c0}.");
        }

        private static void PrintChar(char c, int strLength, StringBuilder sb)
        {
            for (int j = 0; j < (strLength); ++j) { sb.Append(c); }
        }
       private static void PrintHyphen(int strLength, StringBuilder sb)
        {
            sb.Append('+');
            PrintChar('-', strLength, sb);
            sb.Append($"+{Environment.NewLine}");
        }
        private static void PritPipe(int strLength, StringBuilder sb, int padding)
        {
            for (int j = 0; j < padding; ++j)
            {
                sb.Append('|');
                PrintChar(' ', strLength, sb);
                sb.Append($"|{Environment.NewLine}");
            }
        }

        public static string Build(string message, in int padding)
        {
            if (message == null || message.Length == 0)
            {
                return "";
            }
            var sb = new StringBuilder();
            var arr = message.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
            for (int x = 0; x < arr.Length; ++x)
            {
                arr[x] = arr[x].PadLeft(padding + arr[x].Length);
                arr[x] = arr[x].PadRight(padding + arr[x].Length);
            }
            var strLength = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (strLength < arr[i].Length) { strLength = arr[i].Length; }

            }

            PrintHyphen(strLength, sb);
            PritPipe(strLength, sb, padding);

            for (int k = 0; k < arr.Length; ++k)
            {
                sb.Append('|');
                sb.Append(arr[k].PadRight(strLength));
                sb.Append($"|{Environment.NewLine}");
            }

            PritPipe(strLength, sb, padding);
            PrintHyphen(strLength, sb);

            return sb.ToString();
        }

        private static void CheckForInvalidCharInName(string[] lineArr)
        {
            string str = lineArr[0];
            if (!(str.All(x => Char.IsLetter(x) || x == ' ' || x == '\'' || x == '-')))
                throw new InvalidBalancesException("Invalid Character in Name", new Exception());
        }

        private static void CheckForInvalidCharInBalance(string[] lineArr)
        {
            float balance = 0.0f;
            for (int i = 1; i < lineArr.Length; i++)
            {
                bool tryFloat = float.TryParse(lineArr[i], NumberStyles.Currency, CultureInfo.CreateSpecificCulture("en-GB"), out balance);
                if (!tryFloat) throw new InvalidBalancesException("Balance is not valid", new Exception());
            }

        }

        public static void Clean(string dirtyFile, string cleanedFile)
        {
            try
            {
                if (dirtyFile == null || dirtyFile.Length == 0)
                {
                    throw new ArgumentException();
                }

                if (!File.Exists(dirtyFile))
                {
                    throw new ArgumentException();
                }

                string stringFile = File.ReadAllText(dirtyFile);

                if (stringFile.Length > 0)
                {
                    if (stringFile.Contains('_'))
                    {
                        stringFile = stringFile.Replace("_", "");
                    }
                    var arrStr = stringFile.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
                    foreach (var str in arrStr)
                    {
                        var lineArr = str.Split(",", StringSplitOptions.RemoveEmptyEntries);
                        CheckForInvalidCharInName(lineArr);
                        CheckForInvalidCharInBalance(lineArr);
                    }
                    File.WriteAllText(cleanedFile, stringFile.ToString());
                }
                File.WriteAllText(cleanedFile, stringFile.ToString());
            }
            catch (InvalidBalancesException e)
            {
                throw e;
            }
        }
    }
}
