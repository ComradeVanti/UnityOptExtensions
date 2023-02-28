using ComradeVanti.CSharpTools;
using UnityEngine;

namespace Dev.ComradeVanti
{
    /// <summary>
    ///     Opt alternatives for static methods on the UnityEngine.Resources class
    /// </summary>
    public static class OptResources
    {
        /// <summary>
        ///     Attempts to load a resource of a specific type from resources
        /// </summary>
        /// <param name="path">The path to the resource</param>
        /// <typeparam name="T">The type of the resource</typeparam>
        /// <returns>The resource or None if not found</returns>
        public static IOpt<T> TryLoad<T>(string path) where T : Object =>
            Opt.FromNullable(Resources.Load<T>(path));
    }
}