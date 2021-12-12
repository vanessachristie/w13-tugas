using System;
using System.Collections.Generic;
using System.Collections;

namespace w13_tugas
{
    class Program
    {
        public int FindItem(List<string> scrolls, string lala)
        {
            for (int i = 0; i < scrolls.Count; i++)
                if (scrolls[i] == lala) 
                    return i;
            return -1;
        }



        static void Main(string[] args)
        {
            int statusProgram = 1;
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            while (statusProgram == 1)
            {
                Console.WriteLine("1.My scroll list:");
                Console.WriteLine("2.Add scroll:");
                Console.WriteLine("3.Search scroll:");
                Console.WriteLine("4.Remove scroll:");
                Console.Write("Choose what to do:");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (input == 1)
                {
                    int hitung = 1;
                    Console.WriteLine("Scroll to learn list:");
                    foreach (var scroll in scrolls)
                    {
                        Console.WriteLine("Scroll " + hitung + " :" + scroll);
                        hitung++;
                    }
                    Console.WriteLine();
                }
                if (input == 2)
                {
                    Console.Clear();
                    Console.Write("How many scroll to add:");
                    int input2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("In what number of queue:");
                    int input3 = Convert.ToInt32(Console.ReadLine());
                    if (input3 <= 0)
                    {
                        input3 = 1;
                    }
                    if (input3 > scrolls.Count)
                    {
                        input3 = scrolls.Count + 1;
                    }
                    for (int i = 1; i <= input2; i++)
                    {
                        Console.Write($"Scroll {i} name:");
                        string input4 = Convert.ToString(Console.ReadLine());
                        scrolls.Insert(input3 - 1, input4);
                        input3++;

                    }
                }
                if (input == 3)
                {
                    Console.Write("Insert scroll name:");
                    string inputBuku = Console.ReadLine();


                    if (scrolls.FindIndex(x => x.Equals(inputBuku, StringComparison.OrdinalIgnoreCase)) != -1)
                    {
                        int hasil = scrolls.FindIndex(x => x.Equals(inputBuku, StringComparison.OrdinalIgnoreCase)) ;
                        hasil += 1;
                        
                        Console.WriteLine("Book found. Queue number : " + hasil);
                        
                    }
                    else
                    {
                        Console.Write("Book not found\n\n");
                    }



                }
                if (input == 4)
                {
                   

                    Console.Write("Remove from list by scroll name? Y/N:");
                    string remove = Console.ReadLine();
                    if (remove== "y")
                    {
                        Console.Write("Input scroll name: ");
                        string lala = Console.ReadLine();
                        while ((scrolls.FindIndex(x => x.Equals(lala, StringComparison.OrdinalIgnoreCase)) != -1) == false)
                        {
                            Console.WriteLine("Book Not found ! ");
                            Console.Write("Input scroll name: ");
                            lala = Console.ReadLine();
                        }
                        if (scrolls.FindIndex(x => x.Equals(lala, StringComparison.OrdinalIgnoreCase)) != -1)
                        {
                            int hasil = scrolls.FindIndex(x => x.Equals(lala, StringComparison.OrdinalIgnoreCase));
                            
                            Console.WriteLine("Book Removed! ");
                            scrolls.RemoveAt(hasil);
                            Console.WriteLine();
                        }
                       
                    }
                    if (remove == "n")
                    {
                        Console.Write("Input scroll queue: ");
                        int lala = Convert.ToInt32(Console.ReadLine());
                        int test = 0;
                        while (test == 0)
                        {
                            for (int i = 1; i <= scrolls.Count; i++)
                            {
                                if (i == lala)
                                {
                                    scrolls.Remove(scrolls[i - 1]);
                                    Console.WriteLine("Book Removed!");
                                    test = 1;
                                }
                            }
                            if (test == 0)
                            {
                                Console.Write("Queue not found! insert scroll queue: ");
                                lala = Convert.ToInt32(Console.ReadLine());
                            }

                        }

                        Console.WriteLine();   
                    }
                    while (remove != "y" && remove != "n")
                    {
                        Console.WriteLine("Wrong selection. Choose again: ");
                        Console.Write("Remove from list by scroll name? y/n:");
                        remove = Console.ReadLine();
                    }

                }
            }
        }
    }
}
