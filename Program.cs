namespace OOP_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;  //value type  -- store stack memory
            x = 7;  //4 byte
            x = 100;  // 4 byte
            x = 35000; // 4byte

            // int, float, double, char, bool --> value type ( fixed size )
            //-----------------------------------------------------------------------

            string y; //reference type  -- heap memory 
            y = "k";      // 1 byte
            y = "karim";  // 5 byte

            // All data structures are reference type ( non fixed size )
            // array, list, stack, queue ... etc
            //------------------------------------------------------------------------

            int l;
            l = 8;

            int[] c = new int[5];
            c[0] = 12;


            Car z = new Car();
            z.manufacture = "toyota";
            z.year = 2021;
            z.changeSpeed(15);


            BankAccount ba = new BankAccount();
            ba.accountNumber = 2025123;
            //   ba.ownerName = "karim"; error get only

            string accountOwner = ba.ownerName;

            int b = ba.checkBalance(123, "k13");
            if(b != -1 )
            {
                Console.WriteLine("balance = : " + b);
            }
            else

            {
                Console.WriteLine("invalid credintials");
            }
        }
    }
}
