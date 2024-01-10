using Exerc_2_Taxes.Entities;

List <Person> people = new List<Person>();

System.Console.WriteLine("Enter the number of tax players: ");
int numberPlayers = int.Parse(Console.ReadLine());

for(int i = 1; i <= numberPlayers; i++)
{
    System.Console.WriteLine($"Tax player #{i} data");
    System.Console.WriteLine("Individual or Company? (i/c)? ");
    char i_OR_c = char.Parse(Console.ReadLine());

    System.Console.WriteLine("Name: ");
    string name = Console.ReadLine();

    System.Console.WriteLine("Anual Income: ");
    double annualTax = double.Parse(Console.ReadLine());

    if (i_OR_c == 'i')
    {
        System.Console.WriteLine("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine());
        people.Add(new PhysicalPerson(name, annualTax, healthExpenditures));
    }

    if (i_OR_c == 'c')
    {
        System.Console.WriteLine("Number of employees: ");
        int numberEmployees = int.Parse(Console.ReadLine());
        people.Add(new LegalPerson(name, annualTax, numberEmployees));
    }
}

System.Console.WriteLine("TOTAL TAXES: ");
foreach(Person person in people)
{
    System.Console.WriteLine($"{person.Name} ${person.TaxesPaid()}");
}