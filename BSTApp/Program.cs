using System.Text;
using BSTApp;

BstNode[] binarytree = new BstNode[10];



const string PressAnyKey = "\nНажмите любую клавишу...";
var bst = new BinarySearchTree();//создаем бинарное дерево поиска
 //заполнение дерева
 do
 {
     int k0;
     int item;
     do
     {
         //создаем меню
         Console.Clear();
         Console.WriteLine("\nВыберите одно из следующих действий:");
         Console.WriteLine(" 1. Создание дерева случайным образом");
         Console.WriteLine(" 2. Загрузка дерева из файла");
         Console.WriteLine(" 3. Ввод дерева с клавиатуры");
         if (bst.Root == null)
         {
             Console.WriteLine(" 4. Выход из прогрвммы");
             k0 = 4;
         }
         else
         {
             Console.WriteLine(" 4. Обход дерева");
             Console.WriteLine(" 5. Добавление узла в дерево");
             Console.WriteLine(" 6. Поиск узла в дереве");
             Console.WriteLine(" 7. Удаление узла из дерева");
             Console.WriteLine(" 8. Статистика сравнений при поиске");
             Console.WriteLine(" 9. Выход в Windows");
             k0 = 9;
         }

         Console.Write("\n Введите номер выбранного действия: ");
         item = 0;
         try
         {
             item = Convert.ToInt16(Console.ReadLine());
         }
         catch (FormatException ex)
         {
             Console.WriteLine("\nНеобходимо вводить целые числа от 1 до " + Convert.ToString(k0) + PressAnyKey);
             Console.ReadKey();
         }
     } while (item < 1 || item > k0);

     switch (item)
     {
         case 1:
         {
             // Создание нового дерева из случайного набора чисел
             bst = BinaryTreeHelpers.DeleteBinaryTree(bst);
             Console.WriteLine("Создание нового дерева случайным образом");
             Console.WriteLine();
             Console.WriteLine("Введите размер последовательности случайных чисел:");
             int cnt = Convert.ToInt32(Console.ReadLine());
             BinaryTreeHelpers.CreateBSTRandom(ref bst, cnt);
             Console.WriteLine();
             Console.ReadKey();
             break;
         }
         case 2:
         {
             // Создание нового дерева из файла
             bst = BinaryTreeHelpers.DeleteBinaryTree(bst);
             Console.WriteLine("Создание нового дерева из файла");
             Console.WriteLine();
             Console.WriteLine("Введите полное имя файла:");
             string? filname = Console.ReadLine();
             //открываем файл
             if (File.Exists(filname))
             {
                 StreamReader sr = new StreamReader(filname, Encoding.Default);
                 int k;
                 //пока файл не закончился
                 while (sr.EndOfStream != true)
                 {
                     string s = sr.ReadLine()!; //считываем строку
                     k = Convert.ToInt32(s); //конвертируем в число
                     bst.Add(k);
                 } //завершение считывания файла

                 sr.Close(); //закрываем файл
                 Console.WriteLine();
                 Console.WriteLine("Обход дерева в симметричном порядке:");
                 string str = "";
                 bst.WalkInOrder(bst.Root, ref str, 0);
                 Console.WriteLine();
                 Console.WriteLine(str);
                 Console.WriteLine();
             }
             else
             {
                 Console.WriteLine("Файл не найден!");
             }

             Console.ReadKey();
             break;
         }
         case 3:
         {
             // Создание нового дерева вводом с клавиатуры
             bst = BinaryTreeHelpers.DeleteBinaryTree(bst);
             Console.WriteLine("Создание нового дерева, ввод с клавиатуры");
             Console.WriteLine();
             Console.WriteLine("Введите размер последовательности случайных чисел:");
             int cnt = Convert.ToInt32(Console.ReadLine());
             BinaryTreeHelpers.ReadBsTree(bst, cnt);
             Console.WriteLine();
             Console.ReadKey();
             break;
         }
         case 4:
         {
             if (k0 == 4)
             {
                 item = 0; // Реализация выхода из приложения
                 break;
             }

             //реализация различных обходов
             Console.WriteLine();
             Console.WriteLine("Обход дерева в прямом порядке:");
             string str = "";
             bst.WalkPreOrder(bst.Root!, ref str, 0);
             Console.WriteLine();
             Console.WriteLine(str);
             Console.WriteLine();
             Console.WriteLine("Обход дерева в обратном порядке:");
             str = "";
             bst.WalkPostOrder(bst.Root!, ref str, 0);
             Console.WriteLine();
             Console.WriteLine(str);
             Console.WriteLine();
             Console.WriteLine("Обход дерева в симметричном порядке:");
             str = "";
             bst.WalkInOrder(bst.Root!, ref str, 0);
             Console.WriteLine();
             Console.WriteLine(str);
             Console.WriteLine();
             Console.WriteLine("Обход дерева в ширину:");
             bst.WalkBFS(bst.Root!);
             Console.WriteLine();
             Console.ReadKey();
             break;
         }
         case 5:
         {
             //реализация добавления нового элемента в дерево
             Console.WriteLine();
             Console.WriteLine("Введите значение, которое нужно добавить в дерево:");
             int p = Convert.ToInt32(Console.ReadLine());
             bst.Add(p);
             Console.WriteLine();
             Console.WriteLine("Обход дерева в симметричном порядке:");
             string str = "";
             bst.WalkInOrder(bst.Root!, ref str, 0);
             Console.WriteLine();
             Console.WriteLine(str);
             Console.WriteLine();
             Console.ReadKey();
             break;
         }
         case 6:
         {
             //вывод минимального и максимального значений в дереве
             Console.WriteLine("Минимальное и максимальное значения в дереве");
             Console.WriteLine(bst.GetMinValue(bst.Root!));
             Console.WriteLine(bst.GetMaxValue(bst.Root!));
             Console.WriteLine();
             //реализация поиска элемента в дереве
             Console.WriteLine("Введите число для поиска:");
             int p = Convert.ToInt32(Console.ReadLine());
             int cc = 0;
             BstNode? tmp = bst.Search(p, bst.Root, ref cc);
             if (tmp != null)
             {
                 Console.WriteLine("Имеется в наборе: {0}", tmp.Count);
                 Console.WriteLine("сравнений: {0}", cc);
             }
             else
             {
                 Console.WriteLine("Нет такого значения! Сравнений: {0}", cc);
             }

             //поиск следующего элемента в дереве
             Console.WriteLine("Следующий элемент: {0}", bst.Next(p)?.Key);
             Console.WriteLine();
             Console.WriteLine("Предыдущий элемент: {0}", bst.Prev(p)?.Key);
             Console.WriteLine();
             Console.ReadKey();
             break;
         }
         case 7:
         {
             //реализация удаления узла по значению из дерева
             Console.WriteLine("Введите узел для удаления:");
             int p = Convert.ToInt32(Console.ReadLine());
             if (bst.Remove(p))
             {
                 Console.WriteLine("Узел {0} удален", p);
                 Console.WriteLine();
                 Console.WriteLine("Обход дерева в симметричном порядке:");
                 string str = "";
                 bst.WalkInOrder(bst.Root, ref str, 0);
                 Console.WriteLine();
                 Console.WriteLine(str);
             }
             else
             {
                 Console.WriteLine("Нет такого узла!");
             }

             Console.WriteLine();
             Console.ReadKey();
             break;
         }
         case 8:
         {
             //подсчёт сравнений при поиске в дереве и массиве
             for (int i = 10; i < 110; i += 10)
             {
                 int k = i / 2; //задаем число для поиска - половину от длины массива
                 int S = 0; //счетчик сравнений поиске в дереве
                 int P = 0; //счетчик сравнений при поиске в массиве
                 int P1 = 0; //счетчик сравнений при поиске в отсортированном массиве
                 int[] Arr = new int[i]; //создаем массив
                 int[] Arr1 = new int[i];
                 for (int t = 0; t < 1000; t++)
                 {
                     BinaryTreeHelpers.CreateArray(ref Arr, i); //заполняем массив случайными числами от 0 до i
                     Array.Copy(Arr, Arr1, i);
                     Array.Sort(Arr1);
                     BinaryTreeHelpers.CreateBSTArray(ref bst, Arr); //создаем дерево на основе массива
                     bst.Search(k, bst.Root, ref S); //проводим поиск в дереве
                     BinaryTreeHelpers.SearchArray(Arr, k, ref P); //проводим поиск в массиве
                     BinaryTreeHelpers.SearchArray(Arr1, k, ref P1); //проводим поиск в отсортированном массиве
                 }

                 float res1 = (float)S / 1000; //считаем среднее число сравнений по всем повторам
                 float res2 = (float)P / 1000;
                 float res3 = (float)P1 / 1000;
                 //вывод на экран
                 Console.WriteLine("{0} {1} {2} {3} {4}", i, k, res1, res2, res3);
             }

             for (int i = 200; i < 500; i += 100)
             {
                 int k = i / 2; //задаем число для поиска - половину от длины массива
                 int S = 0; //счетчик сравнений поиске в дереве
                 int P = 0; //счетчик сравнений при поиске в массиве
                 int P1 = 0; //счетчик сравнений при поиске в отсортированном массиве
                 int[] Arr = new int[i]; //создаем массив
                 int[] Arr1 = new int[i];
                 for (int t = 0; t < 1000; t++)
                 {
                     BinaryTreeHelpers.CreateArray(ref Arr, i); //заполняем массив случайными числами от 0 до i
                     Array.Copy(Arr, Arr1, i);
                     Array.Sort(Arr1);
                     BinaryTreeHelpers.CreateBSTArray(ref bst, Arr); //создаем дерево на основе массива
                     bst.Search(k, bst.Root, ref S); //проводим поиск в дереве
                     BinaryTreeHelpers.SearchArray(Arr, k, ref P); //проводим поиск в массиве
                     BinaryTreeHelpers.SearchArray(Arr1, k, ref P1); //проводим поиск в отсортированном массиве
                 }

                 float res1 = (float)S / 1000; //считаем среднее число сравнений по всем повторам
                 float res2 = (float)P / 1000;
                 float res3 = (float)P1 / 1000;
                 //вывод на экран
                 Console.WriteLine("{0} {1} {2} {3} {4}", i, k, res1, res2, res3);
             }

             for (int i = 500; i < 1100; i += 500)
             {
                 int k = i / 2; //задаем число для поиска - половину от длины массива
                 int S = 0; //счетчик сравнений поиске в дереве
                 int P = 0; //счетчик сравнений при поиске в массиве
                 int P1 = 0; //счетчик сравнений при поиске в отсортированном массиве
                 int[] Arr = new int[i]; //создаем массив
                 int[] Arr1 = new int[i];
                 for (int t = 0; t < 1000; t++)
                 {
                     BinaryTreeHelpers.CreateArray(ref Arr, i); //заполняем массив случайными числами от 0 до i
                     Array.Copy(Arr, Arr1, i);
                     Array.Sort(Arr1);
                     BinaryTreeHelpers.CreateBSTArray(ref bst, Arr); //создаем дерево на основе массива
                     bst.Search(k, bst.Root, ref S); //проводим поиск в дереве
                     BinaryTreeHelpers.SearchArray(Arr, k, ref P); //проводим поиск в массиве
                     BinaryTreeHelpers.SearchArray(Arr1, k, ref P1); //проводим поиск в отсортированном массиве
                 }

                 float res1 = (float)S / 1000; //считаем среднее число сравнений по всем повторам
                 float res2 = (float)P / 1000;
                 float res3 = (float)P1 / 1000;
                 //вывод на экран
                 Console.WriteLine("{0} {1} {2} {3} {4}", i, k, res1, res2, res3);
             }

             for (int i = 5000; i < 11000; i += 5000)
             {
                 int k = i / 2; //задаем число для поиска - половину от длины массива
                 int S = 0; //счетчик сравнений поиске в дереве
                 int P = 0; //счетчик сравнений при поиске в массиве
                 int P1 = 0; //счетчик сравнений при поиске в отсортированном массиве
                 int[] Arr = new int[i]; //создаем массив
                 int[] Arr1 = new int[i];
                 for (int t = 0; t < 1000; t++)
                 {
                     BinaryTreeHelpers.CreateArray(ref Arr, i); //заполняем массив случайными числами от 0 до i
                     Array.Copy(Arr, Arr1, i);
                     Array.Sort(Arr1);
                     BinaryTreeHelpers.CreateBSTArray(ref bst, Arr); //создаем дерево на основе массива
                     bst.Search(k, bst.Root, ref S); //проводим поиск в дереве
                     BinaryTreeHelpers.SearchArray(Arr, k, ref P); //проводим поиск в массиве
                     BinaryTreeHelpers.SearchArray(Arr1, k, ref P1); //проводим поиск в отсортированном массиве
                 }

                 float res1 = (float)S / 1000; //считаем среднее число сравнений по всем повторам
                 float res2 = (float)P / 1000;
                 float res3 = (float)P1 / 1000;
                 //вывод на экран
                 Console.WriteLine("{0} {1} {2} {3} {4}", i, k, res1, res2, res3);
             }

             Console.WriteLine();
             Console.ReadKey();
             break;
         }
         case 9:
         {
             item = 0; // Реализация выхода из приложения
             break;
         }
         // … другие действия, если список существует
     }

     if (item == 0) break;
 } while (true);