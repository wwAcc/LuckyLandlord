using UnityEngine;

namespace LuckyLandlord.Symbol
{
    [CreateAssetMenu(fileName = "SymbolCherry", menuName = "LuckyLandlord/Symbols/Cherry")]
    public class SymbolCherry : SymbolBase
    {
        private void OnEnable()
        {
            symbolName = "樱桃";
            baseReward = 2;
        }
    }
} 