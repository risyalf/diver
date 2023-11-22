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
    /// Implementasi IPooledObject.
    /// </summary>
    public class PooledObject : MonoBehaviour, IPooledObject
    {
        #region IPooledObject

        public void Activate()
        {
            gameObject.SetActive(true);
        }

        public void DeActivate()
        {
            gameObject.SetActive(false);
        }

        public bool IsActive()
        {
            return gameObject.activeInHierarchy;
        }

        #endregion
    }
}
