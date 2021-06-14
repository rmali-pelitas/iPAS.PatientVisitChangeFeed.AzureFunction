using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace iPAS.PatientVisitChangeFeed.AzureFunction.Models
{
    public class PatientVisitModel
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
        public string SchemaVersionNum { get; set; }

        public string TenantId { get; set; }
        public string FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string FacilityTimeZoneOffSet { get; set; }
        public string PointOfCareId { get; set; }
        public string ServiceTypeCode { get; set; }
        public string ServiceTypeDescription { get; set; }
        public Modulesubscription[] ModuleSubscription { get; set; }
        public string PatientId { get; set; }
        public string PatientVisitId { get; set; }
        public string PatientAccountId { get; set; }
        public string PatientAccountIdentifierType { get; set; }
        public string PatientIdentifierType { get; set; }
        public string PatientVisitIdentifierType { get; set; }
        public string DisplayPatientId { get; set; }

        public string DisplayPatientAccountId { get; set; }
        public string CurrentVisitStatusId { get; set; }
        public string CurrentVisitStatusDescription { get; set; }
        public string StatusChange { get; set; }
        public Visitstatus[] VisitStatus { get; set; }
        public Patient Patient { get; set; }
        public Patientcontact[] PatientContact { get; set; }
        public Visit Visit { get; set; }
        public Guarantor[] Guarantor { get; set; }
        public Insurance[] Insurance { get; set; }
        public Observation[] Observation { get; set; }
        public Diagnosis[] Diagnosis { get; set; }
        public Drg[] DRG { get; set; }
        public Procedure[] Procedure { get; set; }
        public Accident Accident { get; set; }
        public Claimoccurance[] ClaimOccurance { get; set; }
        public Appointment Appointment { get; set; }
        public Transaction[] Transaction { get; set; }
        public string iPASEmployeeId { get; set; }
        public string iPASEmployeeFirstName { get; set; }
        public string iPASEmployeeLastName { get; set; }
        public string iPASAdministrativeDepartmentId { get; set; }
        public string iPASAdministrativeDepartmentName { get; set; }
        public string NoniPASUser { get; set; }
        public string ScoringEnabled { get; set; }
        public ExtendedData[] ExtendedData { get; set; }

    }

    public class Patient
    {
        public List<Tenantpatientidentifier> TenantPatientIdentifier { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientMiddleInitial { get; set; }
        public string PatientSuffix { get; set; }
        public DateTime? PatientDateOfBirth { get; set; }
        public Patientgender PatientGender { get; set; }
        public Patientrace PatientRace { get; set; }
        public Patientlanguage PatientLanguage { get; set; }
        public string MaritalStatus { get; set; }
        public string Religion { get; set; }
        public string Ethnicity { get; set; }
        public string Citizenship { get; set; }
        public string Nationality { get; set; }
        public string IsEmployed { get; set; }
        public string Occupation { get; set; }
        public string IsDeceased { get; set; }
        public DateTime? DeceasedDateTime { get; set; }
        public string PatientMultipleBirthIndicator { get; set; }
        public string PatientMultipleBirthOrder { get; set; }
        public Patientmotheridentifier[] PatientMotherIdentifier { get; set; }
        public string PatientEmailAddress { get; set; }
        public Patientphonenumber[] PatientPhoneNumber { get; set; }
        public Patientaddress[] PatientAddress { get; set; }
        public Primarycareprovider[] PrimaryCareProvider { get; set; }
    }

    public class Patientgender
    {
        public string GenderCode { get; set; }
        public string GenderDescription { get; set; }
    }

    public class Patientrace
    {
        public string RaceCode { get; set; }
        public string RaceDescription { get; set; }
    }

    public class Patientlanguage
    {
        public string LanguageCode { get; set; }
        public string LanguageDescription { get; set; }
    }

    public class Tenantpatientidentifier
    {
        public string TenantPatientId { get; set; }
        public string TenantPatientIdentifierType { get; set; }
        public string TenantPatientIdentifierDescription { get; set; }
    }

    public class Patientmotheridentifier
    {
        public string MotherPatientId { get; set; }
        public string MotherPatientIdentifierType { get; set; }
        public string MotherPatientIdentifierDescription { get; set; }
    }

    public class Patientphonenumber
    {
        public string PhoneNumber { get; set; }
        public string PhoneNumberTypeCode { get; set; }
        public string PhoneNumberTypeDescription { get; set; }
    }

    public class Patientaddress
    {
        public string AddressTypeCode { get; set; }
        public string AddressTypeDescription { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class Primarycareprovider
    {
        public Providertype ProviderType { get; set; }
        public string ProviderNPI { get; set; }
        public string ProviderFirstName { get; set; }
        public string ProviderLastName { get; set; }
    }

    public class Providertype
    {
        public string ProviderTypeCode { get; set; }
        public string ProviderTypeDescription { get; set; }
    }

    public class Visit
    {
        //public Tenantpatientvisitidentifier[] TenantPatientVisitIdentifier { get; set; }
        public string AccountNumber { get; set; }
        public string VisitNumber { get; set; }
        public DateTime? VisitDate { get; set; }
        public string PreAdmissionNumber { get; set; }
        public Patientclass PatientClass { get; set; }
        public Patienttype PatientType { get; set; }
        public Admitsource AdmitSource { get; set; }
        public string VisitService { get; set; }
        public Financialclass FinancialClass { get; set; }
        public string CurrentBalance { get; set; }
        public string PatientResponsibilityEstimate { get; set; }

        public DateTime? VisitDischargeDate { get; set; }
        public string VisitLengthOfStay { get; set; }
        public Admittype AdmitType { get; set; }
        public string VisitReadmisisonIndicator { get; set; }
        public string VisitAdmissionReason { get; set; }
        public string VisitNewbornIndicator { get; set; }
        public Visitlocation VisitLocation { get; set; }
        public Visitprovider[] VisitProvider { get; set; }
    }

    public class Patientclass
    {
        public string PatientClassCode { get; set; }
        public string PatientClassDescription { get; set; }
    }

    public class Patienttype
    {
        public string PatientTypeCode { get; set; }
        public string PatientTypeDescription { get; set; }
    }

    public class Admitsource
    {
        public string AdmitSourceCode { get; set; }
        public string AdmitSourceDescription { get; set; }
    }

    public class Financialclass
    {
        public string FinancialClassCode { get; set; }
        public string FinancialClassDescription { get; set; }
    }

    public class Admittype
    {
        public string AdmitTypeCode { get; set; }
        public string AdmitTypeDescription { get; set; }
    }

    public class Visitlocation
    {
        public string LocationResourceGroupId { get; set; }
        public string LocationId { get; set; }
        public Locationpointofcare LocationPointOfCare { get; set; }
        public string LocationFacility { get; set; }
        public string LocationBuilding { get; set; }
        public string LocationFloor { get; set; }
        public string LocationRoom { get; set; }
        public string LocationBed { get; set; }
        public string LocationType { get; set; }
        public string LocationDescription { get; set; }
        public DateTime? LocationDate { get; set; }
        public string LocationDuration { get; set; }
        public string LocationDurationUnits { get; set; }
        public string LocationStatus { get; set; }
        public Locationnote[] LocationNote { get; set; }
    }

    public class Locationpointofcare
    {
        public string PointofCareCode { get; set; }
        public string PointofCareDescription { get; set; }
    }

    public class Locationnote
    {
        public string NoteId { get; set; }
        public string NoteType { get; set; }
        public string NoteSource { get; set; }
        public string NoteText { get; set; }
    }

    public class Tenantpatientvisitidentifier
    {
        public string TenantPatientVisitId { get; set; }
        public string TenantPatientVisitIdentifierType { get; set; }
        public string TenantPatientVisitIdentifierDescription { get; set; }
    }

    public class Visitprovider
    {
        public string ProviderResourceGroupId { get; set; }
        public string ProviderSetId { get; set; }
        public Providertype ProviderType { get; set; }
        public string ProviderNPI { get; set; }
        public string ProviderFirstName { get; set; }
        public string ProviderLastName { get; set; }
        public string ProviderMiddleInitial { get; set; }
        public string ProviderPrefix { get; set; }
        public string ProviderSuffix { get; set; }
        public DateTime? ProviderStartDate { get; set; }
        public string ProviderDuration { get; set; }
        public string ProviderDurationUnits { get; set; }
        public string ProviderStatus { get; set; }
        public Providernote[] ProviderNote { get; set; }
    }


    public class Providernote
    {
        public string NoteId { get; set; }
        public string NoteType { get; set; }
        public string NoteSource { get; set; }
        public string NoteText { get; set; }
    }

    public class Accident
    {
        public DateTime? AccidentDateTime { get; set; }
        public string AccidentCode { get; set; }
        public string AccidentLocation { get; set; }
        public string AutoAccidentState { get; set; }
        public string AccidentJobRelatedIndicator { get; set; }
        public string AccidentDeathIndicator { get; set; }
        public Accidentaddress AccidentAddress { get; set; }
    }

    public class Accidentaddress
    {
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class Appointment
    {
        public string AppointmentId { get; set; }
        public string AppointmentStatus { get; set; }
        public string AppointmentType { get; set; }
        public DateTime? AppointmentStartDate { get; set; }
        public DateTime? AppointmentEndDate { get; set; }
        public string AppointmentDuration { get; set; }
        public string AppointmentDurationUnits { get; set; }
        public string AppointmentReason { get; set; }
        public Appointmentnote[] AppointmentNote { get; set; }
        public Appointmentservice[] AppointmentService { get; set; }
        public Appointmentgeneralresource[] AppointmentGeneralResource { get; set; }
    }

    public class Appointmentnote
    {
        public string NoteId { get; set; }
        public string NoteType { get; set; }
        public string NoteSource { get; set; }
        public string NoteText { get; set; }
    }

    public class Appointmentservice
    {
        public string ServiceResourceGroupId { get; set; }
        public string ServiceId { get; set; }
        public string ServiceDescription { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string ServiceDuration { get; set; }
        public string ServiceDurationUnits { get; set; }
        public string ServiceStatus { get; set; }
        public Appointmentservicenote[] AppointmentServiceNote { get; set; }
    }

    public class Appointmentservicenote
    {
        public string NoteId { get; set; }
        public string NoteType { get; set; }
        public string NoteSource { get; set; }
        public string NoteText { get; set; }
    }

    public class Appointmentgeneralresource
    {
        public string GeneralResourceGroupId { get; set; }
        public string GeneralResourceId { get; set; }
        public string GeneralResourceDescription { get; set; }
        public string GeneralResourceType { get; set; }
        public string GeneralResourceQuantity { get; set; }
        public string GeneralResourceQuantityUnits { get; set; }
        public DateTime? GeneralResourceDate { get; set; }
        public string GeneralResourceDuration { get; set; }
        public string GeneralResourceDurationUnits { get; set; }
        public string GeneralResourceStatus { get; set; }
        public Appointmentgeneralresourcenote[] AppointmentGeneralResourceNote { get; set; }
    }

    public class Appointmentgeneralresourcenote
    {
        public string NoteId { get; set; }
        public string NoteType { get; set; }
        public string NoteSource { get; set; }
        public string NoteText { get; set; }
    }

    public class Modulesubscription
    {
        public int ModuleRefId { get; set; }
    }

    public class Visitstatus
    {
        public string StatusSequenceNum { get; set; }
        public string ID { get; set; }
        public string Description { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }

    public class Patientcontact
    {
        public Contacttype ContactType { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactMiddleInitial { get; set; }
        public string ContactOrganizationName { get; set; }
        public Contactrelationtopatient ContactRelationToPatient { get; set; }
        public Contactphonenumber[] ContactPhoneNumber { get; set; }
        public Contactaddress[] ContactAddress { get; set; }
    }

    public class Contacttype
    {
        public string ContactCode { get; set; }
        public string ContactDescription { get; set; }
    }

    public class Contactrelationtopatient
    {
        public string RelationshipTypeCode { get; set; }
        public string RelationshipTypeDescription { get; set; }
    }

    public class Contactphonenumber
    {
        public string PhoneNumber { get; set; }
        public string PhoneNumberTypeCode { get; set; }
        public string PhoneNumberTypeDescription { get; set; }
    }

    public class Contactaddress
    {
        public string AddressTypeCode { get; set; }
        public string AddressTypeDescription { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class Guarantor
    {
        public Guid GuarantorId { get; set; }
        public string GuarantorNumber { get; set; }
        public Guarantorrelationtopatient GuarantorRelationToPatient { get; set; }
        public string GuarantorFirstName { get; set; }
        public string GuarantorLastName { get; set; }
        public string GuarantorMiddleInitial { get; set; }
        public DateTime? GuarantorDateOfBirth { get; set; }
        public string GuarantorSSN { get; set; }
        public Guarantorgender GuarantorGender { get; set; }
        public Guarantorlanguage GuarantorLanguage { get; set; }
        public Guarantorrace GuarantorRace { get; set; }
        public string GuarantorEthnicity { get; set; }
        public string GuarantorReligion { get; set; }
        public string GuarantorCitizenship { get; set; }
        public string GuarantorMaritalStatus { get; set; }
        public string GuarantorSpouseFirstName { get; set; }
        public string GuarantorSpouseLastName { get; set; }
        public Guarantorphonenumber[] GuarantorPhoneNumber { get; set; }
        public string GuarantorEmail { get; set; }
        public Guarantoraddress[] GuarantorAddress { get; set; }
        public string GuarantorEmployementStatus { get; set; }
        public string GuarantorEmployerName { get; set; }
        public Guarantoremployeraddress[] GuarantorEmployerAddress { get; set; }
    }

    public class Guarantorrelationtopatient
    {
        public string RelationshipTypeCode { get; set; }
        public string RelationshipTypeDescription { get; set; }
    }

    public class Guarantorgender
    {
        public string GenderCode { get; set; }
        public string GenderDescription { get; set; }
    }

    public class Guarantorlanguage
    {
        public string LanguageCode { get; set; }
        public string LanguageDescription { get; set; }
    }

    public class Guarantorrace
    {
        public string RaceCode { get; set; }
        public string RaceDescription { get; set; }
    }

    public class Guarantorphonenumber
    {
        public string PhoneNumber { get; set; }
        public string PhoneNumberTypeCode { get; set; }
        public string PhoneNumberTypeDescription { get; set; }
    }

    public class Guarantoraddress
    {
        public Addresstype AddressType { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class Addresstype
    {
        public string AddressCode { get; set; }
        public string AddressDescription { get; set; }
    }

    public class Guarantoremployeraddress
    {
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class Insurance
    {
        public Guid InsuranceId { get; set; }
        public string InsuranceSequence { get; set; }
        public string InsurancePlanId { get; set; }
        public string InsurancePlanName { get; set; }
        public string InsurancePlanType { get; set; }
        public Insurancecompanyaddress InsuranceCompanyAddress { get; set; }
        public Insurancecompanyphonenumber InsuranceCompanyPhoneNumber { get; set; }
        public string InsuranceGroupNumber { get; set; }
        public string InsuranceGroupName { get; set; }
        public DateTime? InsurancePlanEffectiveDate { get; set; }
        public DateTime? InsurancePlanExpirationDate { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public string InsuranceCoverageType { get; set; }
        public string InsuranceAuthorizationNumber { get; set; }
        public DateTime? InsuranceAuthorizationDate { get; set; }
        public string InsuranceAuthorizationSource { get; set; }
        public string InsuranceAssignmentOfBenefits { get; set; }
        public string InsuranceCoordinationOfBenefits { get; set; }
        public string InsuranceCoordinationOfBenefitsPriority { get; set; }
        public string InsuranceNoticedOfAdmissionRequired { get; set; }
        public DateTime? InsuranceNoticedOfAdmissionDate { get; set; }
        public DateTime? InsurancePreAdmitCertification { get; set; }
        public DateTime? InsuranceVerificationDate { get; set; }
        public string InsuranceCertificationNumber { get; set; }
        public string InsuranceCertifiedBy { get; set; }
        public DateTime? InsuranceCertificationBeginDate { get; set; }
        public DateTime? InsuranceCertificationEndDate { get; set; }
        public Insured Insured { get; set; }
    }

    public class Insurancecompanyaddress
    {
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class Insurancecompanyphonenumber
    {
        public string PhoneNumber { get; set; }
        public string PhoneNumberTypeCode { get; set; }
        public string PhoneNumberTypeDescription { get; set; }
    }

    public class Insured
    {
        public string Insuredid { get; set; }
        public string MedicareBeneficiaryIdentifier { get; set; }
        public Insuredrelationtopatient InsuredRelationToPatient { get; set; }
        public string InsuredFirstName { get; set; }
        public string InsuredLastName { get; set; }
        public string InsuredMiddleInitial { get; set; }
        public string InsuredSuffix { get; set; }
        public DateTime? InsuredDateOfBirth { get; set; }
        public string InsuredSSN { get; set; }
        public Insuredgender InsuredGender { get; set; }
        public Insuredrace InsuredRace { get; set; }
        public string InsuredMartialStatus { get; set; }
        public string InsuredCitizenship { get; set; }
        public Insurancedphonenumber InsurancedPhoneNumber { get; set; }
        public Insuredaddress InsuredAddress { get; set; }
        public string InsuredGroupEmployerId { get; set; }
        public string InsuredGroupEmployerName { get; set; }
        public string InsuredEmployementStatus { get; set; }
        public Insuredemployeraddress InsuredEmployerAddress { get; set; }
    }

    public class Insuredrelationtopatient
    {
        public string RelationshipTypeCode { get; set; }
        public string RelationshipTypeDescription { get; set; }
    }

    public class Insuredgender
    {
        public string GenderCode { get; set; }
        public string GenderDescription { get; set; }
    }

    public class Insuredrace
    {
        public string RaceCode { get; set; }
        public string RaceDescription { get; set; }
    }

    public class Insurancedphonenumber
    {
        public string PhoneNumber { get; set; }
        public string PhoneNumberTypeCode { get; set; }
        public string PhoneNumberTypeDescription { get; set; }
    }

    public class Insuredaddress
    {
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class Insuredemployeraddress
    {
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class Observation
    {
        public DateTime? ObservationDateTime { get; set; }
        public string ObservationType { get; set; }
        public string ObservationNumber { get; set; }
        public string[] ObservationValue { get; set; }
        public string ObservationUnits { get; set; }
        public string ObservationRange { get; set; }
        public string[] ObservationAbnormalFlag { get; set; }
        public string ObservationProbability { get; set; }
        public string[] ObservationNatureOfAbnormalTest { get; set; }
        public string ObservationResultStatus { get; set; }
        public DateTime? ObservationLastNormalResultDate { get; set; }
        public string ObservationProducerId { get; set; }
        public Observationresponsibleobserver ObservationResponsibleObserver { get; set; }
    }

    public class Observationresponsibleobserver
    {
        public string ResponsibleOberverId { get; set; }
        public string ResponsibleObeserverFirstName { get; set; }
        public string ResponsibleObeserverLastName { get; set; }
    }

    public class Diagnosis
    {
        public string DiagnosisType { get; set; }
        public Diagnosisdescription DiagnosisDescription { get; set; }
        public DateTime? DiagnosisDateTime { get; set; }
        public Diagnosingclinician[] DiagnosingClinician { get; set; }
        public string DiagnosisClassification { get; set; }
        public string DiagnosisConfidentialIndicator { get; set; }
        public DateTime? DiagnosisAssertationDateTime { get; set; }
    }

    public class Diagnosisdescription
    {
        public string DiagnosisCode { get; set; }
        public string DiagnosisName { get; set; }
    }

    public class Diagnosingclinician
    {
        public string DiagnosingClinicianId { get; set; }
        public string DiagnosingClinicianFirstName { get; set; }
        public string DiagnosingClinicianLastName { get; set; }
    }

    public class Drg
    {
        public string DRG { get; set; }
        public DateTime? DRGAssignedDateTime { get; set; }
    }

    public class Procedure
    {
        public string ProcedureNumber { get; set; }
        public string ProcedureType { get; set; }
        public Procedurename ProcedureName { get; set; }
        public DateTime? ProcedureDate { get; set; }
        public string ProcedureModifier { get; set; }
        public Procedureprovider[] ProcedureProvider { get; set; }
        public string ProcedureAthesiaCode { get; set; }
        public string ProcedureAnthesiaMinutes { get; set; }
        public string ProcedurePriority { get; set; }
        public string ProcedureAssociatedDiagnosisCode { get; set; }
    }

    public class Procedurename
    {
        public string ProcedureCode { get; set; }
        public string ProcedureDescription { get; set; }
    }

    public class Procedureprovider
    {
        public Providertype ProviderType { get; set; }
        public string ProviderNPI { get; set; }
        public string ProviderFirstName { get; set; }
        public string ProviderLastName { get; set; }
    }

    public class Claimoccurance
    {
        public string OccuranceCode { get; set; }
        public DateTime? OccuranceDate { get; set; }
    }

    public class Transaction
    {
        public float DocVersionNum { get; set; }
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }
        public string FacilityCode { get; set; }
        public string MessageType { get; set; }
        public Eventtype EventType { get; set; }
        public DateTime? EventDateTime { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
    }

    public class Eventtype
    {
        public string EventTypeCode { get; set; }
        public string EventTypeDescription { get; set; }
    }

    public class ExtendedData
    {
        public string Category { get; set; }
        public string FieldName { get; set; }
        public string Data { get; set; }
    }

}
