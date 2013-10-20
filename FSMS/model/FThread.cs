using System;
using System.Collections.Generic;
using System.Text;

namespace FSMS.model
{
    
    abstract class FThread
    {
        abstract public void ThreadCallback(Object threadContext);

    }
}
