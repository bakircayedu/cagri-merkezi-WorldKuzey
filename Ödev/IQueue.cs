using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    public  interface IQueue
    {

        void Insert(object item);
        object Remove();
        object Peek();

        Boolean IsEmpty();

        int Count();



    }
}
