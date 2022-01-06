using System;
using System.Collections.Generic;
using System.Linq;



namespace LamdaExpressions
{
    //Lambda expressions are anonymous functions
    // => is the lambda operator
    // left side is input
    // right side of operator is the expression/statement
    //https://www.youtube.com/watch?v=DSxjciDUBdw

    class Lambda
    {
        static void Main(string[] args)

        {

            var list = new List<int> { 1, 2, 3 };
            //var x = 0;
 
            //Console.WriteLine(x =>list.Sum()*x);
            Console.WriteLine();
            //Expression lambda

            Func<int, int, bool> Test = (x, y) => x > y;


            //Statement lambda

            Func<int, int, bool> Test2 = (x, y) =>
            {
                var sum = x + y;
                Console.WriteLine(sum);
                return x > y;
            };

            Func<double, double> Test3 = x => x * 100;

            Console.WriteLine(Test3(0.53));

            Func<List<int>, int> Max = numbers =>
             {
                 int max = numbers[0];
                 foreach (int number in numbers)
                 {
                     if (number > max)
                         max = number;
                 }
                 return max;
             };

            //Using lambda statement in a method call
            var bookRepo = new BookRepository();
            var bookList = bookRepo.GetBooks();
            var bookList2 = bookList.Select(b => b.Price > 10).ToList();

            //Select
            string[] fruits = { "apple", "banana", "mango", "orange",
                      "passionfruit", "grape" };

            var query =
                fruits.Select((fruit, index) =>
                                  new { index, str = fruit.Substring(0, index) });

            foreach (var obj in query)
            {
                Console.WriteLine("{0}", obj);
            }


            var testList = new List<int> { 1, 2, 10, 22, 8 };
            Console.WriteLine("The largest number of the list is {0}" ,Max(testList));
            Console.WriteLine(Test(1, 2));
            Console.WriteLine(Test2(1,2));
            //Func<int, int> square = number => number*number;
            //Console.WriteLine(square(2));

            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b=>b.Price<20); //Here we could alternatively call a function that returns bool like IsCheaperThan30, however lamda expression is shorter
 
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }
        public bool Test2Function(int x, int y)
        {
            var sum = x + y;
            Console.WriteLine(sum);
            return x > y;
        }
    }

        class BookRepository
    {
        private List<Book> books = new List<Book>();



        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title = "Glöm mig", Price = 10 },
                new Book() { Title = "IS", Price = 25 },
                new Book() { Title = "Sapiens", Price = 30 }
            };
        }

    }

    class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
}
