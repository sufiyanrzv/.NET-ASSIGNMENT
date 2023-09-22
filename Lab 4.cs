Program 1-

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank("Ritik Kaushik", 1000);
            b1.getDetails();
            Console.ReadKey();
        }
        class Bank
        {
            String name;
            float balance;
            public Bank(String name, float balance)
            {
                this.name = name;  
                if(balance < 0)
                {
                    Console.WriteLine("Enter Correct Balance");
                }
                this.balance = balance;
            }

            public void getDetails()
            {
                Console.WriteLine("Name :" + this.name);
                Console.WriteLine("Balance :"+this.balance);
            }
        }
    }
}

Program 2-

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car b1 = new Car("BMW", "A7", 2002);
            b1.getDetails();
            Console.ReadKey();
        }
        class Car
        {
            String name;
            String model;
            int year;
           
            public Car(String name, String model,int year)
            {
                this.name = name;
                this.year = year;
                this.model = model;

            }

            public void getDetails()
            {
                Console.WriteLine("Name :" + this.name);
                Console.WriteLine("Model :"+this.model);
                Console.WriteLine("Year :" + this.year);
            }
        }
    }
}
Program 3-

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ritik", "Kaushik");
            p1.getDetails();
            Console.ReadKey();
        }
        class Person
        {
            String name;
            String lastname;
            
           
          public Person(String name, String lastname)
            {
                this.name = name;
                this.lastname = lastname;
            }

            public void getDetails()
            {
               String fullname = this.name.ToUpper()+" "+this.lastname.ToUpper();
                Console.WriteLine("FullName : " + fullname);
            }
        }
    }
}

Program 4-

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature t1 = new Temperature(33);
            t1.convertToFahrenheit();
            Console.ReadKey();
        }
        
        class Temperature
        {
            float temp;
            public Temperature(float value)
            {
                temp = value;
            }

            public void convertToFahrenheit()
            {
                float f = (temp*9)/5+ 32;
                Console.WriteLine("Temperature in Fahrenheit is :" + f);
            }
        }
    }
}

Program 5-

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {

        class CustomList
        {
            private int[] num = new int[10];

            public int this[int i]
            {
                get
                {
                    return num[i];
                }
                set
                {
                    num[i] = value;
                }
            }

        }


        static void Main(string[] args)
        {
            CustomList c1 = new CustomList();
            c1[0] = 12;
            c1[1] = 13;
            Console.WriteLine(c1[0]);
            Console.WriteLine(c1[1]);
            Console.ReadLine();

        }


    }
}



Program 6-
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {

        class Stack
        {
            private int[] num = new int[3];

            public int this[int i]
            {
                get
                {
                    return num[i];
                }
                set
                {
                    num[i] = value;
                }
            }

        }


        static void Main(string[] args)
        {
            Stack c1 = new Stack();
            c1[0] = 12;
            c1[1] = 13;
            Console.WriteLine(c1[0]);
            Console.WriteLine(c1[1]);
            Console.ReadLine();

        }


    }
}



Program 7-

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {

        class Book
        {
            private string bookname;

            public string this[ string param]
            {
                get
                {
                    return bookname;
                }
                set
                {    if(param=="title")
                    bookname=value.ToString();
                    else
                    {
                        throw new Exception("please use title for index");
                    }
                }
            }

        }


        static void Main(string[] args)
        {
            Book book = new Book();
            book["title"] = "Python";
            Console.WriteLine(book["title"]);
            Console.ReadLine();

        }


    }
}



Program 8-
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {

      enum Seasons
        {
            spring=1,summer,monsoon,autumn,winter
        }


        static void Main(string[] args)
        {
            Console.WriteLine((int)Seasons.spring);
            Console.WriteLine(Seasons.spring );
            

            Console.WriteLine((int)Seasons.summer);
            Console.WriteLine(Seasons.summer);

            Console.WriteLine((int)Seasons.monsoon);
            Console.WriteLine(Seasons.monsoon);

            Console.WriteLine((int)Seasons.autumn);
            Console.WriteLine(Seasons.autumn);


            Console.WriteLine((int)Seasons.winter);
            Console.WriteLine(Seasons.winter);


            Console.ReadLine();
               

        }


    }
}



Program 9 -
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Program
    {

        enum Shapes
        {
            Circle=1,Triangle,Rectangle,Square
        }
        static void Main(string[] args)
        {
            double area=0;
            Console.WriteLine("Choose the Shape");
            Console.WriteLine("Press 1 for "+Shapes.Circle );
            Console.WriteLine("Press 2 for " + Shapes.Triangle);
            Console.WriteLine("Press 3 for " + Shapes.Rectangle);
            Console.WriteLine("Press 4 for " + Shapes.Square);
            int shape = Convert.ToInt32(Console.ReadLine());

            switch (shape)
            {
                case 1:
                    Console.WriteLine("Enter Rdius ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    area = 3.14 * radius * radius;
                    Console.WriteLine("Area is :" + area);
                    break;

                case 2:
                    Console.WriteLine("Enter Base and Height");
                    int bases = Convert.ToInt32(Console.ReadLine());
                    int height = Convert.ToInt32(Console.ReadLine());
                    area = (1 / 2) * (bases * height);
                    Console.WriteLine("Area is :" + area);
                    break;
                case 3:
                    Console.WriteLine("Enter lengrh and breadth");
                    int length = Convert.ToInt32(Console.ReadLine());
                    int breadth = Convert.ToInt32(Console.ReadLine());
                    area = length * breadth;
                    Console.WriteLine("Area is :" + area);
                    break;

                case 4:
                    Console.WriteLine("Enter side of square");
                    int side = Convert.ToInt32(Console.ReadLine());
                    area = side * side;
                    Console.WriteLine("Area is :" + area);
                    break;

                default: Console.WriteLine("Enter Valid input"); 
                    break;

            }
            Console.ReadLine();
           
            }

       
        }
        
       
    }

Program 10 -

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

[Flags]
public enum permission { read=1,
        write=2,
        Execute=4
}

namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the which domain you belong as (user,admin,authority) ");
            string input=Console.ReadLine().ToLower();
            switch(input)
            {
                case "user":
                    permission us =permission.read;
                    Console.WriteLine($"you only have {us} permission of file :  ");
                    break;
                    case "admin":
                    permission ad = permission.read | permission.write;
                    Console.WriteLine($"you  have {ad} permission of file :  ");
                    break;
                case "authority":
                    permission aut = (permission)7;
                    Console.WriteLine($"you only have {aut} permission of file :  ");
                    break;
            }
        }
    }
}


