using System.Collections.Generic;
namespace WeightObjectTest
{
    public class WeightItem:IWeightObject
    {
        

        
        private Field _weight = new Field();
        public string Name { get; set; }
        public Field Weight {
            get { return _weight; }
            set {
                Weight.Name = "W";
                _weight = value;
            } 
        
        }
        public Field COG { get; set; }

        public List<Field> Children { get;  set; }

        public void AddField(string name)
        {
            var entity = new Field();
            entity.Name=name;
            Children.Add(entity);

        }
        public void AddWeightItem(string name)
        {
            //A weightItem cannot conaint another weight item, check how to implement

        }

        public IWeightObject GetWeightItem(string name)
        {
            //A weightItem cannot conaint another weight item, check how to implement
            return null;
        }
}
}
