using Assets.Team.Tako.Core.Scripts.Modifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Collections;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Modifier
{
    /// <summary>
    /// Implementasi IMovementSpeedGlobalModifier.
    /// </summary>
    public class MovementSpeedGlobalModifier : MonoBehaviour, IMovementSpeedGlobalModifier
    {
        #region IMovementSpeedGlobalModifier

        [field: SerializeField, ReadOnly]
        public float Modifier { get; private set; } = 0;

        public void SetModifier(float modifier)
        {
            Modifier = modifier;
        }

        #endregion
    }
}
