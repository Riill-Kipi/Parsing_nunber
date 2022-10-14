using System;
using System.Linq;

	public static class Program
	{
		public static void Main(string[] args)
		{
			string c = "as23h89kus12kji"; 
			char[] a = c.ToCharArray(); 
			Console.WriteLine(a); 
			string eet = ""; 
			for (int i = 0; i < c.Length; i++) 
			{ 
				if (c[i] == '8') 
				{ 
					char[] ar; 
					string txt = Convert.ToString(i); 
					int v = Convert.ToInt32(txt); 
					ar = c.ToCharArray(v, 6); 
					Console.WriteLine(ar); 
					for (i = 0; i < ar.Length; i++) 
					{ 
						if (ar[i]== '1' || ar[i] == '2' || ar[i] == '3' || ar[i] == '4' || ar[i] == '5' || ar[i] == '6' || ar[i] == '7' || ar[i] == '8' || ar[i] == '9') 
						{ 
							eet = eet + Convert.ToString(ar[i]); 
						} 
					} 
				} 
			} 
		Console.WriteLine(eet);
		} 
	}