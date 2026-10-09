using Microsoft.AspNetCore.Mvc;
using CIITEdge.Areas.Azure.Models;
using CIITEdge.Areas.Azure;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class StorageController : Controller
{
    public IActionResult WhatisAzureStorage() => Lesson("What is Azure Storage?", "WhatisAzureStorage", 1);
    public IActionResult StorageAccount() => Lesson("Storage Account", "StorageAccount", 2);
    public IActionResult BlobStorage() => Lesson("Blob Storage", "BlobStorage", 3);
    public IActionResult BlobUploadDownload() => Lesson("Blob Upload / Download", "BlobUploadDownload", 4);
    public IActionResult PracticalUploadApplicationFiles() => Lesson("Practical — Upload Application Files", "PracticalUploadApplicationFiles", 5);

    private IActionResult Lesson(string title, string action, int number)
    {
        var module = AzureLessonCatalog.GetModule("Storage");
        var lesson = new AzureLesson
        {
            ModuleKey = "Storage",
            ModuleTitle = module.Title,
            Title = title,
            Controller = "Storage",
            Action = action,
            Number = number,
            Total = module.Topics.Count,
            Topic = AzureLessonCatalog.GetTopic("Storage", action)
        };
        return View("Lesson", lesson);
    }
}
