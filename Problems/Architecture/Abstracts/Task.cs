using Architecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Models
{
    abstract public  class Task : IBehaviour, IFormating
    {
        Problem Problem { get;}

        /// <summary>
        /// Hint 
        /// </summary>
        Hint Hint { get;}

        public void EndTask()
        {

        }

        public void RatingTask()
        {

        }

        public void RunTask()
        {

        }

        public void SpacingFormat()
        {
            // TODO : ADD logic
            throw new NotImplementedException();
        }

        public void DashesFormat()
        {
            // TODO: Add logic
            throw new NotImplementedException();
        }
    }
}
