using System;
using System.Globalization;
using System.Text;

namespace StringBasicsMetods
{
    class Program
    {
        static void Main(string[] args)
        {
            //BasicsMetodString();
            //StringEmpty();
            //StringModifications();
            //StringBuilder();
            //FormatString();
        } 

        static void BasicsMetodString()
        {
            string str = "abracadabra";
            bool containsA = str.Contains('a'); // Содержит ли строка этот символ?

            Console.WriteLine(containsA);

            bool endsWithAbra = str.EndsWith("abra"); //оканчивается ли строка на эту подстроку? 4П
            bool startWithAbra = str.StartsWith("abra"); //насинается ли строка на эту подстроку? 4П
            Console.WriteLine(endsWithAbra);
            Console.WriteLine(startWithAbra);

            int indexOfa = str.IndexOf('a'); // ищет первое вхождение этого символа. 9П
            int lastIndexOfa = str.LastIndexOf('a'); // ищет последнее вхождение этого символа. 9П
            Console.WriteLine(indexOfa);
            Console.WriteLine(lastIndexOfa);

            Console.WriteLine(str.Length); // Это свойство выводит длину строки

           string substrFrom5 = str.Substring(5); // Взятие подстроки c пятого элемента по индексу
           string substrFrom0to3 = str.Substring(0,3); // Взятие подстроки c 0uj элемента до 3 по индексу
            Console.WriteLine(substrFrom5);
            Console.WriteLine(substrFrom0to3);
        }
        static void FormatStr() // форматирование строк
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and i`m {1}", name, age);

            string str2 = $"My name is {name} and i`m {age}"; // $ - интерпалирование строк

            str2 = $"My name is {Environment.NewLine}{name}"; // перевод строки раьотающий одинаково для разных систем.

            //string str2 = "My name is " + name + "and i`m " + age;

            //Console.WriteLine(str2);

            int answer = 42;
            string result = string.Format("{0:d}", answer);
            Console.WriteLine(result);
            string result2 = string.Format("{0:d4}", answer); // вывод 4х символов дополняет слева нулями если число меньше 4х символов
            Console.WriteLine(result2);

            double answer2 = 43.08;
            string result3 = string.Format("{0:f}", answer);
            Console.WriteLine(result3);
            string result4 = string.Format("{0:f4}", answer); // вывод 4х символов после запятой. Так же производит округление.
            Console.WriteLine(result4);

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.5;

            result = String.Format("{0:C}", money); // форматированый вывод в денежном формате
            result2 = String.Format("{0:C2}", money);
            Console.WriteLine(money.ToString("C2")); // такая запись более приемлимая string.format почти не используют
            Console.WriteLine(result2);
        }       
        static void StringEmpty()
        {
            string str = string.Empty; // эквивалентно  string empty = "";

            string empty = "";
            string whiteSpaced = " ";
            string notEmty = " b";
            string nullString = null;

            Console.WriteLine("IsNullOrEmty");
            Console.WriteLine();

            bool isNullorEmty = string.IsNullOrEmpty(empty); // 
            Console.WriteLine(isNullorEmty);

            isNullorEmty = string.IsNullOrEmpty(whiteSpaced); // 
            Console.WriteLine(isNullorEmty);

            isNullorEmty = string.IsNullOrEmpty(notEmty); // 
            Console.WriteLine(isNullorEmty);

            isNullorEmty = string.IsNullOrEmpty(nullString); // 
            Console.WriteLine(isNullorEmty);

            Console.WriteLine();

            Console.WriteLine("IsNullOrWhiteSpace");
            Console.WriteLine();

            bool IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty); // 
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced); // 
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmty); // 
            Console.WriteLine(IsNullOrWhiteSpace);

            IsNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString); // 
            Console.WriteLine(IsNullOrWhiteSpace);
        }
        static void StringModifications()
        {
            string nameContact = string.Concat("My ", "name ", "is ", "John"); // конкатенация строк
            Console.WriteLine(nameContact);

            nameContact = string.Join(" ", "My", "name", "is", "John"); // также объяеденяет строки но можно указатьразделитель
            Console.WriteLine(nameContact);

            nameContact = nameContact.Insert(0, "By the way, "); // вставка строки по индексу. Работает только с присвоением!
            Console.WriteLine(nameContact);

            nameContact = nameContact.Remove(0, 1); // удаление подстроки с определенного индекса или кол-во символов с опр. индекса
            Console.WriteLine(nameContact);

            string replaced = nameContact.Replace('n', 'T'); // замена букв
            Console.WriteLine(replaced);

            string data = "12:38:34:58";
            string[] splitDate = data.Split(':'); // извлекает данные в массив между разделителями ':'
            string first = splitDate[0];
            Console.WriteLine(first);

            char[] chars = nameContact.ToCharArray(); // перезапись в массив символов
            Console.WriteLine(chars[2]);


            string lower = nameContact.ToLower(); // привести к нижнему регистру 
            Console.WriteLine(lower);

            string upper = nameContact.ToUpper(); // привести к верхнему регистру 
            Console.WriteLine(upper);

            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine($"To titlecase: {myTI.ToTitleCase(nameContact)}"); // Первая буква в верхнем регистре

            string john = " My name is John ";
            Console.WriteLine(john.Trim()); // обрезвет крайнии пробелы
        }
        static void StringBuilder()
        {
            // можно модифицировать в отличии от string где только присвоение.
             // самый выстрый способ складывания строк
            StringBuilder sb = new StringBuilder(); // работает более оптимизированно к памяти чем любая конкатенация
            sb.Append("My "); // добавление к строке
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John ");

            sb.AppendLine("Hello!"); // добавление с переводом строки
            string str = sb.ToString();
            Console.WriteLine(str);

        }
        static void FormatString()
        {
            int age = 30;
            string name = "John";
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            string str2 = $"My name is {name} and I'm {age}"; // интерпалирование строк

            string str3 = $"My name i {Environment.NewLine}John"; // Кроссплатформенный перевод строк

            Console.WriteLine(str2);

            int answer = 32;
            string result1 = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);

            Console.OutputEncoding = Encoding.UTF8; // вывод в консоль в кодировке UTF8

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(answer.ToString("C2"));

        }
    }
}
