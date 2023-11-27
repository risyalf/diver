using Assets.Team.Tako.Core.Scripts.Authentication;
using Assets.Team.Tako.Core.Scripts.Authentication.Login;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Authentications.Login
{
    /// <summary>
    /// Implementasi ILogin untuk playfab.
    /// </summary>
    public class LoginPlayFab : MonoBehaviour, ILogin
    {
        #region Variable

        private TMP_Text _emailText = null;

        private TMP_Text _passwordText = null;

        #endregion

        #region ILogin

        public Action<IAuthenticationResult> OnFinishAuthentication { get; set; } = null;

        public void DoLogin()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}