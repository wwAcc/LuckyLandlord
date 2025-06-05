using UnityEngine;

namespace LuckyLandlord.Symbol
{
    [CreateAssetMenu(fileName = "SymbolCoin", menuName = "LuckyLandlord/Symbols/Coin")]
    public class SymbolCoin : SymbolBase
    {
        private void OnEnable()
        {
            symbolName = "金币";
            baseReward = 1;
        }
    }
} 