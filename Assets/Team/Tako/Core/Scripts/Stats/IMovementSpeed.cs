namespace Assets.Team.Tako.Core.Scripts.Stats
{
    /// <summary>
    /// Menangani stat kecepatan gerak yang dimiliki oleh suatu instansi.
    /// </summary>
    public interface IMovementSpeed
    {
        /// <summary>
        /// Kecepatan gerak yang dimiliki oleh suatu instansi.
        /// </summary>
        float MovementSpeed { get; }

        /// <summary>
        /// Untuk mengganti nilai movemnt speed.
        /// </summary>
        /// <param name="movementSpeed">
        /// Nilai movement speed yang diset.
        /// </param>
        void SetMovementSpeed(float movementSpeed);
    }
}
