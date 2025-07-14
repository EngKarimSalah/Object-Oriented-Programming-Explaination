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

        // Usage of array and lists in OOP
        /*

        
int[] ages = new int[4];

Guest[] clients = new Guest[10];

ages[0]=6;

clients [0] = new Guest("ahmed", 123);
clients [1] = new Guest ("karim" , 3445)


foreach( int c in ages )
{
  Console.writeline(c)
}


foreach( Guest g in Clients )
{

  Console.writeline( g.name )

}







// step1 setup
Guest[] clients = new Guest[10];
string username;
int userId;

for(int i=0; i < clients.length; i++)
{
   username = Console.readline();
   userID = int.parse(Console.readline());

   Client[i] = new Guest(username, USerID);
   

}


//step2 use/print
for(int i=0; i < clients.length; i++)
{
   Console.writeline( client[i].name )
}

///////////////////////////////////////////////////////////////


//if List
List<Guest>  clients = new List<Guests>();
username = Console.readline();
userID = int.parse(Console.readline());

clients.add( new Guest(username, USerID)  )




Lambda expression





Class Account
{

ownerName
AccNumber
Balance
Currency
StartDate


Deposit()

Withdraw()

ViewBalance()


viewTransactionHistory(accnumber)

PrintReciept()

}

Class Transaction
{

AccNumbr
Date
Type
amount


}


class review()
{


}
     
         */
    }
}
