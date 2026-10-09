using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.Azure.Controllers;

[Area("Azure")]
public class StorageAccountsController : Controller
{
    public IActionResult StorageAccounts() => View();
    public IActionResult StorageAccountPolicies() => View();
    public IActionResult CreateStorageAccount() => View();
    public IActionResult StorageAccountBasics() => View();
    public IActionResult StorageAccountAdvanced() => View();
    public IActionResult StorageAccountNetworking() => View();
    public IActionResult StorageAccountDataProtection() => View();
    public IActionResult StorageAccountEncryptionAndTags() => View();
    public IActionResult StorageAccountReviewAndCreate() => View();
}
