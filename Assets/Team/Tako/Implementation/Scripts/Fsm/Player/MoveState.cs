
using Assets.Team.Tako.Core.Scripts;
using System.Linq;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Fsm.Player
{
    /// <summary>
    /// Implementasi State untuk move milik Player.
    /// </summary>
    public class MoveState : State
    {
        #region Variable

        /// <summary>
        /// Menangani pergerakan instansi.
        /// </summary>
        private IMove _move = null;

        /// <summary>
        /// Input yang diberikan untuk menggerakkan player.
        /// </summary>
        private IInput<int> _playerMoveInput = null;

        /// <summary>
        /// Menangani animasi yang dimiliki oleh instansi.
        /// </summary>
        private Animator _animator = null;

        #endregion

        #region State

        public override void InitializeState()
        {
            _move = GetComponent<IMove>();

            _playerMoveInput = FindObjectsOfType<MonoBehaviour>().OfType<IInput<int>>().First(x => x.Id == "PlayerMoveInput");

            _animator = GetComponentInChildren<Animator>();
        }

        public override void StateEnter()
        {
            _animator.SetBool("Move", true);

            transform.Find("Physics/Graphic").localRotation = Quaternion.Euler(new Vector3(0, 0, 45));
        }

        public override void StateLeave()
        {
            _animator.SetBool("Move", false);
        }

        #endregion

        #region Mono

        private void Update()
        {
            _move.DoMove(Vector3.up * _playerMoveInput.Value);
        }

        #endregion
    }
}
