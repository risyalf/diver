using Assets.Team.Tako.Core.Scripts.ObjectPooling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Team.Tako.Implementation.Scripts.ObjectPoolingManager
{
    /// <summary>
    /// Implementasi IObjectPoolManager untuk background.
    /// </summary>
    [CreateAssetMenu(fileName = "BackgroundObjectPooling", menuName = "Team/Tako/Implementation/ObjectPooling/Background")]
    public class BackgroundObjectPooling : ScriptableObject, IObjectPoolManager
    {
        #region Variable

        /// <summary>
        /// Object yang telah digenerate oleh manager.
        /// </summary>
        private List<IPooledObject> _pooledObjects = new List<IPooledObject>();

        /// <summary>
        /// Base dari background.
        /// </summary>
        [SerializeField]
        private PooledObject prefab = null;

        #endregion

        #region IObjectPoolManager

        public IPooledObject GetFreeObject()
        {
            foreach (var obj in _pooledObjects)
            {
                if (!obj.IsActive())
                {
                    return obj;
                }
            }

            var newPooledObject = Instantiate(prefab);

            _pooledObjects.Add(newPooledObject);

            return newPooledObject;
        }

        public void ResetPooling()
        {
            _pooledObjects.Clear();
        }

        #endregion
    }
}
