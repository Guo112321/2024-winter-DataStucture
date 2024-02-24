using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Node
    {
        public train Data { get; set; }
        public Node Next { get; set; }

        public Node(train data)
        {
            Data = data;
            Next = null;
        }
    }

    
}
