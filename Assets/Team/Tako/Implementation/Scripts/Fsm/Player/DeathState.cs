using Assets.Team.Tako.Core.Scripts;

namespace Assets.Team.Tako.Implementation.Scripts.Fsm.Player
{
    /// <summary>
    /// Implementasi State untuk death milik player.
    /// </summary>
    public class DeathState : State
    {
        #region Variable

        /// <summary>
        /// Menangani kematian instansi.
        /// </summary>
        private IDeath _death = null;

        #endregion

        #region Main

        private void DoDeath()
        {
            Fsm.ChangeState(Id);
        }

        #endregion

        #region State

        public override void InitializeState()
        {
            _death = GetComponent<IDeath>();

            _death.OnDeath += DoDeath;
        }

        public override void StateEnter()
        {

        }

        public override void StateLeave()
        {

        }

        private void OnDestroy()
        {
            _death.OnDeath -= DoDeath;
        }

        #endregion
    }
}
