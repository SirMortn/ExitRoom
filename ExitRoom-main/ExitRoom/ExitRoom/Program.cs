using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Where_am_I
{
    //Hallo
    class Opening
    {
        public static string name;

        /// <summary>
        /// Warnhinweise
        /// </summary>
        public static void Warning()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("______________________________________________________WARNUNG_________________________________________________________\n");
            Console.WriteLine("In der folgenden Anwendung kann es zu verschiedenen Ton und Licht Sequenzen kommen!");
            Console.WriteLine("Menschen mit Licht oder Ton Empfindlichkeiten sollten daher AUSSCHLIESSLICH die dafür\nvorgesehene Option auswählen!  ");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }

        /// <summary>
        /// Begrüßung und Einleitung
        /// </summary>
        public static void Intro()
        {
            Console.WriteLine("_____________________________________________HALLO UND HERZLICH WILKOMMEN_____________________________________________\n");
            Console.WriteLine("In diesem Textabenteuer musst du durch Eingaben auf der \nTastatur verschiedene Aufgaben Lösen.");
            Console.WriteLine("Die meisten Eingaben musst du mit der Enter Taste Bestätigen.");
            Console.WriteLine("Es kann vorkommen dass du für manche Eingaben nur eine vorgegrbene \nZeit hast, dies wird dir ein Countdown anzeigen. (Jetzt ist es so weit, drücke die \"ENTER\"-Taste!)");
            Console.ReadLine();
            Console.Clear();
            Warning();
            Console.WriteLine("_______________________________________________Wilkommen bei WHERE AM I_______________________________________________\n\n");

        }

        /// <summary>
        /// Abfrage vom Spielernamen und Schwierigkeit des Spiels
        /// </summary>
        /// <param name="choice"></param>
        /// <returns>Schwierigkeitsgrad</returns>
        public static int Registration(int choice)
        {
            int age;
            choice = 1;
            string adventure = " ";

            Console.WriteLine("Wie soll ich dich ansprechen?");
            name = Console.ReadLine();

            name = Program.LetterUp(name);
            do
            {
                Program.ClearLine();
                Program.ClearLine();
                Console.WriteLine($"Hallo {name}. Wie alt bist du?");

            } while (!int.TryParse(Console.ReadLine(), out age));
            Program.ClearLine();


            Console.WriteLine();
            if (age < 6)
            {
                do
                {
                    Program.ClearLine();

                    Console.WriteLine($"Wow du kannst mit {age} Jahren schon lesen? Das freut mich, aber leider bist du zu jung für dieses Spiel..");
                    Console.ReadLine();
                    return 999;
                } while (true);
            }
            else if (age >= 6 && age < 11)
            {

                do
                {

                    do
                    {
                        Program.ClearLine();
                        Console.WriteLine($"\nAlles klar, mit {age} Jahren empfehle ich dir: ");
                        Console.WriteLine("\t1: Die Einsteiger Version mit Hilfestellungen\n");
                        Console.ReadLine();
                        Console.WriteLine("\t2: Das Normle Spielvergnügen\n");
                        Console.WriteLine("\t3: Die Profi Version");
                        Console.WriteLine("Natürlich kannst du aber selbst entscheiden...");
                        Console.Write($"\nBitte gib dafür die gewünschte Zahl ein und bestätige mit Enter: ");

                    } while (!int.TryParse(Console.ReadLine(), out choice));



                    Program.ClearLine();
                } while (choice != 1);

            }
            else if (age < 14)
            {
                do
                {
                    do
                    {
                        Program.ClearLine();
                        Console.WriteLine($"\nAlles klar, mit {age} Jahren empfehle ich dir: ");
                        Console.WriteLine("\t2: Das Normle Spielvergnügen\n");

                        Console.ReadLine();
                        Console.WriteLine("\t1: Die Einsteiger Version mit Hilfestellungen\n");

                        Console.WriteLine("\t3: Die Profi Version");
                        Console.WriteLine("\nNatürlich kannst du aber selbst entscheiden...");
                        Console.Write($"\nBitte gib dafür die gewünschte Zahl ein und bestätige mit Enter: ");

                    } while (!int.TryParse(Console.ReadLine(), out choice));
                    Program.ClearLine();
                    Program.ClearLine();
                    Program.ClearLine();



                } while (choice != 1 && choice != 2);

            }
            else
            {
                do
                {
                    do
                    {
                        Program.ClearLine();
                        Console.WriteLine($"\nAlles klar, mit {age} Jahren empfehle ich dir: ");
                        Console.WriteLine("\t3: Die Profi Version");


                        Console.ReadLine();
                        Console.WriteLine("\t1: Die Einsteiger Version mit Hilfestellungen\n");
                        Console.WriteLine("\t2: Das Normle Spielvergnügen\n");
                        Console.WriteLine("\nNatürlich kannst du aber selbst entscheiden...");
                        Console.Write($"\nBitte gib dafür die gewünschte Zahl ein und bestätige mit Enter: ");

                    } while (!int.TryParse(Console.ReadLine(), out choice));
                    Program.ClearLine();
                    Program.ClearLine();
                    Program.ClearLine();
                    Program.ClearLine();
                    Program.ClearLine();

                } while (choice != 1 && choice != 2 && choice != 3);

            }

            if (choice == 1)
            {
                adventure = "\"Die Einsteiger Version mit Hilfestellungen\"";
            }
            else if (choice == 2)
            {
                adventure = "\"Das Normle Spielvergnügen\"";
            }
            else if (choice == 3)
            {
                adventure = "\"Die Profi Version\"";
            }
            Program.ClearLine();
            Program.ClearLine();
            Console.WriteLine($"\nDu hast also {adventure} gewählt, wenn du bereit bist, bestätige mit \"ENTER\"...");
            Console.ReadLine();

            return choice;
        }
    }
    class Program
    {
        //  public static string FirstLetter(string firstLetter){}

        /// <summary>
        /// Ändert den ersten Buchstaben einer string Variablen auf einen Großbuchstaben
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string LetterUp(string word)
        {

            string input = word;

            foreach (char item in input)
            {
                string first = item.ToString();
                first = first.ToUpper();
                word = first + input.Remove(0, 1);
                break;
            }
            return word;
        }

        /// <summary>
        /// Löscht die vorherige Zeile
        /// </summary>
        public static void ClearLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        static void Main(string[] args)
        {
            // Größe des Fensters Fixieren => Wegen "Bildern"
            Console.SetWindowSize(120, 30);
            Console.SetBufferSize(120, 50);

            int door = 1;

            Opening.Intro();
            door = Rooms.FourDoors(door);


            // Die Räume können öfter Betreten werden
            do
            {
                switch (door)
                {
                    case 1:
                        Rooms.RoomOne();
                        break;
                    case 2:
                        break;
                    case 3:
                        Rooms.RoomThree();
                        break;
                    case 4:
                        Rooms.RoomFour();
                        break;
                    // Für das Beenden vorbereitet (door = 999;)
                    default:
                        Console.WriteLine($"Vielen dank für deine Zeit {Opening.name}. Bis bald.");
                        break;

                }
            } while (door != 999);

            Console.ReadKey();
        }
    }

    class Rooms
    {
        /// <summary>
        /// Der Zentrale Raum
        /// </summary>
        /// <param name="door"></param>
        /// <returns>Tür 1-4</returns>
        public static int FourDoors(int door)
        {
            string answer;

            int difficulty = 0;
            difficulty = Opening.Registration(difficulty);

            if (difficulty == 999)
            {
                return door = 999;
            }

            Console.Clear();
            Console.WriteLine("_____________________________________________________WO BIN ICH???_____________________________________________________\n\n");
            Console.WriteLine("... ist die erste Frage die du dir stellst, als du in einem merkwürdigem scheinbar leeren Raum erwachst. Du kennst\ndiesen Ort nicht und du hast keine Ahnung wie du hier hergekommen bist. Du stehst langsam auf und drehst dich.\nDu siehst 4 Wände, jede Wand hat eine Tür. Große Ziffern sind auf den Türen zu erkennen.\n");

            // "Bild" der 4 Türen wird aufgebaut (mit fehlern in den ziffern 1 und 3)
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("************************** ***************************** ****************************** *******************************");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("*                         *                             *                              *                              *");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("*            ****         *       **** **** ****        *        **** **** ****        *                  ****        *");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("*            ****         *       **** **** ****        *        **** **³* ****        *                  ****        *");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("*       **** ****         *  ****                ****   *   ****                ****   *             **** ****        *");
            System.Threading.Thread.Sleep(900);
            Console.WriteLine("*       **** ****         *  ****                ****   *   ****                ****   *             **** ****        *");
            System.Threading.Thread.Sleep(900);
            Console.WriteLine("*  ****      ****         *                      ****   *                       ****   *        ****      ****        *");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine("*  ****      ****         *                      ****   *                       ****   *        ****      ****        *");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine("*            ****         *                 ****        *             **** ****        *   ****           ****        *");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("*            ****         *                 ****        *             **** ****        *   ****           ****        *");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("*            ****         *            ****             *                       ****   *   **** **** **** **** ****   *");
            System.Threading.Thread.Sleep(600);
            Console.WriteLine("*            *#**         *            ****             *                       ****   *   **** **** **** **** ****   *");
            System.Threading.Thread.Sleep(600);
            Console.WriteLine("*            ****         *       ****                  *   ****                ****   *                  ****        *");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("*            ****         *       ****                  *   ****                ****   *                  ****        *");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("*            ****         *  **** **** **** **** ****   *        **** **** ****        *                  ****        *");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("*            ****         *  **** **** **** **** ****   *        **** **** ****        *                  ****        *");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("*                         *                             *                              *                              *");
            System.Threading.Thread.Sleep(400);
            Console.WriteLine("************************** ***************************** ****************************** *******************************");

            Console.WriteLine("\n\n");
            do
            {
                Program.ClearLine();
                Program.ClearLine();
                Program.ClearLine();
                Console.WriteLine("Nachdem du dir die Zahlen genauer angesehen hast, entscheide dich für eine der Türen die du Öffnen willst...");

                // Bei auswahl "MIT HILFE" hilfetext anzeigen lassen
                if (difficulty == 1)
                {
                    Console.WriteLine("ACHTUNG: Wenn du denkst etwas stimmt nicht mit den Zahlen, stimmt möglicherweise auch etwas mit dem Raum nicht!");
                }

            } while (!int.TryParse(Console.ReadLine(), out door));
            Program.ClearLine();

            // Nachfragen ob der Spieler sich sicher ist eventuell bei Erfahrenem spieler weglassen...
            do
            {

                switch (door)
                {

                    case 1:
                        Console.WriteLine($"\nAlso Tür Nummer {door},\nbist du dir sicher?");
                        answer = Console.ReadLine();
                        answer = Program.LetterUp(answer);

                        if (answer != "Y" && answer != "YES" && answer != "Yes" && answer != "J" && answer != "Ja" && answer != "JA")
                        {

                            do
                            {

                                Program.ClearLine();
                                Program.ClearLine();
                                Program.ClearLine();

                                Console.Write($"\nDeine Antwort ist: {answer}\nWelche Tür soll es sonst sein? ");
                            } while (!int.TryParse(Console.ReadLine(), out door));
                        }
                        break;
                    case 2:
                        Console.WriteLine($"\nAlso Tür Nummer {door},\nbist du dir sicher?");
                        answer = Console.ReadLine();
                        answer = Program.LetterUp(answer);

                        if (answer != "Y" && answer != "YES" && answer != "Yes" && answer != "J" && answer != "Ja" && answer != "JA")
                        {
                            do
                            {

                                Program.ClearLine();
                                Program.ClearLine();
                                Program.ClearLine();

                                Console.Write($"\nDeine Antwort ist: {answer}\nWelche Tür soll es sonst sein? ");
                            } while (!int.TryParse(Console.ReadLine(), out door));
                        }
                        else
                        {
                            do
                            {
                                Program.ClearLine();
                                Console.WriteLine($"\nIch muss dich enttäuschen... die Tür {door} lässt sich nicht Öffnen.\nWelche Tür soll es sonst sein?");
                            } while (!int.TryParse(Console.ReadLine(), out door));
                            answer = "n";
                        }
                        break;
                    case 3:
                        Console.WriteLine($"\nAlso Tür Nummer {door},\nbist du dir sicher?");
                        answer = Console.ReadLine();
                        answer = Program.LetterUp(answer);

                        if (answer != "Y" && answer != "YES" && answer != "Yes" && answer != "J" && answer != "Ja" && answer != "JA")
                        {
                            do
                            {

                                Program.ClearLine();
                                Program.ClearLine();
                                Program.ClearLine();

                                Console.Write($"\nDeine Antwort ist: {answer}\nWelche Tür soll es sonst sein? ");
                            } while (!int.TryParse(Console.ReadLine(), out door));
                        }
                        break;
                    case 4:
                        Console.WriteLine($"\nAlso Tür Nummer {door},\nbist du dir sicher?");
                        answer = Console.ReadLine();
                        answer = Program.LetterUp(answer);

                        if (answer != "Y" && answer != "YES" && answer != "Yes" && answer != "J" && answer != "Ja" && answer != "JA")
                        {
                            do
                            {

                                Program.ClearLine();
                                Program.ClearLine();
                                Program.ClearLine();

                                Console.Write($"\nDeine Antwort ist: {answer}\nWelche Tür soll es sonst sein? ");
                            } while (!int.TryParse(Console.ReadLine(), out door));
                        }
                        break;
                    default:
                        Console.WriteLine($"\nEs gibt keine Tür mit der Nummer {door}...");
                        answer = "n";
                        do
                        {
                            Console.Write($"\nAlso welche Tür soll es sonst sein? ");
                        } while (!int.TryParse(Console.ReadLine(), out door));
                        break;

                }
            } while (door != 1 && door != 3 && door != 4 || answer != "Y" && answer != "YES" && answer != "Yes" && answer != "J" && answer != "Ja" && answer != "JA");

            switch (door)
            {
                case 1:
                    Console.WriteLine($"Oh Backe, ob deine Eintscheidung so gut war?...\nNachdem du durch Tür Nummer {door} gegangen bist, ertönt ein schriller\nTon und die Tür fällt hinter dir zu....");
                    System.Threading.Thread.Sleep(5000);
                    //Console.Beep(6000, 3000);
                    break;
                case 3:
                    Console.WriteLine($"Beim öffnen von Tür {door}, bläst dir ein kalter Windzug einen modrigen Geruch ins Gesicht. Du betrittst vorsichtig den Raum...");
                    break;
                case 4:
                    Console.WriteLine($"Gute Wahl... du öffnest Tür {door} und während du die Tür hinter dir schließt, bemerkst du einen Zettel der auf\nder Rückseite klebt...");
                    break;
                default:
                    Console.WriteLine($"\nEs gibt keine Tür mit der Nummer {door}...");
                    answer = "n";
                    do
                    {
                        Console.Write($"\nAlso welche Tür soll es sonst sein? ");
                    } while (!int.TryParse(Console.ReadLine(), out door));
                    break;
            }
            return door;

        }
        /// <summary>
        /// Der Lichter Raum
        /// </summary>
        public static void RoomOne()
        {
            int count = 0;
            string stop = "";
            do
            {
                System.Threading.Thread.Sleep(100);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n________________________________________________________Raum 1_________________________________________________________\n\n");
                Console.Write("Was war das? Deine Ohren schmerzen, jetzt auch noch dieses Flackernde Licht und du bist noch immer nicht in\nFreiheit.");
                Console.Write(" Langsam aber sicher stellt sich bei dir der Gedanke ein, das du hier so schnell nicht wieder raus kommst.\nWenn doch nur diese Lampe normal leuchten würde...");
                if (count > 30)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n\nWas ist das?");

                }
                if (count > 60)
                {
                    Console.WriteLine("\nDrücke z");
                }

                System.Threading.Thread.Sleep(100);

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("\n________________________________________________________Raum 1_________________________________________________________\n\n");
                Console.Write("Was war das? Deine Ohren schmerzen, jetzt auch noch dieses Flackernde Licht und du bist noch immer nicht in\nFreiheit.");
                Console.Write(" Langsam aber sicher stellt sich bei dir der Gedanke ein, das du hier so schnell nicht wieder raus kommst.\nWenn doch nur diese Lampe normal leuchten würde...");
                if (count > 30)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("\n\nWas ist das?");
                }
                if (count > 60)
                {
                    Console.WriteLine("\nDrücke z");
                }
                ConsoleKey.Z.ToString(stop);



                count++;
                // Z Taste abfragen
            } while (count<1000);



            Console.ReadLine();
        }

        public static void RoomThree()
        {

        }

        public static void RoomFour()
        {

        }
    }
}
