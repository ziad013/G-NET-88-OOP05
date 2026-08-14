using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05_Assignment
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {

        public StandardShipment(string trackingCode, string description, double weight,
             decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight,
                deliveryFee, destination)
        {
            Name = "Standard Shipment";
        }

        private decimal estimatedCost;
        public override decimal EstimatedCost { get => DeliveryFee + (decimal)(Weight * 5); set => estimatedCost = value; }

        public decimal CalculateInsurance()
        {
            return 0.05m * EstimatedCost;
        }

        public string GetTrackingStatus()
        {
            return "Shipment SH001 is Ready.\n";
        }

        public override void PrintShipment()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------Standard Shipment----------------");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code: {TrackingCode} \n Description: {Description} \n  " +
                $"Weight: {Weight} KG\n Delivery Fee: {DeliveryFee} EGP\n Destination: {Destination} \n " +
                $"Estimated Cost: {EstimatedCost} EGP");
        }

    }
}
