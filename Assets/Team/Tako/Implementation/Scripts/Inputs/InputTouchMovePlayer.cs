using Assets.Team.Tako.Core.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Inputs
{
    /// <summary>
    /// Implementasi MyInput<T> untuk membaca input touch.
    /// </summary>
    public class InputTouchMovePlayer : MyInput<int>
    {
        #region Variable

        /// <summary>
        /// Menangani status dari game.
        /// </summary>
        private IGameStatus _gameStatus = null;

        #endregion

        #region Main

        /// <summary>
        /// Untuk mengecek game status.
        /// </summary>
        /// <param name="status">
        /// Status yang dimiliki game saat ini.
        /// </param>
        private void CheckStatus(GameStatus status)
        {
            if (status == GameStatus.Play)
            {
                SetDisable(false);
            }
            else
            {
                SetDisable(true);
            }
        }

        #endregion

        #region Mono

        private void Awake()
        {
            SetDisable(true);

            _gameStatus = FindObjectsOfType<MonoBehaviour>().OfType<IGameStatus>().First();

            _gameStatus.OnStatusChanged += CheckStatus;
        }

        private void Update()
        {
            if (Disabled) 
            {
                return;
            }

            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    Value = Value > 0 ? -1 : 1;

                    OnValueChange?.Invoke(Value);
                }
            }            

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Value = Value > 0 ? -1 : 1;

                OnValueChange?.Invoke(Value);
            }
        }

        #endregion
    }
}
