using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOP05_Assignment
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {

        private decimal extraFee;

        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    extraFee = value;
                }
            }
        }

        private decimal estimatedCost;
        public override decimal EstimatedCost
        {
            get
            {
               return DeliveryFee + (decimal)(Weight * 5) + ExtraFee;
            }
            set => estimatedCost = value;
        }



        public ExpressShipment(string trackingCode, string description, double weight,
            decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight,
               deliveryFee, destination)
        {
            ExtraFee = extraFee;
            Name = "Express Shipment";
        }

        public override void PrintShipment()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Express Shipment---------------");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code: {TrackingCode} \n Description: {Description} \n  " +
               $"Weight: {Weight} KG\n Delivery Fee: {DeliveryFee} EGP\n Destination: {Destination} \n " +
               $"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Extra Fee: {ExtraFee} EGP");
        }

        public string GetTrackingStatus()
        {
            return "Shipment SH002 is Out for Delivery.\n";
        }

        public decimal CalculateInsurance()
        {
            return 0.08m * EstimatedCost;
        }
    }
}
