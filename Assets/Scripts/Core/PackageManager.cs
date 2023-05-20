using AJierroCode.UI;
using UnityEngine;
using Random = UnityEngine.Random;

namespace AJierroCode.Core
{
    public class PackageManager : MonoBehaviour
    {

        private string[] packageIds;
        [SerializeField] private Package[] prefabPackage;

        [Header("Dependencies")]
        [SerializeField] private TicketView ticketView;
        
        [Header("Actual Package Info")]
        [SerializeField] private string packId;
        [SerializeField] private string packProducName;
        [SerializeField] private string packLocationFrom;
        [SerializeField] private string packLocationTo;
        [SerializeField] private string packDate;
        [SerializeField] private float packWeight;

        
        private void SpawnPackage(Package package)
        {
            Package packageObj = Instantiate(package, transform.position, Quaternion.identity);
            packageObj.Initialize(packageObj.Id, "Teclado Ozone", "Suecia", "Sevilla", "08/05/2009",1.5f);
            SavePackageInfo(packageObj);
            InitTicketInfo(packageObj);
        }

        //Acoplamos la funcionalidad a la clase del botón para no sobrecargar el Package, aqui registramos los objetos que vamos a instanciar y el botón se encarga de instanciarlos
        public void SpawnPackageButtonMethod()
        {
            SpawnPackage(prefabPackage[Random.Range(0, prefabPackage.Length)]);
        }

        private void SavePackageInfo(Package package)
        {
            packId = package.Id;
            packProducName = package.NameProduct;
            packLocationFrom = package.ShipFrom;
            packLocationTo = package.ShipTo;
            packDate = package.DeliveryDate;
            packWeight = package.PackageWeight;
        }

        private void InitTicketInfo(Package package)
        {
            ticketView.InitTicketValues(package);
        }
    }
}
