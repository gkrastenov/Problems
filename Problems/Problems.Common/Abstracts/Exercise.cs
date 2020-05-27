namespace Architecture.Models
{
    using Problems.Common.Models;
    public abstract class Exercise
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
        public abstract Solution Solution { get; set; }
    }
}
