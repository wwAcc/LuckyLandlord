# Unity核心玩法原型搭建操作流程

本流程文档记录了《幸运房东》类游戏在Unity中搭建核心玩法原型的详细步骤，后续所有开发操作建议均在此文档持续补充和修改。

---

## 1. 创建符号资源（ScriptableObject）
1. 在 `Assets/Resources` 下新建一个文件夹 `Symbols`（如果没有的话）。
2. 在 `Symbols` 文件夹内，右键 → 创建（Create）→ LuckyLandlord → Symbols → Coin，生成 `SymbolCoin` 资源。
3. 同理，再创建一个 `SymbolCherry` 资源。
4. 选中每个资源，在 Inspector 面板中可以为 `icon` 字段拖入一张 Sprite（可用临时图片），其余字段已自动赋值。

## 2. 搭建老虎机主界面
1. 在场景中创建一个空物体，命名为 `SlotGridManager`，并挂载 `SlotGridManager.cs` 脚本。
2. 在 Canvas 下创建一个空物体，命名为 `GridParent`，用于承载格子（可用 Grid Layout Group 组件）。
3. 在 `SlotGridManager` 脚本的 Inspector 面板中，将 `gridParent` 拖入刚才创建的 `GridParent`。
4. 创建一个简单的格子预制体（如一个带 Image 的 UI 物体），命名为 `SymbolPrefab`，并拖入 `symbolPrefab` 字段。

## 3. 创建 UI 显示
1. 在 Canvas 下创建三个 Text（或 TMP_Text）组件，分别命名为 `CoinsText`、`TurnText`、`RentText`。
2. 创建一个空物体 `GameUIManager`，挂载 `GameUIManager.cs` 脚本。
3. 将上面三个 Text 拖到 `GameUIManager` 的对应字段，将 `TurnManager` 拖到 `turnManager` 字段。

## 4. 创建回合与房租管理
1. 在场景中创建一个空物体 `TurnManager`，挂载 `TurnManager.cs` 脚本。
2. 在 `GameUIManager` 的 Inspector 面板，将 `TurnManager` 拖到对应字段。

## 5. 连接拉动操作
1. 在 Canvas 下创建一个 Button，命名为 `PullButton`，文本设为"拉动"。
2. 在 Button 的 OnClick 事件中，拖入 `SlotGridManager`，选择 `SlotGridManager.PullSlot()` 方法。
3. 你可以在 `PullSlot()` 方法中调用 `TurnManager.NextTurn()`，并传入本次收益（可后续完善）。

## 6. 运行测试
1. 点击播放，点击"拉动"按钮，观察格子刷新、回合与金币变化。
2. 若有报错或未显示，检查脚本挂载、资源路径、Inspector 字段是否正确赋值。

---

后续所有开发操作建议、细化步骤、常见问题等均在本文件持续补充和修改。 