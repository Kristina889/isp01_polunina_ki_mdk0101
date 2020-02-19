using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(name: "Kirill", course: 3, gender: "Male");

            Console.WriteLine(student);

            Employee employee = new Employee(name: "Denis", profession: "Trainee", workExp: 5);

            Console.WriteLine(employee);

            Shop shop = new Shop(stringCip: "83rydfj", numberOfEmp: 45);

            Console.WriteLine(shop);

            Book book = new Book(title: "Война и Мир", listOfAutNumes: "Лев Николаевич Толстой", cost: 3870);

            Console.WriteLine(book);

            Test test = new Test(fIoExaminee: "Денис Генадьевич Петров", fIoExaminer: "Вечеслав Иванович Маликов", date: new DateTime(2015, 05, 12), evaluation: 5);
            
            Console.WriteLine(test);

            Product product = new Product(name: "Сыр", quantity: 6, cost: 300, shelfLife: new DateTime(2000, 05, 12));

            Console.WriteLine(product);

            Address address = new Address(postalCode: 404121, city: "Волжский", street: "Пушкина", house: 17, flat: 131);

            Console.WriteLine(address);

            TrainingGroup trainingGroup = new TrainingGroup(cipher: 090207, numberOfStudents: 18, yearOfFormation: 1986, specialty: "Информационные системы и программировние");

            Console.WriteLine(trainingGroup);

            MonetaryDenomination monetaryDenomination = new MonetaryDenomination(seriesAndNumber: 1816206406, par: 100, parString: "Сто");

            Console.WriteLine(monetaryDenomination);

            ComputerGame computerGame = new ComputerGame(name: "Dota2", developerFirm: "Valve", publicationDate: 2009, genre: "Стратегии");

            Console.WriteLine(computerGame);

            Console.ReadKey();
        }
    }
}
