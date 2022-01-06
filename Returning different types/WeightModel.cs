using System.Collections.Generic;
namespace WeightObjectTest
{
    public class WeightModel
    {
        private  Dictionary<string, IWeightObject> _weighObjects = new Dictionary<string, IWeightObject>();

        public string Name { get; set; }

        public WeightList WeightList { get; set; }
        public WeightItem WeightItem { get; set; }


        public WeightList AddWeightList(string name)
        {
            var weightList = new WeightList();
            _weighObjects.Add(name, weightList);
            return weightList;
        }

        public WeightItem AddWeightItem(string name)
        {
            var weightItem = new WeightItem();
            _weighObjects.Add(name, weightItem);
            return weightItem;
        }

        public IWeightObject GetWeightList(string name)
        {
            _weighObjects.TryGetValue(name, out IWeightObject weightObject);
            return weightObject;
        }
    }

}
