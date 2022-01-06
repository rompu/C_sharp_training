namespace WeightObjectTest
{
    public interface IWeightObject
    {
        public Field Weight { get; set; }

        public void AddWeightItem(string name);

        public IWeightObject GetWeightItem(string name);


    }
}
