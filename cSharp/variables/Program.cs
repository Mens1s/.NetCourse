namespace variables{

    class Program{
            
            static void Main(string[] args){
    
                // Variables
                int myNum = 5;
                double myDoubleNum = 5.99D;
                char myLetter = 'D';
                bool myBool = true;
                string myText = "Hello";

                byte myByte = 255;  // 0 to 255 1 byte
                sbyte mySByte = 127; // -128 to 127 1 byte
                short myShort = 32767; // -32768 to 32767 2 byte
                ushort myUShort = 65535; // 0 to 65535 2 byte
 
                Int16 myInt16 = 32767; // -32768 to 32767 2 byte
                Int32 myInt32 = 2147483647; // -2147483648 to 2147483647 4byte
                Int64 myInt64 = 9223372036854775807; // -9223372036854775808 to 9223372036854775807 8byte
                int myInt = 2147483647; // -2147483648 to 2147483647 it is same as Int32 4byte

                long longNum = 9223372036854775807L; // -9223372036854775808 to 9223372036854775807 8byte
                ulong ulongNum = 18446744073709551615; // 0 to 18446744073709551615 8byte  
            
                float myFloat = 5.75F; // 7 decimal digits 4byte
                double myDouble = 19.99D; // 15 decimal digits 8byte
                decimal myDecimal = 19.99M; // 28 decimal digits 16byte

                char myChar = 'A'; // 2byte
                string myString = "Hello"; // 2byte * length

                bool myBool1 = true; // 1byte

                DateTime myDate = DateTime.Now; // 8byte
                Console.WriteLine(myDate);

                object myObject = "Hello"; // 8byte
                
                // string operations
                string str1 = string.Empty;
                str1 = "A Y - Y A";
                
                // Output
                System.Console.WriteLine(myNum);
                System.Console.WriteLine(myDoubleNum);
                System.Console.WriteLine(myLetter);
                System.Console.WriteLine(myBool);
                System.Console.WriteLine(myText);
    
            }   
    }

}