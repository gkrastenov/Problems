using Problems.Common.Models;
using System.Collections.Generic;

namespace Architecture.Models
{
    public class Problem
    {
        public Problem(string description, Dictionary<string, string> input,
            Dictionary<string, string> output, Rating rating)
        {
            this.Description = description;
            this.Input = input;
            this.Output = output;
            this.Rating = rating;
        }
        /// <summary>
        /// Description of the problem 
        /// <para>Output : short text </para>
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Input of the problem
        /// <para>Output : three various case </para>
        /// </summary>
        Dictionary<string, string> Input { get; set; }

        /// <summary>
        /// Input of the problem
        /// <para>Output : The Answears of the problem base on input</para>
        /// </summary>
        Dictionary<string, string> Output { get; set; }

        /// <summary>
        /// Problem rating scale
        /// <para>Output : Number from 0 to 10 </para>
        /// </summary>
        Rating Rating { get; set; }
    }
}
