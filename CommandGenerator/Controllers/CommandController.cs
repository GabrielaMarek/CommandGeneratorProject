using CommandGenerator.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

public class CommandController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public JsonResult GenerateCommand(CommandModel commandModel)
    {
        string generatedCommand = $"/{commandModel.CommandType} {commandModel.PlayerName} {commandModel.Item} {commandModel.Quantity}";

        if (commandModel.Enchantments != null && commandModel.Enchantments.Any())
        {
            generatedCommand += " {Enchantments:[";

            foreach (var enchantment in commandModel.Enchantments)
            {
                generatedCommand += $"{{id:'{enchantment.Enchantment}',lvl:{enchantment.Level}}},";
            }

            generatedCommand = generatedCommand.TrimEnd(',') + "]}";
        }
        return Json(new { command = generatedCommand });
    }


}