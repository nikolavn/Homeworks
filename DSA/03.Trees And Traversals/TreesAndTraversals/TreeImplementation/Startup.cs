namespace TreeImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var tree = CreateTree();

            Console.WriteLine($"Root: {GetRoot(tree).Value}");
            Console.WriteLine($"Middle nodes: {string.Join(",",GetMiddleNodes(tree).Select(n => n.Value).ToList())}");
            Console.WriteLine($"Leaf nodes: {string.Join(",", GetLeaves(tree).Select(n => n.Value).ToList())}");
        }

        private static List<TreeNode<int>> CreateTree()
        {
            var tree = new List<TreeNode<int>>();

            var parentChildPairsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < parentChildPairsCount - 1; i++)
            {
                var pair = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var parent = TreeHasNode(tree, int.Parse(pair[0]));
                var child = TreeHasNode(tree, int.Parse(pair[1]));               

                parent.AddChild(child);
            }

            return tree;
        }

        private static TreeNode<T> TreeHasNode<T>(ICollection<TreeNode<T>> tree, T value) where T : IComparable
        {
            var node = tree.FirstOrDefault(n => n.Value.CompareTo(value) == 0);

            if (node == null)
            {
                node = new TreeNode<T>(value);
                tree.Add(node);
            }

            return node;
        }

        private static TreeNode<T> GetRoot<T>(ICollection<TreeNode<T>> tree)
        {
            return tree.Where(node => !node.HasParent).FirstOrDefault();
        }

        private static ICollection<TreeNode<T>> GetLeaves<T>(ICollection<TreeNode<T>> tree)
        {
            return tree.Where(node => node.ChildrenCount == 0).ToList();
        }

        private static ICollection<TreeNode<T>> GetMiddleNodes<T>(ICollection<TreeNode<T>> tree)
        {
            return tree.Where(node => node.HasParent && node.ChildrenCount > 0).ToList();
        }
    }
}
