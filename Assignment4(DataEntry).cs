using System;
using System.Collections;


namespace Collection
{
    class DataEntry
    {

        ArrayList contacts = new ArrayList();
        public void AddData(string name)
        {
            contacts.Add(name);
        }
        public void RemoveData(string name)
        {
            if (contacts.Contains(name))
            {
                contacts.Remove(name);
            }
            else
                Console.WriteLine($"already {name} is not in your data list:");


        }
        public void UpdateName(string OldName,string NewName)
        {
            contacts.Remove(OldName);
            contacts.Add(NewName);
            Console.WriteLine("data has been successfully updated:");


        }
        public void ShowData()
        {
            if (contacts.Count == 0)
                Console.WriteLine("as of now , your data list is empty:");
            else
            {
                Console.WriteLine("data in your list:");
                foreach (var item in contacts)
                {

                    Console.WriteLine(item);
                }
            }
        }
        public void SearchData(string name)
        {

            if(contacts.Contains(name))
            {
                Console.WriteLine($"YES,{name} is in your data ");

            }
            else
            {
                Console.WriteLine($"NO,{name} is not in your data ");
            }
        }
        public void CountData()
        {
            Console.WriteLine($"total number of contacts--- {contacts.Count}");
        }

        public static void Main()
        {
            DataEntry obj = new DataEntry();
            int num1;
            do
            {
            Label:
                Console.WriteLine("\nif you want to add data then press 1 \n" +
                    "if you want to remove data then press 2 \n" + "if you want to update data then press 3 \n" +
                    "if you want to show data then press 4 \n" + "if you want to count data then press 5 \n"
                    + "if you want to search data then press 6 \n"
                    + "if you want to exit then press 0 \n");



                 num1 = int.Parse(Console.ReadLine());
                if (num1 >= 0 && num1 <= 6)
                {

                    switch (num1)
                    {
                        case 1:
                            Console.WriteLine("how many names do you want to add:");
                            int n = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine("please enter the name that you want to be store:");
                                string name = Console.ReadLine();
                                obj.AddData(name);


                            }

                            break;



                        case 2:
                            Console.WriteLine("please enter the name that you want to be remove:");
                            string R_name = Console.ReadLine();
                            obj.RemoveData(R_name);

                            break;

                        case 3:
                            Console.WriteLine("please enter the old name :");
                            string OldNAme = Console.ReadLine();
                            Console.WriteLine("now enter the New name :");
                            string NewNAme = Console.ReadLine();
                            obj.UpdateName(OldNAme, NewNAme);

                            break;

                        case 4:

                            obj.ShowData();

                            break;

                        case 5:
                            obj.CountData();
                            break;

                        case 6:
                            Console.WriteLine("enter the name which you want ro be search:");
                            string Sname = Console.ReadLine();
                            obj.SearchData(Sname);

                            break;
                        case 0:
                            Console.WriteLine("Thank you");
                            break;


                    }

                }
                else
                {
                    Console.WriteLine("please enter valid key:");
                    goto Label;

                }
            } while (num1 != 0);
        }
    }
}


