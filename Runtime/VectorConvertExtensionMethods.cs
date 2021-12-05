using UnityEngine;

namespace Kogane
{
    public static class VectorConvertExtensionMethods
    {
        public static Vector3 ToVector3( this Vector2Int self )
        {
            return new Vector3( self.x, self.y );
        }

        public static Vector4 ToVector4( this Vector2Int self )
        {
            return new Vector4( self.x, self.y, 0, 0 );
        }

        public static Vector2 ToVector2( this Vector3Int self )
        {
            return new Vector2( self.x, self.y );
        }

        public static Vector4 ToVector4( this Vector3Int self )
        {
            return new Vector4( self.x, self.y, 0, 0 );
        }
    }
}