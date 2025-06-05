using UnityEngine;
using System.Collections.Generic;

namespace LuckyLandlord.Symbol
{
    public static class SymbolFactory
    {
        private static List<SymbolBase> symbolPool;

        static SymbolFactory()
        {
            // 这里可以通过Resources.LoadAll等方式加载所有符号
            symbolPool = new List<SymbolBase>(Resources.LoadAll<SymbolBase>("Symbols"));
        }

        public static SymbolBase GetRandomSymbol()
        {
            if (symbolPool == null || symbolPool.Count == 0)
                return null;
            int idx = Random.Range(0, symbolPool.Count);
            return symbolPool[idx];
        }
    }
} 