using System.Text.Json;
using Data_Structure.Tree;

namespace Data_Structure;

internal static class Program

{
    private static void Main(string[] args)

    {
        var binaryTree = new BinaryTree();
        binaryTree.Insert(11);
        binaryTree.Insert(21);
        binaryTree.Insert(78);
        binaryTree.Insert(31);
        binaryTree.Insert(101);
        binaryTree.Insert(51);
        binaryTree.Insert(82);

        var node = binaryTree.Search(21);
        var depth = binaryTree.GetDepth();
        Console.WriteLine("node: " + JsonSerializer.Serialize(node));
        Console.WriteLine("depth: " + depth);

        Console.WriteLine("PreOrder Traversal:");
        binaryTree.PreOrder(binaryTree.Root);
        Console.WriteLine();

        Console.WriteLine("InOrder Traversal:");
        binaryTree.InOrder(binaryTree.Root);
        Console.WriteLine();

        Console.WriteLine("PostOrder Traversal:");
        binaryTree.PostOrder(binaryTree.Root);
        Console.WriteLine();

        binaryTree.Delete(78);
        binaryTree.Delete(82);

        Console.WriteLine("After Remove Operation, Preorder Traversal:");
        binaryTree.PreOrder(binaryTree.Root);
        Console.WriteLine();
    }
}