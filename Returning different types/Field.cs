using System;
using System.Data;
namespace WeightObjectTest
{

    public class Field
    {

        private string _name;
        public int Id { get; private set; }
        public double Value { get; set; }
        public string Name {
            get { return _name; }  
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Field name must not be null or empty");

                _name = value;
            }
        }

        public Field()
        {

        }
        public Field(string name)
        {
            Name = name;
        }

        public object Calculate(string equationString)
        {
            Value = Convert.ToDouble(new DataTable().Compute(equationString, null));
            return Value;
        }


    }

}
