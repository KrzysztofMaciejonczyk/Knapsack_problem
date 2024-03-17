using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Result
    {
        private List<int> _numbersOfItems = new List<int>();
        private int _totalWeight = 0;
        private int _totalValue = 0;
        public void toString() { }
        public List<int> GetNumberOfItems() { return _numbersOfItems; }
        public int getTotalWeight() { return _totalWeight;}
        public int getTotalValue() { return _totalValue;}
        public void AddTotalWeight(int weight) { _totalWeight += weight; }
        public void AddTotalValue(int value) { _totalValue += value; }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            if (_numbersOfItems.Count == 0) 
            {
                str.Append("No items found.");
            }
            else
            {
                str.Append("Items:");
                for (int i = 0; i < _numbersOfItems.Count; i++)
                {
                    str.Append(" " + _numbersOfItems[i]);
                }
                str.Append(System.Environment.NewLine);
                str.Append("Total value: " + _totalValue + System.Environment.NewLine);
                str.Append("Total weight: " + _totalWeight + System.Environment.NewLine);
            }
            return str.ToString();
        }

    }
}
