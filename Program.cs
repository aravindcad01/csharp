// class Aravindk
// {
//     static void Main(string [] args)
//     {
//     Console.WriteLine("Added value");
//     Arav k=new Arav();
//     k.cal();

//     }
// }
// public class Arav
// {
    
//     public void cal()
//     {
//         int a=20;
//         int b=30;
//         int c;
//         c= a + b;
//         Console.WriteLine(c);
// }
// }

// class Aravind 
// {
//     static void Main(string [] args)
//     {
// a1 s=new a1();
// s.add();
// s.sub();
// s.mul();
// s.div();

//     }
// }


// public class a1
// {
//     public void add()
//     {
//         int a=10;
//         int b=20;
//         int c=a+b;
//         Console.WriteLine(c);
//     }


//     public void sub()
//     {
//         int a=23;
//         int b=45;
//         int c=a-b;
//         Console.WriteLine(c);
//     }

//     public void mul()
//     {
//         int a=50;
//         int b=100;
//         int c=a*b;
//         Console.WriteLine(c);
//     }


    
//         public void div()
//         {
//             int a=20;
//             int b=10;
//             int c=a/b;
//             Console.WriteLine(c);
//         }

//     }




// public class Bca{
//     public string arav = "present today";

// }

// public class Mca:Bca{
//     public string harsh ="present";
// }

// class Miet
// {
//     public static void Main(string [] args)
//     {
//     Mca i=new Mca();
//     Console.WriteLine("attendance for "+i.arav);
//     Console.WriteLine("attendance for "+i.harsh);
//     } 

// }


class Company{
    static void Main(string [] args)
    {
    Tyre1 t=new Tyre1();
    Console.WriteLine("number of  mrf tyres"+t.Mrf);
     Console.WriteLine("number of ceat tyres"+t.Ceat);
    }
}

public class Tyre{
    public int Mrf = 574;
}

public class Tyre1:Tyre{
    public int Ceat = 535;

}