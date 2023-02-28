using ComradeVanti.CSharpTools;
using UnityEngine;

namespace Dev.ComradeVanti
{
    public static class TransformExt
    {
        /// <summary>
        /// Attempts to get the parent of the transform
        /// </summary>
        /// <param name="transform">The transform</param>
        /// <returns>Maybe the parent</returns>
        public static IOpt<Transform> TryParent(this Transform transform) =>
            Opt.FromNullable(transform.parent);
    }
}