namespace ZooProject.Model
{
    public class Zoo
    {
        private List<Aviary> _aviaries;

        public Zoo(params Aviary[] aviaries)
        {
            _aviaries = new List<Aviary>(aviaries);
        }

        public string[] GetAviariesInfo()
        {
            var result = new List<string>();

            string aviaryInfo = string.Empty;

            foreach (var aviary in _aviaries)
            {
                aviaryInfo = $"Вольер с {aviary.AviaryType}";

                result.Add(aviaryInfo);
            }

            return result.ToArray();
        }

        public string[] GetAviaryInfo(int index)
        {
            if (index >= 0 && index < _aviaries.Count)
            {
                return _aviaries[index].GetInfo();
            }

            return [];
        }
    }
}
