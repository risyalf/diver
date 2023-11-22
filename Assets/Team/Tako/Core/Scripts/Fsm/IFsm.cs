namespace Assets.Team.Tako.Core.Scripts.Fsm
{
    /// <summary>
    /// Menangani Finite State Machine yang ada pada suatu instansi.
    /// </summary>
    public interface IFsm
    {
        /// <summary>
        /// State instansi saat ini.
        /// </summary>
        IState CurrentState { get; }

        /// <summary>
        /// Untuk mengganti state pada instansi.
        /// </summary>
        /// <param name="nextState">
        /// State selanjutnya yang akan dimiliki oleh instansi.
        /// </param>
        void ChangeState(string nextState);
    }
}
