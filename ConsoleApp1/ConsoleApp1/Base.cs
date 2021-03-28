using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Base
    {
        static void Main(string[] args)
        {
            var variables = new Variables();
            Console.WriteLine("Loaded libraries:\n" + "int num = " + variables.num + "\nuint uintnum = " +
                              variables.uintnum + "\nfloat floatnum = " + variables.floatnum + "\nbool boolean = " +
                              variables.boolean + "\nstring myString = " + variables.mystring + "\nchar myChar = " +
                              variables.myChar +
                              "\ndouble floatnum = " + variables.floatnumdouble + "\nint randNum = " + variables.randNum + 
                              "\nint randNum_2 = " + variables.randNum_2 + "\nint cycles = " + variables.cycles + 
                              "\nfloat[] foreachcycles = " + variables.foreachcycles +
                              "\nLoaded Constanta: \nconst float  cfscore = Cant load");
            Console.WriteLine("Hello World!");
            Console.WriteLine("First number: ");
            // Записываем в переменную ответ от польхователя и конвертим его в int (ToInt16 - short int, ToInt64 - long int)
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            int num_2 = Convert.ToInt32(Console.ReadLine());
            // ToString() - конвертит число в строку допустим.  В данном случае не обязателен
            Console.WriteLine("Result with plus equal: " + (num + num_2).ToString());
            Console.WriteLine("Result with minus equal: " + (num - num_2).ToString());
            Console.WriteLine("Result with multiply equal: " + (num * num_2).ToString());
            Console.WriteLine("Result with division equal: " + (num / num_2));
            Console.WriteLine("Result with plus one: " + num++);
            Console.WriteLine("Result with minus one: " + num--);
            //num ++ - прибавить единицу
            //num -- - отнять единицу
            Console.WriteLine("Press any key to start another program...");
            Console.ReadKey();
            Console.WriteLine("How old are you?");
            // Конвертим ответ пользователя в double
            variables.floatnumdouble = Convert.ToDouble(Console.ReadLine());
            // Почему после чилса стоит d? Это же мы сравниваем тип double и поэтому мы ставим d
            if (variables.floatnumdouble == 666.666d)
            {
                Console.WriteLine("Fucking Satanist out of here!");
            }
            else if (variables.floatnumdouble > 18.01d)
            {
                Console.WriteLine("YOU ARE OLDER THAN 18.01 OMG OMG OMG(or maybe not)");
            }
            else
            {
                Console.WriteLine("Stupid kid run away!");
            }
            
            Console.WriteLine("Okay, write the number(2 or 3)");
            variables.floatnumdouble = Convert.ToDouble(Console.ReadLine());
            //* && - оператор И, || - оператор ИЛИ *\\
            if (variables.floatnumdouble == 1.111d)
            {
                Console.WriteLine("Right!");
            }
            else
            {
                Console.WriteLine("Stipid, very stupid");
            }
            
            // Проверка в одну строчку
            //                   Переменная                  Число     if True    if false
            string yourmumname = variables.floatnumdouble == 1.666d ? "Valerya" : "NoName";
            Console.WriteLine(yourmumname);
            
            Console.WriteLine("Press any key to start another program...");
            Console.ReadKey();
            // Оператор switch-case. После каждой проверки надо писать break. как юзать: switch (переменная которую нужно сравнить){ case число с чем надо сравнить: код break; }
            switch (variables.randNum_2)
            {
                case 1:
                    Console.WriteLine("Equals 1");
                    break;
                case 5:
                    Console.WriteLine("Equals 5");
                    break;
                default:
                    Console.WriteLine("Equals " + variables.randNum_2);
                    break;
            }
            
            Console.WriteLine("Press any key to start another program...");
            Console.ReadKey();
            // Циклы
            // Цикл for 1 - переменная с присвоенным значение 2. Условие 3. Что будет выполняться при каждом обходе цикла с переменно(допусти cycles--)
            for (variables.cycles = 0; variables.cycles < 10; variables.cycles++)
            {
                if (variables.cycles == 6)
                {   
                    // continue - оператор в циклах, испольхуется для того чтобы пропустить итерацию цикла, то есть в
                    // нашем случае если cycles будет равно 6, то цикл пропустит это число
                    Console.WriteLine("Skipped iteration");
                    continue;
                }

                if (variables.cycles == 8)
                {   
                    // оператор break - выходит из цикла
                    Console.WriteLine("Cycle broke");
                    break;
                }
                Console.WriteLine("Variable Cycle is now(for cycle): " + variables.cycles);
            }

            variables.cycles = 0;
            while (variables.cycles < 10)
            {   
                Console.WriteLine("Variable Cycle is now(while cycle): " + variables.cycles);
                variables.cycles++;
            }

            variables.cycles = 0;
            // do-while - отличается тем, что ни важно условие или нет, оно выполнится один раз, даже если условие будет i > 50 но i будет равно 40
            do
            {
                Console.WriteLine("Variable Cycle is now(do while cycle): " + variables.cycles);
                variables.cycles++;
            } while (variables.cycles < 10);
            
            Console.WriteLine("Press any key to start another program...");
            Console.ReadKey();
            // Массивы
            // Создаем массив и в последних квадратных скобочках указываем длину массива, последнее число не учитывается
            int[] array = new int[5];
            // В массивах отчет начинается с нуля
            // Мы первый и шестой элемент изменяем на числа
            array[0] = 1;
            array[1] = 5;
            array[2] = 15;
            array[3] = 30;
            array[4] = 60;
            
            variables.cycles = 0;
            // Перебираем все элементы массива, Length - узнает длину массива
            for (variables.cycles = 0; variables.cycles < array.Length; variables.cycles++)
            {
                Console.WriteLine(variables.cycles + " iteration and value is " + array[variables.cycles]);
            }
            
            // Создаем массив с сразу присвоенными значениями
            string[] names = new string[]
            {
                "Tom", "John", "George"
            };
            
            variables.cycles = 0;
            for (variables.cycles = 0; variables.cycles < names.Length; variables.cycles++)
            {
                Console.WriteLine(variables.cycles + " iteration and value is " + names[variables.cycles]);
            }
            
            Console.WriteLine("Press any key to start working with lists...");
            Console.ReadKey();
            
            // Создаем список и необходимо импортировать System.Collections.Generic. Список жрет в два раза больше памяти чем массив.
            // Если вы не знаете какой длины будет массив, используйте список, если знаете лучше массив
            List<int> numbers = new List<int>();
            
            numbers.Add(150);
            numbers.Add(300);
            numbers.Add(450);
            numbers.Add(600);
            numbers.Add(750);
            numbers.Add(900);
            
            // RemoveAt - удаляет элемент из списка с указаным индексом в скобочках
            numbers.RemoveAt(0);
            // Remove - удаляет элемент из списка у которого значение равно тому что указано в скобках
            numbers.Remove(450);

            variables.cycles = 0;
            // Нам нужно со списками использовать не Length а Count, но опять же, это жрет много памяти
            for (variables.cycles = 0; variables.cycles < numbers.Count; variables.cycles++)
            {
                Console.WriteLine(variables.cycles + " iteration and value is " + numbers[variables.cycles]);
            }
            
            // Создаем двумерный массив, чем больше запятых, тем больше будет массив. например: 3 запятые трехмерный массив и т.дю
            int[,] moreNumbers = new int[5, 5];

            moreNumbers[1, 2] = 23;
            
            Console.WriteLine(moreNumbers[1, 2]);
            
            Console.WriteLine("Press any key to start another program...");
            Console.ReadKey();
            
            // 10 Урок - Цикл foreach
            
            // Первый аргумент - переменная(любая)
            // in
            // Второй аргумент - Где мы беребираем
            foreach (float el in variables.foreachcycles)
            {
                Console.WriteLine(el);
            }
            
            Console.WriteLine("Press any key to start another program...");
            Console.ReadKey();
            
            // 11 Урок - Методы и функции
            
            PrintLine("Enter first number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            PrintLine("Enter second number");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            
            // Вызываем функцию и передаем два аргумента
            Multiply(firstNum, secondNum);
            // Сохраняем возвращенные данные в переменную
            int divideResult = Divide(firstNum, secondNum);
            Console.WriteLine("Divide Result equals " + divideResult);
            
            Console.WriteLine("Press any key to start another program...");
            Console.ReadKey();
            
            // 12 Урок - Работа со строками
            // Выводим на экран вторую букву строки
            Console.WriteLine("Second letter");
            Console.WriteLine(variables.mystring[1]);
            // Выводим на экран шестую букву строки
            Console.WriteLine("Sixth letter");
            Console.WriteLine(variables.mystring[5]);
            // Выводим количество букв(символов) в строке
            Console.WriteLine("Length of mystring");
            Console.WriteLine(variables.mystring.Length);
            // Обращаемся к классу String и к методу IsNullOrEmpty - блягодаря ему мы можем узнать - пустая ли
            // строка(в ней ВООБЩЕ ничего не написано даже пробелов нет), в данный момент выведет False - потому что строка не пустая
            Console.WriteLine("Is string null or empty?");
            Console.WriteLine(String.IsNullOrEmpty(variables.mystring));
            // Такая же функция как и IsNullOrEmpty - но если в строке есть куча пробелов или же в ней вообще ничего нет то выведет - True
            Console.WriteLine("Is Null Or WhiteSpace?");
            Console.WriteLine(String.IsNullOrWhiteSpace(variables.mystring));
            
            // String Compare - сравнивает буквы в алфавитном порядке(то есть буквы как цифры можно сказать a - 1, b - 2, c - 3 и т.д) и выводит:
            // если первая буква меньше второй - выведет -1
            // если первая буква равна второй - выведет 0
            // если первая буква больше второй - выведет 1
            Console.WriteLine(String.Compare("a", "b")); // -1
            
            Console.WriteLine(String.Compare("a", "a")); // 0
            
            Console.WriteLine(String.Compare("b", "a")); // 1
            
            Console.WriteLine("string is so low");
            // ToLower() - метод для перевода строки в нижний регистр
            Console.WriteLine(variables.mystring.ToLower());
            
            Console.WriteLine("string is so high".ToUpper());
            // ToUpper() - метод для перевода строки в верхний регистр
            Console.WriteLine(variables.mystring.ToUpper());
            // Contains - проверяет, есть ли указаные буквы в строке(в нашем случае буквы way в строке mystring) и выводит True или False
            Console.WriteLine(variables.mystring.Contains("way")); // True

            Console.WriteLine(variables.mystring.Contains("hell")); // False
            // StartsWith - проверяет, начинается ли строка со строки которая указана в скобках(в нашем случае проверяем, начинается ли строка Run Away! с Run)
            Console.WriteLine(variables.mystring.StartsWith("Run")); // True

            Console.WriteLine(variables.mystring.StartsWith("un")); // False
            // EndsWith - тоже самое что и StartsWith, только проверяет не начинается ли, а заканчивается ли
            Console.WriteLine(variables.mystring.EndsWith("Away!")); // True

            Console.WriteLine(variables.mystring.EndsWith("Run")); // False
            // Insert - вставляет символы в строку, 1-ый параметр, индекс, 2-ой параметр, символы 
            Console.WriteLine(variables.mystring.Insert(5, "In"));
            // Remove - удаляет все в строке после указанного индекса
            Console.WriteLine(variables.mystring.Remove(5));
            // Replace - 1 аргумент - подстрока которую нужно заменить 2 аргумент - на что заменяем
            Console.WriteLine(variables.mystring.Replace("way", "yaw"));
            // ToCharArray - Переводит строку в массив из символов
            char[] symbolsArray = variables.mystring.ToCharArray();
            Console.WriteLine(symbolsArray[2]);
            string clubs = "Arsenal, Dynamo, Real";
            // Split - 1 аргумент - буква или строка, и строка которую указали будет разделятся после указанного символа
            // или строки(например строка: "Arsenal, Dynamo, Real" будет разделена на "Arsenal", "Dynamo", "Real")
            string[] clubsArray = clubs.Split(',');
            Console.WriteLine(clubsArray[1]);

            Console.WriteLine("Press any key to start another program...");
            Console.ReadKey();
            
            // 13 урок - Оператор try-catch
            
            Console.WriteLine("Enter Number: ");
            // если код не будет выдавать ошибку FormatException(не соответствие формата) то выполнится код в try. Иначе в catch
            // catch(тип эксепшена)
            // Также можно указать не FormatException а любой другой эксепшен, или просто Exception, и это будет значить что catch сработает на абсолютно любые экспепшионы
            // Типы эксепшионов - DivideByZeroException - деление на ноль, FileNotFoundException - когда файл не находит,
            // IndexOutOfRangeException - когда индекс заходит за пределы списков, массивов и т.д
            // Короче говоря как try-except в питоне
            // Можно указывать сколько угодно этих catch
            // то что в finally сработает 1000000000000000%
            try
            {
                int validingNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number is valid");
                // return - завершает весь код, но то что в finally все равно выполнится
                return; 
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception");
            }
            finally
            {
                Console.WriteLine("final");
            }
        }

        public static void PrintLine(string line)
        {
            Console.WriteLine(line);
        }
        // Создаем функцию которая принимает два аргумента
        // void - мы ничего не возвращаем
        public static void Multiply(int firstMulti, int secondMulti)
        {
            Console.WriteLine("Multiply Result equals " + firstMulti * secondMulti);
        }
        
        // тип данных указан(в нашем случае int) потому что мы уже возвращаем данные этого же типа(в нашем случае int)
        public static int Divide(int firstDivide, int secondDivide)
        {
            return firstDivide / secondDivide;
        }
        
    }
}