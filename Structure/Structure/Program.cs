using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{

    struct OurPoint
    {
        public int x, y;     //user define variable (member variable)

       /* public OurPoint()
        {
            x = 0;                //default constructor 
            y = 0;              //can't decleared by programmer cause it is buit in 
        }
*/
        public OurPoint(int x, int y)
        {
            this.x = x;             //peramitarized constructor (local variable)
            this.y = y;             //we use (this) key word to avoid AMBIGUITY
                                    //***((cause there multiple content with same name))***

        }
        
        //There is no static variables 

        public void show()
        {
            Console.WriteLine("({0},{1})",this.x,this.y);       //method
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            OurPoint p = new OurPoint();
            p.x = 10;
            p.y = 20;  
            p.show();


            OurPoint p1;    //Fixed memory Allocation 

            Console.Write("Enter the point values: ");
            p1.x = Convert.ToInt32(Console.ReadLine());
            p1.y = Convert.ToInt32(Console.ReadLine());
            p1.show();
           

            Console.Write("pass value through constructor: ");
            //user input through constructor 
            OurPoint p2 = new OurPoint(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter the point values: ");
            p2.show();

           
            Console.Write("\nDirect value thrugh constructor: ");

            OurPoint p3 = new OurPoint(3,4);   //dynamically memory allocation bacause of new key word
            p3.show();
           
        }
    }
}
