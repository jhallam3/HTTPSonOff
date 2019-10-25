using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnOnAndOffHTTPS.Classes
{
    class SetupXML
    {
    }

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Settings
    {

        private bool skipTypeCheckOnInitializationField;

        private bool dynamicLocalModuleLoadingField;

        private sbyte maxWritableSizeInBytesField;

        private bool noLockReadsField;

        private bool optimizeDataMemberAccessField;

        private object sendErrorsToField;

        private sbyte autoProfileApiThresholdInSecondsField;

        private ushort autoProfileTimespanInSecondsField;

        private ushort minBytesToCompressField;

        private byte numberOfExclusiveApiThreadsField;

        private bool hideCreatedByOnImportField;

        private string defaultAccountEmailAddressField;

        private bool lazyServiceHostingField;

        private bool offlineField;

        private bool warnOnSystemValidationIssuesField;

        private byte defaultExpireDaysField;

        private bool shareAccountSessionsField;

        private bool useCustomBehaviorsField;

        private bool useClientFastCallField;

        private bool useGPUAccelerationField;

        private bool showUnhandledExceptionDialogField;

        private byte clientStorageQuotaField;

        private bool pushAllToWindowsEventViewerField;

        private bool pushErrorsToWindowsEventViewerField;

        private bool userIdCaseSensitiveField;

        private uint logFileMaxSizeField;

        private byte logMaxBackupsField;

        private bool asyncBootupField;

        private bool useTimeZoneTranslationField;

        private byte logSqlStatementsTakingMoreThanSecondsField;

        private bool outputSQLProfileLogField;

        private byte logAPICallsTakingMoreThanSecondsField;

        private sbyte logFlowStepsTakingMoreThanMillisecondsField;

        private bool logFatalField;

        private bool logErrorField;

        private bool logWarnField;

        private bool logInfoField;

        private bool logDebugField;

        private ushort ipcChannelPortField;

        private bool ignoreAllCertificateErrorsField;

        private bool launchDebuggerOnUnitTestFailField;

        private SettingsInitializationEndPoint initializationEndPointField;

        //private SettingsEndPointDefinition[] controlInstanceEndpointsField;

        private string databaseConnectStringField;

        private byte defaultDatabaseQueryTimeoutField;

        private object secondaryDatabaseConnectStringField;

        private string dataBaseTypeField;

        private ushort watcherSocketPortField;

        private object httpEndpointPortField;

        private object httpsEndpointPortField;

        private bool enableNamedPipeField;

        private bool enableNetTcpField;

        private bool enableWSHttpField;

        private string portalBaseUrlField;

        private object clusterAddressableIPField;

        private string serverAdministratorEmailField;

        private string serverTypeField;

        private SettingsMail mailField;

        private string pushModeField;

        private string serverNameField;

        private bool splitInstancesToProcessesField;

        private bool restartStoppedInstancesField;

        private byte serverHeartBeatIntervalInSecondsField;

        private string socketsAddressField;

        private ushort socketsPortField;

        private bool sendWakeUpUsingOneWayCallField;

        private bool useLuceneFullTextSearchField;

        private bool useJSONOptimizedReportFetchingField;

        private bool enableCommunicationCompressionField;

        private string splashScreenTextField;

        private object productTitleField;

        private string fileStorageLocationField;

        private bool logCheckFieldTypesField;

        private object mSSqlReplicationPublicationNameField;

        private bool enableSingleSignOnField;

        private bool autoStartProfilerField;

        private string instanceDatabaseConnectionStringTemplateField;

        private string instanceSecondaryDatabaseConnectionStringTemplateField;

        private string recoverablePasswordEncryptionTypeField;

        private string passwordHashEncryptionTypeField;

        private bool waitForDebuggerField;

        private object allowedIPAddressesField;

        private object deniedIPAddressesField;

        private string defaultInstanceNameField;

        private bool enableClientEventDiagnosticsField;

        private string locallyAddressableIISWebsiteIPOrDNSNameField;

        private byte windowsEventViewerEventIdField;

        private bool suppressNewUserWizardField;

        private bool filterDuplicateLogMessagesField;

        private ushort duplicateLogMessageTimingInSecondsField;

        private bool oRMSaveByMergeField;

        private bool skipEnforceDBExistsStepField;

        private bool usePrototypeInstanceField;

        private string fullTextSearchField;

        private object wCFMaxConcurrentCallsPerServiceField;

        private bool hideDetailedErrorMessagesField;

        private string interServerCommunicationModeField;

        /// <remarks/>
        public bool SkipTypeCheckOnInitialization
        {
            get
            {
                return this.skipTypeCheckOnInitializationField;
            }
            set
            {
                this.skipTypeCheckOnInitializationField = value;
            }
        }

        /// <remarks/>
        public bool DynamicLocalModuleLoading
        {
            get
            {
                return this.dynamicLocalModuleLoadingField;
            }
            set
            {
                this.dynamicLocalModuleLoadingField = value;
            }
        }

        /// <remarks/>
        public sbyte MaxWritableSizeInBytes
        {
            get
            {
                return this.maxWritableSizeInBytesField;
            }
            set
            {
                this.maxWritableSizeInBytesField = value;
            }
        }

        /// <remarks/>
        public bool NoLockReads
        {
            get
            {
                return this.noLockReadsField;
            }
            set
            {
                this.noLockReadsField = value;
            }
        }

        /// <remarks/>
        public bool OptimizeDataMemberAccess
        {
            get
            {
                return this.optimizeDataMemberAccessField;
            }
            set
            {
                this.optimizeDataMemberAccessField = value;
            }
        }

        /// <remarks/>
        public object SendErrorsTo
        {
            get
            {
                return this.sendErrorsToField;
            }
            set
            {
                this.sendErrorsToField = value;
            }
        }

        /// <remarks/>
        public sbyte AutoProfileApiThresholdInSeconds
        {
            get
            {
                return this.autoProfileApiThresholdInSecondsField;
            }
            set
            {
                this.autoProfileApiThresholdInSecondsField = value;
            }
        }

        /// <remarks/>
        public ushort AutoProfileTimespanInSeconds
        {
            get
            {
                return this.autoProfileTimespanInSecondsField;
            }
            set
            {
                this.autoProfileTimespanInSecondsField = value;
            }
        }

        /// <remarks/>
        public ushort MinBytesToCompress
        {
            get
            {
                return this.minBytesToCompressField;
            }
            set
            {
                this.minBytesToCompressField = value;
            }
        }

        /// <remarks/>
        public byte NumberOfExclusiveApiThreads
        {
            get
            {
                return this.numberOfExclusiveApiThreadsField;
            }
            set
            {
                this.numberOfExclusiveApiThreadsField = value;
            }
        }

        /// <remarks/>
        public bool HideCreatedByOnImport
        {
            get
            {
                return this.hideCreatedByOnImportField;
            }
            set
            {
                this.hideCreatedByOnImportField = value;
            }
        }

        /// <remarks/>
        public string DefaultAccountEmailAddress
        {
            get
            {
                return this.defaultAccountEmailAddressField;
            }
            set
            {
                this.defaultAccountEmailAddressField = value;
            }
        }

        /// <remarks/>
        public bool LazyServiceHosting
        {
            get
            {
                return this.lazyServiceHostingField;
            }
            set
            {
                this.lazyServiceHostingField = value;
            }
        }

        /// <remarks/>
        public bool Offline
        {
            get
            {
                return this.offlineField;
            }
            set
            {
                this.offlineField = value;
            }
        }

        /// <remarks/>
        public bool WarnOnSystemValidationIssues
        {
            get
            {
                return this.warnOnSystemValidationIssuesField;
            }
            set
            {
                this.warnOnSystemValidationIssuesField = value;
            }
        }

        /// <remarks/>
        public byte DefaultExpireDays
        {
            get
            {
                return this.defaultExpireDaysField;
            }
            set
            {
                this.defaultExpireDaysField = value;
            }
        }

        /// <remarks/>
        public bool ShareAccountSessions
        {
            get
            {
                return this.shareAccountSessionsField;
            }
            set
            {
                this.shareAccountSessionsField = value;
            }
        }

        /// <remarks/>
        public bool UseCustomBehaviors
        {
            get
            {
                return this.useCustomBehaviorsField;
            }
            set
            {
                this.useCustomBehaviorsField = value;
            }
        }

        /// <remarks/>
        public bool UseClientFastCall
        {
            get
            {
                return this.useClientFastCallField;
            }
            set
            {
                this.useClientFastCallField = value;
            }
        }

        /// <remarks/>
        public bool UseGPUAcceleration
        {
            get
            {
                return this.useGPUAccelerationField;
            }
            set
            {
                this.useGPUAccelerationField = value;
            }
        }

        /// <remarks/>
        public bool ShowUnhandledExceptionDialog
        {
            get
            {
                return this.showUnhandledExceptionDialogField;
            }
            set
            {
                this.showUnhandledExceptionDialogField = value;
            }
        }

        /// <remarks/>
        public byte ClientStorageQuota
        {
            get
            {
                return this.clientStorageQuotaField;
            }
            set
            {
                this.clientStorageQuotaField = value;
            }
        }

        /// <remarks/>
        public bool PushAllToWindowsEventViewer
        {
            get
            {
                return this.pushAllToWindowsEventViewerField;
            }
            set
            {
                this.pushAllToWindowsEventViewerField = value;
            }
        }

        /// <remarks/>
        public bool PushErrorsToWindowsEventViewer
        {
            get
            {
                return this.pushErrorsToWindowsEventViewerField;
            }
            set
            {
                this.pushErrorsToWindowsEventViewerField = value;
            }
        }

        /// <remarks/>
        public bool UserIdCaseSensitive
        {
            get
            {
                return this.userIdCaseSensitiveField;
            }
            set
            {
                this.userIdCaseSensitiveField = value;
            }
        }

        /// <remarks/>
        public uint LogFileMaxSize
        {
            get
            {
                return this.logFileMaxSizeField;
            }
            set
            {
                this.logFileMaxSizeField = value;
            }
        }

        /// <remarks/>
        public byte LogMaxBackups
        {
            get
            {
                return this.logMaxBackupsField;
            }
            set
            {
                this.logMaxBackupsField = value;
            }
        }

        /// <remarks/>
        public bool AsyncBootup
        {
            get
            {
                return this.asyncBootupField;
            }
            set
            {
                this.asyncBootupField = value;
            }
        }

        /// <remarks/>
        public bool UseTimeZoneTranslation
        {
            get
            {
                return this.useTimeZoneTranslationField;
            }
            set
            {
                this.useTimeZoneTranslationField = value;
            }
        }

        /// <remarks/>
        public byte LogSqlStatementsTakingMoreThanSeconds
        {
            get
            {
                return this.logSqlStatementsTakingMoreThanSecondsField;
            }
            set
            {
                this.logSqlStatementsTakingMoreThanSecondsField = value;
            }
        }

        /// <remarks/>
        public bool OutputSQLProfileLog
        {
            get
            {
                return this.outputSQLProfileLogField;
            }
            set
            {
                this.outputSQLProfileLogField = value;
            }
        }

        /// <remarks/>
        public byte LogAPICallsTakingMoreThanSeconds
        {
            get
            {
                return this.logAPICallsTakingMoreThanSecondsField;
            }
            set
            {
                this.logAPICallsTakingMoreThanSecondsField = value;
            }
        }

        /// <remarks/>
        public sbyte LogFlowStepsTakingMoreThanMilliseconds
        {
            get
            {
                return this.logFlowStepsTakingMoreThanMillisecondsField;
            }
            set
            {
                this.logFlowStepsTakingMoreThanMillisecondsField = value;
            }
        }

        /// <remarks/>
        public bool LogFatal
        {
            get
            {
                return this.logFatalField;
            }
            set
            {
                this.logFatalField = value;
            }
        }

        /// <remarks/>
        public bool LogError
        {
            get
            {
                return this.logErrorField;
            }
            set
            {
                this.logErrorField = value;
            }
        }

        /// <remarks/>
        public bool LogWarn
        {
            get
            {
                return this.logWarnField;
            }
            set
            {
                this.logWarnField = value;
            }
        }

        /// <remarks/>
        public bool LogInfo
        {
            get
            {
                return this.logInfoField;
            }
            set
            {
                this.logInfoField = value;
            }
        }

        /// <remarks/>
        public bool LogDebug
        {
            get
            {
                return this.logDebugField;
            }
            set
            {
                this.logDebugField = value;
            }
        }

        /// <remarks/>
        public ushort IpcChannelPort
        {
            get
            {
                return this.ipcChannelPortField;
            }
            set
            {
                this.ipcChannelPortField = value;
            }
        }

        /// <remarks/>
        public bool IgnoreAllCertificateErrors
        {
            get
            {
                return this.ignoreAllCertificateErrorsField;
            }
            set
            {
                this.ignoreAllCertificateErrorsField = value;
            }
        }

        /// <remarks/>
        public bool LaunchDebuggerOnUnitTestFail
        {
            get
            {
                return this.launchDebuggerOnUnitTestFailField;
            }
            set
            {
                this.launchDebuggerOnUnitTestFailField = value;
            }
        }

        /// <remarks/>
        public SettingsInitializationEndPoint InitializationEndPoint
        {
            get
            {
                return this.initializationEndPointField;
            }
            set
            {
                this.initializationEndPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EndPointDefinition", IsNullable = false)]
        //public SettingsEndPointDefinition[] ControlInstanceEndpoints
        //{
        //    get
        //    {
        //        return this.controlInstanceEndpointsField;
        //    }
        //    set
        //    {
        //        this.controlInstanceEndpointsField = value;
        //    }
        //}

        /// <remarks/>
        public string DatabaseConnectString
        {
            get
            {
                return this.databaseConnectStringField;
            }
            set
            {
                this.databaseConnectStringField = value;
            }
        }

        /// <remarks/>
        public byte DefaultDatabaseQueryTimeout
        {
            get
            {
                return this.defaultDatabaseQueryTimeoutField;
            }
            set
            {
                this.defaultDatabaseQueryTimeoutField = value;
            }
        }

        /// <remarks/>
        public object SecondaryDatabaseConnectString
        {
            get
            {
                return this.secondaryDatabaseConnectStringField;
            }
            set
            {
                this.secondaryDatabaseConnectStringField = value;
            }
        }

        /// <remarks/>
        public string DataBaseType
        {
            get
            {
                return this.dataBaseTypeField;
            }
            set
            {
                this.dataBaseTypeField = value;
            }
        }

        /// <remarks/>
        public ushort WatcherSocketPort
        {
            get
            {
                return this.watcherSocketPortField;
            }
            set
            {
                this.watcherSocketPortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object HttpEndpointPort
        {
            get
            {
                return this.httpEndpointPortField;
            }
            set
            {
                this.httpEndpointPortField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object HttpsEndpointPort
        {
            get
            {
                return this.httpsEndpointPortField;
            }
            set
            {
                this.httpsEndpointPortField = value;
            }
        }

        /// <remarks/>
        public bool EnableNamedPipe
        {
            get
            {
                return this.enableNamedPipeField;
            }
            set
            {
                this.enableNamedPipeField = value;
            }
        }

        /// <remarks/>
        public bool EnableNetTcp
        {
            get
            {
                return this.enableNetTcpField;
            }
            set
            {
                this.enableNetTcpField = value;
            }
        }

        /// <remarks/>
        public bool EnableWSHttp
        {
            get
            {
                return this.enableWSHttpField;
            }
            set
            {
                this.enableWSHttpField = value;
            }
        }

        /// <remarks/>
        public string PortalBaseUrl
        {
            get
            {
                return this.portalBaseUrlField;
            }
            set
            {
                this.portalBaseUrlField = value;
            }
        }

        /// <remarks/>
        public object ClusterAddressableIP
        {
            get
            {
                return this.clusterAddressableIPField;
            }
            set
            {
                this.clusterAddressableIPField = value;
            }
        }

        /// <remarks/>
        public string ServerAdministratorEmail
        {
            get
            {
                return this.serverAdministratorEmailField;
            }
            set
            {
                this.serverAdministratorEmailField = value;
            }
        }

        /// <remarks/>
        public string ServerType
        {
            get
            {
                return this.serverTypeField;
            }
            set
            {
                this.serverTypeField = value;
            }
        }

        /// <remarks/>
        public SettingsMail Mail
        {
            get
            {
                return this.mailField;
            }
            set
            {
                this.mailField = value;
            }
        }

        /// <remarks/>
        public string PushMode
        {
            get
            {
                return this.pushModeField;
            }
            set
            {
                this.pushModeField = value;
            }
        }

        /// <remarks/>
        public string ServerName
        {
            get
            {
                return this.serverNameField;
            }
            set
            {
                this.serverNameField = value;
            }
        }

        /// <remarks/>
        public bool SplitInstancesToProcesses
        {
            get
            {
                return this.splitInstancesToProcessesField;
            }
            set
            {
                this.splitInstancesToProcessesField = value;
            }
        }

        /// <remarks/>
        public bool RestartStoppedInstances
        {
            get
            {
                return this.restartStoppedInstancesField;
            }
            set
            {
                this.restartStoppedInstancesField = value;
            }
        }

        /// <remarks/>
        public byte ServerHeartBeatIntervalInSeconds
        {
            get
            {
                return this.serverHeartBeatIntervalInSecondsField;
            }
            set
            {
                this.serverHeartBeatIntervalInSecondsField = value;
            }
        }

        /// <remarks/>
        public string SocketsAddress
        {
            get
            {
                return this.socketsAddressField;
            }
            set
            {
                this.socketsAddressField = value;
            }
        }

        /// <remarks/>
        public ushort SocketsPort
        {
            get
            {
                return this.socketsPortField;
            }
            set
            {
                this.socketsPortField = value;
            }
        }

        /// <remarks/>
        public bool SendWakeUpUsingOneWayCall
        {
            get
            {
                return this.sendWakeUpUsingOneWayCallField;
            }
            set
            {
                this.sendWakeUpUsingOneWayCallField = value;
            }
        }

        /// <remarks/>
        public bool UseLuceneFullTextSearch
        {
            get
            {
                return this.useLuceneFullTextSearchField;
            }
            set
            {
                this.useLuceneFullTextSearchField = value;
            }
        }

        /// <remarks/>
        public bool UseJSONOptimizedReportFetching
        {
            get
            {
                return this.useJSONOptimizedReportFetchingField;
            }
            set
            {
                this.useJSONOptimizedReportFetchingField = value;
            }
        }

        /// <remarks/>
        public bool EnableCommunicationCompression
        {
            get
            {
                return this.enableCommunicationCompressionField;
            }
            set
            {
                this.enableCommunicationCompressionField = value;
            }
        }

        /// <remarks/>
        public string SplashScreenText
        {
            get
            {
                return this.splashScreenTextField;
            }
            set
            {
                this.splashScreenTextField = value;
            }
        }

        /// <remarks/>
        public object ProductTitle
        {
            get
            {
                return this.productTitleField;
            }
            set
            {
                this.productTitleField = value;
            }
        }

        /// <remarks/>
        public string FileStorageLocation
        {
            get
            {
                return this.fileStorageLocationField;
            }
            set
            {
                this.fileStorageLocationField = value;
            }
        }

        /// <remarks/>
        public bool LogCheckFieldTypes
        {
            get
            {
                return this.logCheckFieldTypesField;
            }
            set
            {
                this.logCheckFieldTypesField = value;
            }
        }

        /// <remarks/>
        public object MSSqlReplicationPublicationName
        {
            get
            {
                return this.mSSqlReplicationPublicationNameField;
            }
            set
            {
                this.mSSqlReplicationPublicationNameField = value;
            }
        }

        /// <remarks/>
        public bool EnableSingleSignOn
        {
            get
            {
                return this.enableSingleSignOnField;
            }
            set
            {
                this.enableSingleSignOnField = value;
            }
        }

        /// <remarks/>
        public bool AutoStartProfiler
        {
            get
            {
                return this.autoStartProfilerField;
            }
            set
            {
                this.autoStartProfilerField = value;
            }
        }

        /// <remarks/>
        public string InstanceDatabaseConnectionStringTemplate
        {
            get
            {
                return this.instanceDatabaseConnectionStringTemplateField;
            }
            set
            {
                this.instanceDatabaseConnectionStringTemplateField = value;
            }
        }

        /// <remarks/>
        public string InstanceSecondaryDatabaseConnectionStringTemplate
        {
            get
            {
                return this.instanceSecondaryDatabaseConnectionStringTemplateField;
            }
            set
            {
                this.instanceSecondaryDatabaseConnectionStringTemplateField = value;
            }
        }

        /// <remarks/>
        public string RecoverablePasswordEncryptionType
        {
            get
            {
                return this.recoverablePasswordEncryptionTypeField;
            }
            set
            {
                this.recoverablePasswordEncryptionTypeField = value;
            }
        }

        /// <remarks/>
        public string PasswordHashEncryptionType
        {
            get
            {
                return this.passwordHashEncryptionTypeField;
            }
            set
            {
                this.passwordHashEncryptionTypeField = value;
            }
        }

        /// <remarks/>
        public bool WaitForDebugger
        {
            get
            {
                return this.waitForDebuggerField;
            }
            set
            {
                this.waitForDebuggerField = value;
            }
        }

        /// <remarks/>
        public object AllowedIPAddresses
        {
            get
            {
                return this.allowedIPAddressesField;
            }
            set
            {
                this.allowedIPAddressesField = value;
            }
        }

        /// <remarks/>
        public object DeniedIPAddresses
        {
            get
            {
                return this.deniedIPAddressesField;
            }
            set
            {
                this.deniedIPAddressesField = value;
            }
        }

        /// <remarks/>
        public string DefaultInstanceName
        {
            get
            {
                return this.defaultInstanceNameField;
            }
            set
            {
                this.defaultInstanceNameField = value;
            }
        }

        /// <remarks/>
        public bool EnableClientEventDiagnostics
        {
            get
            {
                return this.enableClientEventDiagnosticsField;
            }
            set
            {
                this.enableClientEventDiagnosticsField = value;
            }
        }

        /// <remarks/>
        public string LocallyAddressableIISWebsiteIPOrDNSName
        {
            get
            {
                return this.locallyAddressableIISWebsiteIPOrDNSNameField;
            }
            set
            {
                this.locallyAddressableIISWebsiteIPOrDNSNameField = value;
            }
        }

        /// <remarks/>
        public byte WindowsEventViewerEventId
        {
            get
            {
                return this.windowsEventViewerEventIdField;
            }
            set
            {
                this.windowsEventViewerEventIdField = value;
            }
        }

        /// <remarks/>
        public bool SuppressNewUserWizard
        {
            get
            {
                return this.suppressNewUserWizardField;
            }
            set
            {
                this.suppressNewUserWizardField = value;
            }
        }

        /// <remarks/>
        public bool FilterDuplicateLogMessages
        {
            get
            {
                return this.filterDuplicateLogMessagesField;
            }
            set
            {
                this.filterDuplicateLogMessagesField = value;
            }
        }

        /// <remarks/>
        public ushort DuplicateLogMessageTimingInSeconds
        {
            get
            {
                return this.duplicateLogMessageTimingInSecondsField;
            }
            set
            {
                this.duplicateLogMessageTimingInSecondsField = value;
            }
        }

        /// <remarks/>
        public bool ORMSaveByMerge
        {
            get
            {
                return this.oRMSaveByMergeField;
            }
            set
            {
                this.oRMSaveByMergeField = value;
            }
        }

        /// <remarks/>
        public bool SkipEnforceDBExistsStep
        {
            get
            {
                return this.skipEnforceDBExistsStepField;
            }
            set
            {
                this.skipEnforceDBExistsStepField = value;
            }
        }

        /// <remarks/>
        public bool UsePrototypeInstance
        {
            get
            {
                return this.usePrototypeInstanceField;
            }
            set
            {
                this.usePrototypeInstanceField = value;
            }
        }

        /// <remarks/>
        public string FullTextSearch
        {
            get
            {
                return this.fullTextSearchField;
            }
            set
            {
                this.fullTextSearchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object WCFMaxConcurrentCallsPerService
        {
            get
            {
                return this.wCFMaxConcurrentCallsPerServiceField;
            }
            set
            {
                this.wCFMaxConcurrentCallsPerServiceField = value;
            }
        }

        /// <remarks/>
        public bool HideDetailedErrorMessages
        {
            get
            {
                return this.hideDetailedErrorMessagesField;
            }
            set
            {
                this.hideDetailedErrorMessagesField = value;
            }
        }

        /// <remarks/>
        public string InterServerCommunicationMode
        {
            get
            {
                return this.interServerCommunicationModeField;
            }
            set
            {
                this.interServerCommunicationModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SettingsInitializationEndPoint
    {

        private uint maxReceivedMessageSizeField;

        private uint maxArrayLengthField;

        private ushort receiveTimeoutSecondsField;

        private ushort sendTimeoutSecondsField;

        private uint maxStringContentLengthField;

        private string hostField;

        private sbyte portField;

        private string securityModeField;

        /// <remarks/>
        public uint MaxReceivedMessageSize
        {
            get
            {
                return this.maxReceivedMessageSizeField;
            }
            set
            {
                this.maxReceivedMessageSizeField = value;
            }
        }

        /// <remarks/>
        public uint MaxArrayLength
        {
            get
            {
                return this.maxArrayLengthField;
            }
            set
            {
                this.maxArrayLengthField = value;
            }
        }

        /// <remarks/>
        public ushort ReceiveTimeoutSeconds
        {
            get
            {
                return this.receiveTimeoutSecondsField;
            }
            set
            {
                this.receiveTimeoutSecondsField = value;
            }
        }

        /// <remarks/>
        public ushort SendTimeoutSeconds
        {
            get
            {
                return this.sendTimeoutSecondsField;
            }
            set
            {
                this.sendTimeoutSecondsField = value;
            }
        }

        /// <remarks/>
        public uint MaxStringContentLength
        {
            get
            {
                return this.maxStringContentLengthField;
            }
            set
            {
                this.maxStringContentLengthField = value;
            }
        }

        /// <remarks/>
        public string Host
        {
            get
            {
                return this.hostField;
            }
            set
            {
                this.hostField = value;
            }
        }

        /// <remarks/>
        public sbyte Port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }

        /// <remarks/>
        public string SecurityMode
        {
            get
            {
                return this.securityModeField;
            }
            set
            {
                this.securityModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SettingsEndPointDefinition
    {

        private uint maxReceivedMessageSizeField;

        private uint maxArrayLengthField;

        private ushort receiveTimeoutSecondsField;

        private ushort sendTimeoutSecondsField;

        private uint maxStringContentLengthField;

        private string hostField;

        private ushort portField;

        private string securityModeField;

        /// <remarks/>
        public uint MaxReceivedMessageSize
        {
            get
            {
                return this.maxReceivedMessageSizeField;
            }
            set
            {
                this.maxReceivedMessageSizeField = value;
            }
        }

        /// <remarks/>
        public uint MaxArrayLength
        {
            get
            {
                return this.maxArrayLengthField;
            }
            set
            {
                this.maxArrayLengthField = value;
            }
        }

        /// <remarks/>
        public ushort ReceiveTimeoutSeconds
        {
            get
            {
                return this.receiveTimeoutSecondsField;
            }
            set
            {
                this.receiveTimeoutSecondsField = value;
            }
        }

        /// <remarks/>
        public ushort SendTimeoutSeconds
        {
            get
            {
                return this.sendTimeoutSecondsField;
            }
            set
            {
                this.sendTimeoutSecondsField = value;
            }
        }

        /// <remarks/>
        public uint MaxStringContentLength
        {
            get
            {
                return this.maxStringContentLengthField;
            }
            set
            {
                this.maxStringContentLengthField = value;
            }
        }

        /// <remarks/>
        public string Host
        {
            get
            {
                return this.hostField;
            }
            set
            {
                this.hostField = value;
            }
        }

        /// <remarks/>
        public ushort Port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }

        /// <remarks/>
        public string SecurityMode
        {
            get
            {
                return this.securityModeField;
            }
            set
            {
                this.securityModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SettingsMail
    {

        private bool byPassSmtpServerField;

        private SettingsMailSmtpServer smtpServerField;

        /// <remarks/>
        public bool ByPassSmtpServer
        {
            get
            {
                return this.byPassSmtpServerField;
            }
            set
            {
                this.byPassSmtpServerField = value;
            }
        }

        /// <remarks/>
        public SettingsMailSmtpServer SmtpServer
        {
            get
            {
                return this.smtpServerField;
            }
            set
            {
                this.smtpServerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SettingsMailSmtpServer
    {

        private object serverAddressField;

        private bool requiresAuthenticationField;

        private object usernameField;

        private object passwordField;

        private bool useSSLField;

        private object useImplicitSSLField;

        private byte portField;

        /// <remarks/>
        public object ServerAddress
        {
            get
            {
                return this.serverAddressField;
            }
            set
            {
                this.serverAddressField = value;
            }
        }

        /// <remarks/>
        public bool RequiresAuthentication
        {
            get
            {
                return this.requiresAuthenticationField;
            }
            set
            {
                this.requiresAuthenticationField = value;
            }
        }

        /// <remarks/>
        public object Username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        public object Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        public bool UseSSL
        {
            get
            {
                return this.useSSLField;
            }
            set
            {
                this.useSSLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object UseImplicitSSL
        {
            get
            {
                return this.useImplicitSSLField;
            }
            set
            {
                this.useImplicitSSLField = value;
            }
        }

        /// <remarks/>
        public byte Port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }
    }


}
