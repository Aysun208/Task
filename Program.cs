namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(245, "asd", 245);
            BankAccount account1 = new BankAccount(245, "asd", 245);
            Console.WriteLine("emeliyyat secin");
            Console.WriteLine(" \n 1.DisplayAccountInfo \n 2. Deposit \n 3. WithDraw \n 4. esas menyu \n 0.Quit Application");
            int Menu = int.Parse(Console.ReadLine());
       
            switch(Menu)
            {
                case 1:
                    account1.DisplayAccountInfo();
                    break;
                    case 2:
                    Console.WriteLine("ne qeder pul elave etmek isteyirsiniz");
                    decimal deposit = int.Parse(Console.ReadLine());
                    account1.Deposit(deposit);
                    break;
                    case 3:
                    Console.WriteLine("ne qeder pul elave etmek isteyirsiniz");
                    decimal withdraw = int.Parse(Console.ReadLine());  
                    account1.   WithDraw(withdraw);
                    break;
                    case 4:
                    Console.WriteLine("esas menyuya qayit");
                    break;
                case 0:
                    Console.WriteLine("bitir");
                    return;
            }
        }


    }
}
