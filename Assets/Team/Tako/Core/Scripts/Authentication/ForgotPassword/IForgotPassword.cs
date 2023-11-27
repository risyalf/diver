using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Team.Tako.Core.Scripts.Authentication.ForgotPassword
{
    /// <summary>
    /// Untuk melakukan forgot password pada suatu platform.
    /// </summary>
    public interface IForgotPassword : IAuthentication
    {
        /// <summary>
        /// Untuk Forgot Password.
        /// </summary>
        void DoForgotPassword();
    }
}