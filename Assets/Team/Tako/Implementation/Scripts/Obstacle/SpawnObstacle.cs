using Assets.Team.Tako.Core.Scripts.Factory;
using Assets.Team.Tako.Core.Scripts.ObjectPooling;
using Assets.Team.Tako.Core.Scripts.Spawn;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Obstacle
{
    /// <summary>
    /// Menangani spawning obstacle.
    /// </summary>
    public class SpawnObstacle : MonoBehaviour, ISpawn
    {
        #region Variable

        /// <summary>
        /// Menangani pembuatan dari obstacle.
        /// </summary>
        private IFactory<IPooledObject> _obstacleFactory = null;

        #endregion

        #region ISpawn

        [field: SerializeField]
        public string Id { get; private set; } = string.Empty;

        public void DoSpawn()
        {
            var obstacle = _obstacleFactory.Get(transform);

            obstacle.Activate();
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _obstacleFactory = (IFactory<IPooledObject>)Resources.Load("SO/Factory/ObstacleFactory");
        }

        private void OnDestroy()
        {
            _obstacleFactory.Reset();
        }

        #endregion
    }
}