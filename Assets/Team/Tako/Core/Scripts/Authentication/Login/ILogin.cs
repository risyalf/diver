using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Team.Tako.Core.Scripts.Authentication.Login
{
    /// <summary>
    /// Menangani login pada suatu platform.
    /// </summary>
    public interface ILogin : IAuthentication
    {
        /// <summary>
        /// Untuk melakukan login.
        /// </summary>
        void DoLogin();
    }
}