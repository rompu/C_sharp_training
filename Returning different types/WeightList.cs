using System;
using System.Collections.Generic;

namespace WeightObjectTest
{
    public class WeightList:IWeightObject
    {

    private Dictionary<string, IWeightObject> _weightItems = new Dictionary<string, IWeightObject>();



    public string Name { get; set; }
  
    public Field Weight
        {
            get {return SumWeight(); }

            set { }
        }



    public void AddWeightItem(string name)
    {
        var weightItem = new WeightItem();
        _weightItems.Add(name, weightItem);
    }

    public IWeightObject GetWeightItem(string name)
    {
            _weightItems.TryGetValue(name, out IWeightObject weightObject);
            return weightObject;
        }

        public Field SumWeight()
        {
            Field totalWeightInList = new Field();
            foreach (WeightItem weightItem in _weightItems.Values)
            {
                totalWeightInList.Value += weightItem.Weight.Value;
            }
            return totalWeightInList;
        }


    }



    
}
