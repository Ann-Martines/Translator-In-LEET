using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFЗаданиеLeet
{
	class Translate
	{
		Dictionary<string, string> dicToLeet = null;
		Dictionary<string, string> dicToEnglish = null;
		string result = null;

		/// <summary>
		/// The property returning the translated symbol
		/// </summary>
		public string Result
		{
			get
			{
				return this.result;
			}
		}

		/// <summary>
		/// Filling of the dictionary with keys and values
		/// </summary>
		public Translate()
		{
			dicToLeet = new Dictionary<string, string>();
			dicToLeet.Add("A", "4");
			dicToLeet.Add("B", "8");
			dicToLeet.Add("E", "3");
			dicToLeet.Add("G", "6");
			dicToLeet.Add("I", "1");
			dicToLeet.Add("O", "0");
			dicToLeet.Add("S", "5");
			dicToLeet.Add("T", "7");
			dicToLeet.Add("Z", "2");

			dicToEnglish = new Dictionary<string, string>();
			dicToEnglish.Add("4", "A");
			dicToEnglish.Add("8", "B");
			dicToEnglish.Add("3", "E");
			dicToEnglish.Add("6", "G");
			dicToEnglish.Add("1", "I");
			dicToEnglish.Add("0", "O");
			dicToEnglish.Add("5", "S");
			dicToEnglish.Add("7", "T");
			dicToEnglish.Add("2", "Z");


		}

		/// <summary>
		/// Makes a transfer to leet letters
		/// </summary>
		/// <param name="str"></param>
		public void ToLeet(string str)
		{
			result = null;
			this.dicToLeet.TryGetValue(str, out this.result);
		}

		/// <summary>
		/// Makes a transfer to the English letters
		/// </summary>
		/// <param name="str"></param>
		public void ToEnglish(string str)
		{

			this.result = null;
			this.dicToEnglish.TryGetValue(str, out this.result);
		}
	}
}
