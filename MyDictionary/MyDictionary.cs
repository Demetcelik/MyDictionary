using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] itemKey;
        TValue[] itemValue;
        
        public MyDictionary()
        {
            itemKey = new TKey[0];
            itemValue = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempArrayKey = itemKey;
            TValue[] tempArrayValue = itemValue;

            itemKey = new TKey[itemKey.Length + 1];
            itemValue = new TValue[itemValue.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                itemKey[i] = tempArrayKey[i];
                itemValue[i] = tempArrayValue[i];

            }


            itemKey[itemKey.Length - 1] = key;
            itemValue[itemValue.Length - 1] = value;

        }

        public int Count
        {
            get { return itemKey.Length; }
        }


        public TKey[] KeyList
        {
            get { return itemKey; }

        }

        public TValue[] ValueList
        {
            get { return itemValue; }

        }
    }
}



              
