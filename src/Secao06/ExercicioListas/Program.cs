
namespace Secao06.ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            System.Console.Write("How many employess will be registered? ");
            int qtdEmplyoess = int.Parse(Console.ReadLine());

            for(int i = 0; i <qtdEmplyoess; i++)
            {
                System.Console.WriteLine($"Employee #{i+1}:");
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                Employee pessoa = new Employee (id, name, salary);
                employees.Add(pessoa);
            }
            System.Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());
            Employee emp = employees.Find(x => x.Id == searchId);

            if (emp != null)
            {
                System.Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.RaiseSalary(percentage);
            }
            else
            {
                System.Console.WriteLine("This id does not exist!");
            }

            System.Console.WriteLine("Update list of employess:");
            foreach (var pessoas in employees)
            {
                System.Console.WriteLine(pessoas);
            }
            

        }    
        
    }
}