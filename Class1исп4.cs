using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ClassLibrary1
{
	public class Library
	{

		public static void OutputResult(string text, List<string> result)
		{
			Console.Write(text);
			for (int i = 0; i < result.Count; ++i)
				Console.Write(result[i]);
			Console.WriteLine();
		}
		public static List<string> GetInfo(string WIN32_Class, string ClassItemField)
		{
			List<string> result = new List<string>();
			ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + WIN32_Class);
			try
			{
				foreach (ManagementObject obj in searcher.Get())
				{
					result.Add(obj[ClassItemField].ToString().Trim());
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return result;
		}

	}

}
