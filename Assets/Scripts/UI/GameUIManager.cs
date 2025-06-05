using UnityEngine;
using UnityEngine.UI;
using LuckyLandlord.Turn;

namespace LuckyLandlord.UI
{
    public class GameUIManager : MonoBehaviour
    {
        public Text coinsText;
        public Text turnText;
        public Text rentText;
        public TurnManager turnManager;

        void Update()
        {
            if (turnManager != null)
            {
                coinsText.text = $"金币：{turnManager.coins}";
                turnText.text = $"回合：{turnManager.currentTurn}";
                rentText.text = $"房租：{turnManager.currentRent}";
            }
        }
    }
} 