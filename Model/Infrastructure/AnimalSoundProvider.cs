using ZooProject.Model.Enums;

namespace ZooProject.Model.Infrastructure
{
    public class AnimalSoundProvider
    {
        private Dictionary<AnimalsType, string> _sounds =
            new Dictionary<AnimalsType, string>()
            {
                    {AnimalsType.Cat, "Meow"},
                    {AnimalsType.Dog, "Woof" },
                    {AnimalsType.Elephant, "tu-tu" },
                    {AnimalsType.Penguin, "tee-hee" }
            };

        public string GetSound(AnimalsType type)
        {
            return _sounds[type];
        }
    }
}
