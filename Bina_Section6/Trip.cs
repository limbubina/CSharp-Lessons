using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina_Section6
{
    internal class Trip
    {
        string destination;
        int distanceTravelled;
        decimal costOfGasoline;
        int numberOfGallons;

        //Constructor
        public Trip(string destination, int distanceTravelled, decimal costOfGasoline, int numberOfGallons)
        {
            Destination = destination;
            DistanceTravelled = distanceTravelled;
            CostOfGasoline = costOfGasoline;
            NumberOfGallons = numberOfGallons;
        }

        //Proiperties
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int DistanceTravelled
        {
            get { return distanceTravelled; }
            set { distanceTravelled = value; }
        }
        public decimal CostOfGasoline
        {
            get { return costOfGasoline; }
            set 
            {
               // costOfGasoline = Math.Round(value,2);
                costOfGasoline = value;
            }
        }
        public int NumberOfGallons
        {
            get { return numberOfGallons; }
            set { numberOfGallons = value; }
        }

        //Methods
        public int milesPerGallon()
        {
            int milesPerGallon = DistanceTravelled / NumberOfGallons;
            return milesPerGallon;
        }

        public decimal costPerMile()
        {
            decimal costPerMile = CostOfGasoline / Convert.ToDecimal(DistanceTravelled);
            decimal roundUpCost= Math.Round(costPerMile,3);
            return roundUpCost;
        }

        public override string ToString()
        {
            return $"Destination: {Destination}, " +
                $"\nDistance travelled: {DistanceTravelled}, " +
                $"\nCost of Gas: {CostOfGasoline.ToString("C")}, " +
                $"\nTotal gallon: {NumberOfGallons}";
                   
        }
    }
}
