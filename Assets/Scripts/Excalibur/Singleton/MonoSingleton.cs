using UnityEngine;

namespace Excalibur
{
    public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour, new()
    {
        private static T _instance;

        public static T Instance => _instance;

        protected virtual void Awake()
        {
            if (_instance == null)
            {
                _instance = this as T;
            }
        }

        public static bool Initialized()
        {
            return _instance != null;
        }
    }
}
