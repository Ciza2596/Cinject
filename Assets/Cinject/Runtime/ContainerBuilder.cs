using UnityEngine;

namespace Cinject
{
    [DefaultExecutionOrder(-5000)]
    public sealed class ContainerBuilder : MonoBehaviour
    {
        [SerializeField] private bool _isAuto;
        [SerializeField] private MonoInstaller[] _monoInstallers;
        
        public void Build()
        {
            
        }
    }
}
