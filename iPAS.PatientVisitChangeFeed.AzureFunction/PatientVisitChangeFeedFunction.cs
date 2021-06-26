using System;
using System.Collections.Generic;
using iPAS.PatientVisitChangeFeed.AzureFunction.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace iPAS.PatientVisitChangeFeed.AzureFunction
{
    public static class PatientVisitChangeFeed
    {
        [FunctionName("PatientVisitChangeFeedFunction")]
        public static void Run([CosmosDBTrigger(
            databaseName: "PatientVisit",
            collectionName: "PatientVisitUA",
            ConnectionStringSetting = "AzureCosmosConnectionString",
            LeaseCollectionName = "leases",
            CreateLeaseCollectionIfNotExists = true)]IReadOnlyList<Document> input, ILogger log)
        {
            if (input != null && input.Count > 0)
            {
                log.LogInformation("Documents modified " + input.Count);
                CosmosClient _cosmosClient = new CosmosClient("AccountEndpoint=https://ipasqa-patient-cosmos-db.documents.azure.com:443/;AccountKey=anAbRiNBDRQBpCOhbioVFajlCWFdyxyiWk4p3tTIJsKLVOs1finuCROWmSjO8BlMQZl2Wv3HdgxKma2zoKSnVA==;");
                var _patientvisitMatchContainer = _cosmosClient.GetContainer("PatientVisit", "PatientMatchUA");
                foreach (var document in input)
                {
                    var patientVisitJson = JsonConvert.SerializeObject(document);

                    PatientVisitModel patientVisitObj = JsonConvert.DeserializeObject<PatientVisitModel>(patientVisitJson);

                    PatientVisitMatch newpatientVisitMatchObj = new PatientVisitMatch(patientVisitObj);

                    var patientIdentifier = patientVisitObj.Patient.TenantPatientIdentifier.Find(x => x.TenantPatientIdentifierType == patientVisitObj.PatientIdentifierType)?.TenantPatientId;
                    var _partitionKey = patientVisitObj.FacilityId + (String.IsNullOrEmpty(patientIdentifier) ? "_SYSTEM" : "_" + patientIdentifier);

                    try
                    {

                        var existingRec = _patientvisitMatchContainer.ReadItemAsync<PatientVisitMatch>(id: patientVisitObj.PatientVisitId, partitionKey: new Microsoft.Azure.Cosmos.PartitionKey(_partitionKey))?.Result;
                        if (existingRec != null && existingRec.Resource != null)
                        {
                            var deleteRes = _patientvisitMatchContainer.DeleteItemAsync<PatientVisitMatch>(existingRec.Resource.PatientVisitId, new Microsoft.Azure.Cosmos.PartitionKey(_partitionKey))?.Result;
                        }

                    }
                    catch (Exception)
                    {
                        log.LogError("RECORD NOT FOUND WITH PATIENTVISITID: " + patientVisitObj.PatientVisitId);
                    }
                    finally
                    {
                        var res = _patientvisitMatchContainer.CreateItemAsync<PatientVisitMatch>(newpatientVisitMatchObj, new Microsoft.Azure.Cosmos.PartitionKey(_partitionKey))?.Result;
                        log.LogInformation("PatientVisitMatch is updated with PatientVisitId: " + patientVisitObj.PatientVisitId);

                        try
                        {
                            if (!String.IsNullOrEmpty(patientIdentifier))
                                {
                                var existingSystemRec = _patientvisitMatchContainer.ReadItemAsync<PatientVisitMatch>(id: patientVisitObj.PatientVisitId, partitionKey: new Microsoft.Azure.Cosmos.PartitionKey(patientVisitObj.FacilityId + "_SYSTEM"))?.Result;
                                if (existingSystemRec != null && existingSystemRec.Resource != null)
                                {
                                    var deleteSysRes = _patientvisitMatchContainer.DeleteItemAsync<PatientVisitMatch>(existingSystemRec.Resource.PatientVisitId, new Microsoft.Azure.Cosmos.PartitionKey(patientVisitObj.FacilityId + "_SYSTEM"))?.Result;
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }

                }

            }
        }
    }
}
