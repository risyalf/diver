using Assets.Team.Tako.Core.Scripts.Factory;
using Assets.Team.Tako.Core.Scripts.ObjectPooling;
using Assets.Team.Tako.Implementation.Scripts.ObjectPoolingManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.Factory
{
    /// <summary>
    /// Implementasi IFactory<GameObject> untuk generate background.
    /// </summary>
    [CreateAssetMenu(fileName = "BackgroundFactory", menuName = "Team/Tako/Implementation/Factory/Background")]
    public class BackgroundFactory : ScriptableObject, IFactory<IPooledObject>
    {
        #region Variable

        /// <summary>
        /// Menangani object pool.
        /// </summary>
        [SerializeField]
        private List<BackgroundObjectPooling> _obstacleObjectPoolManagers = new();

        #endregion

        #region IFactory<GameObject>

        public IPooledObject Get(params object[] parameters)
        {
            var objectPool = _obstacleObjectPoolManagers[Random.Range(0, _obstacleObjectPoolManagers.Count)].GetFreeObject();

            var objectPoolMono = (MonoBehaviour)objectPool;

            var parent = (Transform)parameters[0];

            objectPoolMono.transform.SetParent(parent);

            objectPoolMono.name = objectPoolMono.name.Replace("(Clone)", "");

            objectPoolMono.transform.localScale = Vector3.one;

            objectPoolMono.transform.localPosition = Vector3.zero;

            return objectPool;
        }

        public void Reset()
        {
            foreach (var poolingManager in _obstacleObjectPoolManagers)
            {
                poolingManager.ResetPooling();
            }
        }

        #endregion
    }
}