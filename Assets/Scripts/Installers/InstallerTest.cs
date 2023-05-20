using UnityEngine;
using System;
using AJierroCode.Core;
using Zenject;

namespace AJierroCode.Installers
{
    public class InstallerTest : MonoInstaller
    {

        public override void InstallBindings()
        {
            Container.Bind<PackageManager>().AsSingle().NonLazy();
        }
        
        
    }
}
