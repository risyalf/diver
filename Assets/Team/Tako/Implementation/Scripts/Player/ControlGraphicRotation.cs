using Assets.Team.Tako.Core.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Player
{
    /// <summary>
    /// Menangani rotasi graphic pada player.
    /// </summary>
    public class ControlGraphicRotation : MonoBehaviour
    {
        #region Variable

        /// <summary>
        /// Input yang diberikan untuk menggerakkan player.
        /// </summary>
        private IInput<int> _playerMoveInput = null;

        /// <summary>
        /// Menangani animasi yang dimiliki oleh instansi.
        /// </summary>
        private Animator _animator = null;

        #endregion

        #region Main

        /// <summary>
        /// Dipanggil ketika event value pada input ganti.
        /// </summary>
        /// <param name="value">
        /// Nilai input yang baru.
        /// </param>
        private void ChangeRotation(int value)
        {
            _animator.SetTrigger("Turn");

            if (value < 0)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0 ,0 , -135));
            }
            else
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -45));
            }
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _playerMoveInput = FindObjectsOfType<MonoBehaviour>().OfType<IInput<int>>().First(x => x.Id == "PlayerMoveInput");

            _playerMoveInput.OnValueChange += ChangeRotation;

            _animator = GetComponentInChildren<Animator>();
        }

        private void OnDestroy()
        {
            _playerMoveInput.OnValueChange -= ChangeRotation;
        }

        #endregion
    }
}