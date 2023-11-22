namespace Assets.Team.Tako.Core.Scripts.Fsm
{
    /// <summary>
    /// Menangani state yang sedang dilakukan oleh suatu instansi.
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Id yang dimiliki oleh state.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Fsm yang dimiliki state.
        /// </summary>
        IFsm Fsm { get; set; }

        /// <summary>
        /// Untuk inisialisasi state;
        /// </summary>
        void InitializeState();

        /// <summary>
        /// Menangani behaviour instansi ketika masuk ke state.
        /// </summary>
        void StateEnter();

        /// <summary>
        /// Menangani behaviour instansi ketika keluar dari state.
        /// </summary>
        void StateLeave();
    }
}
