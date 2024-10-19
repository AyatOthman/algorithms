using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BFS_Algorithim
{
    public class Node
    {
        public int []State { get; set; }
        public Node Parent { get; set; }
        public int Depth { get; set; }
        public int PathCost { get; set; }
        //root node
        public Node(int[]State)
        {
            this.State = State;
            this.Parent = null;
            this.Depth = 0;
            this.PathCost = 0;
        }
        //child node
        public Node(Node parent, int []State)
        {
            this.State = State;
            this.Parent = parent;
            this.Depth = parent.Depth + 1;
            this.PathCost = parent.PathCost + 1;
        }
        public bool isEqual(Node s)
        {
            for (int i = 0; i < this.State.Length; i++)
            {
                if (this.State[i] != s.State[i])
                {
                    return false;
                }
            }
            return true;
        }
        public Node[] getChildren()
        {
            Node[] children = new Node[2];
            children[0] = new Node(this, this.State[] * 2 + 1);
            children[1] = new Node(this, this.State[] * 2 + 2);
            return children;
        }
        public Node[] getReverseChildren()
        {
            Node[] children = new Node[2];
            children[1] = new Node(this, this.State[] * 2 + 1);
            children[0] = new Node(this, this.State[] * 2 + 2);
            return children;
        }
    }
    class breadthFirstSearch
    {
        public void BFS_Solver(int[] arr)
        {
            int[] goal = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            Queue<Node>bfsQueue = new Queue<Node>();
            Node initialState = new Node(arr[]);
            bfsQueue.Enqueue(initialState);
            Console.WriteLine("Trace");
            while (bfsQueue.Count != 0)
            {
                //dequeue
                Node currentNode = (Node)bfsQueue.Dequeue();
                Console.Write(currentNode.State + "\t");
                //check if goal
                if (currentNode.State == goal)
                {
                    //return solution
                    List<int> sol = new List<int>();
                    while (currentNode != null)
                    {
                        sol.Insert(0, currentNode.State[]);
                        currentNode = currentNode.Parent;
                    }
                    Console.WriteLine("\n Solution");
                    foreach (var item in sol)
                    {
                        Console.Write(item + "\t");
                    }
                    break;
                }
                //add children
                foreach (var item in currentNode.getChildren())
                {
                    bfsQueue.Enqueue(item);
                }
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
