#pragma warning disable 1591
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using CookComputing.XmlRpc;
using Zutubi.Pulse.Api.Types;

namespace Zutubi.Pulse.Api.Backend
{
    public interface BackendInterface : IXmlRpcProxy
    {
        #region MonitorApi
        [XmlRpcMethod("MonitorApi.getStatusForAllProjects")]
        ProjectsStatus GetStatusForAllProjects(string token, bool includePersonal, string lastTimestamp);
        [XmlRpcMethod("MonitorApi.getStatusForMyProjects")]
        ProjectsStatus GetStatusForMyProjects(string token, bool includePersonal, string lastTimestamp);
        [XmlRpcMethod("MonitorApi.getStatusForProjects")]
        ProjectsStatus GetStatusForProjects(string token, string[] projects, bool includePersonal, string lastTimestamp);
        #endregion

        #region TestApi
		
		#region Pulse Version 2.3.8 -- Build 0203008000
        //[XmlRpcMethod("TestApi.cancelActiveBuilds")]
        //bool CancelActiveBuilds(string token);
        //[XmlRpcMethod("TestApi.engueueSynchronisationMessage")]
        //bool EnqueueSynchronisationMessage(string token, string agent, bool synchronous, string description, bool succeed);
        //[XmlRpcMethod("TestApi.getRunningPlugins")]
        //Plugin[] GetRunningPlugins(string token);
        //[XmlRpcMethod("TestApi.installPlugin")]
        //bool InstallPlugin(string token, string pluginJar);
        //[XmlRpcMethod("TestApi.logError")]
        //bool LogError(string token, string message);
        //[XmlRpcMethod("TestApi.logWarning")]
        //bool LogWarning(string token, string message);
		#endregion
		
        #endregion

        #region RemoteApi
        [XmlRpcMethod("RemoteApi.addBuildComment")]
        string AddBuildComment(string token, string projectName, int buildId, string message);
        [XmlRpcMethod("RemoteApi.cancelBuild")]
        bool CancelBuild(string token, string projectName, int buildID);
        [XmlRpcMethod("RemoteApi.cancelQueuedBuildRequest")]
        bool CancelQueuedBuildRequest(string token, string id);
        [XmlRpcMethod("RemoteApi.canCloneConfig")]
        bool CanCloneConfig(string token, string path);
        [XmlRpcMethod("RemoteApi.canPullUpConfig")]
        bool CanPullUpConfig(string token, string path, string ancestorKey);
        [XmlRpcMethod("RemoteApi.canPushDownConfig")]
        bool CanPushDownConfig(string token, string path, string childKey);
        [XmlRpcMethod("RemoteApi.clearResponsibility")]
        bool ClearResponsibility(string token, string projectName);
        [XmlRpcMethod("RemoteApi.cloneConfig")]
        bool CloneConfig(string token, string parentPath, Hashtable keyMap);
        [XmlRpcMethod("RemoteApi.configPathExists")]
        bool ConfigPathExists(string token, string path);
        [XmlRpcMethod("RemoteApi.createDefaultConfig")]
        Hashtable CreateDefaultConfig(string token, string symbolicName);
        [XmlRpcMethod("RemoteApi.deleteAllConfigs")]
        int DeleteAllConfigs(string token, string pathPattern);
        [XmlRpcMethod("RemoteApi.deleteBuild")]
        bool DeleteBuild(string token, string projectName, int id);
        [XmlRpcMethod("RemoteApi.deleteBuildComment")]
        bool DeleteBuildComment(string token, string projectName, int buildId, string commentId);
        [XmlRpcMethod("RemoteApi.deleteConfig")]
        bool DeleteConfig(string token, string path);
        [XmlRpcMethod("RemoteApi.disableAgent")]
        bool DisableAgent(string token, string name);
        [XmlRpcMethod("RemoteApi.doConfigAction")]
        bool DoConfigAction(string token, string path, string action);
        [XmlRpcMethod("RemoteApi.doConfigActionWithArgument")]
        bool DoConfigActionWithArgument(string token, string path, string action, Hashtable argument);
        [XmlRpcMethod("RemoteApi.enableAgent")]
        bool EnableAgent(string token, string name);
        [XmlRpcMethod("RemoteApi.getAgentCount")]
        int GetAgentCount(string token);
        [XmlRpcMethod("RemoteApi.getAgentEnableState")]
        string GetAgentEnableState(string token, string name);
        [XmlRpcMethod("RemoteApi.getAgentStatus")]
        string GetAgentStatus(string token, string name);
        [XmlRpcMethod("RemoteApi.getAllAgentNames")]
        string[] GetAllAgentNames(string token);
        [XmlRpcMethod("RemoteApi.getAllProjectGroups")]
        string[] GetAllProjectGroups(string token);
        [XmlRpcMethod("RemoteApi.getAllProjectNames")]
        string[] GetAllProjectNames(string token);
        [XmlRpcMethod("RemoteApi.getAllUserLogins")]
        string[] GetAllUserLogins(string token);
        [XmlRpcMethod("RemoteApi.getArtifactFileListing")]
        string[] GetArtifactFileListing(string token, string projectName, int id, string stageName, string commandName, string artifactName, string path);
        [XmlRpcMethod("RemoteApi.getArtifactFileListingPersonal")]
        string[] GetArtifactFileListingPersonal(string token, int id, string stageName, string commandName, string artifactName, string path);
        [XmlRpcMethod("RemoteApi.getArtifactsInBuild")]
        Artifact[] GetArtifactsInBuild(string token, string projectName, int id);
        [XmlRpcMethod("RemoteApi.getArtifactsInPersonalBuild")]
        Artifact[] GetArtifactsInPersonalBuild(string token, int id);
        [XmlRpcMethod("RemoteApi.getBuild")]
        BuildResult[] GetBuild(string token, string projectName, int id);
        [XmlRpcMethod("RemoteApi.getBuildComments")]
        Comment[] GetBuildComments(string token, string projectName, int buildId);
        [XmlRpcMethod("RemoteApi.getBuildQueueSnapshot")]
        QueuedBuild[] GetBuildQueueSnapshot(string token);
        [XmlRpcMethod("RemoteApi.getBuildRange")]
        BuildResult[] GetBuildRange(string token, string projectName, int afterBuild, int toBuild);
        [XmlRpcMethod("RemoteApi.getBuildRequestStatus")]
        BuildRequestStatus GetBuildRequestStatus(string token, string requestId);
        [XmlRpcMethod("RemoteApi.getChangesInBuild")]
        ChangeList[] GetChangesInBuild(string token, string projectName, int id);
        [XmlRpcMethod("RemoteApi.getConfig")]
        Hashtable GetConfig(string token, string path);
        [XmlRpcMethod("RemoteApi.getConfigActions")]
        string[] GetConfigActions(string token, string path);
        [XmlRpcMethod("RemoteApi.getConfigHandle")]
        string GetConfigHandle(string token, string path);
        [XmlRpcMethod("RemoteApi.getConfigListing")]
        string[] GetConfigListing(string token, string path);
        [XmlRpcMethod("RemoteApi.getCustomFieldsInBuild")]
        Hashtable GetCustomFieldsInBuild(string token, string projectName, int buildId);
        [XmlRpcMethod("RemoteApi.getErrorMessagesInBuild")]
        Feature[] GetErrorMessagesInBuild(string token, string projectName, int id);
        [XmlRpcMethod("RemoteApi.getInfoMessagesInBuild")]
        Feature[] GetInfoMessagesInBuild(string token, string projectName, int id);
        [XmlRpcMethod("RemoteApi.getLatestBuildForProject")]
        BuildResult[] GetLatestBuildForProject(string token, string projectName);
        [XmlRpcMethod("RemoteApi.getLatestBuildsForProject")]
        BuildResult[] GetLatestBuildsForProject(string token, string projectName, bool completedOnly, int maxResults);
        [XmlRpcMethod("RemoteApi.getLatestBuildsWithWarnings")]
        BuildResult[] GetLatestBuildsWithWarnings(string token, string projectName, int maxResults);
        [XmlRpcMethod("RemoteApi.getLatestBuildWithWarnings")]
        BuildResult[] GetLatestBuildWithWarnings(string token, string projectName);
        [XmlRpcMethod("RemoteApi.getLatestPersonalBuild")]
        BuildResult[] GetLatestPersonalBuild(string token, bool completedOnly);
        [XmlRpcMethod("RemoteApi.getLatestPersonalBuilds")]
        BuildResult[] GetLatestPersonalBuilds(string token, bool completedOnly, int maxResults);
        [XmlRpcMethod("RemoteApi.getMessagesInBuild")]
        Feature[] GetMessagesInBuild(string token, string projectName, int id);
        [XmlRpcMethod("RemoteApi.getMyProjectNames")]
        string[] GetMyProjectNames(string token);
        [XmlRpcMethod("RemoteApi.getNextBuildNumber")]
        int GetNextBuildNumber(string token, string projectName);
        [XmlRpcMethod("RemoteApi.getPersonalBuild")]
        BuildResult[] GetPersonalBuild(string token, int id);
        [XmlRpcMethod("RemoteApi.getPreviousBuild")]
        BuildResult[] GetPreviousBuild(string token, string projectName, int id);
        [XmlRpcMethod("RemoteApi.getProjectCount")]
        int GetProjectCount(string token);

        //ProjectGroup GetProjectGroup(string token, string name);
        [XmlRpcMethod("RemoteApi.getProjectNameById")]
        string GetProjectNameById(string token, string id);
        [XmlRpcMethod("RemoteApi.getProjectState")]
        string GetProjectState(string token, string projectName);
        [XmlRpcMethod("RemoteApi.getRawConfig")]
        Hashtable getRawConfig(string token, string path);
        [XmlRpcMethod("RemoteApi.getReportData")]
        ReportData GetReportData(string token, string projectName, string reportGroup, string report, int timeFrame, string timeUnit);
        [XmlRpcMethod("RemoteApi.getResponsibilityInfo")]
        Hashtable GetResponsibilityInfo(string token, string projectName);
        [XmlRpcMethod("RemoteApi.getServerInfo")]
        Hashtable GetServerInfo(string token);
        [XmlRpcMethod("RemoteApi.getTemplateChildren")]
        string[] GetTemplateChildren(string token, string path);
        [XmlRpcMethod("RemoteApi.getTemplateParent")]
        string GetTemplateParent(string token, string path);
        [XmlRpcMethod("RemoteApi.getUserCount")]
        int GetUserCount(string token);
        [XmlRpcMethod("RemoteApi.getVersion")]
        int GetVersion();
        [XmlRpcMethod("RemoteApi.getWarningMessagesInBuild")]
        Feature[] GetWarningMessagesInBuild(string token, string projectName, int id);
        [XmlRpcMethod("RemoteApi.initialiseProject")]
        bool InitializeProject(string token, string projectName);
        [XmlRpcMethod("RemoteApi.insertConfig")]
        string InsertConfig(string token, string path, Hashtable config);
        [XmlRpcMethod("RemoteApi.insertTemplatedConfig")]
        string InsertTemplatedConfig(string token, string templateParentPath, Hashtable config, bool template);
        [XmlRpcMethod("RemoteApi.isConfigPermanent")]
        bool IsConfigPermanent(string token, string path);
        [XmlRpcMethod("RemoteApi.isConfigValid")]
        bool IsConfigValid(string token, string path);
        [XmlRpcMethod("RemoteApi.login")]
        string Login(string login, string password);
        [XmlRpcMethod("RemoteApi.logout")]
        bool Logout(string token);
        [XmlRpcMethod("RemoteApi.pauseProject")]
        bool PauseProject(string token, string projectName);
        [XmlRpcMethod("RemoteApi.ping")]
        string Ping();
        [XmlRpcMethod("RemoteApi.pullUpConfig")]
        string PullUpConfig(string token, string path, string ancestorKey);
        [XmlRpcMethod("RemoteApi.pushDownConfig")]
        string[] PushDownConfig(string token, string path, string[] childKeys);
        [XmlRpcMethod("RemoteApi.queryBuildsForProject")]
        BuildResult[] QueryBuildsForProject(string token, string projectName, string[] resultStates, int firstResult, int maxResults, bool mostRecentFirst);
        [XmlRpcMethod("RemoteApi.restoreConfig")]
        bool RestoreConfig(string token, string path);
        [XmlRpcMethod("RemoteApi.resumeProject")]
        bool ResumeProject(string token, string projectName);
        [XmlRpcMethod("RemoteApi.saveConfig")]
        string SaveConfig(string token, string path, Hashtable config, bool deep);
        [XmlRpcMethod("RemoteApi.setNextBuildNumber")]
        bool SetNextBuildNumber(string token, string projectName, string number);
        [XmlRpcMethod("RemoteApi.shutdown")]
        bool Shutdown(string token, bool force, bool exitJvm);
        [XmlRpcMethod("RemoteApi.stopService")]
        bool StopService(string token);
        [XmlRpcMethod("RemoteApi.smartClone")]
        bool SmartClone(string token, string parentPath, string rootKey, string parentKey, Hashtable originalKeyToCloneKey);
        [XmlRpcMethod("RemoteApi.takeResponsibility")]
        bool TakeResponsibility(string token, string projectName, string comment);
        [XmlRpcMethod("RemoteApi.triggerBuild")]
        bool TriggerBuild(string token, string project);
        [XmlRpcMethod("RemoteApi.waitForBuildRequestToBeActivated")]
        BuildRequestStatus WaitForBuildRequestToBeActivated(string token, string requestId, int timeoutMillis);
        [XmlRpcMethod("RemoteApi.waitForBuildRequestToBeHandled")]
        BuildRequestStatus WaitForBuildRequestToBeHandled(string token, string requestId, int timeoutMilis);
        #endregion
    }
}
#pragma warning restore 1591