// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeRegistrationProperties. </summary>
    public partial class ResourceTypeRegistrationProperties
    {
        /// <summary> Initializes a new instance of ResourceTypeRegistrationProperties. </summary>
        public ResourceTypeRegistrationProperties()
        {
            Endpoints = new ChangeTrackingList<ResourceTypeEndpoint>();
            SwaggerSpecifications = new ChangeTrackingList<SwaggerSpecification>();
            AllowedUnauthorizedActions = new ChangeTrackingList<string>();
            AuthorizationActionMappings = new ChangeTrackingList<AuthorizationActionMapping>();
            LinkedAccessChecks = new ChangeTrackingList<LinkedAccessCheck>();
            LoggingRules = new ChangeTrackingList<LoggingRule>();
            ThrottlingRules = new ChangeTrackingList<ThrottlingRule>();
            RequiredFeatures = new ChangeTrackingList<string>();
            DisallowedActionVerbs = new ChangeTrackingList<string>();
            ServiceTreeInfos = new ChangeTrackingList<ServiceTreeInfo>();
            SubscriptionStateRules = new ChangeTrackingList<ProviderSubscriptionStateRule>();
            ExtendedLocations = new ChangeTrackingList<ProviderHubExtendedLocationOptions>();
        }

        /// <summary> Initializes a new instance of ResourceTypeRegistrationProperties. </summary>
        /// <param name="routingType"></param>
        /// <param name="regionality"></param>
        /// <param name="endpoints"></param>
        /// <param name="extensionOptions"></param>
        /// <param name="marketplaceType"></param>
        /// <param name="swaggerSpecifications"></param>
        /// <param name="allowedUnauthorizedActions"></param>
        /// <param name="authorizationActionMappings"></param>
        /// <param name="linkedAccessChecks"></param>
        /// <param name="defaultApiVersion"></param>
        /// <param name="loggingRules"></param>
        /// <param name="throttlingRules"></param>
        /// <param name="requiredFeatures"></param>
        /// <param name="featuresRule"></param>
        /// <param name="isAsyncOperationEnabled"></param>
        /// <param name="provisioningState"></param>
        /// <param name="isThirdPartyS2SEnabled"></param>
        /// <param name="subscriptionLifecycleNotificationSpecifications"></param>
        /// <param name="isPureProxy"></param>
        /// <param name="identityManagement"></param>
        /// <param name="checkNameAvailabilitySpecifications"></param>
        /// <param name="disallowedActionVerbs"></param>
        /// <param name="serviceTreeInfos"></param>
        /// <param name="requestHeaderOptions"></param>
        /// <param name="subscriptionStateRules"></param>
        /// <param name="templateDeploymentOptions"></param>
        /// <param name="extendedLocations"></param>
        /// <param name="resourceMovePolicy"></param>
        /// <param name="resourceDeletionPolicy"></param>
        internal ResourceTypeRegistrationProperties(ResourceRoutingType? routingType, ResourceTypeRegistrationRegionality? regionality, IList<ResourceTypeEndpoint> endpoints, ResourceTypeExtensionOptions extensionOptions, MarketplaceType? marketplaceType, IList<SwaggerSpecification> swaggerSpecifications, IList<string> allowedUnauthorizedActions, IList<AuthorizationActionMapping> authorizationActionMappings, IList<LinkedAccessCheck> linkedAccessChecks, string defaultApiVersion, IList<LoggingRule> loggingRules, IList<ThrottlingRule> throttlingRules, IList<string> requiredFeatures, FeaturesRule featuresRule, bool? isAsyncOperationEnabled, ProviderHubProvisioningState? provisioningState, bool? isThirdPartyS2SEnabled, SubscriptionLifecycleNotificationSpecifications subscriptionLifecycleNotificationSpecifications, bool? isPureProxy, IdentityManagementProperties identityManagement, CheckNameAvailabilitySpecifications checkNameAvailabilitySpecifications, IList<string> disallowedActionVerbs, IList<ServiceTreeInfo> serviceTreeInfos, RequestHeaderOptions requestHeaderOptions, IList<ProviderSubscriptionStateRule> subscriptionStateRules, TemplateDeploymentOptions templateDeploymentOptions, IList<ProviderHubExtendedLocationOptions> extendedLocations, ResourceMovePolicy resourceMovePolicy, ResourceDeletionPolicy? resourceDeletionPolicy)
        {
            RoutingType = routingType;
            Regionality = regionality;
            Endpoints = endpoints;
            ExtensionOptions = extensionOptions;
            MarketplaceType = marketplaceType;
            SwaggerSpecifications = swaggerSpecifications;
            AllowedUnauthorizedActions = allowedUnauthorizedActions;
            AuthorizationActionMappings = authorizationActionMappings;
            LinkedAccessChecks = linkedAccessChecks;
            DefaultApiVersion = defaultApiVersion;
            LoggingRules = loggingRules;
            ThrottlingRules = throttlingRules;
            RequiredFeatures = requiredFeatures;
            FeaturesRule = featuresRule;
            IsAsyncOperationEnabled = isAsyncOperationEnabled;
            ProvisioningState = provisioningState;
            IsThirdPartyS2SEnabled = isThirdPartyS2SEnabled;
            SubscriptionLifecycleNotificationSpecifications = subscriptionLifecycleNotificationSpecifications;
            IsPureProxy = isPureProxy;
            IdentityManagement = identityManagement;
            CheckNameAvailabilitySpecifications = checkNameAvailabilitySpecifications;
            DisallowedActionVerbs = disallowedActionVerbs;
            ServiceTreeInfos = serviceTreeInfos;
            RequestHeaderOptions = requestHeaderOptions;
            SubscriptionStateRules = subscriptionStateRules;
            TemplateDeploymentOptions = templateDeploymentOptions;
            ExtendedLocations = extendedLocations;
            ResourceMovePolicy = resourceMovePolicy;
            ResourceDeletionPolicy = resourceDeletionPolicy;
        }

        /// <summary> Gets or sets the routing type. </summary>
        public ResourceRoutingType? RoutingType { get; set; }
        /// <summary> Gets or sets the regionality. </summary>
        public ResourceTypeRegistrationRegionality? Regionality { get; set; }
        /// <summary> Gets the endpoints. </summary>
        public IList<ResourceTypeEndpoint> Endpoints { get; }
        /// <summary> Gets or sets the extension options. </summary>
        internal ResourceTypeExtensionOptions ExtensionOptions { get; set; }
        /// <summary> Gets or sets the extension options resource creation begin. </summary>
        public ExtensionOptions ExtensionOptionsResourceCreationBegin
        {
            get => ExtensionOptions is null ? default : ExtensionOptions.ResourceCreationBegin;
            set
            {
                if (ExtensionOptions is null)
                    ExtensionOptions = new ResourceTypeExtensionOptions();
                ExtensionOptions.ResourceCreationBegin = value;
            }
        }

        /// <summary> Gets or sets the marketplace type. </summary>
        public MarketplaceType? MarketplaceType { get; set; }
        /// <summary> Gets the swagger specifications. </summary>
        public IList<SwaggerSpecification> SwaggerSpecifications { get; }
        /// <summary> Gets the allowed unauthorized actions. </summary>
        public IList<string> AllowedUnauthorizedActions { get; }
        /// <summary> Gets the authorization action mappings. </summary>
        public IList<AuthorizationActionMapping> AuthorizationActionMappings { get; }
        /// <summary> Gets the linked access checks. </summary>
        public IList<LinkedAccessCheck> LinkedAccessChecks { get; }
        /// <summary> Gets or sets the default api version. </summary>
        public string DefaultApiVersion { get; set; }
        /// <summary> Gets the logging rules. </summary>
        public IList<LoggingRule> LoggingRules { get; }
        /// <summary> Gets the throttling rules. </summary>
        public IList<ThrottlingRule> ThrottlingRules { get; }
        /// <summary> Gets the required features. </summary>
        public IList<string> RequiredFeatures { get; }
        /// <summary> Gets or sets the features rule. </summary>
        internal FeaturesRule FeaturesRule { get; set; }
        /// <summary> Gets or sets the required features policy. </summary>
        public FeaturesPolicy? RequiredFeaturesPolicy
        {
            get => FeaturesRule is null ? default(FeaturesPolicy?) : FeaturesRule.RequiredFeaturesPolicy;
            set
            {
                FeaturesRule = value.HasValue ? new FeaturesRule(value.Value) : null;
            }
        }

        /// <summary> Gets or sets the is async operation enabled. </summary>
        public bool? IsAsyncOperationEnabled { get; set; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public ProviderHubProvisioningState? ProvisioningState { get; set; }
        /// <summary> Gets or sets the is third party s 2 s enabled. </summary>
        public bool? IsThirdPartyS2SEnabled { get; set; }
        /// <summary> Gets or sets the subscription lifecycle notification specifications. </summary>
        public SubscriptionLifecycleNotificationSpecifications SubscriptionLifecycleNotificationSpecifications { get; set; }
        /// <summary> Gets or sets the is pure proxy. </summary>
        public bool? IsPureProxy { get; set; }
        /// <summary> Gets or sets the identity management. </summary>
        public IdentityManagementProperties IdentityManagement { get; set; }
        /// <summary> Gets or sets the check name availability specifications. </summary>
        public CheckNameAvailabilitySpecifications CheckNameAvailabilitySpecifications { get; set; }
        /// <summary> Gets the disallowed action verbs. </summary>
        public IList<string> DisallowedActionVerbs { get; }
        /// <summary> Gets the service tree infos. </summary>
        public IList<ServiceTreeInfo> ServiceTreeInfos { get; }
        /// <summary> Gets or sets the request header options. </summary>
        internal RequestHeaderOptions RequestHeaderOptions { get; set; }
        /// <summary> Gets or sets the opt in headers. </summary>
        public OptInHeaderType? OptInHeaders
        {
            get => RequestHeaderOptions is null ? default : RequestHeaderOptions.OptInHeaders;
            set
            {
                if (RequestHeaderOptions is null)
                    RequestHeaderOptions = new RequestHeaderOptions();
                RequestHeaderOptions.OptInHeaders = value;
            }
        }

        /// <summary> Gets the subscription state rules. </summary>
        public IList<ProviderSubscriptionStateRule> SubscriptionStateRules { get; }
        /// <summary> Gets or sets the template deployment options. </summary>
        public TemplateDeploymentOptions TemplateDeploymentOptions { get; set; }
        /// <summary> Gets the extended locations. </summary>
        public IList<ProviderHubExtendedLocationOptions> ExtendedLocations { get; }
        /// <summary> Gets or sets the resource move policy. </summary>
        public ResourceMovePolicy ResourceMovePolicy { get; set; }
        /// <summary> Gets or sets the resource deletion policy. </summary>
        public ResourceDeletionPolicy? ResourceDeletionPolicy { get; set; }
    }
}
