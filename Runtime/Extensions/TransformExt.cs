using ComradeVanti.CSharpTools;
using UnityEngine;

namespace Dev.ComradeVanti
{
    public static class TransformExt
    {
        public static IOpt<Transform> TryParent(this Transform transform) =>
            Opt.FromNullable(transform.parent);
    }
}