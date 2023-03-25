using UnityEngine;

namespace Cinject
{
    public abstract class MonoInstaller : MonoBehaviour
    {
        protected virtual void InstallBindings(ContainerBuilder builder) { }
    }
}