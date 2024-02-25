namespace cs3
{
    internal class Program
    {
        static void Main()
        {
            var data = new Data(1, 1, 2001);
            Console.WriteLine("Enter pip: ");
            string pip = Console.ReadLine();
            
            Console.WriteLine("Enter phone: ");
            string phone = Console.ReadLine();
            
            Console.WriteLine("Enter email: ");
            string email = Console.ReadLine();
            
            Console.WriteLine("Enter post: ");
            string post = Console.ReadLine();
            
            Console.WriteLine("Enter responsibilities: ");
            string respon = Console.ReadLine();

            Employee employee = new Employee(pip, data, phone, email, post, respon);
            employee.ShowInfo(data);
        }
    }
}
