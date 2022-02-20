using ComradeVanti.CSharpTools;
using UnityEngine;

namespace ComradeVanti.OptUnity
{

    public static class ComponentExt
    {

        public static Opt<TValue> TryGetComponent<TValue>(this Component comp) where TValue : Component =>
            comp.GetComponent<TValue>().ToOpt();

        public static Opt<TValue> TryGetComponentInChildren<TValue>(this Component comp) where TValue : Component =>
            comp.GetComponentInChildren<TValue>().ToOpt();

        public static Opt<TValue> TryGetComponentInParent<TValue>(this Component comp) where TValue : Component =>
            comp.GetComponentInParent<TValue>().ToOpt();

    }

}