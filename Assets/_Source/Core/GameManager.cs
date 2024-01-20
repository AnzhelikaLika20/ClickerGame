using UnityEngine;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public ResourceBank ResourceBank { get; } = new();

        private void Awake()
        {
            ResourceBank.ChangeResource(GameResource.Humans, 10);
            ResourceBank.ChangeResource(GameResource.Food, 5);
            ResourceBank.ChangeResource(GameResource.Wood, 5);
        }
    }
}