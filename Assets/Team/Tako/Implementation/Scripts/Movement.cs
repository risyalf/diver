using Assets.Team.Tako.Core.Scripts;
using Assets.Team.Tako.Core.Scripts.Modifier;
using System.Linq;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Player
{
    /// <summary>
    /// Implementasi IMove.
    /// </summary>
    public class Movement : MonoBehaviour, IMove
    {
        #region Variable

        /// <summary>
        /// Menangani kecepatan gerak dari instansi.
        /// </summary>
        private IMovementSpeed _movementSpeed = null;

        /// <summary>
        /// Menangani modifier untuk semua movement speed.
        /// </summary>
        private IMovementSpeedGlobalModifier _modifier = null;

        #endregion

        #region IMove

        public void DoMove(Vector3 direction)
        {
            transform.Translate(direction * (_movementSpeed.Value + _modifier.Modifier) * Time.deltaTime);
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _movementSpeed = GetComponent<MovementSpeed>();

            _modifier = FindObjectsOfType<MonoBehaviour>().OfType<IMovementSpeedGlobalModifier>().First();
        }

        #endregion
    }
}
