using System.Text;

namespace BSTApp;

public class BstNode
{
    public int Key { get; set; }
    public int Count { get; set; }
    public BstNode? Left { get; set; }
    public BstNode? Right { get; set; }

    public BstNode()
    {
        Left = null;
        Right = null;
    }

    public BstNode(int data)
    {
        Key = data;
        Count = 1;
        Left = null;
        Right = null;
    }

    public override string ToString()
    {
        //return key + "(" + count + ")";
        return $"{Key}({Count})";
    }
}