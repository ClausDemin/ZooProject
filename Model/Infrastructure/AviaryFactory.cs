using ZooProject.Model;
using ZooProject.Model.Enums;
using ZooProject.Model.Utils;

namespace ZooProject.Model.Infrastructure
{
    public class AviaryFactory
    {
        private AnimalBuilder _builder = new AnimalBuilder();

        public Aviary Create(AnimalsType type, int animalsCount)
        {
            var aviary = new Aviary(type);

            for (int i = 0; i < animalsCount; i++)
            {

                aviary.TryAdd
                (
                _builder
                    .AddGender(GetRandomGender())
                    .Build(type)
                );
            }

            return aviary;
        }

        private AnimalsGender GetRandomGender()
        {
            var genders = Enum.GetNames<AnimalsGender>();

            var gender = Enum.Parse<AnimalsGender>(genders[UserUtils.Next(0, genders.Length)]);

            return gender;
        }
    }
}
