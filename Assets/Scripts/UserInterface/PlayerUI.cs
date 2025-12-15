using System;
using Player;
using TMPro;
using UnityEngine;

namespace UserInterface
{
    public class PlayerUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI playerMoney;

        private PlayerStats playerStats;

        private void Start()
        {
            playerMoney.text = playerStats.money.ToString();
        }
    }
}