using Bogus;
using datatable.Models;

namespace datatable.Data;

public class EmployeeSeedData
{
    public static List<Employee> GetSampleData()
    {
        
        var status = new[] { "employee", "retired", "intern", "experienced" };
        var Id = 1;
        
        var faker = new Faker<Employee>()
            .StrictMode(true)
            .RuleFor(t => t.Id,f=>Id++ )
            .RuleFor(t => t.Age, f => f.Random.Number(15, 35))
            .RuleFor(t => t.Name, f => f.Name.FullName())
            .RuleFor(t => t.Company, f => f.Company.CompanyName())
            .RuleFor(t => t.Status, f => f.PickRandom(status));

        var employees = faker.Generate(45);

        return employees;
    }
}