namespace Architecture.Models
{
    using System;
    using System.Text;
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
            stringBuilder.Append("Number of hint : " + this.Number);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("Description : " + this.Description);

            return stringBuilder.ToString();
        }
    }
}