using ZooProject.Model.Enums;

namespace ZooProject.Model
{
    public class Animal
    {
        public Animal(AnimalsType type, AnimalsGender gender, string sound)
        {
            Type = type;
            Gender = gender;
            Sound = sound;
        }

        public AnimalsType Type { get; }
        public AnimalsGender Gender { get; }
        public string Sound { get; }
    }
}
