using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using ClassLibrary1;

namespace ConsoleApplication12
{
	class Program {
		
		static void Main()
		{
			Library.OutputResult("Процессор:", Library.GetInfo("Win32_Processor", "Name"));
			Library.OutputResult("Производитель:", Library.GetInfo("Win32_Processor", "Manufacturer"));
			Library.OutputResult("Описание:", Library.GetInfo("Win32_Processor", "Description"));
			Library.OutputResult("Видеокарта:", Library.GetInfo("Win32_VideoController", "Name"));
			Library.OutputResult("Видеопроцессор:", Library.GetInfo("Win32_VideoController", "VideoProcessor"));
			Library.OutputResult("Версия драйвера:", Library.GetInfo("Win32_VideoController", "DriverVersion"));
			Library.OutputResult("Объем памяти видеокарты (в байтах):", Library.GetInfo("Win32_VideoController", "AdapterRAM"));
			Library.OutputResult("Объем оперативной памяти (в байтах)):", Library.GetInfo("Win32_PhysicalMemory", "Capacity"));
			Library.OutputResult("Жесткий диск:", Library.GetInfo("Win32_DiskDrive", "Caption"));
			Library.OutputResult("Объем жесткого диска (БАЙТЫ):", Library.GetInfo("Win32_DiskDrive", "Size"));
			Console.ReadKey();
		}
	}
	
}
