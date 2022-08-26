using ComradeVanti.CSharpTools;
using UnityObject = UnityEngine.Object;

namespace Dev.ComradeVanti
{

    public static class ObjectExt
    {

        /// <summary>
        ///     Creates an optional from this unity-object. The optional will be missing
        ///     if the object is null or destroyed
        /// </summary>
        /// <param name="obj">The object to create the optional from</param>
        /// <typeparam name="TValue">The type of the contained value</typeparam>
        /// <returns>The created optional</returns>
        public static IOpt<TValue> ToOpt<TValue>(this TValue obj) where TValue : UnityObject =>
            obj ? Opt.Some(obj) : Opt.None<TValue>();

    }

}