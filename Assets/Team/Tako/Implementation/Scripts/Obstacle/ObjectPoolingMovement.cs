using Assets.Team.Tako.Core.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts
{
    /// <summary>
    /// Menangani pergerakan objectPooling.
    /// </summary>
    public class ObjectPoolingMovement : MonoBehaviour
    {
        #region Variable

        /// <summary>
        /// Menangani pergerakan dari objectPooling.
        /// </summary>
        private IMove _movement = null;

        /// <summary>
        /// Menangani status game.
        /// </summary>
        private IGameStatus _gameStatus = null;

        #endregion

        #region Main

        /// <summary>
        /// Untuk cek status dari game.
        /// </summary>
        /// <param name="status">
        /// Status yang dimiliki game.
        /// </param>
        private void CheckStatus(GameStatus status)
        {
            enabled = status == GameStatus.Play;
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _movement = GetComponent<IMove>();
            _gameStatus = FindObjectsOfType<MonoBehaviour>().OfType<IGameStatus>().FirstOrDefault();

            _gameStatus.OnStatusChanged += CheckStatus;

            CheckStatus(_gameStatus.Status);
        }

        private void Update()
        {
            _movement.DoMove(Vector3.left);
        }

        private void OnDestroy()
        {
            _gameStatus.OnStatusChanged -= CheckStatus;
        }

        #endregion
    }
}