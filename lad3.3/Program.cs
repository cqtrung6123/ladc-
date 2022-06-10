// See https://aka.ms/new-console-template for more information
using lad3._3;

  List<Employee> employees = new List<Employee>();
Console.WriteLine("Program Employee");
Console.WriteLine("======================");
while (true)
{
    Console.WriteLine("1. add employee");
    Console.WriteLine("2. Get all employee");
    Console.WriteLine("3. Get bonus employee");
    Console.WriteLine("4. Exit");
    Console.WriteLine("choose 1-4");
    int choose= Int16.Parse(Console.ReadLine());
    switch (choose)
    {
        case 1:
            Console.WriteLine("Enter the first name employee:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the last name employee:");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter address employee:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter sin employee:");
            long sin = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter sin employee:");
            double salary = double.Parse(Console.ReadLine());
            Employee emp2 = new Employee(fname,lname,address,sin,salary);
            employees.Add(emp2);
            break;
        case 2:
            em
            break;
        case 3:
            Console.WriteLine("Enter the precentage:");
            float precentage=float.Parse(Console.ReadLine());
            emp.CaculateBonus(precentage);
            break;
        case 4:
            
            System.Console.WriteLine("Exit");
      
            break;
    }
}

