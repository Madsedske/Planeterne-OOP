using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne_OOP
{
    class Planet
    {
        private string name;
        private double mads;
        private int diameter;
        private int density;
        private double gravity;
        private double rotationPeriod;
        private double lenghtOfDay;
        private double distanceFromSun;
        private double orbitalPeriod;
        private double orbitalVelocity;
        private int temperature;
        private int numberOfMoons;
        private bool ringSystem;

        public Planet(string Name, double Mads, int Diameter, int Density, double Gravity, double RotationPeriod, double LenghtOfDay, double DistanceFromSun, double OrbitalPeriod, double OrbitalVelocity, int Temperature, int NumberOfMoons, bool RingSystem)
        {
            name = Name;
            mads = Mads;
            diameter = Diameter;
            density = Density;
            gravity = Gravity;
            rotationPeriod = RotationPeriod;
            lenghtOfDay = LenghtOfDay;
            distanceFromSun = DistanceFromSun;
            orbitalPeriod = OrbitalPeriod;
            orbitalVelocity = OrbitalVelocity;
            temperature = Temperature;
            numberOfMoons = NumberOfMoons;
            ringSystem = RingSystem;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Mads
        {
            get { return this.mads; }
            set { this.mads = value; }
        }
        public int Diameter
        {
            get { return this.diameter; }
            set { this.diameter = value; }
        }
        public int Density
        {
            get { return this.density; }
            set { this.density = value; }
        }
        public double Gravity
        {
            get { return this.gravity; }
            set { this.gravity = value; }
        }

        public double RotationPeriod
        {
            get { return this.rotationPeriod; }
            set { this.rotationPeriod = value; }
        }
        public double LenghtOfDay
        {
            get { return this.lenghtOfDay; }
            set { this.lenghtOfDay = value; }
        }
        public double DistanceFromSun
        {
            get { return this.distanceFromSun; }
            set { this.distanceFromSun = value; }
        }

        public double OrbitalPeriod
        {
            get { return this.orbitalPeriod; }
            set { this.orbitalPeriod = value; }
        }
        public double OrbitalVelocity
{
            get { return this.orbitalVelocity; }
            set { this.orbitalVelocity = value; }
        }
        public int Temperature
{
            get { return this.temperature; }
            set { this.temperature = value; }
        }
        public int NumberOfMoons
{
            get { return this.numberOfMoons; }
            set { this.numberOfMoons = value; }
        }
        public bool RingSystem
        {
            get { return this.ringSystem; }
            set { this.ringSystem = value; }
        }
    }
}
