using Assets.Team.Tako.Core.Scripts;
using System;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Player
{
    /// <summary>
    /// Implementasi IDeath.
    /// </summary>
    public class Death : MonoBehaviour, IDeath
    {
        #region IDeath

        public void DoDeath()
        {
            OnDeath?.Invoke();
        }

        public Action OnDeath { get; set; } = null;

        #endregion
    }
}
