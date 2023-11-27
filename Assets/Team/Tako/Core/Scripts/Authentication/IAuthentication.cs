using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Team.Tako.Core.Scripts.Authentication
{
    /// <summary>
    /// Menangani autentikasi pada suatu platform.
    /// </summary>
    public interface IAuthentication
    {
        /// <summary>
        /// Event yang dipanggil ketika autentikasi telah selesai.
        /// </summary>
        Action<IAuthenticationResult> OnFinishAuthentication { get; set; }
    }
}