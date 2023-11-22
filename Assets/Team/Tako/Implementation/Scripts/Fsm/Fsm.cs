using Assets.Team.Tako.Core.Scripts.Fsm;
using System.Linq;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Fsm
{
    /// <summary>
    /// Implementasi IFsm.
    /// </summary>
    public class Fsm : MonoBehaviour, IFsm
    {
        #region Variable

        /// <summary>
        /// Semua state yang ada pada object.
        /// </summary>
        private IState[] _states = null;

        #endregion

        #region IFsm

        public IState CurrentState { get; private set; } = null;

        public void ChangeState(string nextState)
        {
            CurrentState.StateLeave();

            ((MonoBehaviour)CurrentState).enabled = false;

            CurrentState = _states.First(x => x.Id == nextState);

            CurrentState.StateEnter();

            ((MonoBehaviour)CurrentState).enabled = true;
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _states = GetComponents<IState>();

            foreach (var state in _states)
            {
                state.Fsm = this;

                state.InitializeState();

                ((MonoBehaviour)state).enabled = false;
            }

            CurrentState = _states[0];

            ((MonoBehaviour)CurrentState).enabled = true;

            CurrentState.StateEnter();
        }

        #endregion
    }
}