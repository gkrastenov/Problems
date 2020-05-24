using System;
using System.Text;

namespace Problems.Common.Models
{
    public class Material
    {
        public Material(string author, string reference)
        {
            this.Author = author;
            this.Reference = reference;
        }

        string Author { get; set; }
        string Reference { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Author : " + this.Author);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("Reference : " + this.Reference);

            return stringBuilder.ToString(); 
        }
    }
}
