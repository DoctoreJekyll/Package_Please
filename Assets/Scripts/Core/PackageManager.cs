using System;
using Global;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Core
{
    public class PackageManager : MonoBehaviour
    {

        private string[] packageIds;
        [SerializeField] private Package[] prefabPackage;

        private void SpawnPackage(Package package)
        {
            Package packageObj = Instantiate(package, transform.position, Quaternion.identity);
            packageObj.Initialize(packageObj.Id, "Product Name", "location A", "location b", "date",10f);
        }

        //Acoplamos la funcionalidad a la clase del botón para no sobrecargar el Package, aqui registramos los objetos que vamos a instanciar y el botón se encarga de instanciarlos
        public void SpawnPackageButtonMethod()
        {
            SpawnPackage(prefabPackage[Random.Range(0, prefabPackage.Length)]);
        }
    }
}
