using Assets.Team.Tako.Core.Scripts;
using System.Linq;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Inputs
{
    /// <summary>
    /// Menangani input touch untuk memulai game.
    /// </summary>
    public class InputStartGame : MonoBehaviour
    {
        #region Variable

        /// <summary>
        /// Menangani status dari game.
        /// </summary>
        private IGameStatus _gameStatus = null;

        /// <summary>
        /// Indikasi apakah game sudah dimulai atau tidak.
        /// </summary>
        bool _started = false;

        #endregion

        #region Mono

        private void Awake()
        {
            _gameStatus = FindObjectsOfType<MonoBehaviour>().OfType<IGameStatus>().First();
        }

        private void Update()
        {
            if (_started)
            {
                return;
            }

            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    _gameStatus.ChangeStatus(GameStatus.Play);

                    _started = true;
                }
            }
            

            if (Input.GetKeyDown(KeyCode.Space))
            {
                _gameStatus.ChangeStatus(GameStatus.Play);

                _started = true;
            }
        }

        #endregion
    }
}
