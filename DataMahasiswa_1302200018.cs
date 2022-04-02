using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_Kelompok_08
{
	internal class Program
	{
		
			public static void readJSON(object jsonString)
			{
				string jsonstring = File.ReadAllText("C:\\Users\\lenovo\\OneDrive\\Dokumen\\praktikum\\jurmod\\Mod6_1302200018");

				dynamic data = JsonConvert.DeserializeObject(jsonstring);



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
			}
		}

		
	}

