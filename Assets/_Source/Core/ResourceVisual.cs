using System;
using TMPro;
using UnityEngine;

namespace Core
{
    public class ResourceVisual : MonoBehaviour
    {
        [SerializeField] private GameResource gameResource;
        [SerializeField] private GameManager gameManager;

        void Start()
        {
            gameManager.ResourceBank.BankResources[gameResource].OnValueChanged =
                newValue => GetComponent<TMP_Text>().text = $"{Enum.GetName(typeof(GameResource), gameResource)}\n{newValue}";
            gameManager.ResourceBank.ChangeResource(gameResource, 0);
        }
    }
}