using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE307_Project
{
    // This interface is declared generic; the methods, Add and Delete, can be executed with any types to make changes to a country.
    interface IOperationService<T1, Country>
    {
        void Add(T1 item, Country country);
        void Delete(T1 item, Country country);
    }
}
