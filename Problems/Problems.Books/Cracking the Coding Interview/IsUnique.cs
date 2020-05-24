using Architecture.Models;
using Problems.Common.Interfaces;
using Problems.Common.Models;
using System;

namespace Problems.Books.Cracking_the_Coding_Interview
{
    public class IsUnique : Exercise, ICreating
    {
        public IsUnique()
        {
            CreatProblem();
            CreateSolution();
            CreatHint();
            CreateMaterial();
            CreatRating();
        }
        public override Problem Problem { get; set; }
        public override Hint Hint { get; set; }
        public override Material Material { get; set; }
        public override Solution Solution { get; set; }

        public void CreateMaterial()
        {
            throw new NotImplementedException();
        }

        public void CreateSolution()
        {
            throw new NotImplementedException();
        }

        public void CreatHint()
        {
            throw new NotImplementedException();
        }

        public void CreatProblem()
        { 
            throw new NotImplementedException();
        }

        public void CreatRating()
        {
            throw new NotImplementedException();
        }
    }
}
