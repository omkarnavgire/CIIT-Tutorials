using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class DevOpsController : Controller
{
    public IActionResult CreateProjectUsingBasicProcess() => View();
    public IActionResult AzureDevOpsProcesses() => View();
    public IActionResult WhyChooseBasicProcess() => View();
    public IActionResult BasicProcessWorkItems() => View();
    public IActionResult WhenShouldYouChooseBasicProcess() => View();
    public IActionResult CreateBasicProcessProject() => View();
    public IActionResult AzureDevOpsProjectFeatures() => View();
    public IActionResult CreateProjectUsingAgileProcess() => View();
    public IActionResult AgileProcessWorkItems() => View();
    public IActionResult AzurePipelinesIntroduction() => View();
    public IActionResult WhatIsAzurePipelines() => View();
    public IActionResult WhyAzurePipelinesForCICD() => View();
    public IActionResult KeyFeaturesOfAzurePipelines() => View();
    public IActionResult CreatingAzureDevOpsPipeline() => View();
    public IActionResult CreateAzureDevOpsOrganization() => View();
    public IActionResult CreateDevOpsProject() => View();
    public IActionResult CreateBuildPipeline() => View();
    public IActionResult CreateReleasePipeline() => View();
    public IActionResult AzurePipelinesContinuousDelivery() => View();
    public IActionResult CICDPipelineInAzure() => View();
    public IActionResult AzurePipelinesVsJenkins() => View();
}
