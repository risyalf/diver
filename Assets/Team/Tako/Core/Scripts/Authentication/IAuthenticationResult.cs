using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Team.Tako.Core.Scripts.Authentication
{
    /// <summary>
    /// Hasil dari proses autentikasi.
    /// </summary>
    public interface IAuthenticationResult
    {
        /// <summary>
        /// Indikasi apakah autentikasi error atau tidak.
        /// </summary>
        bool Error { get; set; }

        /// <summary>
        /// Pesan error yang dimiliki oleh autentikasi.
        /// </summary>
        string ErrorMessage { get; set; }
    }
}