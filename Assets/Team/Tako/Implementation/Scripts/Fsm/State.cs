using Assets.Team.Tako.Core.Scripts.Fsm;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Fsm
{
    /// <summary>
    /// Implementasi IState.
    /// </summary>
    public abstract class State : MonoBehaviour, IState
    {
        #region IState

        [field: SerializeField]
        public string Id { get; private set; } = string.Empty;

        public IFsm Fsm { get; set; } = null;

        public abstract void InitializeState();

        public abstract void StateEnter();

        public abstract void StateLeave();

        #endregion
    }
}
