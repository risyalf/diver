using Assets.Team.Tako.Core.Scripts;
using Assets.Team.Tako.Core.Scripts.Modifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts
{
    /// <summary>
    /// Implementasi IMovementSpeed.
    /// </summary>
    public class MovementSpeed : MonoBehaviour, IMovementSpeed
    {
        #region IMovementSpeed

        [field: SerializeField]
        public float Value { get; private set; } = 0;

        public void ChangeMovementSpeed(float amount)
        {
            Value += amount;
        }

        #endregion
    }
}
