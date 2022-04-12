////////Demo Assigment salim 12 April 2022


////////*                               *
////////        *               *
////////                *
////////        *               *
////////*                               *



////////for (int row = 0; row < 5; row++)
////////{
////////    for (int column = 0; column < 5; column++)
////////    {
////////        if (((column == 0 || column == 4) && (row > 3 || row < 1)) || row == column || (column == 1 && row == 3) || column == 3 && row == 1)
////////            Console.Write("*\t");
////////        else
////////            Console.Write("\t");
////////    }
////////    Console.Write("\n");
////////}

////////-----------------------------------------------------------------------------

////////Oraganation org = new Oraganation("prasad", "ngr", 1, 9011410653);
////////org.Display();
////////org.Update("shubham", "pune");
////////org.setValues("raj",2);
////////org.Display();


////////class Oraganation
////////{
////////    private string Name;
////////    private string Address;
////////    private int Id;
////////    private long Phone;


////////    public void setValues(string name,int Id) 
////////    {
////////        this.Name=name;
////////        this.Id=Id;

////////    }

////////    public Oraganation(string Name, string Address, int Id, long Phone)
////////    {
////////        this.Name = Name;
////////        this.Address = Address;
////////        this.Id = Id;
////////        this.Phone = Phone;
////////    }

////////    public void Display()
////////    {
////////        Console.WriteLine($"{Name} , {Address} , {Id} ,{Phone}");
////////    }

////////    public void Update(string Name, string Address)
////////    {
////////        this.Name = Name;
////////        this.Address = Address;
////////    }


////////}


//////////-------------------------  print sum of array --------------------------------------------

////////Console.Write("enter row : ");
////////int row = int.Parse(Console.ReadLine());

////////Console.Write("enter col : ");
////////int col = int.Parse(Console.ReadLine());

////////int[,] arr = new int[row,col];

////////for (int i = 0; i < arr.GetLength(0); i++)
////////{
////////    for(int j = 0; j < arr.GetLength(1); j++)
////////    {
////////        Console.Write("enter array value : ");
////////        arr[i,j] = int.Parse(Console.ReadLine());
////////    }

////////}
////////int sum = 0;
////////for (int i = 0; i < arr.GetLength(0); i++)
////////{
////////    for (int j = 0; j < arr.GetLength(1); j++)
////////    {
////////        sum+=arr[i,j];
////////    }

////////}
////////Console.Write("print sum of  the array : "+sum);


////////-------------------------------  find gretest array find prime number  -------------------------------------

////////Console.Write("enter row : ");
////////int row = int.Parse(Console.ReadLine());

////////Console.Write("enter col : ");
////////int col = int.Parse(Console.ReadLine());

////////int[,] arr = new int[row, col];

////////for (int i = 0; i < arr.GetLength(0); i++)
////////{
////////    for (int j = 0; j < arr.GetLength(1); j++)
////////    {
////////        Console.Write("enter array value : ");
////////        arr[i, j] = int.Parse(Console.ReadLine());
////////    }
////////}

////////int gretestNumber = arr.Cast<int>().Max();
////////Console.Write("print array gretest number : " + gretestNumber + "\n");

////////string CheckPrimeNumber = (gretestNumber % 2 == 0) ? gretestNumber + " : Number is not Prime."  : gretestNumber + " : Number is Prime.";
////////Console.Write(CheckPrimeNumber);



////////========================================   oops ======================================================
////////Create Account class as Abstract and override some methods in saving_acoount and current_account class.  
////////A.Display account information  
////////Properties :
////////Account- AccountId , Branch Location , Balance, AccountType 
////////Saving_ account - TypeName , Interest Rate 
////////current_ account - TypeName , Interest Rate 
////////-------------------------------------------------------------------

///////*Account s = new SavingAccount(5, "Ahmednagar", 5000);
//////s.Display();
//////s.RateOfInterest();
//////s.Display();
//////Account c = new Current_Account(10, "Pune", 10000);
//////c.Display();
//////c.RateOfInterest();
//////c.Display();

//////abstract class Account
//////{
//////    protected int AccountId;
//////    protected string Branch_Location;
//////    protected int Balance;
//////    protected string Account_Type;

//////    public abstract void RateOfInterest();

//////    public void Display()
//////    {
//////        Console.WriteLine(" --------------------------------------------------------------------------------------------");
//////        Console.WriteLine($"| Account-Id: {AccountId,3} | Branch-Location : {Branch_Location,-10} | Balance: {Balance,-10} | Account-Type: {Account_Type} |");
//////    }
//////}
//////class SavingAccount : Account
//////{
//////    int rateOfInterest = 5;
//////    public SavingAccount(int AccountId, string Branch_Location, int Balance)
//////    {
//////        this.AccountId = AccountId;
//////        this.Branch_Location = Branch_Location;
//////        this.Balance = Balance;
//////        this.Account_Type = "Saving";
//////    }
//////    public override void RateOfInterest()
//////    {
//////        var interest = Balance * rateOfInterest / 100;
//////        Balance += interest;
//////    }
//////}

//////class Current_Account : Account
//////{
//////    int rateOfInterest = 3;
//////    public Current_Account(int AccountId, string Branch_Location, int Balance)
//////    {
//////        this.AccountId = AccountId;
//////        this.Branch_Location = Branch_Location;
//////        this.Balance = Balance;
//////        this.Account_Type = "Saving";
//////    }
//////    public override void RateOfInterest()
//////    {
//////        var interest = Balance * rateOfInterest / 100;
//////        Balance = Balance+ interest;
//////    }
//////}

//////*/

////////-------------------------------------------------------------------------------------------------------------------------
////////12.Create two class book and library and implement has-a-relationship  between those classes 
////////A. Display Books of library  B.library has many books 

//Libarary a = new Libarary();
//a.Display();
//Libarary b = new Libarary();
//b.Display();
//Book c = new Book();
//c.Display();
//Console.WriteLine("Total Books in Libarary : > "+Libarary.TotalCountBook());


//class Libarary
//{
//    public static int count = 0;
//    public void Display()
//    {
//        Console.WriteLine("Libarary Books");
//    }
//    public Libarary()
//    {
//        count++;
//    }

//    public static int TotalCountBook()
//    {
//        return count;

//    }
//}


//class Book : Libarary
//{
//    public void Display()
//    {
//        Console.WriteLine("book");    
//    }
//}






////////----------------------------------------- pattern program----------------------------------------------------------------------

////////    *
////////   ***
////////  *****
//////// *******
////////*********
//////// *******
////////  *****
////////   ***
////////    *


//////Console.Write("enter number : ");
//////int n = int.Parse(Console.ReadLine());

//////for (int i = 1; i <= n; i++)
//////{
//////    for (int j = 1; j <= (n - i); j++)
//////    {
//////        Console.Write(" ");
//////    }
//////    for (int k = 1; k < i * 2; k++)
//////    {
//////        Console.Write("*");
//////    }
//////    Console.WriteLine();
//////}

//////for (int i = n - 1; i >= 1; i--)
//////{
//////    for (int j = 1; j <= (n - i); j++) 
//////    {
//////        Console.Write(" ");
//////    }
//////    for (int k = 1; k < i * 2; k++)
//////    {
//////        Console.Write("*");
//////    }
//////    Console.WriteLine();
//////}

//////Console.WriteLine();

//////---13 ass ---------------------------------------------------------------------------------------
////Person p1 = new Person();
////p1.age = 10;
////p1.name = "A";

////Person p2 = new Person();
////p2.age = 20;
////p2.name = "B";

////p1.saysHi();
////p2.saysHi();

////swap1(p1, p2);

////p1.saysHi();
////p2.saysHi();

////void swap1(Person psn1, Person psn2)
////{
////    Person temp = psn1;
////    psn1 = psn2;
////    psn2 = temp;
////}
////public class Person
////{
////    public int age;
////    public String name;

////    public void saysHi()
////    {
////        Console.WriteLine(name + "[" + age + "] says hi");
////    }
////}


//////--14 ass --------------------------------------------------------
//14.demart owner want  to store  customer information. they want  give discount to customer based on customer type("dailly_cust","weeklly_cust","monthly_cust","other")

//using following data made a program for demart.

//    note :five class should be there in assignment.
//          used abstraction approach while solving program

//    properties need in classes:

//            customer--      cust_name,cust_phone,cust_address,total_amt,actual_paidamount,date_of_order
//               (actual_paidamount  means what amount will be paid after the given discount;)
//            dailly_cust--   discountrate,
//            weeklly_cust--  discountrate,
//            monthly_cust--  discountrate

//    1.dailly_cust have 4 % discount on purchase.
//    2. weeklly_cust have 3% discount on purchase.
//    3. monthly_cust have 2% discount on purchase.
//    4. other have not discount.

Customer c = new Dailly_Cust("abc", 9876543213, "ngr", 500, 500, "16-4-2022");
c.Display();
c.Discount();
Console.Write($"4% discount daily Customer : ");
c.Display();

Customer w = new Weeklly_Cust("abc", 9876543213, "ngr", 500, 500, "16-4-2022");
w.Display();
w.Discount();
Console.Write($"3% weaklly daily Customer : ");

w.Display();

Customer m = new Monthly_Cust("abc", 9876543213, "ngr", 500, 500, "16-4-2022");
m.Display();
m.Discount();
Console.Write($"3% discount monthly Customer : ");
m.Display();

Customer o = new Other_Cust("abc", 9876543213, "ngr", 500, 500, "16-4-2022");
o.Display();
o.Discount();


abstract class Customer
{
    protected string cust_name;
    protected long cust_phone;
    protected string cust_address;
    protected int total_amt;
    protected int actual_paidamount;
    protected string date_of_order;

    public Customer(string cust_name, long cust_phone, string cust_address, int total_amt, int actual_paidamount, string date_of_order)
    {
        this.cust_name = cust_name;
        this.cust_phone = cust_phone;
        this.cust_address = cust_address;
        this.total_amt = total_amt;
        this.actual_paidamount = actual_paidamount;
        this.date_of_order = date_of_order;
    }

    public abstract void Discount();

    public void Display()
    {

        Console.WriteLine($"{cust_name} , {cust_phone} ,{cust_address}, {total_amt} ,{actual_paidamount} ,{date_of_order}\n");
    }
}

class Dailly_Cust : Customer
{
    int daily_discount = 4;
    public Dailly_Cust(string cust_name, long cust_phone, string cust_address, int total_amt, int actual_paidamount, string date_of_order) : base(cust_name, cust_phone, cust_address, total_amt, actual_paidamount, date_of_order)
    {
    }

    public override void Discount()
    {
        var dis = total_amt * daily_discount / 100;
        actual_paidamount = total_amt - dis;

    }
}

class Weeklly_Cust : Customer
{
    int weeklly_cust = 3;
    public Weeklly_Cust(string cust_name, long cust_phone, string cust_address, int total_amt, int actual_paidamount, string date_of_order) : base(cust_name, cust_phone, cust_address, total_amt, actual_paidamount, date_of_order)
    {
    }

    public override void Discount()
    {
        var dis = total_amt * weeklly_cust / 100;
        actual_paidamount = total_amt - dis;

    }
}

class Monthly_Cust : Customer
{
    int monthly_cust = 2;
    public Monthly_Cust(string cust_name, long cust_phone, string cust_address, int total_amt, int actual_paidamount, string date_of_order) : base(cust_name, cust_phone, cust_address, total_amt, actual_paidamount, date_of_order)
    {
    }

    public override void Discount()
    {
        var dis = total_amt * monthly_cust / 100;
        actual_paidamount = total_amt - dis;

    }
}


class Other_Cust : Customer
{

    public Other_Cust(string cust_name, long cust_phone, string cust_address, int total_amt, int actual_paidamount, string date_of_order) : base(cust_name, cust_phone, cust_address, total_amt, actual_paidamount, date_of_order)
    {
    }

    public override void Discount()
    {
        Console.WriteLine("other customer not Applicable discount ");
    }
}