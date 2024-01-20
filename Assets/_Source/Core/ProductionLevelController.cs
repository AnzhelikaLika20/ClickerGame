using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class ProductionLevelController
    {
        private Dictionary<ProductionLevel, ObservableInt> ProductionLevels { get; }

        public ProductionLevelController()
        {
            ProductionLevels = new Dictionary<ProductionLevel, ObservableInt>
            {
                { ProductionLevel.HumansProdLvl, new ObservableInt(1) },
                { ProductionLevel.FoodProdLvl, new ObservableInt(1) },
                { ProductionLevel.GoldProdLvl, new ObservableInt(1) },
                { ProductionLevel.WoodProdLvl, new ObservableInt(1) },
                { ProductionLevel.StoneProdLvl, new ObservableInt(1) }
            };
        }

        public void IncreaseProductionLevel(ProductionLevel production)
        {
            ProductionLevels[production].Value += 1;
        }

        public ObservableInt GetProductionLevel(ProductionLevel production)
        {
            return ProductionLevels[production];
        }
    }
}