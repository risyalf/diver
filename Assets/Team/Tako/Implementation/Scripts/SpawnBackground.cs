using Assets.Team.Tako.Core.Scripts.Factory;
using Assets.Team.Tako.Core.Scripts.ObjectPooling;
using Assets.Team.Tako.Core.Scripts.Spawn;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts
{
    /// <summary>
    /// Menangani spawn pada background.
    /// </summary>
    public class SpawnBackground : MonoBehaviour, ISpawn
    {
        #region Variable

        /// <summary>
        /// Menangani pembuatan dari obstacle.
        /// </summary>
        private IFactory<IPooledObject> _backgroundFactory = null;

        #endregion

        #region ISpawn

        [field: SerializeField]
        public string Id { get; private set; } = string.Empty;

        public void DoSpawn()
        {
            var obstacle = _backgroundFactory.Get(transform);

            obstacle.Activate();
        }

        #endregion

        #region Mono

        private void Awake()
        {
            _backgroundFactory = (IFactory<IPooledObject>)Resources.Load("SO/Factory/BackgroundFactory");
        }

        private void OnDestroy()
        {
            _backgroundFactory.Reset();
        }

        #endregion
    }
}