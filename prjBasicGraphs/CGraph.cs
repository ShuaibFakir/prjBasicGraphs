﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prjBasicGraphs
{
    internal class CGraph
    {
        private Dictionary<int, CNode<string>> nodeLookup = new Dictionary<int, CNode<string>>();

        public void addNode(int id, string data) 
        {
            nodeLookup.Add(id, new CNode<string>(data, id));
        }
        public CNode<string> getNode(int id) 
        {
            return nodeLookup[id]; 
        }
        public void addEdges(int source, int destination) 
        {
            CNode<string> s = getNode(source);
            CNode<string> d = getNode(destination);

            s.children.AddFirst(d);
        }
        public bool hasPathDFS(int source, int child)
        {
            CNode<string> s = getNode(source);
            CNode<string> d = getNode(child);
            HashSet<int> visited = new HashSet<int>();

            return hasPathDFS(s, d, visited);

        }
        private bool hasPathDFS(CNode<string> source, 
            CNode<string> child, HashSet<int> visited)
        {
            if (visited.Contains(child.id)) 
            {
                return false;
            }

            visited.Add(source.id);

            if(source == child) 
            {
                return true;
            }
            foreach(CNode<string> forChild in source.children) 
            {
                if(hasPathDFS(child, child, visited)) 
                {
                    return true;
                }
            }
            return false;
        }
        public bool hasPathBFS(int source, int child) 
        {
            return hasPathBFS(getNode(source), getNode(child));
        }

        private bool hasPathBFS(CNode<string> source ,CNode<string> child) 
        {
            Queue<CNode<string>> nexttovisit = new Queue<CNode<string>>();
            HashSet<int> visited = new HashSet<int>();
            nexttovisit.Enqueue(source);

            while(nexttovisit.Count > 0) 
            {
                CNode<string> Node = nexttovisit.Dequeue();

                if (Node == child) 
                {
                    return true;
                }

                if (visited.Contains(Node.id)) 
                {
                    continue;
                }

                visited.Add(Node.id);
                foreach(CNode<string> Forchild in Node.children) 
                {
                    nexttovisit.Enqueue(Forchild);
                }
            }
            return false;
        }




    }
}
