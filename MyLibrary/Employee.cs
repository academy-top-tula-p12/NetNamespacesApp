namespace MyLibrary
{
    public class Employee
    {
        
        int age;

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value > 0) age = value;
            }
        }

        void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
