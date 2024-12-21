using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models;

public class PlayerInfoModel
{
    public string? UsersName { get; set; }
    public static List<GridSpotModel> ShipLocations { get; set; } = new List<GridSpotModel>();
    public static List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>(); 
}
