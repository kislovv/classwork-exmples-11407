namespace BSTApp;

public class BinarySearchTree
{
    public BstNode? Root { get; set; } //корень дерева

    public BinarySearchTree()
    {
        Root = null;
    }

    public BinarySearchTree(int num)
    {
        Root = new BstNode(num);
    }

    public void Add(int num) //Добавление нового узла в дерево
    {
        if (Root == null)//если дерево пусто, то создаем корень дерева
        {
            Root = new BstNode(num);
            return;
        }
        //проверяем, есть ли потомки у текущего узла
        BstNode current = Root;
        while (current.Left != null || current.Right != null)//переходим к соответствующему узлу
        {
            if (current.Key > num)
            {
                if (current.Left == null) break;
                current = current.Left; //запоминаем текущий узел
            }
            else
            {
                if (current.Key < num)
                {
                    if (current.Right == null) break;
                    current = current.Right;
                }
                else
                {
                    current.Count ++; //если такой узел уже существует, увеличиваем счётчик
                    return;
                }
            }
        }
        //выбираем место вставки нового узла (справа или слева)
        if (current.Key <= num)
        {
            if (current.Key < num)
            {
                current.Right = new BstNode(num);
            }
            else
            {
                current.Count ++; //если такой лист уже существует, увеличиваем счётчик
            }
        }
        else
        {
            current.Left = new BstNode(num);
        }
    }

    public int GetMinValue(BstNode theRoot) //Минимальное значение в поддереве (самый левый лист)
    {
        var minValue = theRoot.Key;
        while (theRoot.Left != null)
        {
            minValue = theRoot.Left.Key;
            theRoot = theRoot.Left;
        }
        return minValue;
    }

    public int GetMaxValue(BstNode theRoot) //Максимальное значение в поддереве (самый правый лист)
    {
        var maxValue = theRoot.Key;
        while (theRoot.Right != null)
        {
            maxValue = theRoot.Right.Key;
            theRoot = theRoot.Right;
        }
        return maxValue;
    }

    public BstNode? Next(int data)
    {
        // root — корень дерева
        BstNode? current = Root;
        BstNode? successor = null;
        while (current != null)
        {
            if (current.Key > data)
            {
                successor = current;
                current = current.Left;
            }
            else
            {
                current = current.Right;
            }
        }
        return successor;
    }

    public BstNode? Prev(int data)
    {
        // root — корень дерева
        BstNode? current = Root, successor = null;
        while (current != null)
        {
            if (current.Key < data)
            {
                successor = current;
                current = current.Right;
            }
            else
            {
                current = current.Left;
            }
        }
        return successor;
    }

    //Поиск в бинарном дереве 
    public BstNode? Search(int element, BstNode? root, ref int cnt)
    {
        if (root == null) return null;//если дерево пусто (прошли всё дерево и вышли к корню), то возвращем null
        if (element == root.Key) //если нашли искомый элемент
        {
            cnt++; //увеличиваем счётчик сравнений
            return root; //возвращаем узел с нужным ключом
        }

        if (root.Key > element) //если ключ текущего узла больше искомого значения
        {
            cnt++;//увеличиваем счётчик сравнений
            return Search(element, root.Left, ref cnt); //возвращаем результат поиска в левом потомке текущего узла
        }
        else //если ключ текущего узла меньше искомого значения
        {
            cnt++;//увеличиваем счётчик сравнений
            return Search(element, root.Right, ref cnt);//возвращаем результат поиска в правом потомке текущего узла
        }
    }

    //обход дерева в симметричном порядке
    public void WalkInOrder(BstNode? theRoot, ref string s, int lvl = 0)
    {
        if (theRoot == null) return; // Если корень пуст, выходим

        // Обходим левое поддерево
        WalkInOrder(theRoot.Left, ref s, lvl + 1);

        // Обрабатываем текущий узел
        Console.Write($"{theRoot},");
        var spaces = new string(' ', lvl * 5);
        s += $"{spaces}[{theRoot}]\n";

        // Обходим правое поддерево
        WalkInOrder(theRoot.Right, ref s, lvl + 1);
    }

    //обход дерева в прямом порядке
    public void WalkPreOrder(BstNode? theRoot, ref string s, int lvl)
    {
        if (theRoot == null) return; // Если корень пуст, выходим

        // Обрабатываем текущий узел
        Console.Write($"{theRoot},");
        var spaces = new string(' ', lvl * 5);
        s += $"{spaces}[{theRoot}]\n";

        // Рекурсивный обход левого и правого поддеревьев
        WalkPreOrder(theRoot.Left, ref s, lvl + 1);
        WalkPreOrder(theRoot.Right, ref s, lvl + 1);
    }

    //обход дерева в обратном порядке
    public void WalkPostOrder(BstNode? theRoot, ref string s, int lvl)
    {
        if (theRoot == null) return; // Если корень пуст, выходим

        // Рекурсивный обход левого и правого поддеревьев
        WalkPostOrder(theRoot.Left, ref s, lvl + 1);
        WalkPostOrder(theRoot.Right, ref s, lvl + 1);

        // Обрабатываем текущий узел
        Console.Write($"{theRoot},");
        var spaces = new string(' ', lvl * 5);
        s += $"{spaces}[{theRoot}]\n";
    }

    //обход дерева в ширину
    public void WalkBFS(BstNode? theRoot)
    {
        if (theRoot == null) return; // Проверка на пустое дерево

        // Для обхода в ширину используем очередь
        Queue<BstNode> bfsQueue = new Queue<BstNode>();
        bfsQueue.Enqueue(theRoot); // Добавляем корень в очередь

        while (bfsQueue.Any()) // Пока в очереди есть узлы
        {
            var current = bfsQueue.Dequeue(); // Извлекаем узел из очереди
            Console.Write($"{current},");

            // Добавляем потомков в очередь, если они существуют
            if (current.Left != null)
                bfsQueue.Enqueue(current.Left);
            if (current.Right != null)
                bfsQueue.Enqueue(current.Right);
        }
    }

    //удаление узла из дерева
    public bool Remove(int data)
    {
        Root = Remove(Root, data);
        return Root != null;
    }
    private BstNode Remove(BstNode root, int data)
    {
        if (root == null)
        {
            return root;
        }
        if (data < root.Key)
        {
            root.Left = Remove(root.Left, data);
        }
        else if (data > root.Key)
        {
            root.Right = Remove(root.Right, data);
        }
        else
        {
            if (root.Left == null)
            {
                return root.Right;
            }
            else if (root.Right == null)
            {
                return root.Left;
            }
            root.Key = GetMinValue(root.Right);
            root.Right = Remove(root.Right, root.Key);
        }
        return root;
    }
} //Конец описания класса бинарного дерева поиска
