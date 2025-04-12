namespace BSTApp;

public static class BinaryTreeHelpers
{
    //освобождение памяти, выделенной под бинарное дерево 
    public static BinarySearchTree DeleteBinaryTree(BinarySearchTree tree)
    {
        tree.Root = null;
        return tree;
        
        /*
        if (tree.Root!=null)
        {
            if (tree.Root.Left!=null) tree.Remove(tree.Root.Left.Key);
            if (tree.Root.Right!=null) tree.Remove(tree.Root.Right.Key);
            tree.Root = null;
        }
        return tree;
        */
    }

    //ввести элементы дерева с клавиатуры;
    public static void ReadBsTree(BinarySearchTree bstree, int n)
    {
        Console.WriteLine("Введите элементы дерева:");
        for (int i = 0; i < n; i++)
        {
            //вводим элемент дерева и добавляем его в дерево
            bstree.Add(Convert.ToInt32(Console.ReadLine()));
        }
    }

    //заполнение массива случайными числами
    public static void CreateArray(ref int[] A, int n)
    {
        //заполнение массива случайными числами
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            A[i] = rand.Next(0, n);//Заполняем случайными числами диапозоном от 0 до n;
        }
    }

    //поиск в массиве заданного значения
    public static void SearchArray(int[] A, int k, ref int P)
    {
        int n = A.Length; //считываем длину массива
        for (int i = 0; i < n; i++)
        {
            //пока не найден нужный элемент, сравниваем каждый элемента массива с искомым
            if (A[i] == k)
            {
                //если нашли искомый
                P++; //увеличваем счётчик сравнение
                return;//завершаем работу подпрограммы
            }
            else
            {
                //если не нашли, увеличиваем счётчик
                P++;
            }
        }
    }

    //заполнение дерева случайными числами
    public static void CreateBSTRandom(ref BinarySearchTree bstree, int n)
    {
        //создаем рандомайзер
        Random rand = new Random();
        //задаем последовательность случайных чисел длиной n
        for (int i = 0; i < n; i++)
        {
            int t = rand.Next(0, n); // получаем случайное число от 0 до n
            Console.Write(t + " "); // выводим на консоль
            bstree.Add(t);//добавляем случайное число в дерево
        }
    }

    //заполнение дерева из массива
    public static void CreateBSTArray(ref BinarySearchTree bstree, int[] A)
    {
        //считываем длину массива
        int n =A.Length;
        for (int i = 0; i < n; i++)
        {
             bstree.Add(A[i]);//добавляем значение массива в дерево
        }
    }
}