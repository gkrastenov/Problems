namespace Architecture.Models
{
    using Problems.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;
    abstract public  class Exercise
    {
        public abstract Problem Problem { get; set; }

        /// <summary>
        /// Hint 
        /// </summary>
        public abstract Hint Hint { get; set; }

        /// <summary>
        /// Original material plus reference 
        /// </summary>
        public abstract Material Material { get; set; }
    }
}
