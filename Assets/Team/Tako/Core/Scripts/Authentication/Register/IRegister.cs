using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Team.Tako.Core.Scripts.Authentication.Register
{
    /// <summary>
    /// Untuk melakukan register pada suatu platform.
    /// </summary>
    public interface IRegister : IAuthentication
    {
        /// <summary>
        /// Untuk register.
        /// </summary>
        void DoRegister();
    }
}