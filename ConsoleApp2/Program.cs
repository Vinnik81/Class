using System;
using System.Text;

namespace ConsoleApp2
{
    //public class Person
    //{



    //    // public int age;

    //    //private int age;
    //    //public int Age
    //    //{
    //    //    get { return age; }
    //    //    set {

    //    //        if (value>0 && value<100)
    //    //        {
    //    //            age = value;
    //    //        } 
    //    //    }
    //    //}


    //    //private string name;
    //    //public string Name
    //    //{
    //    //    get { return name; }
    //    //    set
    //    //    { 
    //    //        if (value.Contains('5'))
    //    //        {
    //    //            name = value;
    //    //        }
    //    //    }
    //    //}


    //    //private int age;

    //    //public int Age
    //    //{
    //    //    get { return age; }
    //    //    set { age = value; }
    //    //}

    //    //private string name;

    //    //public string Name
    //    //{
    //    //    get { return name; }
    //    //    set { name = value; }
    //    //}


    //    //public int MyProperty { get; set; }
    //    //public string Name { private get; set; }
    //    //public string Surname { get; private set; }


    //    //public int MyProperty { private get; set; }

    //    //public Person()
    //    //{
    //    //    // box = 10;
    //    //    num = 10;
    //    //}
    //    //public int GetNum()
    //    //{
    //    //    //  box = 200;
    //    //  //  num = 200;
    //    //    return box;
    //    //}

    //    //const int box = 5;
    //    //public readonly int num;


    //    //public Person(int age)
    //    //{
    //    //    Age = age;
    //    //}

    //    //public int Age { get; set; }


    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public int Age { get; set; }

    //    public Person()
    //    {
    //        //Console.WriteLine("Thrid ctor");
    //        counter++;
    //        Console.WriteLine($"Created new object num => {counter}");

    //    }
    //    //public Person(int age) : this()
    //    //{
    //    //    Console.WriteLine("Second ctor");
    //    //    Age = age;
    //    //}
    //    //public Person(string name, string surname, int age) : this(age)
    //    //{
    //    //    Console.WriteLine("First ctor");
    //    //    Surname = surname;
    //    //    Name = name;
    //    //}

    //       public static int counter = 0;


    //}


    class Person
    {
        public Person(string surname, int age = 0, string name = "No name")
        {
            Age = age;
            Name = name;
            Surname = surname;
        }

        public Person()
        {

        }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString() => $"{Name} {Surname} {Age}";

    }

    class Program
    {
        //static public int Sum(int a, int b)
        //{
        //    return a + b;
        //}
        //static public int Sum(int a, int b) => a + b;

        //static public void Sum2(int a, int b)
        //{
        //    Console.WriteLine(a+b);
        //} 
        // static public void Sum2(int a, int b) => Console.WriteLine(a + b);

        //static public int Sum(params int[] arr)
        //{
        //    int sum = 0; 

        //    for (int i = 0; i < arr.Length; i++)  sum += arr[i];

        //    return sum;
        //}


        //static public int Sum(params int[] arr) // lenght = 5
        //{
        //    int sum = 0;

        //    // 1 + 2+3+4+5+6
        //    for (int i = 0; i < arr.Length;) sum += arr[++i];

        //    return sum;
        //}
        //static public int Sum(int a = 10,int b = 20)
        //{
        //    return a + b;
        //}

        static void Main(string[] args)
        {


            //int count = 0;

            //for (; ; )
            //{
            //    count++;
            //    //3 , 5
            //    Console.WriteLine(count++);//1,3,5
            //    //2,4,6

            //         if (count == 5) break;

            //    if (count == 6) break;

            //    if (count == 7) break;

        }



    }












    //for (int i = 0; ; i++)//0=>12
    //{
    //    Console.WriteLine(i);//0,1...9, 10,15

    //    if (i==10) // 10=>15
    //    {
    //        i += 5; // 15
    //    }

    //    if (i == 12)
    //    {
    //        break;
    //    }
    //}








    //int count = 0;
    //List<int> arr = new List<int>();
    //while (true)
    //{
    //    arr.Add(count++);
    //    //1
    //    if (true)  count--; 
    //    //0
    //    if (count>=10) break; 
    //}

    //for (int i = 0; i < arr.Count; i++)
    //{
    //    Console.Write(arr[i] + " ");//
    //}














    //LinkedList<int> list = new LinkedList<int>();

    //List<int> arr = new List<int>(); // vector
    //arr.Add(10);
    //arr.Add(20);
    //arr.Add(30);
    //arr.Add(-200);
    //arr.Add(50);

    ////Console.WriteLine(arr.Count);
    ////arr.Clear();

    // int[] tmp = { 1, 2, 3, 4, 5 };


    // arr.AddRange(tmp);
    //arr.RemoveAt(0);
    //arr.Remove(1);
    //arr.RemoveAll(x=>x==1);
    //var tmp = arr.ToArray();
    //arr.Capacity
    //arr.RemoveRange(0,6);
    // Console.WriteLine(arr.IndexOf(1));
    //Console.WriteLine(arr.LastIndexOf(1));
    //arr.Insert(0, 100);
    // arr.InsertRange(0, tmp);
    //arr.Reverse();
    //arr.Sort(); 
    //Console.WriteLine(arr.Find(x => x == 50));
    //Console.WriteLine(arr.Contains(20));







    //for (int i = 0; i < arr.Count; i++)
    //{
    //    Console.Write(arr[i] + " ");
    //}











    //Console.WriteLine(Sum(20));

    //Person person = new Person { Name = "Farid",Age = 26,Surname="Abdullayev"};

    //person = new Person(age: 10, name: "Farid", surname: "Abdullayev");
    //person = new Person(name: "Farid", age: 10, surname: "Abdullayev");
    ////person = new Person( "Farid",  "Abdullayev",26);
    //person = new Person("Abdullayev",26);
    //Console.WriteLine(person.ToString());





    //uint a = uint.MaxValue;
    //Console.WriteLine(a);//2147483647
    //a++;
    //Console.WriteLine(a);



    // -2147483647  0 2147483647


    //int i = 10;
    //for (; i-- < 20; )
    //{
    //    Console.WriteLine(i);
    //}




    //int a = 10;
    //float b = 10.4f;
    //double c = 10.5;
    //decimal d = 10.4m;


    //a = (int)d;
    //b = a;
    //d = (decimal)c;


    //Console.WriteLine(a);
    //Console.WriteLine(b);
    //Console.WriteLine(d);






    // int[] arr = { 1, 2, 3, 4, 5 };
    //Logic

    //Console.WriteLine(Sum(1,2,3,4,5,6,7,8,9,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1)); // 





    //int a = 10;
    //int b = 10;

    //string a = "Farid";
    //string b = "Farid";

    //Person a = new Person("Farid", "Abdullayev", 26);
    //Person b = new Person("Farid", "Abdullayev", 26);

    //Person a = new Person("Farid", "Abdullayev", 26);
    //Person b = a;

    //a.Name = "Sawa";
    //b.Surname = "Cerkasov";

    //Console.WriteLine(a);


    //if (a == b) Console.WriteLine("Yes"); 
    //else  Console.WriteLine("No");


    // string str = (a == b) ? "Yes" : "No";

    // Console.WriteLine(str);






    //Object

    //Person person = new Person();
    //person.Age = 26;
    //person.Name = "Farid";
    //person.Surname = "Abdullayev";
    //Console.WriteLine(person.ToString());









    //Console.WriteLine(Sum(10, 5));
    //Sum2(10, 5);












    //Person person = new Person("Farid","Abdullayev",26); 

    //   Person person1 = new Person();
    //   Person person2 = new Person();
    //   Person person3 = new Person();

    //Console.WriteLine(Person.counter);

    //Person person = new Person();
    //Person person = new Person();
    //Person person = new Person();
    //Person person = new Person();
    //Person person = new Person();
    //Person person = new Person();
    //Person person = new Person();



    //person.MyProperty = 10;
    //person.Name = "Farid";
    //person.Surname = "Farid";

    // Console.WriteLine(person.Name);
    //Console.WriteLine(person.Surname);








    //Person person = new Person();
    //person.Age = 45;
    //person.Name = "ss5ss";




    //Console.WriteLine(person.Age);
    //Console.WriteLine(person.Name);
    //Modifiers person = new Modifiers();
    //person.name = "";
    //person.name4 = "";
    //person.name5 = 


    /*  //static void Main(string[] args)
      // {
      //string str = "";
      //StringBuilder stringBuilder = new StringBuilder();
      ////for (int i = 0; i < 10; i++)
      ////{
      ////    str += i;                 \\ этот код затрачевает много памяти
      ////}
      //for (int i = 0; i < 10; i++)
      //{
      //    stringBuilder.Append(i);
      //}
      ////Console.Write(str);
      //Console.WriteLine(stringBuilder);
      // StringBuilder password = new StringBuilder();

      //   for (int i = 0; i < 10; i++) builder.Append(i); Console.WriteLine(10);

      //string pass = "AR123";

      //while (true)
      //{
      //    ConsoleKeyInfo key = Console.ReadKey(true);
      //    if (key.Key == ConsoleKey.Enter) break;
      //    if (key.Key == ConsoleKey.Backspace)
      //    {
      //        if (password.Length > 0)
      //        {
      //            password.Remove(password.Length - 1, 1);
      //            Console.Write("\b \b");
      //        }
      //    }
      //    else
      //    {
      //            password.Append(key.KeyChar);
      //            Console.Write('*');
      //    }
      //}
      //    Console.WriteLine(password);
      // Console.WriteLine(password);
      //Console.Clear();

      //Console.WriteLine(password);
      //Console.WriteLine(pass);

      //if (pass.Equals(password.ToString()))
      //{
      //    Console.WriteLine("Welcome");
      //}
      //else
      //{
      //    Console.WriteLine("Password wrong");
      //}

      //string symbols = "1234567890qwertyuioplkjhgfdsazxcvbnmZXCVBNMLKJHGFDSAQWERTYUIOP";

      ////fabdullayev902@gmail.com

      //    Random random = new Random();

      //    StringBuilder password = new StringBuilder();

      //      for (int i = 0; i < 10; i++)
      //{
      //    int index = random.Next(0, symbols.Length - 1);
      //    password.Append(symbols[index]);
      //}

      //Console.WriteLine(password);

      //string name = "Farid";
      //string surname = "Abdullayev";
      //string number = "0519999902";

      //StringBuilder login = new StringBuilder();
      //Random random = new Random();

      //for (int i = 0; i < 9; i++)
      //{
      //    if (i < 3) // i => 0 , 1 , 2
      //    {
      //        int index = random.Next(0, name.Length - 1); // 0 => 9
      //        login.Append(name[index]);
      //    }
      //    else if (i < 6) // i => 3,4,5
      //    {
      //        int index = random.Next(0, surname.Length - 1);
      //        login.Append(surname[index]);
      //    }
      //    else // i => 6 , 7, 8
      //    {
      //        int index = random.Next(0, number.Length - 1);
      //        login.Append(number[index]);
      //    }
      //}

      //Console.WriteLine(login);


      //}
  }*/
}
