using System;
using System.Text;

namespace Architecture.Models
{
    public class Hint
    {
        public Hint(int number, string description)
        {
            this.Number = number;
            this.Description = description;
        }
        int Number { get; }
        string Description { get; }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Number : " + this.Number);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("Description : " + this.Description);

            return stringBuilder.ToString();
        }
    }
}