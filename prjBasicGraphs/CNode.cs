using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBasicGraphs
{
    internal class CNode<T>
    {
        public int id;
        T data;
        public LinkedList<CNode<T>> children = new LinkedList<CNode<T>>();
        public CNode(T data, int id) 
        {
            this.data = data;
            this.id = id;
            
        }
    }
}
