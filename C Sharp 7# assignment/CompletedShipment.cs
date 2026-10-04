using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_7__assignment
{
    internal sealed class CompletedShipment : Shipment
    {
        #region Constructors

        public CompletedShipment(string trackingCode, string description, decimal weight, decimal delivaryFee, DeliveryAddress destination) : base(trackingCode, description, weight, delivaryFee, destination)
        {
        }

        #endregion
    }
}
