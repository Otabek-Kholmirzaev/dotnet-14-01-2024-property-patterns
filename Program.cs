var emp = new Employee(49, "Otabek", 1000);
Console.WriteLine(emp.Salary);
emp.GiveBonus(100);
Console.WriteLine(emp.Salary);


class Employee
{
    int _age;
    string _name;
    int _salary; 
    public int Salary 
    {
        get => _salary;
        set => _salary = value;
    }
    public Employee(int age, string name, int salary)
    {
        _age = age;
        _name = name;
        _salary = salary;
    }
    
    public void GiveBonus(int amount)
    {
        _salary = this switch 
        {
            {_age: > 50 } => _salary + amount,
            _ => _salary + amount / 2
        };
    }
}
