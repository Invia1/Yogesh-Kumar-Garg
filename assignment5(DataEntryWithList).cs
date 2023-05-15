using System;
using System.Collections.Generic;
using System.Reflection.Emit;

class entrydata
{
    List<string> t = new List<string>();
    public void insert(string name)
    {
        t.Add(name);
    }
    public void update(string OldName, string NewName)
    {
        t.Remove(OldName);
        t.Add(NewName);
    }
    public void delete(string name)
    {
        t.Remove(name);
    }
    public void search(string Name)
    {
        bool a = t.Contains(Name);
        if (a)
        {
            Console.WriteLine($"{Name} is found");
        }
        else
        {
            Console.WriteLine($"{Name} is not found");
        }
    }
    public void display()
    {
        foreach (string s in t)
        {
            Console.WriteLine(s);
        }
    }
}
class p
{

    public static void Main()
    {

        entrydata obj = new entrydata();


        string Name;
        int num;
        do
        {
        Label:
            Console.WriteLine("if you want to add data then press 1");
            Console.WriteLine("if you want to remove data then press 2");
            Console.WriteLine("if you want to update data then press 3");
            Console.WriteLine("if you want to search data then press 4");
            Console.WriteLine("if you want to display data then press 5");
            Console.WriteLine("if you want to exit then press 0");

            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0 && num <= 5)
            {
                switch (num)
                {

                    case 1:
                        Console.WriteLine("please enter the name that you want to add:");
                        Name = Console.ReadLine();
                        obj.insert(Name);

                        break;

                    case 2:
                        Console.WriteLine("please enter the name that you want to delete:");
                        Name = Console.ReadLine();
                        obj.delete(Name);
                        break;

                    case 3:
                        Console.WriteLine("enter old name");
                        string OldName = Console.ReadLine();
                        Console.WriteLine("enter new Name");
                        string NewName = Console.ReadLine();
                        obj.update(OldName, NewName);
                        break;

                    case 4:
                        Console.WriteLine("enter the name that you want to search:");
                        Name = Console.ReadLine();
                        obj.search(Name);
                        break;
                    case 5:
                        obj.display();
                        break;
                    case 0:
                        Console.WriteLine("Thank You");
                        break;


                }
            }

            else
            {
                Console.WriteLine("please enter valid number");
                goto Label;
            }
        } while (num != 0);
    }
}
