using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Store<T> : IEnumerable<T>
    {
        T[] products = new T[10];
        public int count = 0;

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                yield return products[i];
            }
        }

        public void Add(T product)
        {
            if(count == products.Length)
            {
                int index = count * 2;
                T[] extension = new T[index];
                Array.Copy(products, extension, index);
                products = extension;
            }

            products[count] = product;
            count++;
        }

        public void Remove(T product)
        {
            T[] temp = new T[count - 1];
            int tempCount = 0;

            foreach(T p in products)
            {
                if (p != null)
                {
                    if(!p.Equals(product))
                    {
                        temp[tempCount] = p;
                        tempCount++;
                    }
                }
            }

            products = temp;
            count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
