using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class ProductionBuilding : MonoBehaviour
    {
        [SerializeField]
        private float productionTime;

        private Button _button;
        private Slider _slider;
        [SerializeField] private GameManager gameManager;
        [SerializeField] private GameResource gameResource;
        private void Awake()
        {
            _button = GetComponentInChildren<Button>();
            _slider = GetComponentInChildren<Slider>();
        }

        private void Start()
        {
            _button.onClick.AddListener(() => StartCoroutine(IncreaseResourceValue()));
        }

        private IEnumerator IncreaseResourceValue()
        {
            _button.interactable = false;

            var stepCount = productionTime * 100;
            for (int i = 0; i < stepCount; i++)
            {
                _slider.value += 1 / stepCount;
                yield return new WaitForSeconds(0.01f);
            }
            
            gameManager.ResourceBank.ChangeResource(gameResource, 1);
            _button.interactable = true;
            _slider.value = 0;
        }
    }
}
