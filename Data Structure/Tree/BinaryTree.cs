namespace Data_Structure.Tree;

internal class BinaryTree
{
    public Node? Root { get; set; }

    public bool Insert(int value)
    {
        Node? before = null;
        Node? after = Root;
        while (after != null)
        {
            before = after;

            //Is new node in left tree?
            if (value < after.Data)
            {
                after = after.LeftNode;
            }

            //Is new node in right tree?

            else if (value > after.Data)
            {
                after = after.RightNode;
            }

            //Exist same value
            else
            {
                return false;
            }
        }

        var newNode = new Node();

        newNode.Data = value;

        if (Root == null) //Tree ise empty

        {
            Root = newNode;
        }

        else

        {
            if (value < before!.Data)

                before.LeftNode = newNode;

            else

                before.RightNode = newNode;
        }

        return true;
    }

    public Node? Search(int value)
    {
        return Search(value, Root);
    }

    public void Delete(int value)
    {
        Root = Delete(Root, value);
    }

    private Node? Delete(Node? parent, int key)
    {
        if (parent == null) return parent;

        if (key < parent.Data)
        {
            parent.LeftNode = Delete(parent.LeftNode, key);
        }
        else if (key > parent.Data)

        {
            parent.RightNode = Delete(parent.RightNode, key);
        }

        // if the value is the same as the parent's value, then this node is to be deleted  

        else

        {
            // the node with one or no child  

            if (parent.LeftNode == null)
            {
                return parent.RightNode;
            }

            if (parent.RightNode == null)
            {
                return parent.LeftNode;
            }

            // node with two children: Get the inorder successor (smallest in the right subtree)  

            parent.Data = MinValue(parent.RightNode);

            // Delete the inorder successor  

            parent.RightNode = Delete(parent.RightNode, parent.Data);
        }

        return parent;
    }

    private int MinValue(Node? node)
    {
        var minValue = node!.Data;

        while (node.LeftNode != null)
        {
            minValue = node.LeftNode.Data;
            node = node.LeftNode;
        }

        return minValue;
    }

    private Node? Search(int value, Node? parent)
    {
        if (parent != null)
        {
            if (value == parent.Data) return parent;

            if (value < parent.Data)
            {
                return Search(value, parent.LeftNode);
            }

            return Search(value, parent.RightNode);
        }

        return null;
    }

    public int GetDepth()
    {
        return GetDepth(Root);
    }

    private int GetDepth(Node? parent)
    {
        return parent == null ? 0 : Math.Max(GetDepth(parent.LeftNode), GetDepth(parent.RightNode)) + 1;
    }

    public void PreOrder(Node? parent)
    {
        if (parent != null)
        {
            Console.Write(parent.Data + " ");
            PreOrder(parent.LeftNode);
            PreOrder(parent.RightNode);
        }
    }

    public void InOrder(Node? parent)
    {
        if (parent != null)
        {
            InOrder(parent.LeftNode);
            Console.Write(parent.Data + " ");
            InOrder(parent.RightNode);
        }
    }

    public void PostOrder(Node? parent)
    {
        if (parent != null)

        {
            PostOrder(parent.LeftNode);
            PostOrder(parent.RightNode);
            Console.Write(parent.Data + " ");
        }
    }
}