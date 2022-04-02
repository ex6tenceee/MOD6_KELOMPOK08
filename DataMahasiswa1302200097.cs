﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul6_Kelompok_08
{
    internal class DataMahasiswa1302200097
    {
        public static void readJSON()
        {
            String jsonString = File.ReadAllText("C://users//NITRO////source//repos//modul6_Kelompok_08//jurnal6_1_1302200097.json");

			dynamic data = JsonConvert.DeserializeObject(jsonString);

           

			Console.WriteLine("Nama Lengkap : " + data.firstName + " " + data.lastName);
			Console.WriteLine("Gender : " + data.gender);
			Console.WriteLine("Umur : " + data.age);
			Console.WriteLine("Alamat : " + data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);
			Console.WriteLine("Mata Kuliah : ");
			foreach (var item in data.courses)
			{
				Console.WriteLine();
				Console.WriteLine("Kode matkul : " + item.code);
				Console.WriteLine("Nama matkul : " + item.name);
			}
			Console.WriteLine();
		}
    }
}