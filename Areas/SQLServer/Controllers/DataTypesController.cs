//using Microsoft.AspNetCore.Mvc;

//namespace CIITEdge.Areas.SQLServer.Controllers
//{
//    [Area("SQLServer")]
//    public class DataTypesController : Controller
//    {
//        // 1. Data Types
//        public IActionResult Index()
//        {
//            return View();
//        }

//        // 2. Numeric Data Types
//        public IActionResult NumericDataTypes()
//        {
//            return View();
//        }

//        // 3. Character & String Data Types
//        public IActionResult CharacterStringDataTypes()
//        {
//            return View();
//        }

//        // 4. Date & Time Data Types
//        public IActionResult DateTimeDataTypes()
//        {
//            return View();
//        }

//        // 5. Other SQL Server Data Types
//        public IActionResult OtherDataTypes()
//        {
//            return View();
//        }
//    }
//}






using Microsoft.AspNetCore.Mvc;

namespace CIITEdge.Areas.SQLServer.Controllers
{
    [Area("SQLServer")]
    public class DataTypesController : Controller
    {
        // =====================================================
        // 1. DATA TYPES
        // URL: /SQLServer/DataTypes
        // =====================================================
        public IActionResult Index()
        {
            return View();
        }


        // =====================================================
        // 2. NUMERIC DATA TYPES
        // URL: /SQLServer/DataTypes/NumericDataTypes
        // =====================================================
        public IActionResult NumericDataTypes()
        {
            return View();
        }


        // =====================================================
        // 3. CHARACTER & STRING DATA TYPES
        // URL: /SQLServer/DataTypes/CharacterStringDataTypes
        // =====================================================
        public IActionResult CharacterStringDataTypes()
        {
            return View();
        }


        // =====================================================
        // 4. DATE & TIME DATA TYPES
        // URL: /SQLServer/DataTypes/DateTimeDataTypes
        // =====================================================
        public IActionResult DateTimeDataTypes()
        {
            return View();
        }


        // =====================================================
        // 5. OTHER SQL SERVER DATA TYPES
        // URL: /SQLServer/DataTypes/OtherDataTypes
        // =====================================================
        public IActionResult OtherDataTypes()
        {
            return View();
        }
    }
}