using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrClass
{
    abstract class School
    { 
        abstract public string personName { get; set; }
        abstract public string name { get; set; }
        abstract public int capacity { get; set; }
    }
}
