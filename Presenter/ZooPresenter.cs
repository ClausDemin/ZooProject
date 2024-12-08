using ZooProject.Model;
using ZooProject.Model.Enums;
using ZooProject.Model.Infrastructure;
using ZooProject.Model.Utils;

namespace ZooProject.Presenter
{
    public class ZooPresenter
    {
        private Zoo _zoo;

        public ZooPresenter(int minAnimalsCount, int maxAnimalsCount) 
        { 
            _zoo = new Zoo(GetAviaries(minAnimalsCount, maxAnimalsCount));
        }

        public string[] AviariesInfo => _zoo.GetAviariesInfo();

        public string[] GetAviaryInfo(int index) 
        { 
            return _zoo.GetAviaryInfo(index);
        }

        private Aviary[] GetAviaries(int minAnimalsCount, int maxAnimalsCount) 
        { 
            var result = new List<Aviary>();

            var aviaryFactory = new AviaryFactory();

            var animalTypeNames = Enum.GetNames<AnimalsType>();

            foreach (var name in animalTypeNames) 
            {
                var type = Enum.Parse<AnimalsType>(name);

                var aviary = aviaryFactory.Create(type, UserUtils.Next(minAnimalsCount, maxAnimalsCount));

                result.Add(aviary);
            }

            return result.ToArray();
        }
    }
}
