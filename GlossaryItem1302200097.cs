using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_Kelompok_08
{
    internal class GlossaryItem1302200097
    {

        String jsonString = File.ReadAllText("C://users//NITRO////source//repos//modul6_Kelompok_08//jurnal6_3_1302200097.json");

        dynamic data3 = JsonConvert.DeserializeObject(jsonString);

        Console.WriteLine("Glossary : " + data3.title);
		Console.WriteLine("Glossary Entry : " + data3.ID);
    }
}
