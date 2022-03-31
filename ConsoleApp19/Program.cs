using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class ConsoleApp19
{
    public static void Main()
    {
        Collection<string> KodAkademya = new Collection<string>();

        KodAkademya.Add("Mustafa");
        KodAkademya.Add("Yusqa");
        KodAkademya.Add("Qasimzade");
        KodAkademya.Add("Yusif");

        Console.WriteLine("{0} KodAkademya:", KodAkademya.Count);
        Display(KodAkademya);

        Console.WriteLine("\nIndexOf(\"Yusif\"): {0}",
            KodAkademya.IndexOf("Yusif"));

        Console.WriteLine("\nContains(\"Yusqa\"): {0}",
            KodAkademya.Contains("Yusqa"));

        Console.WriteLine("\nInsert(2, \"Hikmet\")");
        KodAkademya.Insert(2, "Hikmet");
        Display(KodAkademya);

        Console.WriteLine("\nKodAkademya[2]: {0}", KodAkademya[2]);

        Console.WriteLine("\nKodAkademya[2] = \"GulPembe\"");
        KodAkademya[2] = "GulPembe";
        Display(KodAkademya);

        Console.WriteLine("\nRemove(\"Mustafa\")");
        KodAkademya.Remove("Mustafa");
        Display(KodAkademya);

        Console.WriteLine("\nRemoveAt(0)");
        KodAkademya.RemoveAt(0);
        Display(KodAkademya);

        Console.WriteLine("\nKodAkademya.Clear()");
        KodAkademya.Clear();
        Console.WriteLine("Count: {0}", KodAkademya.Count);
    }

    private static void Display(Collection<string> cs)
    {
        Console.WriteLine();
        foreach (string item in cs)
        {
            Console.WriteLine(item);
        }
    }
}

