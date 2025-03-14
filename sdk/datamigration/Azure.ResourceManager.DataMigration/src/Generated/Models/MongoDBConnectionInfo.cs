// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes a connection to a MongoDB data source. </summary>
    public partial class MongoDBConnectionInfo : ConnectionInfo
    {
        /// <summary> Initializes a new instance of MongoDBConnectionInfo. </summary>
        /// <param name="connectionString"> A MongoDB connection string or blob container URL. The user name and password can be specified here or in the userName and password properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public MongoDBConnectionInfo(string connectionString)
        {
            Argument.AssertNotNull(connectionString, nameof(connectionString));

            ConnectionString = connectionString;
            ConnectionInfoType = "MongoDbConnectionInfo";
        }

        /// <summary> Initializes a new instance of MongoDBConnectionInfo. </summary>
        /// <param name="connectionInfoType"> Type of connection info. </param>
        /// <param name="userName"> User name. </param>
        /// <param name="password"> Password credential. </param>
        /// <param name="connectionString"> A MongoDB connection string or blob container URL. The user name and password can be specified here or in the userName and password properties. </param>
        /// <param name="dataSource"> Data source. </param>
        /// <param name="encryptConnection"> Whether to encrypt the connection. </param>
        /// <param name="serverBrandVersion"> server brand version. </param>
        /// <param name="serverVersion"> server version. </param>
        /// <param name="serverName"> name of the server. </param>
        /// <param name="trustServerCertificate"> Whether to trust the server certificate. </param>
        /// <param name="enforceSSL"></param>
        /// <param name="port"> port for server. </param>
        /// <param name="additionalSettings"> Additional connection settings. </param>
        /// <param name="authentication"> Authentication type to use for connection. </param>
        internal MongoDBConnectionInfo(string connectionInfoType, string userName, string password, string connectionString, string dataSource, bool? encryptConnection, string serverBrandVersion, string serverVersion, string serverName, bool? trustServerCertificate, bool? enforceSSL, int? port, string additionalSettings, AuthenticationType? authentication) : base(connectionInfoType, userName, password)
        {
            ConnectionString = connectionString;
            DataSource = dataSource;
            EncryptConnection = encryptConnection;
            ServerBrandVersion = serverBrandVersion;
            ServerVersion = serverVersion;
            ServerName = serverName;
            TrustServerCertificate = trustServerCertificate;
            EnforceSSL = enforceSSL;
            Port = port;
            AdditionalSettings = additionalSettings;
            Authentication = authentication;
            ConnectionInfoType = connectionInfoType ?? "MongoDbConnectionInfo";
        }

        /// <summary> A MongoDB connection string or blob container URL. The user name and password can be specified here or in the userName and password properties. </summary>
        public string ConnectionString { get; set; }
        /// <summary> Data source. </summary>
        public string DataSource { get; set; }
        /// <summary> Whether to encrypt the connection. </summary>
        public bool? EncryptConnection { get; set; }
        /// <summary> server brand version. </summary>
        public string ServerBrandVersion { get; set; }
        /// <summary> server version. </summary>
        public string ServerVersion { get; set; }
        /// <summary> name of the server. </summary>
        public string ServerName { get; set; }
        /// <summary> Whether to trust the server certificate. </summary>
        public bool? TrustServerCertificate { get; set; }
        /// <summary> Gets or sets the enforce ssl. </summary>
        public bool? EnforceSSL { get; set; }
        /// <summary> port for server. </summary>
        public int? Port { get; set; }
        /// <summary> Additional connection settings. </summary>
        public string AdditionalSettings { get; set; }
        /// <summary> Authentication type to use for connection. </summary>
        public AuthenticationType? Authentication { get; set; }
    }
}
