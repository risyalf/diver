using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Team.Tako.Core.Scripts
{
    /// <summary>
    /// Menangani kecepatan gerak yang dimiliki oleh suatu instansi.
    /// </summary>
    public interface IMovementSpeed
    {
        /// <summary>
        /// Kecepatan gerak yang dimiliki oleh suatu instansi.
        /// </summary>
        float Value { get; }

        /// <summary>
        /// Untuk mengubah kecepatan gerak.
        /// </summary>
        /// <param name="amount">
        /// Banyaknya kecepatan gerak berubah.
        /// </param>
        void ChangeMovementSpeed(float amount);
    }
}