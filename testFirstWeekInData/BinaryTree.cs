using testFirstWeekInData;
using System.Text.Json;

public class BinaryTree
{
    private TreeNode root;
    public BinaryTree()
    {
        root = null;
    }


    //O(1)
    //הפעולה שאני מבצע היא פעולה בודדת, כאשר נכנס אליה
    //נסתבך, וזו הפונקציה הבאה
    public void Insert(int maxSeverity, int minSeverity, List<string> defences)
    {
        root = InsertRec(root,maxSeverity, minSeverity, defences);
    }
    

    // O(log n)
    public TreeNode InsertRec(TreeNode node, int maxSeverity, int minSeverity, List<string> defences)
    {
        if (root == null)
        {
            node = new TreeNode(maxSeverity, minSeverity, defences);
            return node;
        }
        if (maxSeverity > node.MaxSeverity)
        {
            node.right = InsertRec(node.right, maxSeverity, minSeverity, defences);
        }
        else
        {
            node.left = InsertRec(node.left, maxSeverity, minSeverity, defences);
        }
        return node;

    }


    // בשביל להדפיס את העץ אני צריך להיכנס קודם לשמאל ואז לימין ולעבור על כל הצמתים לכן זה בסך הכללי יצא O(n)
    public string PrintTree()
    {
        if (root == null) { return "The tree is empty"; }
        string result = "";
        result += PrintTreeRecForLeft(root);
        result += PrintTreeRecForRight(root);

        return result;
    }

    // מעבר על צד שמאל
    public string PrintTreeRecForLeft(TreeNode node)
    {
        if (root == null) { return "The tree is empty"; }

        string result;

        result = root.Defences.ToString();

        if (root.left != null)
        {
            result += root.left.Defences.ToString();

            if(root.left != null) { PrintTreeRecForLeft(root.left); }

            if (root.right != null) { result += PrintTreeRecForRight(root); }
            
        }
        return result;
    }

    // מעבר על צד ימין
    public string PrintTreeRecForRight(TreeNode node)
    {
        if (root == null) { return "The tree is empty"; }

        string result;

        result = root.Defences.ToString();

        if (root.right != null)
        {
            result += root.right.Defences.ToString();

            if (root.left != null) { result += PrintTreeRecForLeft(root); }
           
            if (root.right != null) { PrintTreeRecForRight(root.right); }
        }
        return result;
    }

}
