using System;
using System.Collections.Generic;
using System.Text;

namespace OOP05_Assignment
{
    internal abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;


        public string Name { get; set; }
        public Shipment(string trackingCode, string description, double weight,
                decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50, default)
        {
            this.trackingCode = trackingCode;
        }
        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("TrackingCode is required");
                }
                trackingCode = value;

            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }

        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }

        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }

        }

        public abstract decimal EstimatedCost { get; set; }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0) { deliveryFee = newFee; }
        }
        public abstract void PrintShipment();
       







        public void weightUpdate(double newWeight)
        {
            weight = newWeight;
        }

        public void weightUpdate(double newWeight, double packingWeight)
        {
            weight = newWeight + packingWeight;
        }
    }
}
