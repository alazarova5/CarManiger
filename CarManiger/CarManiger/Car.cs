﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManiger
{
    public class Car
    {
        private string make;
        private string model;
        private double fuelConsumption;
        private double fuelAmount;
        private double fuelCapacity;
        public Car(string make, string model, double fuelConsumption, double fuelCapacity)
        {
            this.Make = make;
            this.Model = model;
            this.FuelConsumption = fuelConsumption;
            this.FuelCapacity = fuelCapacity;
            this.FuelAmount = 0;
        }
        public string Make
        {
            get
            {
                return this.make;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Make cannot be null or empty!");
                }
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }
                this.model = value;
            }
        }
        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            private set
            {
                if (value <= 0)
{
                    throw new ArgumentException("Fuel consumption cannot be zero or negative! ");
                }
                this.fuelConsumption = value;
            }
        }
        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;
            }
            private set
            {
                if (value < 0)
{
                    throw new ArgumentException("Fuel amount cannot be negative! ");
                }
                this.fuelAmount = value;
            }
        }
        public double FuelCapacity
        {
            get
            {
                return this.fuelCapacity;
            }
            private set
            {
                if (value <= 0)
{
                    throw new ArgumentException(" Fuel capacity cannot be zero or negative! ");
                }
                this.fuelCapacity = value;
            }
        }
        public void Refuel(double fuelToRefuel)
        {
            if (fuelToRefuel<= 0)
{
                throw new ArgumentException(" Fuel amount cannot be zero or negative!");
            }
            this.FuelAmount += fuelToRefuel;

            if (this.FuelAmount > this.FuelCapacity)
{
                this.FuelAmount = this.FuelCapacity;
            }
        }
        public void Drive(double distance)
        {
            double fuelNeeded = (distance / 100) * this.FuelConsumption;
            if (fuelNeeded > this.FuelAmount)
{
                throw new InvalidOperationException("You don't have enough fuel to drive!");
}
            this.FuelAmount -= fuelNeeded;
        }
    }
}
