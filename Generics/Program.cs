using System;

namespace Generics
{   //used to store generic data. the type int double, object need not to be pre-defined
    //useful predefined generic lists found in System.Collection.Generic
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new Genericlist<int>();
            //numbers.Add(10);

            //var books = new Genericlist<Book>();
            //books.Add(new Book());

            //var dictionary = new GenericDictonary<string, Book>();

            //var book = new Book();
            //book.Title = "Hitch hikers guide to the galaxy";
            //book.Index = 1;
            //dictionary.Add("1",book);


            //var number2 = new Nullable<int>();
            //Console.WriteLine("Has value? "+number2.HasValue);
            //Console.WriteLine("Value: " +number2.GetValueOrDefault());

            var utility = new Utilities();
            int result = utility.Max<int>(1, 3);
            Console.WriteLine(result);


            var weight = new WeightField("testW",1000);
            weight.SetValue(100);

            var xCog = new COGField();
            xCog.SetValue(100);

            var w1=weight.GetValue();
            var x1 = xCog.GetValue();

        }
    }

    class Genericlist<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public int Index { get; set; }

        public float Price { get; set; }
    }

    class GenericDictonary<TKey, TValue> //prefix with T and then give a proper name
    {
        public void Add(TKey key, TValue value)
        {

        }
    }
    class Utilities
    {
        public T Max<T>(T a, T b) where T : IComparable //IComparable is a constraint
        //other constraints:
        //where T  Product ->Product is a clss
        //where T: struct -> value type
        //where T: class
        //where T: new() -> object that has  default constructor
        {
            return a.CompareTo(b) > 0 ? a : b;
            //return a > b ? a : b; //return a if a is lager than b, however this doesnt compile becase the compiler doesn't know if a and b are values
        }
    }

    class DiscountCalulator<TProduct> where TProduct: Book
    {
        public float CalculateDiscount(TProduct book)
        {
            //do something...
            return book.Price;
        }
    }

    class Nullable<T> where T:struct
    {
        private object _value;

        public Nullable()
        {
            Console.WriteLine("constructor");
        }
        
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }

    public interface IWeightField
    {

        IWeightField GetValue();

        void SetValue(double value);
    }

    public class WeightField : IWeightField
    {
        public double Weight { get; private set; }
        public string Name { get; set; }

        public WeightField(string name, double weight)
        {
            Weight = weight;
            Name = name;
        }
        
        public IWeightField GetValue()
        { 
            return this;
        }
        public void SetValue(double value)
        {
            Weight = value;
        }
    }
    public class COGField : IWeightField
    {
        public double X { get; private set; }

        public IWeightField GetValue()
        {
            return this;
        }

        public void SetValue(double x)
        {
            X = x;
        }
    }
}
