public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public string FirstName => this.firstName;

    public string LastName => this.lastName;

    public int Age => this.age;

    public double Salary
    {
        get => this.salary;
        private set => this.salary = value;
    }

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public void IncreaseSalary(double bonus)
    {
        if (this.Age < 30)
        {
            bonus /= 2;
        }

        double bonusSalary = this.Salary * bonus / 100;
        this.Salary += bonusSalary;
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this.Salary:F2} leva";
    }
}