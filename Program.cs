using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senasteVinnaren = "Ingen har vunnit än";
            Random slump = new Random();
            while (true)
            {
                
                Console.Clear();
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programmet");
                string Menysvar = Console.ReadLine();

                if (Menysvar == "1") 
                {
                    int spelarensPoäng = 0;
                    int datornsPoäng = 0;

                    senasteVinnaren = "Ingen har vunnit än";
                    Console.WriteLine();
                    Console.WriteLine("Nu startar vi spelet!");
                    Task.Delay(500).Wait();
                    Console.Clear();
                    Console.WriteLine("Nu kommer två kort dras per spelare");
                    datornsPoäng += slump.Next(1, 11);
                    datornsPoäng += slump.Next(1, 11);
                    spelarensPoäng += slump.Next(1, 11);
                    spelarensPoäng += slump.Next(1, 11);
                    string kortVal = "";
                    while (kortVal != "n" && spelarensPoäng <= 21)
                    {
                        Console.WriteLine($"Din poäng: {spelarensPoäng}");
                        Console.WriteLine($"Datorns poäng: {datornsPoäng}");
                        Console.WriteLine("Vill du ha ett kort till? (j/n)");
                        kortVal = Console.ReadLine().ToLower();

                        switch (kortVal)
                        {
                            case "j":
                                int nyPoäng = slump.Next(1, 11);
                                spelarensPoäng += nyPoäng;
                                Console.WriteLine($"Ditt nya kort är värt {nyPoäng} poäng");
                                Console.WriteLine($"Du är nu på {spelarensPoäng} poäng");
                                break;
                            case "n":
                                break;

                            default:
                                Console.WriteLine("Du valde inte ett giltigt alternativ");
                                break;
                                
                        }
                    }
                    if (spelarensPoäng > 21)
                    {
                        Console.WriteLine("Du har mer än 21 poäng och har förlorat.");
                        Task.Delay(700).Wait();
                    }


                    
                }
                else if (Menysvar == "2")
                {
                    Console.WriteLine($"Senaste Vinnaren: {senasteVinnaren}");
                    Console.ReadKey();
                }
                else if (Menysvar == "3")
                {
                    Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng. ");
                    Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1 - 10 poäng. ");
                    Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
                    Console.WriteLine("Både du och datorn får två kort i början.Därefter får du");
                    Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
                    Console.WriteLine("När du är färdig drar datorn kort till den har");
                    Console.WriteLine("mer poäng än dig eller över 21 poäng.");
                    Console.ReadKey();
                }
                else if (Menysvar == "4") 
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Skriv in 1, 2, 3 eller 4.");
                    Task.Delay(300).Wait();
                }
            }
        }
    }
}
