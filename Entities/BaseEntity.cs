using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Project.Entities
{
    public abstract class BaseEntity
    {
         public Guid Id = Guid.NewGuid();
        
    }
}