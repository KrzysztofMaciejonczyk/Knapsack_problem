using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAB1
{
    internal class Item
    {
        private int _weight;
        private int _value;
        private float _valuePerWeight;
        private int _index;
        public int GetWeight() { return _weight; }
        public void SetWeight(int weight) { _weight = weight; }
        public int GetValue() { return _value; }
        public void SetValue(int value) { _value = value; }
        public float GetvaluePerWeight() { return _valuePerWeight; }
        public void SetvaluePerWeight(float valuePerWeight) { _valuePerWeight = valuePerWeight; }
        public int GetIndex() { return _index; }
        public void SetIndex(int index) { _index = index; }

    }

    
}
