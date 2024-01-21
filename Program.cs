using System;

class MainClass
{
    public static void Main(string[] args)
    {
        (string username, string surname, string login, int loginLength, bool hasPet, int age, string[] favColor) User;
        
        for (int k = 0; k <3; k++)
        {
            Console.WriteLine("Введите имя");
            User.username = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.surname = Console.ReadLine();
            Console.WriteLine("Введите логин");
            User.login = Console.ReadLine(); ;
            User.loginLength = User.login.Length;
            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            if (Console.ReadLine() == "Да")
            {
                User.hasPet = true;
            }
            else
            {
                User.hasPet = false;
            }
            Console.WriteLine("Введите возраст пользователя");
            User.age = int.Parse(Console.ReadLine());

            User.favColor = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя");
            for (int i = 0; i < User.favColor.Length; i++)
            {
                User.favColor[i] = Console.ReadLine();
            }
        }

    }
    
}