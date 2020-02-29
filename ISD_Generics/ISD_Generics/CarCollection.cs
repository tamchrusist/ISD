using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Generics
{
     class CarCollection<T> where T : ICar, new()
    {
        List<T> Cars = new List<T>();

        public void Add(string Name, int Year)
        {
            Cars.Add(new T() { Name = Name, Year = Year });
        }

        public T this[int Index]
        {
            get { return Cars[Index]; }
            set { Cars[Index] = value; }
        }

        public int Count
        {
            get { return Cars.Count; }
        }
        public void Clear()
        {
            Cars.Clear();
        }
    }

    class CarA : ICar
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"A: {Name} {Year}";
        }
    }

    class CarB : ICar
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"B: {Name} {Year}";
        }
    }
    class CarC : ICar
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"C: {Name} {Year}";
        }
    }
}
