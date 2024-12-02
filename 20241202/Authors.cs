using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241202
{
    internal class Authors
    {
        public Guid Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Authors(string fullName) 
        { 
            Id = Guid.NewGuid();
            var nameParts = fullName.Split(' ');
            if (nameParts.Length != 2 || nameParts[0].Length < 3 || nameParts[0].Length > 32 || nameParts[1].Length < 3 || nameParts[1].Length > 32)
            { throw new ArgumentException("Invalid name format."); }
            FirstName = nameParts[0]; LastName = nameParts[1]; 
        }
        public override string ToString() 
        { 
            return $"{FirstName} {LastName}"; 
        }
    }
}
