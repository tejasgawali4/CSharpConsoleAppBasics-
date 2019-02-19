using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        static void Main(string[] args)
        {
            //datatypes
            Int32 num = 30;
            double dub = 30.30;
            Boolean status = true;
            String msg = "Hey How are you..";

            //Console.Write(" Number  :-" +  num );
           // Console.Write(" Double :-" + dub);
            //Console.Write(" Boolean :- " + status);
            //Console.Write(" String :-" + msg);

            //Enum
            //Console.Write(" Days :-" + Days.Fri);


            //Arithematic Operators
            Int32 val1 = 10;
            Int32 val2 = 20;

            //Console.Write(val1 + val2);
            //Console.Write(val1 > val2);
            //Console.Write(!(status));


            //Loops
            if (val1 < 10)
            {
                //Console.Write("values is less than 10");
            }else{
                //Console.Write("values is grether than 10");
            }


            //Switch
            Int32 value1 = 11;
            switch (value1)
            {
                case 1: //Console.WriteLine("Value is 1");
                    break;
                case 2: //Console.WriteLine("Value is 2");
                    break;
                default: //Console.WriteLine("value is different");
                    break;
            }

            //While Loop
            Int32 value = 3, i = 0;

            while (i < value)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            //for loop
            for (Int32 j = 0; j < 3; j++)
            {
                Console.WriteLine(j);
            }

            //Arrays
            //valu = new Int32[3];

            //valu[0] = 1;
            //valu[1] = 2;
            //valu[2] = 3;

            //Console.WriteLine(valu[1]);



            //Class1 c1 = new Class1();

            //c1.SetUser(1, "Tejas", "Gawali", 8);

            //Console.Write(c1.GetUser());

            //Console.ReadKey();

            //Console.ReadKey();


            //Collections C# ArrayList
            ArrayList a1 = new ArrayList();

            a1.Add("Tejas");
            a1.Add("Divine");
            a1.Add("emiway");

            Console.WriteLine(a1.Count);
            Console.WriteLine(a1.Contains(2));
            Console.WriteLine(a1[1]);
            a1.RemoveAt(1);
            Console.WriteLine(a1[1]);


            //Stack 
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the stack " + st.Count);
            Console.WriteLine("Does the stack contain the elements 3 " + st.Contains(3));

            st.Pop();
            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }


            //Queue
            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the Queue " + qt.Count);
            Console.WriteLine("Dose the Queue contain " + qt.Contains(3));

            qt.Dequeue();
            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }


            //Hashtables
            Hashtable ht = new Hashtable();
            ht.Add("001", ".Net");
            ht.Add("002", "C#");
            ht.Add("003", "ASP.Net");

            ICollection keys = ht.Keys;

            foreach (String k in keys)
            {
                Console.WriteLine(ht[k]);
            }

            Console.WriteLine(ht.ContainsKey("001"));
            Console.WriteLine(ht.ContainsValue("C#"));

            Console.ReadKey();

        }
    }
}
