using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_7__assignment
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        #region Constructors

        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination, string destinationCountry, decimal CustomsFee) : base(trackingCode, description, weight, delivaryFee, destination, destinationCountry, CustomsFee)
        {

        }

        #endregion
        #region Methods

        public sealed override void GenerateCustomsReports()
        {
            base.GenerateCustomsReports();
        }

        #endregion
    }
}
