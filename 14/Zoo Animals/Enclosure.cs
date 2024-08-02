using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_Animals.Animals;

namespace Zoo_Animals
{
    class Enclosure : IEnumerable, IEnumerator
    {
        public List<Animal> Animals = new List<Animal>();
        public AnimalType AnimalType;
        private int _index = -1;

        public Enclosure(AnimalType animalType)
        {
            AnimalType = animalType;
        }

        public void AddAnimal(Animal animal)
        {
            if (AnimalType.HasFlag(animal.Type))
            {
                Animals.Add(animal);
            }
            else
            {
                Console.WriteLine("This enclosure is only for {0}. Try other enclosure", AnimalType);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public object Current
        {
            get { return Animals[_index]; }
        }

        public bool MoveNext()
        {
            if (_index == Animals.Count - 1)
            {
                Reset();
                return false;
            }

            _index++;
            return true;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
