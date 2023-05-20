using UnityEngine;

namespace AJierroCode.Core
{
    public class Package : MonoBehaviour
    {
        #region ------------------------------VARIABLES------------------------------
        [SerializeField] private string id;
        public string Id => id;
        [SerializeField] private string nameProduct;
        public string NameProduct => nameProduct;
        [SerializeField] private string shipFrom;
        public string ShipFrom => shipFrom;
        [SerializeField] private string shipTo;
        public string ShipTo => shipTo;
        [SerializeField] private string deliveryDate;
        public string DeliveryDate => deliveryDate;
        //Seteamos nuestro peso para que no existan errores en sus numeros
        [SerializeField] private float packageWeight;
        public float PackageWeight
        {
            get => packageWeight;
            private set
            {
                if (value < 0.1f)
                {
                    packageWeight = 0.1f;
                }
                else if (value > 100f)
                {
                    packageWeight = 100f;
                }
                else
                {
                    packageWeight = value;
                }
            }
        }

        #endregion

        
        // Si necesitamos inicialiar un paquete con ciertos datos
        public void Initialize(string idInit, string nameProductInit, string shipFromInit, string shipToInit, string deliveryDateInit, float packageWeightInit)
        {
            this.id = idInit;
            this.nameProduct = nameProductInit;
            this.shipFrom = shipFromInit;
            this.shipTo = shipToInit;
            this.deliveryDate = deliveryDateInit;
            PackageWeight = packageWeightInit;
        }
        
        
        
        
    }
}
