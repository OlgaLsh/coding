using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class GenericComparer<T>:IEqualityComparer<T>
    {
        private readonly Func<T, object> func;
        public GenericComparer(Func<T, object> func)
        {
            this.func = func;
        }
        public bool Equals(T x, T y)
        {
            return func(x).Equals(func(y));
        }
        public int GetHashCode(T obj)
        {
            return func(obj).GetHashCode();
        }
    }
}
