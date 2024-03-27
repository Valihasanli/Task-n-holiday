using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using task_holiday_;
//Employee employee1 = new()
//{
//   Name = "Arif",
//   Surname = "Suleymanov",
//   Age = 22,
//   DepartmentName = "Hardware",
//   Salary = 1250.7
//};
//Employee employee2 = new()
//{
//   Name = "Murad",
//   Surname = "Hesenov",
//   Age = 24,
//   DepartmentName = "Software",
//   Salary = 1500.5
//};
//Employee employee3 = new()
//{
//   Name = "Ilkin",
//   Surname = "Quliyev",
//   Age = 18,
//   DepartmentName = "Al-ver",
//   Salary = 1000000
//};
//employee1.ShowEmployeeInfo();
//employee2.ShowEmployeeInfo();
//employee3.ShowEmployeeInfo();

//Department Employees = new Department();
//Employees.AddEmployee(employee1);
//Employees.AddEmployee(employee2);
//Employees.AddEmployee(employee3);
//Employees.ShowAllEmployees();
int number = 2;
Department Employees = new Department();
switch (number)
{
    case 1:
        Console.WriteLine("Ishchinin adini daxil et:");
        string name = Console.ReadLine();

        Console.WriteLine("ishchinin soyadini daxil et:");
        string surname = Console.ReadLine();

        Console.WriteLine("Ishchinin yashini daxil et: ");
        string agestr = Console.ReadLine();
        bool age = byte.TryParse(agestr, out byte result);

        Console.WriteLine("Ishchinin departmen");
        string departmentname = Console.ReadLine();

        Console.WriteLine("Ishchinin maashini daxil et: ");
        string salarystr = Console.ReadLine();

        bool salary = double.TryParse(salarystr, out double salary1);
        Employee employee = new Employee(name, surname, result, departmentname, salary1);

        Employees.AddEmployee(employee);
        break;

    case 2:
        Employees.ShowAllEmployees();
        break;
    case 3:
       // Əgər 3 - ü seçsək bizdən maxSalary və minSalary tələb etməlidir if(salary>=minSalary && salary<=maxSalary) serti yoxlanilir eger odeyirse employee ekrana cixarilir
    case 0:
        break;//C:\Users\User\Desktop\task(holiday)\task(holiday)\task(holiday)\bin\Debug\net8.0\task(holiday).exe (process 7588) exited with code 0.Bele netice verdi duzelde bilmedim
}




namespace task_holiday_
{
    class Employee 
    {
        public Employee(string name,string surname,byte age,string departmentname,double salary)//her hansi birini daxil etmesek yaratmaq olmur
        {
            Name=name;
            Surname=surname;
            Age=age;
            DepartmentName=departmentname;
            Salary=salary;
        }

        public Employee(string? name, string? surname)
        {
        }

        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public double Salary;


        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age} {this.DepartmentName} {this.Salary} ");
        }
    }

    class Department
    {
        Employee[] Employees;

        public Department()
        {
            Employees = new Employee[0];
        }        

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length+1);
            Employees[Employees.Length-1] = employee;
        }
        public Employee[] GetAllEmployees()
        {
            return Employees;
        }
        public void ShowAllEmployees()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($"{Employees[i].Name} {Employees[i].Surname} {Employees[i].Age} {Employees[i].DepartmentName} {Employees[i].Salary}");
            }    
        }
        
    };

}