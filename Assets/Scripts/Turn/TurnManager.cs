using UnityEngine;

namespace LuckyLandlord.Turn
{
    public class TurnManager : MonoBehaviour
    {
        public int currentTurn = 1;
        public int rentInterval = 5;
        public int currentRent = 10;
        public int rentIncrease = 5;
        public int coins = 20;

        public void NextTurn(int reward)
        {
            currentTurn++;
            coins += reward;
            if (currentTurn % rentInterval == 0)
            {
                PayRent();
            }
        }

        void PayRent()
        {
            if (coins >= currentRent)
            {
                coins -= currentRent;
                currentRent += rentIncrease;
                // TODO: 提示成功支付房租
            }
            else
            {
                // TODO: 游戏失败处理
            }
        }
    }
} 
 