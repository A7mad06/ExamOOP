namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Shallow Copy - Deep Copy
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());
            //Arr02 = Arr01;
            ////Shallow Copy 
            ////Same Object two names
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());
            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);//100
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());
            //Arr02 = (int[])Arr01.Clone();
            ////Shallow Copy 
            ////Same Object two names
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());
            #endregion
            #region IClonable
            //Employee emp1 = new Employee() { Id = 1, Name = "ahmad", Salary = 10000 };
            //Employee emp2 = new Employee() { Id = 2, Name = "muhammad", Salary = 20000 };
            //Console.WriteLine(emp1.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());
            //emp2 = (Employee)emp1.Clone();
            //Console.WriteLine(emp1.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());
            #endregion
            #region IComparable And Generics
            Employee[] employees =
            {
                new Employee(){ Id=1,Name="Ahmad",Salary=19673},
                new Employee(){ Id=2,Name="Muhammad",Salary=56295},
                new Employee(){ Id=3,Name="Adeeb",Salary=94736},
                new Employee(){ Id=4,Name="Yousef",Salary=86746}
            };
            for(int i = 0; i < employees.Length; i++)
            {
                for(int j = 0; j < employees.Length - i - 1;j++)
                {
                    if (employees[j].CompareTo(employees[j+1]) == 1)
                    {
                        Helper<Employee>.SWAP(ref employees[j], ref employees[j+1]);
                    }
                }
            }
            foreach(Employee e in employees)
            {
                Console.WriteLine(e);
            }
            #endregion

        }
    }
}
