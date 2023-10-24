using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string DirtyFile = @"C:\Users\AK055494\OneDrive - Cerner Corporation\Avinash K\Repos\CSharp\CSharp_Repo\Src\BootCamp.Chapter\Input\Balances.corrupted";
            string CleanFile = @"C:\Users\AK055494\OneDrive - Cerner Corporation\Avinash K\Repos\CSharp\CSharp_Repo\Src\BootCamp.Chapter\Input\Balances.clean";

            //Make the file free of corruption
            Checks.Clean(DirtyFile, CleanFile);

            //Find Poor, Rich, Highest Balance, Biggest lost
            string strInput = File.ReadAllText(CleanFile);
            string[] strArr = strInput.Split("\r\n", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            //Console.WriteLine(Checks.Build(Checks.FindMostPoorPerson(strArr), 1));
            //Console.WriteLine(Checks.Build(Checks.FindRichestPerson(strArr), 1));
            //Console.WriteLine(Checks.Build(Checks.FindPersonWithBiggestLoss(strArr), 1));
            //Console.WriteLine(Checks.Build(Checks.FindHighestBalanceEver(strArr), 1));

            //Console.WriteLine(Checks.FindMostPoorPerson(strArr));
            //Console.WriteLine(Checks.FindRichestPerson(strArr));
            //Console.WriteLine(Checks.FindPersonWithBiggestLoss(strArr));
            //Console.WriteLine(Checks.FindHighestBalanceEver(strArr));

            var StringBuild = new StringBuilder("");

            string[] arr = new string[4];
            arr[0] = (Checks.FindMostPoorPerson(strArr));
            arr[1] = (Checks.FindRichestPerson(strArr));
            arr[2] = (Checks.FindPersonWithBiggestLoss(strArr));
            arr[3] = (Checks.FindHighestBalanceEver(strArr));
            StringBuild.AppendJoin("\r\n", arr);
           

            //For good UI
            Console.WriteLine(Checks.Build(StringBuild.ToString(), 1));
        }
    }
}
