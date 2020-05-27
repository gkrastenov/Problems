namespace Problems.Books.Cracking_the_Coding_Interview
{
    using System;
    using Architecture.Models;
    using Problems.Common.Interfaces;
    using Problems.Common.Models;

    public class IsUnique : Exercise, ICreating
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsUnique"/> class.
        /// </summary>
        public IsUnique()
        {
            this.CreatProblem();
            this.CreateSolution();
            this.CreatHint();
            this.CreateMaterial();
            this.CreatRating();
        }

        /// <inheritdoc/>
        public override Problem Problem { get; set; }

        /// <inheritdoc/>
        public override Hint Hint { get; set; }

        /// <inheritdoc/>
        public override Material Material { get; set; }

        /// <inheritdoc/>
        public override Solution Solution { get; set; }

        /// <inheritdoc/>
        public void CreateMaterial()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void CreateSolution()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void CreatHint()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void CreatProblem()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void CreatRating()
        {
            throw new NotImplementedException();
        }
    }
}
