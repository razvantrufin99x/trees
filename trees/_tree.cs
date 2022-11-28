using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trees
{
    public  class _tree
    {
        public _node root = new _node();
        public _tree() { }

       
        public void addLeft(int pid, string pvalue, _node _nodepLeft) {
            root._nodeLeft = _nodepLeft;
            root._nodeLeft.id = pid;
            root._nodeLeft.value = pvalue;
            
           
        }
        public void addRight(int pid, string pvalue, _node _nodepRight) {
            root._nodeRight = _nodepRight;
            root._nodeRight.id = pid;
            root._nodeRight.value = pvalue;
          
        }

    }
}
