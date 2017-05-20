using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task1
{
    class Program
    {
        bool Is(int x)
        {
            for (int i = 1; i <= 1000000; i *= 2)
                if (i == x)
                    return true;
            return false;
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo (@"C:\Users\Elibay\Desktop\Final\Task");
            FileInfo[] files = d.GetFiles();
            foreach (FileInfo a in files)
            {
                Console.Write(a.FullName);
                StreamReader sr = new StreamReader(a.FullName);
                string ss = sr.ReadLine();
                if (ss == "")
                    continue;
                string[] s = ss.Split();
                foreach (string w in s)
                {
                    if (w.Length < 1)
                        continue;
                    int x = int.Parse(w), y = 1;
                    for (int i = 1; i <= 32; ++i)
                    {
                        if (x == y)
                            Console.Write(" " + w);
                        y *= 2;
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
