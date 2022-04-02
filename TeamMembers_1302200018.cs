using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_Kelompok_08
{
    internal class TeamMembers_1302200018
    {
        string jsonstring = File.ReadAllText("C:\\Users\\lenovo\\OneDrive\\Dokumen\\praktikum\\jurmod\\Mod6_1302200018");

        dynamic data = JsonConvert.DeserializeObject(jsonstring);
    }
}
