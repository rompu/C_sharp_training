using System;

namespace Nullable
{
    class Program

    {
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2021,1,1); //? makes date nullable so that it can be set to null if date is not given
            DateTime date2; 

            date = null;

            date2 = date.GetValueOrDefault(); //cannot have date2 = date because date2 cannot be null, however GetValueOrDefault will return default date if date is null

            if (date != null)
                date2 = date.GetValueOrDefault();
            else
                date2 = DateTime.Today;



            //Null coalesing operator, the above can be written shorter
            DateTime date3 = date ?? DateTime.Today; //If date has a value put it in date3, otherwise put DateTime.Today

            //Similar syntax as in ternary conditional operator
            DateTime date4 = (date == null) ? DateTime.Today : date.GetValueOrDefault();

            Console.WriteLine(date4);






        }
    }
}
