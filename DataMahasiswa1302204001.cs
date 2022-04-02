using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_Kelompok_08
{
	internal class DataMahasiswa1302204001
	{
		public static void readJSON()
		{
			String jsonString = File.ReadAllText("C:\\Users\\HP\\Praktikum_KPL\\MODUL6_1302204001\\jurnal6_1_1302204001.json");

			dynamic data = JsonConvert.DeserializeObject(jsonString);



			Console.WriteLine("Nama : " + data.firstName + " " + data.lastName);
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
