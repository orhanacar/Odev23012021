using System;
using System.Collections.Generic;
using System.Text;

namespace Odev23012021
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];

        }
        public void Add(TKey key, TValue value)
        {
           

            TKey[] TempKeys = keys;
            TValue[] TempValue = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < TempKeys.Length; i++)
            {
                keys[i] = TempKeys[i];
                values[i] = TempValue[i];

            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
        public int Length
        {
            get { return keys.Length; }

        }
    }
}