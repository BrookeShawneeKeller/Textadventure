using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("************************************************************************************************************************");
        Console.WriteLine("************************************************************************************************************************");
        Console.WriteLine("************************************************************************************************************************");
        Console.WriteLine("************************************************************************************************************************");
        Console.WriteLine("Drücke die a-Taste und bestätige das Spiel mit ENTER");

        string starteingabe = Console.ReadLine();
        if(starteingabe == "a")
        {
            // a wurde eingegeben. Das Spiel startet.
            System.Console.Clear();
            Console.WriteLine("Du bist im Schloss und läufst einen Gang entlang.");
            Console.WriteLine("Am Ende des Ganges gibt es zwei Türen. Welche Tür wählst du? (a oder b)");

            char choice1 = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (choice1 == 'a')
            {
                Console.WriteLine("Hinter dieser Tür ist ein giftiger Zaubertrank, und du stirbst.");
                GameOver();
            }
            else if (choice1 == 'b')
            {
                Console.WriteLine("Hinter dieser Tür ist ein Zaubertrank, und du kannst aus zwei Wünschen auswählen.");
                Console.WriteLine("Wähle einen Wunsch: (a) Fliegen oder (b) Durch Wände gehen");

                char choice2 = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice2 == 'a')
                {
                    Console.WriteLine("Du fliegst aus dem Fenster und ein Raubvogel entdeckt dich und verspeist dich zum Znacht.");
                    GameOver();
                }
                else if (choice2 == 'b')
                {
                    Console.WriteLine("Du gehst durch die Wand, und links neben dir taucht ein Drache auf.");
                    Console.WriteLine("Entscheide dich: (a) Für die Flucht oder (b) Kämpfe gegen den Drachen");

                    char choice3 = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    if (choice3 == 'a')
                    {
                        Console.WriteLine("Der Drache verfolgt dich, ist schneller als du und verspeist dich bei lebendigem Leib.");
                        GameOver();
                    }
                    else if (choice3 == 'b')
                    {
                        Console.WriteLine("Du kämpfst gegen den Drachen, tötest ihn und erhältst seine Fähigkeit, Feuer zu spucken.");
                        Console.WriteLine("Das beeindruckt die Prinzessin so sehr, dass sie mit dir zusammen sein will.");
                        Console.WriteLine("Ihr heiratet, und jetzt kannst du euer Hochzeitsmenü aussuchen.");
                        Console.WriteLine("Herzlichen Glückwunsch, du hast das Spiel gewonnen!");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Das Spiel endet.");
                        GameOver();
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Das Spiel endet.");
                    GameOver();
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Das Spiel endet.");
                GameOver();
            }
        }
        else
        {
            //falsche Eingabe! Das Spiel wird beendet.
            Console.WriteLine("Du hast nicht a eingegeben, sondern" + starteingabe + ".Das Spiel wird beebdet.");
        }

        
    }

    private static void GameOver()
    {
        throw new NotImplementedException();
    }
}



