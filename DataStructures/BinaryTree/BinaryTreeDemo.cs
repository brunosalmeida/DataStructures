using System;

namespace DataStructures.BinaryTree
{
    public static class BinaryTreeDemo
    {
        public static void Demo()
        {
            var numbers = new int[] {4, 2, 5, 1, 3};

            var bt = new BinaryTree();

            foreach (var number in numbers)
            {
                bt.Insert(number);
            }
            
            Console.WriteLine($"The total nodes is: {bt.GetTotalNodes()}");
        }
    }
}