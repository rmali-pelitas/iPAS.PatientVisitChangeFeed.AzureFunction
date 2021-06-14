using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace iPAS.PatientVisitChangeFeed.AzureFunction.Models
{
    public class TenantPatientIdentifier
    {
        public string TenantPatientId { get; set; }
        public string TenantPatientIdentifierType { get; set; }
    }

    public class PatientPhoneNumber
    {
        public string PhoneNumber { get; set; }
        public string PhoneNumberTypeCode { get; set; }
    }

    public class PatientAddress
    {
        public string AddressTypeCode { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }

    public class PatientVisitMatch
    {
        public PatientVisitMatch()
        {

        }
        public PatientVisitMatch(PatientVisitModel patientvisitModel)
        {
            this.Id = patientvisitModel.PatientVisitId;

            var patientIdentifierType = patientvisitModel.Patient.TenantPatientIdentifier.Find(x => x.TenantPatientIdentifierType == patientvisitModel.PatientIdentifierType)?.TenantPatientId;
            var _partitionKey = patientvisitModel.FacilityId + (String.IsNullOrEmpty(patientIdentifierType) ? "_SYSTEM" : "_" + patientIdentifierType);
            this.PartitionKey = _partitionKey;
            this.TenantId = patientvisitModel.TenantId;
            this.FacilityId = patientvisitModel.FacilityId;
            this.PatientId = patientvisitModel.PatientId;
            this.PointOfCareId = patientvisitModel.PointOfCareId;
            this.PatientVisitId = patientvisitModel.PatientVisitId;
            this.PatientAccountId = patientvisitModel.PatientAccountId;
            this.DisplayPatientId = patientvisitModel.DisplayPatientId;
            this.DisplayPatientAccountId = patientvisitModel.DisplayPatientAccountId;
            this.TenantPatientIdentifier = new List<TenantPatientIdentifier>();

            foreach (var patientIdentifier in patientvisitModel.Patient.TenantPatientIdentifier)
            {
                var tenantPatientIdentifier = new TenantPatientIdentifier();
                tenantPatientIdentifier.TenantPatientId = patientIdentifier.TenantPatientId;
                tenantPatientIdentifier.TenantPatientIdentifierType = patientIdentifier.TenantPatientIdentifierType;
                this.TenantPatientIdentifier.Add(tenantPatientIdentifier);
            }

            this.PatientFirstName = patientvisitModel.Patient.PatientFirstName;
            this.PatientLastName = patientvisitModel.Patient.PatientLastName;
            this.PatientMiddleInitial = patientvisitModel.Patient.PatientMiddleInitial;
            this.PatientSuffix = patientvisitModel.Patient.PatientSuffix;
            this.PatientDateOfBirth = patientvisitModel.Patient.PatientDateOfBirth;
            this.GenderCode = patientvisitModel.Patient.PatientGender.GenderCode;
            this.PatientEmailAddress = patientvisitModel.Patient.PatientEmailAddress;

            

            if (patientvisitModel.Patient.PatientPhoneNumber != null)
            {
                this.PatientPhoneNumber = new List<PatientPhoneNumber>();
                foreach (var phonenumber in patientvisitModel.Patient.PatientPhoneNumber)
                {
                    var patientPhoneNum = new PatientPhoneNumber();

                    patientPhoneNum.PhoneNumber = phonenumber.PhoneNumber;
                    patientPhoneNum.PhoneNumberTypeCode = phonenumber.PhoneNumberTypeCode;

                    this.PatientPhoneNumber.Add(patientPhoneNum);
                }
            }
            

            
            if (patientvisitModel.Patient.PatientAddress != null)
            {
                this.PatientAddress = new List<PatientAddress>();
                foreach (var address in patientvisitModel.Patient.PatientAddress)
                {
                    var addressObj = new PatientAddress();

                    addressObj.AddressTypeCode = address.AddressTypeCode;
                    addressObj.City = address.City;
                    addressObj.PostalCode = address.PostalCode;
                    addressObj.State = address.State;
                    addressObj.StreetAddress1 = address.StreetAddress1;
                    addressObj.StreetAddress2 = address.StreetAddress2;

                    this.PatientAddress.Add(addressObj);
                }
            }

            this.AccountNumber = patientvisitModel.Visit.AccountNumber;
            this.VisitNumber = patientvisitModel.Visit.VisitNumber;
            this.VisitDate = patientvisitModel.Visit.VisitDate;
            this.AppointmentId = patientvisitModel.Appointment?.AppointmentId;

        }
        [JsonProperty("id")]
        public string Id { get; set; }

        public string PartitionKey { get; set; }
        public string TenantId { get; set; }
        public string FacilityId { get; set; }
        public string PatientId { get; set; }
        public string PointOfCareId { get; set; }
        public string PatientVisitId { get; set; }
        public string PatientAccountId { get; set; }
        public string DisplayPatientId { get; set; }
        public string DisplayPatientAccountId { get; set; }
        public List<TenantPatientIdentifier> TenantPatientIdentifier { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientMiddleInitial { get; set; }
        public string PatientSuffix { get; set; }
        public DateTime? PatientDateOfBirth { get; set; }
        public string GenderCode { get; set; }
        public string PatientEmailAddress { get; set; }
        public List<PatientPhoneNumber> PatientPhoneNumber { get; set; }
        public List<PatientAddress> PatientAddress { get; set; }
        public string AccountNumber { get; set; }
        public string VisitNumber { get; set; }
        public DateTime? VisitDate { get; set; }
        public string AppointmentId { get; set; }
    }
}
