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

        public static Vector3Int ToVector3Int( this Vector2Int self )
        {
            return new( self.x, self.y, 0 );
        }

        public static Vector2 ToVector2( this Vector3 self )
        {
            return new( self.x, self.y );
        }

        public static Vector2 ToVector2( this Vector3Int self )
        {
            return new( self.x, self.y );
        }

        public static Vector2Int ToVector2Int( this Vector3 self )
        {
            return new( ( int )self.x, ( int )self.y );
        }

        public static Vector2Int ToVector2Int( this Vector3Int self )
        {
            return new( self.x, self.y );
        }
    }
}