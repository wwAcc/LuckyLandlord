using UnityEngine;

namespace LuckyLandlord.Symbol
{
    public abstract class SymbolBase : ScriptableObject
    {
        public string symbolName;
        public Sprite icon;
        public int baseReward;

        // 结算时调用
        public virtual int GetReward()
        {
            return baseReward;
        }
    }
} 