using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPatterns
{
    //Single Resposnsibilty Principles
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count} :{text}");
            return count;   //momento
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }


    }


    public class Persistance
    {
        public void SaveTofile(Journal j, string fileName)
        {
            if (!File.Exists(fileName))
                File.WriteAllText(fileName, j.ToString());
        }
    }
    class SingleResopnsibilityPrinciple
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I am Atul");
            j.AddEntry("I am From Pune");
            Console.WriteLine(j);

            var per = new Persistance();
            string fileName = @"E:\temp\journal.txt";
            per.SaveTofile(j, fileName);


        }
    }
}
