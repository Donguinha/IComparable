using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparablee.Entities
{
    internal class Employees : IComparable
    {

        public string name { get; set; }
        public double salario { get; set; }

        public Employees(string csvEmployee)
        {
            string[] vetor = csvEmployee.Split(',');
            name = vetor[0];
            salario = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return name + ", " + salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Employees))
            {
                throw new ArgumentException("Comparing error ");
            }

            Employees other = obj as Employees;
            return name.CompareTo(other.name);
        }
    }
}

