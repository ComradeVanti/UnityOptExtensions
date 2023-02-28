using ComradeVanti.CSharpTools;
using UnityEngine;

namespace Dev.ComradeVanti
{
    public static class ComponentExt
    {

        /// <summary>
        ///     Attempts to find a component of a specific type on this game-object.
        ///     Will return none if the component is not found
        /// </summary>
        /// <param name="comp">The component relative to which to search</param>
        /// <typeparam name="TValue">The type of the component to search.</typeparam>
        /// <returns>An optional which may contain the component</returns>
        public static IOpt<TValue> TryGetComponent<TValue>(this Component comp) where TValue : class => 
            Opt.FromNullable(comp.GetComponent<TValue>());

        /// <summary>
        ///     Attempts to find a component of a specific type on this game-object
        ///     or any of its children.
        ///     Will return none if the component is not found
        /// </summary>
        /// <param name="comp">The component relative to which to search</param>
        /// <typeparam name="TValue">The type of the component to search.</typeparam>
        /// <returns>An optional which may contain the component</returns>
        public static IOpt<TValue> TryGetComponentInChildren<TValue>(this Component comp) where TValue : class =>
            Opt.FromNullable(comp.GetComponentInChildren<TValue>());

        /// <summary>
        ///     Attempts to find a component of a specific type on this game-object
        ///     or any of its parents.
        ///     Will return none if the component is not found
        /// </summary>
        /// <param name="comp">The component relative to which to search</param>
        /// <typeparam name="TValue">The type of the component to search.</typeparam>
        /// <returns>An optional which may contain the component</returns>
        public static IOpt<TValue> TryGetComponentInParent<TValue>(this Component comp) where TValue : class =>
            Opt.FromNullable(comp.GetComponentInParent<TValue>());
    }
}