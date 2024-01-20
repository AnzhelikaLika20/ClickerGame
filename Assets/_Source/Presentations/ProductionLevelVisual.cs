using System;
using Core;
using TMPro;
using UnityEngine;

namespace Presentations
{
    public class ProductionLevelVisual : MonoBehaviour
    {
        [SerializeField] private ProductionLevel productionLevel;
        [SerializeField] private GameManager gameManager;

        private void Start()
        {
            gameManager.ProductionLevelController.GetProductionLevel(productionLevel).OnValueChanged =
                newProductionLevel => GetComponent<TMP_Text>().text = $"ProdLvl: {newProductionLevel}";
        }
    }
}