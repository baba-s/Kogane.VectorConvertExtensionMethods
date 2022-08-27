using UnityEngine;

namespace Kogane
{
    public static class VectorConvertExtensionMethods
    {
        public static Vector3 ToVector3( this Vector2 self )
        {
            return new( self.x, self.y );
        }

        public static Vector3 ToVector3( this Vector2Int self )
        {
            return new( self.x, self.y );
        }

        public static Vector2 ToVector2( this Vector3 self )
        {
            return new( self.x, self.y );
        }

        public static Vector2 ToVector2( this Vector3Int self )
        {
            return new( self.x, self.y );
        }
    }
}