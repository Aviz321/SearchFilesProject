using System;
using System.Data;
using System.Linq;
using DAL_Search;
using DbManager;


namespace SearchComputerFiles
{
    class Program
    {

        static void Main()
        {
            string choice;
            do
            {

                SearchManager Find = new SearchManager(); //create a variable to reach out the functions from SearchManager

                Console.WriteLine("Welcome To Avi's Search App :)");
                Console.WriteLine();
                Console.WriteLine("Please Choose One of the Following \n 1-File Name To Search, 2- File Name And Directory Path, e-Exit Program");
                choice = Console.ReadLine();
                if (choice == "1" || choice == "2")
                {
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Please Enter File Name That You Want To Search...");
                            Find.FileName = Console.ReadLine();
                            if (Find.FileName.Length <= 0) //if the file name is null
                            {
                                Console.WriteLine("You Didnt Insert File Name");
                                Console.WriteLine();

                            }
                            else
                            {
                                Find.Recursion(Find.FileName);
                                Console.WriteLine();
                            }
                            break;


                        case "2":
                            Console.WriteLine("Please Enter Directory Path That You Want To Search In...");
                            Find.Path = Console.ReadLine();
                            do //
                            {
                                Console.WriteLine("You Didn't Insert Directory Path..Try Again");
                                Console.WriteLine("Please Enter Directory Path That You Want To Search In...");
                                Find.Path = Console.ReadLine();
                            } while (Find.Path.Length <= 0);

                            Console.WriteLine("Please Enter File Name That You Want To Search...");
                            Find.FileName = Console.ReadLine();
                            if (Find.FileName.Length <= 0) //if the file name is null
                            {
                                Console.WriteLine("You Didnt Insert File Name");
                                Console.WriteLine();

                            }
                            else
                            {
                                Find.Recursion(Find.FileName,Find.Path);
                            }

                            break;

                    }
                }
                else if (choice == "e")
                {
                    Console.WriteLine("Goodbye :)");

                }
                else //if the user didn't chose '1' or '2' or 'e' to exit
                {
                    Console.WriteLine("You Can Choose 1 Or 2 Only, Try Again...");
                }

            } while (choice != "e");

        }

    }
}

