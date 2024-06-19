using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_16._2
{
    internal class Block
    {
        int top, bottom, right, left;

        public Block(int top, int bottom, int right, int left)
        { 
            this.top = top;
            this.bottom = bottom;
            this.right = right;
            this.left = left;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                Block temp = (Block)obj;

                if (temp.top == this.top && temp.bottom == this.bottom && temp.right == this.right && temp.left == this.left)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString() 
        {
            return "Top: " + top + "  " +  "Bottom: " + bottom + "  " + "Right: " + right + "  " + "Left: " + left;
        }

        public override int GetHashCode()
        {
            return top ^ bottom ^ right ^ left;
        }
    }
}
