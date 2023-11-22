using Assets.Team.Tako.Core.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts
{
    /// <summary>
    /// Implementasi IGameStatus.
    /// </summary>
    public class GameStatusMono : MonoBehaviour, IGameStatus
    {
        #region IGameStatus

        [field: SerializeField, ReadOnly]
        public GameStatus Status { get; private set; } = default;

        public Action<GameStatus> OnStatusChanged { get; set; } = null;

        public void ChangeStatus(GameStatus status)
        {
            Status = status;

            OnStatusChanged?.Invoke(Status);
        }

        #endregion
    }
}