using Core;
using Global;
using UnityEngine;

namespace AJierroCode.UI
{
    public class InstantiatePackageButton : MonoBehaviour
    {

        [SerializeField] private PackageManager packageManager;

        public void InstantiateNextPackage()
        {
            AssertDebug.CheckComponent(packageManager);
            packageManager.SpawnPackageButtonMethod();
        }

    }
}
