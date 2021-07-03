using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE307_Project
{
    // This interface is declared generic; the method, ShowData, can be executed with any types.
    public interface IDataService<T>
    {
        string ShowData(T item);
    }
}
