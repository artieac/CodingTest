﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprivata
{
    public class CityClinicsTest : LoggableTest
    {
        static int MinNumberOfCities = 1;
        static int MaxNumberOfCities = 500000;
        static int MaxNumberOfClinics = 2000000;

        static int MinPopulation = 1;
        static int MaxPopulation = 5000000;

        private class CityClinicDetails
        {
            public static string ConvertListToString(IList<CityClinicDetails> cityClinicDetails)
            {
                string retVal = "";

                if(cityClinicDetails != null)
                {
                    foreach(CityClinicDetails cityClinicDetail in cityClinicDetails)
                    {
                        retVal += "\n****\n" + cityClinicDetail.ToString() + "\n****\n";
                    }
                }

                return retVal;
            }
            public CityClinicDetails(int cityNumber, int population)
            {
                this.CityNumber = cityNumber;
                this.Population = population;
                this.NumberOfClinics = 0;
            }

            public int CityNumber { get; private set; }
            public int Population { get; private set; }

            public int NumberOfClinics { get; private set; }

            public int MaxVaccinationsPerClinic { get; private set; }
            public void AddClinic()
            {
                this.NumberOfClinics++;

                this.MaxVaccinationsPerClinic = this.Population / this.NumberOfClinics;
            }

            public bool IsPopulationValid()
            {
                bool retVal = true;
                if( this.Population < MinPopulation ||
                    this.Population > MaxPopulation)                   
                {
                    retVal = false;
                }

                return retVal;
            }

            public override string ToString()
            {
                string retVal = "";
                
                retVal = "City: " + this.CityNumber + "\n";
                retVal += "Population: " + this.Population + "\n";
                retVal += "Number of Clinics:" + this.NumberOfClinics + "\n";
                retVal += "Max Vaccinations:" + this.MaxVaccinationsPerClinic + "\n";

                return retVal;
            }
        }

        public CityClinicsTest(IOutputLogger outputLogger) : base(outputLogger) { }

        public bool AreCitiesAndClinicsValid(int numberOfCities, int numberOfClinics)
        {
            bool retVal = false;

            if (numberOfCities >= MinNumberOfCities &&
               numberOfCities <= MaxNumberOfCities &&
               numberOfCities <= numberOfClinics &&
               numberOfClinics <= MaxNumberOfClinics)
            {
                this.OutputLogger.WriteMessage("Numbers of cities and clinics are valid.");
                retVal = true;
            }
            else
            {
                this.OutputLogger.WriteMessage("Numbers of cities and clinics are NOT valid.");
            }

            return retVal;
        }

        public int DaterminMaxVaccinationsInLargestClinic(int numberOfCities, int numberOfClinics, int[] cityPopulations)
        {
            int retVal = 0;
            bool areInputsValid = true;
            int usedClinics = 0;
            IList<CityClinicDetails> cityClinicData = new List<CityClinicDetails>();

            this.OutputLogger.WriteMessage("*******************");
            this.OutputLogger.WriteMessage("Number of cities: " + numberOfCities);
            this.OutputLogger.WriteMessage("Number of clinics: " + numberOfClinics);

            if (this.AreCitiesAndClinicsValid(numberOfCities, numberOfClinics) == true)
            {
                for(int i = 0; i < numberOfCities; i++)
                {
                    CityClinicDetails newItem = new CityClinicDetails(i, cityPopulations[i]);
                    if(newItem.IsPopulationValid())
                    {
                        this.OutputLogger.WriteMessage("The population of city " + i + " is valid.");

                        newItem.AddClinic();
                        usedClinics++;
                        cityClinicData.Add(newItem);
                    }
                    else
                    {
                        this.OutputLogger.WriteMessage("The population of city " + i + " is NOT valid.");
                        areInputsValid = false;
                        break;
                    }
                }
            }

            if(areInputsValid)
            {
                cityClinicData = cityClinicData.OrderByDescending(o => o.MaxVaccinationsPerClinic).ToList();

                this.OutputLogger.WriteMessage("Starting point: " + CityClinicDetails.ConvertListToString(cityClinicData));

                while (numberOfClinics - usedClinics > 0)
                {
                    cityClinicData[0].AddClinic();
                    usedClinics++;
                    cityClinicData = cityClinicData.OrderByDescending(o => o.MaxVaccinationsPerClinic).ToList();
                    this.OutputLogger.WriteMessage("Updated order: " + CityClinicDetails.ConvertListToString(cityClinicData));
                }

                retVal = cityClinicData[0].MaxVaccinationsPerClinic;
                this.OutputLogger.WriteMessage("Return value of Max Vaccinations per clinic: " + retVal);
            }

            return retVal;
        }
    }
}
