using Assets.Team.Tako.Core.Scripts;
using System;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Inputs
{
    /// <summary>
    /// Implementasi IInput<T>
    /// </summary>
    /// <typeparam name="T">
    /// Semua jenis tipe yang ada pada sistem.
    /// </typeparam>
    public class MyInput<T> : MonoBehaviour, IInput<T>
    {
        #region Variable

        /// <summary>
        /// Indikasi apakah input disable atau tidak.
        /// </summary>
        protected bool Disabled = false;

        #endregion

        #region IInput<T>

        [field: SerializeField]
        public string Id { get; private set; } = string.Empty;

        public T Value { get; protected set; } = default;

        public Action<T> OnValueChange { get; set; } = null;

        public void SetDisable(bool disable)
        {
            Disabled = disable;
        }

        #endregion
    }
}