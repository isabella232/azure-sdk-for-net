// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Sql;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// This is the main client class for interacting with the Azure SQL
    /// Database REST APIs.
    /// </summary>
    public partial interface ISqlManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Includes operations for importing and exporting Azure SQL Databases
        /// into and out of Azure blob storage.
        /// </summary>
        IDacOperations Dac
        {
            get; 
        }
        
        /// <summary>
        /// Represents the SQL Database Management API includes operations for
        /// managing SQL Server database copies for a subscription.
        /// </summary>
        IDatabaseCopyOperations DatabaseCopies
        {
            get; 
        }
        
        /// <summary>
        /// The Azure SQL Database Management API includes operations for
        /// getting database operations. Specifically, this API allows you to
        /// get a specific operation, or to list all the operations that
        /// happened on a specific database or on all databases in the Azure
        /// SQL Database Server.
        /// </summary>
        IDatabaseOperationOperations DatabaseOperations
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Databases.
        /// Contains operations to: Create, Retrieve, Update, and Delete
        /// databases, and also includes the ability to get the event logs for
        /// a database.
        /// </summary>
        IDatabaseOperations Databases
        {
            get; 
        }
        
        /// <summary>
        /// The Azure SQL Database Management API includes operations for
        /// managing the server-level Firewall Rules for Azure SQL Database
        /// Servers. You cannot manage the database-level firewall rules using
        /// the Azure SQL Database Management API; they can only be managed by
        /// running the Transact-SQL statements against the master or
        /// individual user databases.
        /// </summary>
        IFirewallRuleOperations FirewallRules
        {
            get; 
        }
        
        /// <summary>
        /// The Azure SQL Database Management API includes operations for
        /// getting Azure SQL Database Server quotas. Specifically, using the
        /// APIs you can get a specific quota or list all of the quotas for
        /// the Azure SQL Database Server.
        /// </summary>
        IQuotaOperations Quotas
        {
            get; 
        }
        
        /// <summary>
        /// Contains operations for getting Azure SQL Databases that can be
        /// recovered.
        /// </summary>
        IRecoverableDatabaseOperations RecoverableDatabases
        {
            get; 
        }
        
        /// <summary>
        /// Contains the operation to create recovery requests for Azure SQL
        /// Databases.
        /// </summary>
        IRecoverDatabaseOperations RecoverDatabaseOperations
        {
            get; 
        }
        
        /// <summary>
        /// Contains operations for getting dropped Azure SQL Databases that
        /// can be restored.
        /// </summary>
        IRestorableDroppedDatabaseOperations RestorableDroppedDatabases
        {
            get; 
        }
        
        /// <summary>
        /// Contains the operation to create restore requests for Azure SQL
        /// Databases.
        /// </summary>
        IRestoreDatabaseOperations RestoreDatabaseOperations
        {
            get; 
        }
        
        /// <summary>
        /// Contains methods to allow various operations on Azure SQL Database
        /// Servers.
        /// </summary>
        IServerOperations Servers
        {
            get; 
        }
        
        /// <summary>
        /// This class provides methods to get a specific service objective by
        /// using its ID or to List all of the service objectives on a server.
        /// </summary>
        IServiceObjectiveOperations ServiceObjectives
        {
            get; 
        }
    }
}
