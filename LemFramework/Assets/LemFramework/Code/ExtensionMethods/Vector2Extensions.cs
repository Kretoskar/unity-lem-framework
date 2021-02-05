using UnityEngine;

namespace LemFramework.ExtensionMethods
{
    public static class Vector2Extensions
    {
        #region Set

        public static Vector2 SetX(this Vector2 v, float x)
        {
            return new Vector2(x, v.y);
        }

        public static Vector2 SetY(this Vector2 v, float y)
        {
            return new Vector2(v.x, y);
        }

        #endregion

        #region Add

        public static Vector2 AddX(this Vector2 v, float x)
        {
            return new Vector2(v.x + x, v.y);
        }
        public static Vector2 AddY(this Vector2 v, float y)
        {
            return new Vector2(v.x, v.y + y);
        }

        #endregion
    }
}