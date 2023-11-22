using Assets.Team.Tako.Core.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts
{
    /// <summary>
    /// Implementasi ITimer.
    /// </summary>
    public class TimerMono : MonoBehaviour, ITimer
    {
        #region Variable

        /// <summary>
        /// Menampilkan text timer.
        /// </summary>
        [SerializeField]
        private TMP_Text timerText = null;

        /// <summary>
        /// Menangani status pada game.
        /// </summary>
        private IGameStatus _gameStatus = null;

        #endregion

        #region ITimer

        public float Timer { get; private set; } = 0;

        #endregion

        #region Main

        /// <summary>
        /// Untuk cek gamestatus.
        /// </summary>
        /// <param name="status">
        /// Status yang dimiliki game saat ini.
        /// </param>
        private void CheckStatus(GameStatus status)
        {
            enabled = status == GameStatus.Play;
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _gameStatus = FindObjectsOfType<MonoBehaviour>().OfType<IGameStatus>().First();

            _gameStatus.OnStatusChanged += CheckStatus;

            CheckStatus(_gameStatus.Status);
        }

        private void Update()
        {
            Timer += Time.deltaTime;

            timerText.text = Timer.ToString("F0");
        }

        private void OnDestroy()
        {
            _gameStatus.OnStatusChanged -= CheckStatus;
        }

        #endregion
    }
}