using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            char selection = '\0';
            double sum = 0;
            double avg = 0;
            do
            {
                
                Console.WriteLine("----- Main Menu -----");
                Console.WriteLine("P: print the numbers");
                Console.WriteLine("A: Add new number");
                Console.WriteLine("M: Display Avg");
                Console.WriteLine("L: Display Maximum Value");
                Console.WriteLine("S: Display Minimum Value");
                Console.WriteLine("R: Prints Reverse numbers");
                Console.WriteLine("X: Ascending sort");
                Console.WriteLine("D: Descending sort");
                Console.WriteLine("F: Find a Value");
                Console.WriteLine("C: Clear the list");
                Console.WriteLine("Q: To Exit"); 
                Console.WriteLine("---------------------");
                selection = char.ToUpper(char.Parse(Console.ReadLine()));
                // ---- Print ----
                if (selection == 'P')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("This List is Empty . ");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.Write(" list Contains:  [");
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.Write($"  {list[i]}");
                        }
                        Console.Write(" ]");
                        Console.WriteLine(" ");
                    }
                }
                //---- Reverse List ----
                // ---- Print ----
                if (selection == 'R')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("This List is Empty . ");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.Write(" list Contains:  [");

                        //للأمانة تمت الاستعانة بموقع 
                        //W3resorces
                        // لإني كنت نسيت احط (-1 ) والنتيجة كان بيكون فيها
                        // error 
                        for (int i = list.Count - 1; i >= 0; i--)
                        {
                            Console.Write($"  {list[i]}");
                        }
                        Console.Write(" ]");
                        Console.WriteLine(" ");
                    }
                }

                // ---- Add ----
                else if (selection == 'A')
                {
                    Console.Write(" please enter the number:   ");
                    int value = int.Parse(Console.ReadLine());

                    if (list.Count == 0)
                    {
                        list.Add(value);
                        Console.WriteLine($"({value}) was added . ");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        bool duplicate = false;
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == value)
                            {
                                duplicate = true;
                            }
                        }
                        if (duplicate == true)
                        {
                            Console.WriteLine($"({value}) Duplicated value !!  , try another number");
                            Console.WriteLine();
                        }
                        else
                        {
                            list.Add(value);
                            Console.WriteLine($"({value}) was added . ");
                            Console.WriteLine(" ");
                        }
                    }
                }
                //---- Clear ---
                else if (selection == 'C')
                {
                    list.Clear();
                    Console.WriteLine($"Clear successfully ");
                    Console.WriteLine(" ");
                }
                //----  
                else if (selection == 'M')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("This List is Empty , please enter some numbers. ");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        int size = list.Count;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }
                        avg = sum / size;
                        Console.WriteLine($"Average is: ({avg})");
                        Console.WriteLine();
                    }
                }
                //---- Min ---- 
                else if (selection == 'S')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("This List is Empty , please enter some numbers. ");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        int Min = list[0];
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] < Min)
                            { Min = list[i]; }
                        }

                        Console.WriteLine($"Minimum Value  is: ({Min})");
                        Console.WriteLine();
                    }
                }
                //----- Max ----
                else if (selection == 'L')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("This List is Empty , please enter some numbers. ");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        int Max = list[0];
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] > Max)
                            { Max = list[i]; }
                        }
                        Console.WriteLine($"Maximum Value  is: ({Max})");
                        Console.WriteLine();
                    }
                }
                //---- Find ----
                else if (selection == 'F')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("This List is Empty , please enter some numbers. ");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.Write("please enter a number :");
                        int finder = int.Parse(Console.ReadLine());
                        bool status = false;
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (finder == list[i])
                            {
                                status = true;
                            }
                        }
                        if (status == false)
                        {
                            Console.WriteLine($" ({finder}) is Not exsists .");
                            Console.WriteLine();
                        }
                        else Console.WriteLine($" ({finder})  is exsist . ");
                        Console.WriteLine();

                    }
                }

                // ---- Ascending sort ----
                else if (selection == 'X')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("This List is Empty , please enter some numbers. ");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        int swap = 0;
                        Console.Write("After Ascending Sorting:  [ ");
                        for(int i = 0;i<list.Count; i++)
                        {
                            for(int j = i+1;j<list.Count; j++)
                            {
                                if (list[i] > list[j])
                                {
                                    swap = list[i];
                                    list[i] = list[j];
                                    list[j] = swap;
                                }
                            }
                        }
                        for (int i = 0; i < list.Count; i++) { Console.Write($"{list[i]} "); }
                        Console.Write(" ]");
                        Console.WriteLine();
                    }
                }


                //---- Descending Sort
                else if (selection == 'D')
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("This List is Empty , please enter some numbers. ");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        int swap = 0;
                        Console.Write("After Descending  Sorting:  [ ");
                        for (int i = 0; i < list.Count; i++)
                        {
                            for (int j = i + 1; j < list.Count; j++)
                            {
                                if (list[i] < list[j])
                                {
                                    swap = list[i];
                                    list[i] = list[j];
                                    list[j] = swap;
                                }
                            }
                        }
                        for (int i = 0; i < list.Count; i++) { Console.Write($"{list[i]} "); }
                        Console.Write(" ]");
                        Console.WriteLine();
                    }
                }


                //---Exit----
                else if (selection == 'Q')
                    Console.WriteLine("Good Bye !");
                else
                {
                    Console.WriteLine("Unknown option - please try again");
                }


                //-------------------------------//
            }
            while (selection!='Q');





        }
    }
}
