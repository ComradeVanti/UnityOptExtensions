using ComradeVanti.CSharpTools;
using UnityEngine;

namespace ComradeVanti.OptUnity
{

    public static class GameObjectExt
    {

        /// <summary>
        ///     Attempts to find a component of a specific type on this game-object.
        ///     Will return none if the component is not found
        /// </summary>
        /// <param name="comp">The component relative to which to search</param>
        /// <typeparam name="TValue">The type of the component to search.</typeparam>
        /// <returns>An optional which may contain the component</returns>
        public static IOpt<TValue> TryGetComponent<TValue>(this GameObject go) where TValue : Component =>
            go.GetComponent<TValue>().ToOpt();

    }

}