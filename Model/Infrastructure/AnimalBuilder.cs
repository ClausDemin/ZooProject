using ZooProject.Model;
using ZooProject.Model.Enums;

namespace ZooProject.Model.Infrastructure
{
    public class AnimalBuilder
    {
        private AnimalSoundProvider _soundProvider = new AnimalSoundProvider();

        private AnimalsGender _gender;

        public AnimalBuilder Reset()
        {
            _gender = default;

            return this;
        }

        public AnimalBuilder AddGender(AnimalsGender gender)
        {
            _gender = gender;

            return this;
        }

        public Animal Build(AnimalsType type)
        {
            return new Animal(type, _gender, _soundProvider.GetSound(type));
        }
    }
}
