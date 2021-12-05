# Kogane Vector Convert Extension Methods

Vector2Int や Vector3Int を Vector2 や Vector3 などに変換する拡張メソッド

## 使用例

### Vector2Int

```cs
Vector3 vector3 = Vector2Int.one.ToVector3();
Vector4 vector4 = Vector2Int.one.ToVector4();
```

### Vector3Int

```cs
Vector2 vector2 = Vector3Int.one.ToVector2();
Vector4 vector4 = Vector3Int.one.ToVector4();
```