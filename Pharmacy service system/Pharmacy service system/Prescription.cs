using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_service_system
{
    class Prescription
    {
        int ID;
        string medication;
        int patientID;
        int doctorID;
        int pharmacyID;
        string status;
        char type;
        char dosage;
        int refillTotal;
        string startDate;
        string endDate;
        string lastRefillDate;


        public Prescription()
        {

        }

        public void displayAllPrescription()
        {

        }

        public void displayNewPrescription()
        {

        }

        public void indicateNewPrescription()
        {

        }

        public void viewPrescriptionDetail()
        {

        }

        public void retrieveAllRefillRequest()
        {

        }

        public void viewRefillDetail()
        {

        }

        public void displayAllRefillRequest()
        {

        }

        public void displayNewRefillRequest()
        {

        }

        public void indicateNewRefillRequest()
        {

        }

        public void changeRefillStatus()
        {

        }



        //get methods
        public int getID()
        {
            return ID;
        }
        public string getMedication()
        {
            return medication;
        }
        public int getPatientID()
        {
            return patientID;
        }
        public int getDoctorID()
        {
            return doctorID;
        }
        public int getPharmacyID()
        {
            return pharmacyID;
        }
        public string getStatus()
        {
            return status;
        }
        public char getType()
        {
            return type;
        }
        public char getDosage()
        {
            return dosage;
        }
        public string getStartDate()
        {
            return startDate;
        }
        public string getEndDate()
        {
            return endDate;
        }
        public string getLastRefillDate()
        {
            return lastRefillDate;
        }
    }
}
