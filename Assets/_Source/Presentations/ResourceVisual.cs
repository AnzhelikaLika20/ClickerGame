using System;
using Core;
using TMPro;
using UnityEngine;

namespace Presentations
{
    public class ResourceVisual : MonoBehaviour
    {
        [SerializeField] private GameResource gameResource;
        [SerializeField] private GameManager gameManager;

        private void Start()
        {
            gameManager.ResourceBank.GetResource(gameResource).OnValueChanged =
                newValue => GetComponent<TMP_Text>().text =
                    $"{Enum.GetName(typeof(GameResource), gameResource)}\n{newValue}";
            gameManager.ResourceBank.ChangeResource(gameResource, 0);
        }
    }
}