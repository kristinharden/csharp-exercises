using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        string Name;
        string Description;

        public Cheese(string name, string description)
        {
            Name = name;
            Description = description;
        }
}
