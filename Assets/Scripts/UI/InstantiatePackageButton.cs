using AJierroCode.Core;
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
            ChangeModeToEvent();
            InstantiatePackage();
        }

        private void InstantiatePackage()
        {
            packageManager.SpawnPackageButtonMethod();
        }

        private void ChangeModeToEvent()
        {
            StatesGameManager.Instance.SetGameState(StatesGameManager.GameStates.Event);
        }

    }
}
