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




        /////////////////////////////////////////////////////
        ///
        /*   Solve the minibank system with oop part1
             /*
     * step 1: determine the main class ex: user or patient or visitor
     * step 2: decide which data will be primitive and which user defined
     * and which is single / list
     * step 3: implement all the user defined classes needed
     * step 4: keep repeating 2,3 till all classes have only primitive
     * step 5: complete all other seperate classes needed
     * step 6: we are now defined all data needed and the next step 
     * is to determine the access modifiers / and static 
     
     * step 7: for private data fields implement public methods
     * to set and get them
     * step 8: implemet methods which have logic
     * step 9: implement Main program method with it's logic
     * ( instantiate system objects )
     *//*
        class Transaction
        {
            public DateTime Date { get; set; }
            public string Type { get; set; } // Deposit or Withdraw
            public double Amount { get; set; }

            public override string ToString()
            {
                return $"{Date}|{Type}|{Amount}";
            }

            public static Transaction FromString(string line)
            {
                var parts = line.Split('|');
                return new Transaction
                {
                    Date = DateTime.Parse(parts[0]),
                    Type = parts[1],
                    Amount = double.Parse(parts[2])
                };
            }
        }

        class Review
        {
            public string Reviewer { get; set; }
            public DateTime Date { get; set; }
            public int Rating { get; set; }

            public void Priting()
            {
                Console.WriteLine($"{Date}|{Reviewer}|Rating: {Rating}/5");
            }
        }

        class Account
        {
            public int AccountNumber { get; set; }
            //public string AccountHolder { get; set; }
            public double Balance { get; private set; }
            public List<Transaction> Transactions { get; private set; }

            public Account(int accNo, string holder)
            {
                AccountNumber = accNo;
                // AccountHolder = holder;
                Balance = 0.0;
                Transactions = new List<Transaction>();
                // Reviews = new List<Review>();
            }

            public void Deposit(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Invalid deposit amount.");
                    return;
                }

                Balance += amount;
                Transactions.Add(new Transaction
                {
                    Date = DateTime.Now,
                    Type = "Deposit",
                    Amount = amount
                });
            }

            public void Withdraw(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Invalid withdraw amount.");
                    return;
                }

                if (Balance >= amount)
                {
                    Balance -= amount;
                    Transactions.Add(new Transaction
                    {
                        Date = DateTime.Now,
                        Type = "Withdraw",
                        Amount = amount
                    });
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }

            public void ShowTransactions()
            {
                Console.WriteLine("Transaction History:");
                foreach (Transaction t in Transactions)
                {
                    Console.WriteLine(t.ToString());
                }
            }



            public override string ToString()
            {
                return $"{AccountNumber},{Balance}";
            }
        }

        class User
        {
            public int Id { get; set; }
            public string UserName { get; set; }
            public DateOnly Birthdate { get; set; }
            public string Email { get; set; }
            public int age { get; set; }
            public string Password { get; set; }

            public List<Account> Accounts { get; set; }
            public List<Review> Reviews { get; private set; }

            public void AddReview(string reviewer, int rating)
            {
                Reviews.Add(new Review
                {
                    Reviewer = reviewer,
                    Date = DateTime.Now,
                    Rating = rating
                });
            }

            public void ShowReviews()
            {
                Console.WriteLine("Reviews:");
                foreach (var review in Reviews)
                {
                    Console.WriteLine(review.ToString());
                }
            }
        }
         */
    }
}
