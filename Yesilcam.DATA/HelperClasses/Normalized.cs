namespace Yesilcam.DATA.HelperClasses
{
	public static class Normalized
	{
		public static string TurkishToEnglish(string name)
		{
			string turkishCharacter = "ığüşöç ";  //boşlukta ascii kodu yazar o yüzden ekledik
			string englishCharacter = "igusoc ";

			for (int i = 0; i < turkishCharacter.Length; i++)
			{
				name = name.ToLower().Replace(turkishCharacter[i], englishCharacter[i]);
			}

			return name;
		}
	}
}
