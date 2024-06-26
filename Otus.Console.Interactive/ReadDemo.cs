﻿
namespace Otus.Console.Interactive
{
    using System;
    using System.Globalization;

    public static class ReadDemo
    {


        static void OutDemo(out string q)
        {
            q = "Привет";
        }

        public static void Demo()
        {

            //Greetings();
            //ShowRead();

            //ShowKeyInfo();
            //ShowReadLine();


            //var d = double.Parse("123.45");

            //Console.WriteLine(d * 2);



            	//ShowRead();


             //ShowReadLine();

            //var cultureInfo = CultureInfo.CurrentCulture;
            //CultureInfo.CurrentCulture = new CultureInfo("en-US");
            // var f1 = DateTime.TryParse("11.12.2022", out var d1);
            // var f2 = DateTime.TryParse("1/23/2022", out var d2);
            // var f3 = DateTime.TryParse("1/23/2022", new CultureInfo("en-US"), DateTimeStyles.None, out var d3);
            
            //return;
            
            //ShowCapitalized();
        }

        class Point
        {
            public int x;
            public int y;
        }

        class Person
        {
            public string FirstName;
            public string LastName;
        }

        public static void ShowKeyInfo()
        {
            // Создаю пустую строку
            var longString = string.Empty;

            //var p = new Point();

            //p.x = 2;
            //p.y = 2;

            //var person = "Эдгар Пилипсон";

            ConsoleKeyInfo key;
            do
            {
                Console.Write("Жду клавишу: ");
                key = Console.ReadKey();
                if (key.Key != ConsoleKey.Escape)
                {
                    // Добавляю символ, который ввел в строку
                    longString += key.KeyChar;

                    Console.WriteLine($"\nВы нажали клавишу {key.Key}, у нее символ '{key.KeyChar}', были дополнительные кнопки? Вот: {key.Modifiers}");
                    Console.WriteLine($"Строка теперь равна '{longString}'");
                }

            } while (key.Key != ConsoleKey.Escape);
        }


        /// <summary>
        /// Демо для парсинга
        /// </summary>
        public static void Parse()
        {
            string s;
            do
            {
                s = Console.ReadLine();

                var number = int.Parse(s);

                Console.WriteLine($"{number} на 2 = {number / 2}");

            } while (s != string.Empty);
        }



        public static void ShowReadLine()
        {
            string inputString;
            do
            {
                Console.Write("Введите целое число: ");
                inputString = Console.ReadLine();
                if (inputString != "")
                {

                }
                //var i = int.Parse(inputString);
                //Console.WriteLine($"Вы ввели строку, если прибавим к ней 100 то получим {i + 100}"); ;

                //var i = int.Parse(inputString);
                //Console.WriteLine($"Вы ввели строку, если прибавим к ней 1 то получим {i + 1}"); ;
                //var parsed = int.TryParse(inputString, out var i);
                
                //int i;
                var parsed = int.TryParse(inputString, out var i);

                if (parsed)
                {
                    Console.WriteLine($"Вы ввели строку, если прибавим к ней 1 то получим {i + 1}"); ;
                }
                else
                {
                    Console.WriteLine($"Вы ввели строку в некорректном формате '{inputString}'"); ;
                }
            } while (inputString != "");
        }


        /// <summary>
        /// Демонстрация приведения к верхнему регистру
        /// </summary>
        public static void ShowCapitalized()
        {
            ConsoleKeyInfo c;
            do
            {
                Console.Write("Введите букву: ");
                c = Console.ReadKey();

                Console.WriteLine();

                Console.WriteLine($"Ввели букву: {char.ToUpper(c.KeyChar)}");
            } while (c.Key != ConsoleKey.Escape);
        }


        /// <summary>
        /// Демонстрация приведения к верхнему регистру
        /// </summary>
        public static void ShowRead()
        {
            Console.WriteLine("Введите что-нибудь");
            var f = Console.Read();

            var c = (char)f;
            Console.WriteLine($"Символ код = {f} а символ значение = {c}");

            f = Console.Read();

            c = (char)f;
            Console.WriteLine($"Символ код = {f} а символ значение = {c}");
            f = Console.Read();
            Console.WriteLine($"Символ код = {f} а символ значение = {(char)f}");
            f = Console.Read();
            //return;

            //char ch;
            //Console.Write("Введите буквы: ");

            //do
            //{

            //    var c = Console.Read();

            //    Console.WriteLine();

            //    ch = (char)c;

            //    Console.Write($"Вы ввели букву '{ch}' у нее код по юникоду '{c}' ");

            //} while (ch != '+');
        }

        /// <summary>
        /// Программа считывает строку пользователя, и выводит его текст
        /// </summary>
        public static void Greetings()
        {
            string username;
            Console.WriteLine("Приветствую тебя, Пользователь! Как тебя зовут?");
            Console.Write("Меня зовут: ");

            username = Console.ReadLine();

            Console.WriteLine($"Очень приятно, {username}! Рад знакомству!");

            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
