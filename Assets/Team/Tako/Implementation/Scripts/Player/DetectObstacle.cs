using Assets.Team.Tako.Core.Scripts;
using System.Linq;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Player
{
    /// <summary>
    /// Untuk mendeteksi obstacle yang terkena player.
    /// </summary>
    public class DetectObstacle : MonoBehaviour
    {
        #region Variable

        /// <summary>
        /// Menangani kematian player.
        /// </summary>
        private IDeath _death = null;

        /// <summary>
        /// Status yang dimiliki game.
        /// </summary>
        private IGameStatus _gameStatus = null;

        #endregion

        #region Mono

        private void Awake()
        {
            _death = GetComponentInParent<Death>();

            _gameStatus = FindObjectsOfType<MonoBehaviour>().OfType<IGameStatus>().FirstOrDefault();
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.CompareTag("Obstacle") && _gameStatus.Status == GameStatus.Play)
            {
                _death.DoDeath();

                _gameStatus.ChangeStatus(GameStatus.End);
            }
        }

        #endregion
    }
}
