using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<key, value>
    {
        key[] numberPlates;
        value[] cities;


        public MyDictionary()
        {
            numberPlates = new key[0];
            cities = new value[0];
        }

        public void Add(key numberPlate, value city)
        {
            key[] tempArray = numberPlates;
            value[] tempArray2 = cities;

            numberPlates = new key[numberPlates.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                numberPlates[i] = tempArray[i];
            }

            cities = new value[cities.Length + 1];
            for (int j = 0; j < tempArray2.Length; j++)
            {
                cities[j] = tempArray2[j];
            }

            numberPlates[numberPlates.Length - 1] = numberPlate;
            cities[cities.Length - 1] = city;
        }

        public int Length
        {
            get { return numberPlates.Length; }
        }
        public int Length2
        {
            get { return cities.Length; }
        }

        public void ToList()
        {
            for (int k = 0; k < numberPlates.Length; k++)
            {
                Console.WriteLine(numberPlates[k] + " :  " + cities[k]);
            }
        }






    }
}
