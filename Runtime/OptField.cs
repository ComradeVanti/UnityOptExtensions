using System;
using ComradeVanti.CSharpTools;
using UnityEngine;

namespace Dev.ComradeVanti
{

    [Serializable]
    public sealed class OptField<T> : IOpt<T>
    {

        [SerializeField] private T[] arr = Array.Empty<T>();


        /// <inheritdoc />
        public TResult Match<TResult>(Func<T, TResult> onSome, Func<TResult> onNone) =>
            arr.TryFirst().Match(onSome, onNone);

    }

}