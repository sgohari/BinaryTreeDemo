using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDemo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //created random number generator.
            int num;

            Random rnd = new Random();
            num = rnd.Next(0, 100);

           Tree Mytree = new Tree(num);
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());


            string myString = "";

            for (int i = 0; i < n; i++)
            {
                num = rnd.Next(0, 100);
                Mytree.Add(n);
                Mytree.Print(null, ref myString);
                Console.WriteLine(myString);
            }
           
           
            Console.ReadLine(); // run it now// exactly same but works different/
            // thats ok man....
        }
    }
}
