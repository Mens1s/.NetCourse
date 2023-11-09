namespace operators{

    class Program{
        static void Main(string[] args){
            int a = 10;
            int b = 20;
            int c = a + b;

            // give me all operator types
            System.Console.WriteLine("Arithmetic Operators");
            System.Console.WriteLine("Addition: " + (a + b));
            System.Console.WriteLine("Subtraction: " + (a - b));
            System.Console.WriteLine("Multiplication: " + (a * b));
            System.Console.WriteLine("Division: " + (a / b));
            System.Console.WriteLine("Modulus: " + (a % b));
            System.Console.WriteLine("Increment: " + (++a));
            System.Console.WriteLine("Decrement: " + (--b));

            System.Console.WriteLine("Relational Operators");
            System.Console.WriteLine("Equal: " + (a == b));
            System.Console.WriteLine("Not Equal: " + (a != b));
            System.Console.WriteLine("Greater Than: " + (a > b));
            System.Console.WriteLine("Less Than: " + (a < b));
            System.Console.WriteLine("Greater Than or Equal: " + (a >= b));
            System.Console.WriteLine("Less Than or Equal: " + (a <= b));

            System.Console.WriteLine("Logical Operators");
            System.Console.WriteLine("And: " + (a > b && a < b));
            System.Console.WriteLine("Bitwise Operators");
            System.Console.WriteLine("Or: " + (a > b || a < b));
            System.Console.WriteLine("Not: " + !(a > b && a < b));

            System.Console.WriteLine("Assignment Operators");
            System.Console.WriteLine("Equal: " + (a = b));
            System.Console.WriteLine("Addition: " + (a += b));
            System.Console.WriteLine("Subtraction: " + (a -= b));
            System.Console.WriteLine("Multiplication: " + (a *= b));
            System.Console.WriteLine("Division: " + (a /= b));
            System.Console.WriteLine("Modulus: " + (a %= b));

            System.Console.WriteLine("Conditional Operators");
            System.Console.WriteLine("Ternary: " + (a > b ? a : b));

            System.Console.WriteLine("Type Operators");
            System.Console.WriteLine("TypeOf: " + (typeof(int)));

            System.Console.WriteLine("Bitwise Operators");
            System.Console.WriteLine("And: " + (a & b));
            System.Console.WriteLine("Or: " + (a | b));
            System.Console.WriteLine("Xor: " + (a ^ b));
            System.Console.WriteLine("Complement: " + (~a));
            System.Console.WriteLine("Left Shift: " + (a << b));
            System.Console.WriteLine("Right Shift: " + (a >> b));

            System.Console.WriteLine("Other Operators");
            // System.Console.WriteLine("Indexer: " + (a[b]));
            System.Console.WriteLine("Cast: " + ((int)a));
            System.Console.WriteLine("SizeOf: " + (sizeof(int)));
            System.Console.WriteLine("Checked: " + (checked(a + b)));
            System.Console.WriteLine("Unchecked: " + (unchecked(a + b)));
            System.Console.WriteLine("Default: " + (default(int)));

            


            System.Console.WriteLine(c);
        }
    }
    
}