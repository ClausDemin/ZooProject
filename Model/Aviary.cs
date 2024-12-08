using ZooProject.Model.Enums;

namespace ZooProject.Model
{
    public class Aviary
    {
        private List<Animal> _animals;

        public Aviary(AnimalsType type)
        {
            _animals = new List<Animal>();

            AviaryType = type;
        }

        public AnimalsType AviaryType { get; }

        public bool TryAdd(Animal animal)
        {
            if (animal.Type == AviaryType)
            {
                _animals.Add(animal);

                return true;
            }

            return false;
        }

        public string[] GetInfo()
        {
            var aviaryInfo = new List<string>();

            string animalInfo = string.Empty;

            aviaryInfo.Add($"В вольере {_animals.Count} животных.");

            foreach (var animal in _animals)
            {
                animalInfo = $"Животное: {animal.Type}, пол: {animal.Gender}, издаваемый звук: {animal.Sound}";
                aviaryInfo.Add(animalInfo);
            }

            return aviaryInfo.ToArray();
        }
    }
}
