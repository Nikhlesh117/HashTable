using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class MyMapNode<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
        public MyMapNode<K, V> Next { get; set; }

    }
}
