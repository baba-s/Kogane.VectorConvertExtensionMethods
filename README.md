# Kogane Vector Convert Extension Methods

Vector2Int や Vector3Int を Vector2 や Vector3 などに変換する拡張メソッド

## 使用例

```cs
var v1 = Vector2.one + Vector3.one.ToVector2();
var v2 = Vector2.one + Vector3Int.one.ToVector2();
var v3 = Vector3.one + Vector2.one.ToVector3();
var v4 = Vector3.one + Vector2Int.one.ToVector3();
```