using System;
using System.Collections.Generic;



class Programm
{
    
    static (string name, string surname, int age, bool hasPet, int petsQuantity, string[] petsNames, int favColorsQuantity, string[] favColorsNames) getDataFromConsole()
    {
        (string name, string surname, int age, bool hasPet, int petsQuantity, string[] petsNames, int favColorsQuantity, string[] favColorsNames) dataSeq;
        Console.WriteLine("Enter your name:");
        dataSeq.name = Console.ReadLine();

        Console.WriteLine("Enter your surname:");
        dataSeq.surname = Console.ReadLine();

        Console.WriteLine("Enter your age:");
        
        while (!isCorrectInt(Console.ReadLine(), out dataSeq.age))
        {
            Console.WriteLine("{0}: incorrect age! Please enter age again...", dataSeq.age);
            //dataSeq.age = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Do you have pets(pets) [Y,N]:");

        dataSeq.hasPet = false;
        dataSeq.petsQuantity = 0;
        dataSeq.petsNames = null;
        if (Console.ReadLine() == "Y")
        {
            dataSeq.hasPet = true;
            Console.WriteLine("How many pets do you have?");
            while(!isCorrectInt(Console.ReadLine(), out dataSeq.petsQuantity))
            {
                Console.WriteLine("{0}: incorrect pets number! Please enter pets quantity again...", dataSeq.petsQuantity);
                //dataSeq.petsQuantity = int.Parse(Console.ReadLine());
            }

            dataSeq.petsNames = getPetsNames(dataSeq.petsQuantity);
        }

        Console.WriteLine("How many favorite colors do you have?");
        while (!isCorrectInt(Console.ReadLine(), out dataSeq.favColorsQuantity))
        {
            Console.WriteLine("{0}: incorrect favorite coloirs number! Please enter favorite colors number again...", dataSeq.favColorsQuantity);
            dataSeq.favColorsQuantity = int.Parse(Console.ReadLine());
        }
        dataSeq.favColorsNames = getFavColors(dataSeq.favColorsQuantity);

        return (dataSeq.name, dataSeq.surname, dataSeq.age, dataSeq.hasPet, dataSeq.petsQuantity, dataSeq.petsNames, dataSeq.favColorsQuantity, dataSeq.favColorsNames);


    }
    static string[] getPetsNames(in int petsQuantity)
    {
        string[] petsNames = new string[petsQuantity];

        for (int i = 0; i < petsQuantity; i++)
        {
            Console.WriteLine("Enter pet number {0} name:", i + 1);
            petsNames[i] = Console.ReadLine();
        }
        return petsNames;
    }
    static bool isCorrectInt(in string strNum, out int number)
    {
        int tempInt;
        number = 0;
        if (int.TryParse(strNum, out tempInt))
        {
            if (tempInt < 0)
            {
                return false;
            }
            number = tempInt;
        }
        else
        {
            return false;
        }
        return true;
    }
    static string[] getFavColors(in int favColorsNum)
    {
        string[] favColors = new string[favColorsNum];
        if (favColorsNum > 0 )
        {
            for (int i=0; i < favColorsNum; i++)
            {
                Console.WriteLine("Enter favorite color number {0}:", i + 1);
                favColors[i] = Console.ReadLine();
            }
        }
        return favColors;
    }

    static void printData((string name, string surname, int age, bool hasPet, int petsQuantity, string[] petsNames, int favColorsQuantity, string[] favColorsNames) dataSeq)
    {
        Console.WriteLine("Your name is: {0}", dataSeq.name);
        Console.WriteLine("Your surname is: {0}", dataSeq.surname);
        Console.WriteLine("Your age is: {0}", dataSeq.age);
        if(dataSeq.hasPet)
        {
            Console.WriteLine("Your have {0} pet(s). Their names:", dataSeq.petsQuantity);
            for (int i=0; i < dataSeq.petsNames.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, dataSeq.petsNames[i]);
            }
        }
        else
        {
            Console.WriteLine("Your have no pet.");
        }

        Console.WriteLine("You have {0} favorite colors. They are:", dataSeq.favColorsQuantity);
        for (int i=0; i < dataSeq.favColorsNames.Length; i++)
        {
            Console.WriteLine("{0}: {1}", i + 1, dataSeq.favColorsNames[i]);
        }

    }

    public static void Main(string[] args)
    {

        (string name, string surname, int age, bool hasPet, int petsQuantity, string[] petsNames, int favColorsQuantity, string[] favColorsNames) userData = getDataFromConsole();
        printData(userData);

    }


}