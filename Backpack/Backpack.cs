using System.Runtime.CompilerServices;
using System.Text;
[assembly: InternalsVisibleTo("Backpack_testUnit")]
[assembly: InternalsVisibleTo("BackpackGUI")]
namespace LAB1
{
    internal class Backpack
    {
        int _items;
        //Item[] _listOfItems;
        public Item[] _listOfItems{ get; set; }

        public Backpack(int number, int seed) 
        {
            _items = number;
            _listOfItems = new Item[number];
            Random random = new Random(seed);
            CreateItems(random);
        }
        //Constructor for unit tests
        public Backpack(int number) 
        {
            _items = number;
            _listOfItems = new Item[number];
        }
        public static int CompareByValuePerWeightThenByWeight(Item item1, Item item2)
        {
            if (item1.GetvaluePerWeight() == item2.GetvaluePerWeight())
            {
                return item2.GetWeight().CompareTo(item1.GetWeight());
            }
            else
            {
                return item1.GetvaluePerWeight().CompareTo(item2.GetvaluePerWeight());
            }  
        }
        private void CreateItems(Random random)
        {
            for (int i = 0; i < _items; i++)
            {
                _listOfItems[i] = new Item();
                _listOfItems[i].SetWeight(random.Next(1,11));
                _listOfItems[i].SetValue(random.Next(1,11));
                _listOfItems[i].SetIndex(i);
            }
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            if (_listOfItems.Length == 0)
            {
                str.Append("No items found.");
            }
            else
            {
                for (int i = 0; i < _listOfItems.Length; i++)
                {
                    str.Append("Item: " + _listOfItems[i].GetIndex() + " Weight: " + _listOfItems[i].GetWeight() + " Value:" + _listOfItems[i].GetValue() + System.Environment.NewLine);
                }
            }
            return str.ToString();
        }
        public void DisplayList()
        {
            Console.WriteLine("Items:");
            for (int i=0; i < _listOfItems.Length; i++)
            {
                Console.WriteLine("Item: " + _listOfItems[i].GetIndex() +" Weight: "+_listOfItems[i].GetWeight()+" Value:"+ _listOfItems[i].GetValue());
            }
        }
        public Result Solve(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("Capacity cannot be smaller than 0.");
            }
            Result result = new Result();
            for (int i=0; i < _listOfItems.Length; i++)
            {
                _listOfItems[i].SetvaluePerWeight((float)_listOfItems[i].GetValue() / (float)_listOfItems[i].GetWeight());
            }
            Array.Sort(_listOfItems, CompareByValuePerWeightThenByWeight);
            Array.Reverse(_listOfItems);

            for (int i=0; i < _listOfItems.Length; i++)
            {
                if (capacity - result.getTotalWeight() - _listOfItems[i].GetWeight() >= 0)
                {
                    result.GetNumberOfItems().Add(_listOfItems[i].GetIndex());
                    result.AddTotalValue(_listOfItems[i].GetValue());
                    result.AddTotalWeight(_listOfItems[i].GetWeight());
                }
            }
            return result;
        }
    }
}
