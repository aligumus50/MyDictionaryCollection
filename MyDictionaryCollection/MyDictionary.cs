using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryCollection
{
    class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] tempArrayK = keys;
            V[] tempArrayV = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempArrayK.Length; i++)
            {
                keys[i] = tempArrayK[i];
            }

            for (int j = 0; j < tempArrayV.Length; j++)
            {
                values[j] = tempArrayV[j];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

    }
}
