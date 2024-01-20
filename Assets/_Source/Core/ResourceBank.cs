using System.Collections.Generic;

namespace Core
{
    public class ResourceBank
    {
        public Dictionary<GameResource, ObservableInt> BankResources { get; }

        public ResourceBank()
        {
            BankResources = new Dictionary<GameResource, ObservableInt>
            {
                { GameResource.Food, new ObservableInt(0) },
                { GameResource.Gold, new ObservableInt(0) },
                { GameResource.Humans, new ObservableInt(0) },
                { GameResource.Stone, new ObservableInt(0) },
                { GameResource.Wood, new ObservableInt(0) }
            };
        }

        public void ChangeResource(GameResource resource, int value)
        {
            BankResources[resource].Value += value;
        }

        public ObservableInt GetResource(GameResource resource)
        {
            return BankResources[resource];
        }
    }
}