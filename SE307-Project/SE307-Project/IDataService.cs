using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE307_Project
{
    public interface IDataService<T>
    {
        string ShowData(T item);
    }
}
