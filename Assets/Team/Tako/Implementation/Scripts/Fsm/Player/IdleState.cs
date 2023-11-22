using Assets.Team.Tako.Core.Scripts;
using System.Linq;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Fsm.Player
{
    /// <summary>
    /// Implementasi State untuk idle milik Player.
    /// </summary>
    public class IdleState : State
    {
        #region Variable

        /// <summary>
        /// Status yang dimiliki game.
        /// </summary>
        private IGameStatus _gameStatus = null;

        #endregion

        #region Main

        /// <summary>
        /// Callback untuk cek event change game status.
        /// </summary>
        /// <param name="status">
        /// Status yang dimiliki oleh game
        /// </param>
        private void Checkstatus(GameStatus status)
        {
            if (status == GameStatus.Play)
            {
                Fsm.ChangeState("MoveState");
            }
        }

        #endregion

        #region State

        public override void InitializeState()
        {
            _gameStatus = FindObjectsOfType<MonoBehaviour>().OfType<IGameStatus>().First();

            _gameStatus.OnStatusChanged += Checkstatus;
        }

        public override void StateEnter()
        {
            if (_gameStatus.Status == GameStatus.Play)
            {
                Fsm.ChangeState("MoveState");
            }
        }

        public override void StateLeave()
        {
            _gameStatus.OnStatusChanged -= Checkstatus;
        }

        #endregion
    }
}
