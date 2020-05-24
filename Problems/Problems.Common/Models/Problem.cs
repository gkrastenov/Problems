using Problems.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Architecture.Models
{
    public class Problem
    {
        /// <summary>
        /// Description of the problem 
        /// <para>Output : short text </para>
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Input of the problem
        /// <para>Output : three various case </para>
        /// </summary>
        Dictionary<string, string> Input { get; }

        /// <summary>
        /// Input of the problem
        /// <para>Output : The Answears of the problem base on input</para>
        /// </summary>
        Dictionary<string, string> Output { get; }

        /// <summary>
        /// Problem rating scale
        /// <para>Output : Number from 0 to 10 </para>
        /// </summary>
        Rating Scale { get;}
    }
}
