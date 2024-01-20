using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class ProductionLevelUps : MonoBehaviour
    {
        private Button _button;

        [SerializeField] private GameManager gameManager;
        [SerializeField] private ProductionLevel productionLevel;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void Start()
        {
            _button.onClick.AddListener(
                () =>
                {
                    if (gameManager.ProductionLevelController.GetProductionLevel(productionLevel).Value == 100)
                        _button.interactable = false;
                    else
                        gameManager.ProductionLevelController.IncreaseProductionLevel(productionLevel);
                });
        }
    }
}