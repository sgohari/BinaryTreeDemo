using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDemo
{
    class Tree
    {
        Node top;

        public Tree()
        {
            top = null;
        }

        public Tree(int initial)
        {
            top = new Node(initial);
        }

        public void Add(int value)
        {
            //non-recurse add
            if (top == null)// the tree is empty.
            {
                //add item as the base node
                Node newNode = new Node(value);
                top = newNode;
                return;
            }
            Node currentnode = top;
            bool added = false;

            do
            {
                //traerse tree
                if (value < currentnode.value)
                    //go to left
                    if (currentnode.left == null)
                    {
                        //add the item
                        Node NewNode = new Node(value);
                        added = true;
                    }
                    else
                    {
                        //go left
                        currentnode = currentnode.left;
                    }

                if (value >= currentnode.value)
                {
                    if (currentnode.right == null)
                    {
                        Node NewNode = new Node(value);
                        currentnode.right = NewNode;
                        added = true;
                    }
                    else
                    {
                        //go right
                        currentnode = currentnode.right;
                    }
                }
            } while (!added);

    
        }

        public void AddRc(int value)
        {
            //recurse add
            AddR(ref top, value);

        }

        private void AddR(ref Node N, int value)
        {
            //private recursive search where add the new mode
            if (N == null)
            {
                //Node doesn't exist add it here
                Node NewNode = new Node(value);
                //Set the old Node refeence to the newly created mode, Attach it to the tree
                N = NewNode;
                return; // End the function call and fall back
            }
            if (value < N.value)
            {
                AddR(ref N.left, value);
                return;
            }
            if (value > N.value)
            {
                AddR(ref N.right, value);
                return;
            }
        }


        public void Print( Node N,ref string s)
        {
            //Write out the tree in sorted order othe strig newstring
           
            //implement using reursion
            if (N == null) { N = top; }

            if (N.left != null)
            {
                Print(N.left, ref s);
               // s = s + N.value.ToString().PadLeft(3);
            }
            else
            {
                s = s = N.value.ToString().PadLeft(3);
            } 
            if (N.right != null)
            {
                Print(N.right, ref s);
            }
        }
    }
}
