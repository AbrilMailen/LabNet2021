using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB.EF.Logic
{
    interface IABMLogic <T>
    {
        List<T> GetAll();
        void Add(T newT);
        void Update(T upT);
    }
}
