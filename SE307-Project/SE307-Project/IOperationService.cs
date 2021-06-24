using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE307_Project
{
    interface IOperationService<T1, Country>
    {
        void Add(T1 item, Country country);
        void Delete(T1 item, Country country);
    }
}
