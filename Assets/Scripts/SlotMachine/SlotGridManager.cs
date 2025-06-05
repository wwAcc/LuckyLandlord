using System.Collections.Generic;
using UnityEngine;
using LuckyLandlord.Symbol;

namespace LuckyLandlord.SlotMachine
{
    public class SlotGridManager : MonoBehaviour
    {
        public int rows = 4;
        public int cols = 5;
        public GameObject symbolPrefab;
        public Transform gridParent;

        private SymbolBase[,] gridSymbols;

        void Start()
        {
            InitGrid();
            RefreshAllSymbols();
        }

        // 初始化格子
        void InitGrid()
        {
            gridSymbols = new SymbolBase[rows, cols];
            // 这里可以实例化UI格子或3D格子，暂用逻辑占位
        }

        // 刷新所有格子的符号
        public void RefreshAllSymbols()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    gridSymbols[r, c] = SymbolFactory.GetRandomSymbol();
                }
            }
            // TODO: 更新UI显示
        }

        // 拉动老虎机（外部调用）
        public void PullSlot()
        {
            RefreshAllSymbols();
            // TODO: 结算收益
        }
    }
} 