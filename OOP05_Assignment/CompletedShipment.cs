using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05_Assignment
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(
       string trackingCode,
       string description,
       double weight,
       decimal deliveryFee,
       DeliveryAddress destination)
       : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

        public override decimal EstimatedCost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }
    }
}
