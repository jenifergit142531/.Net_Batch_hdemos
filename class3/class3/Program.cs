using class3;
using CsvHelper;
using System.Collections;

using System.Globalization;

class Program
{
    public static void MySortedSet()
    {
        SortedSet<int> set1 = new SortedSet<int>();
        set1.Add(201);
        set1.Add(101);
        set1.Add(500);
        set1.Add(45);
        set1.Add(0);

        foreach(var i in set1)
        {
            Console.WriteLine(i);
        }

        //  set1.Remove(45);

        //set1.Clear();
        if(set1.Contains(10)== true)
        {
            Console.WriteLine("Element available...");
        }
        else
        {
            Console.WriteLine("Element not available");
        }
        Console.WriteLine("After removing the values :");
        foreach (var i in set1)
        {
            Console.WriteLine(i);
        }

    }
    public static void Main(string[] args)
    {

        //MySortedSet();
        //LinkedListApp.showLinkedList();
        //MyDictionary.ShowDictionary();
        //MyDictionary.showSortedDictionary();
        //ByteFileIO.writeByte();
        //ByteFileIO.readByte();
        var department = new SortedSet<string>();

        department.Add("hr");
        department.Add("sales");

        

        var patientList = new List<Animal>()
        {
             new Animal {animalId=101,animalName="dog"},
             new Animal {animalId=102,animalName="cat"},
             new Animal {animalId=102,animalName="panda"},

        };
     //   animals.Add("cat");
       // animals.Add("dog");4
      //  animals.Add("Anaconda");
   

        using (var fs = new StreamWriter("C:\\demo\\FileIOFolder\\patients.csv"))
        {
            using var csvwriter = new CsvWriter(fs, CultureInfo.CurrentCulture);
            csvwriter.WriteField("Animal Id :");
            csvwriter.WriteField("Animal Name :");
            csvwriter.NextRecord();
            foreach (var i in patientList)
            {
                csvwriter.WriteField(i.animalId);
                csvwriter.WriteField(i.animalName);
            }
           
            Console.WriteLine("Content is written successfully to the csv file");
        };




            }
}
