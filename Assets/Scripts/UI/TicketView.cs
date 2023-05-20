using System.Globalization;
using AJierroCode.Core;
using TMPro;
using UnityEngine;

namespace AJierroCode.UI
{
    public class TicketView : MonoBehaviour
    {
        [SerializeField] private TMP_Text idTTmpxt;
        [SerializeField] private TMP_Text productTmpTxt;
        [SerializeField] private TMP_Text shipFromTmpTxt;
        [SerializeField] private TMP_Text shipToTmpTxt;
        [SerializeField] private TMP_Text dateTmpTxt;
        [SerializeField] private TMP_Text weigthTmpTxt;
        
        public void InitTicketValues(Package package)
        {
            idTTmpxt.text = package.Id;
            productTmpTxt.text = package.NameProduct;
            shipFromTmpTxt.text = package.ShipFrom;
            shipToTmpTxt.text = package.ShipTo;
            dateTmpTxt.text = package.DeliveryDate;
            weigthTmpTxt.text = package.PackageWeight.ToString(CultureInfo.CurrentCulture);
        }
        
        
    }
}
