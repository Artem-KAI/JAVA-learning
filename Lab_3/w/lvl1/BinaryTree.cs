public class BinaryTree
{
    private TreeNode root;

    public void AddStudent(Student student)
    {
        root = AddRecursive(root, student);
    }

    private TreeNode AddRecursive(TreeNode node, Student student)
    {
        if (node == null)
        {
            return new TreeNode(student);
        }
         
        if (string.Compare(student.LastName, node.Data.LastName) < 0)
        {
            node.Left = AddRecursive(node.Left, student);
        }else
        {
            node.Right = AddRecursive(node.Right, student);
        }

        return node;
    }

    public void PrintStudentInfo()
    {
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine($"{"Прізвище",-15} {"Ім'я",-15} {"Курс",-6} {"Квиток",-12} {"Хобі",-10}");
        Console.WriteLine("-------------------------------------------------------------");

        DFSmethod(root);

        Console.WriteLine("-------------------------------------------------------------");
    }
 
    private void DFSmethod(TreeNode node)
    {
        if (node == null)
            return;

        Console.WriteLine(node.Data);

        DFSmethod(node.Left);
        DFSmethod(node.Right);
    }
}
