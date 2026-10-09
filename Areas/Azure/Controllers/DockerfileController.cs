using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class DockerfileController : Controller
{
    public IActionResult WhatIsDockerfile() => View();
    public IActionResult DockerfileSyntaxRules() => View();
    public IActionResult DockerfileInstructions() => View();
    public IActionResult FromInstruction() => View();
    public IActionResult MaintainerInstruction() => View();
    public IActionResult RunInstruction() => View();
    public IActionResult AddInstruction() => View();
    public IActionResult EnvInstruction() => View();
    public IActionResult EntrypointInstruction() => View();
    public IActionResult CmdInstruction() => View();
    public IActionResult ExposeInstruction() => View();
    public IActionResult VolumeInstruction() => View();
    public IActionResult WorkdirInstruction() => View();
    public IActionResult UserInstruction() => View();
    public IActionResult ArgInstruction() => View();
    public IActionResult DockerfileBestPractices() => View();
    public IActionResult CreateDockerfileForMaven() => View();
}
