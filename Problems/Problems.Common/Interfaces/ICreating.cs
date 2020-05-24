using Problems.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Common.Interfaces
{
    public interface ICreating
    {
        void CreatProblem();
        void CreatHint();
        void CreateMaterial();
        void CreatRating();
        void CreateSolution();
    }
}
