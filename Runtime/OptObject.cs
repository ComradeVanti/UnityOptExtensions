using ComradeVanti.CSharpTools;
using UnityEngine;

namespace Dev.ComradeVanti
{
    /// <summary>
    ///     Opt alternatives for static methods on the UnityEngine.Object class
    /// </summary>
    public static class OptObject
    {
        /// <summary>
        ///     Attempts to find the first Object of a specific type in the current scene
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <returns>The object or None if not found</returns>
        public static IOpt<T> TryFindObjectOfType<T>() where T : Object =>
            Opt.FromNullable(Object.FindObjectOfType<T>());
    }
}