using Architecture.Interfaces;
using Problems.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Models
{
    abstract public  class Task
    {
        Problem Problem { get; set; }

        /// <summary>
        /// Hint 
        /// </summary>
        Hint Hint { get; set; }

        /// <summary>
        /// Original material plus reference 
        /// </summary>
        Material Material { get; set; }
    }
}
