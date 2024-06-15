using System;
using System.Globalization;


namespace Linq.Entities
{
    public  class Empoyees
    {
        public string Name {get; set;}
        public double Salary {get; set;}
        public string Seniority {get; set;}
        public string SoftwareEngineering {get; set;}

        public override string ToString()
        {
            return $"Nome: {Name} \nSalário: {Salary} \nSenioridade: {Seniority} \nEngenheiro De Software: {SoftwareEngineering}";
        }
    }


}