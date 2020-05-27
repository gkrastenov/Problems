namespace Problems.Common.Models
{
    using System;
    using System.Text;

    public class Material
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Material"/> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="reference"></param>
        public Material(string author, string reference)
        {
            this.Author = author;
            this.Reference = reference;
        }

        public string Author { get; set; }
        public string Reference { get; set; }

        /// <inheritdoc/>
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
