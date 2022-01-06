using System;

namespace Serialization
{    //Binary: https://www.youtube.com/watch?v=WHKPcA_xvE0
    //XML: https://www.youtube.com/watch?v=M8VeTHB08ao
    //json: https://www.youtube.com/watch?v=Ib3jnD158NI&t=38s
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input serializationmethos: Binary/XML/json");
            string sMethod = Console.ReadLine();

            Person person = new Person() { FirstName = "John", LastName = "Smith" };
            Person p = null;
            string filePath = "data.save";//"c:/sandbox/data.save";
            DataSerializer dataSerializer = new DataSerializer();
            if (sMethod == "Binary")
            {
                dataSerializer.BinarysSerialize(person, filePath);
                p = dataSerializer.BinaryDeserialize(filePath) as Person;
            }
            else if(sMethod == "XML"){
                dataSerializer.XmlSerialize(typeof(Person), person, filePath);
                p = dataSerializer.XmlDeserialize(typeof(Person), filePath) as Person;
            }            
            else if(sMethod == "json"){
                dataSerializer.JsonSerialize(person, filePath);
                p = dataSerializer.JsonDeserialize(typeof(Person), filePath) as Person;
            }

            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
        }
    }
}
