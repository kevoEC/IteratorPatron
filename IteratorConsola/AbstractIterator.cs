using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorConsola
{
    interface AbstractIterator
    {
        Empleado First();
        Empleado Next();
        bool IsCompleted { get; }
    }
}
