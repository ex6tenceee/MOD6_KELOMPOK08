using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_Kelompok_08
{
    internal class TeamMembers1302200097
    {
        String jsonString = File.ReadAllText("C://users//NITRO////source//repos//modul6_Kelompok_08//jurnal6_2_1302200097.json");

        dynamic data2 = JsonConvert.DeserializeObject(jsonString);



        Console.WriteLine("NIM: " + data2.NIM + " Nama Lengkap " + data2.firstname + data2.lastName + "umur" + data2.age + "Jenis Kelamin" + data2.gender);
	    Console.WriteLine("NIM: " + data2.NIM + " Nama Lengkap " + data2.firstname + data2.lastName + "umur" + data2.age + "Jenis Kelamin" + data2.gender);
        Console.WriteLine("NIM: " + data2.NIM + " Nama Lengkap " + data2.firstname + data2.lastName + "umur" + data2.age + "Jenis Kelamin" + data2.gender);
    }
}
