using Assets.Team.Tako.Core.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts
{
    /// <summary>
    /// Untuk menampilkan death menu ketika game telah berakhir.
    /// </summary>
    public class ShowDeathMenu : MonoBehaviour
    {
        #region Variable

        /// <summary>
        /// Menangani status game pada game.
        /// </summary>
        private IGameStatus _gameStatus = null;

        #endregion

        #region Main

        /// <summary>
        /// Untuk cek status game.
        /// </summary>
        /// <param name="status">
        /// Status pada game saat ini.
        /// </param>
        private void CheckStatus(GameStatus status)
        {
            if (status == GameStatus.End)
            {
                gameObject.SetActive(true);
            }
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _gameStatus = FindObjectsOfType<MonoBehaviour>().OfType<IGameStatus>().FirstOrDefault();

            _gameStatus.OnStatusChanged += CheckStatus;

            gameObject.SetActive(false);
        }

        private void OnDestroy()
        {
            _gameStatus.OnStatusChanged -= CheckStatus;
        }

        #endregion
    }
}