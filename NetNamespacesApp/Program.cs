using MyLibrary;
using NetNamespacesApp;
using PersonApp;

using Newtonsoft.Json;



User user = new User() { Name = "Sam", Age = 34 };
string json = JsonConvert.SerializeObject(user);
Console.WriteLine(json);



PersonApp.MyPerson.Person person = new PersonApp.MyPerson.Person();

Employee employee = new Employee();

employee.Name = "Bobby";
employee.Age = 30;

Money dollar = new Money(95.0m);
Money.GetN();

Console.WriteLine(dollar.Course);

MyMath.Sum(10, 20);