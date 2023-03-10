using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorConsola
{
    class ConcreteCollection : AbstractCollection
    {
        private List<Empleado> listEmployees = new List<Empleado>();
        //Create Iterator
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        // Gets item count
        public int Count
        {
            get { return listEmployees.Count; }
        }
        //Add items to the collection
        public void AddEmployee(Empleado employee)
        {
            listEmployees.Add(employee);
        }
        //Get item from collection
        public Empleado GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}
