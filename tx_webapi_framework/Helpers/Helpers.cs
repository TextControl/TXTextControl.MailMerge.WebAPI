
	public class Helpers
	{
		public static bool IsKnownReturnFormat(string format)
		{
			switch (format)
			{
				case "PDF":
				case "PDFA":
				case "DOC":
				case "DOCX":
				case "TX":
				case "RTF":
				case "HTML":
				case "TXT":
					return true;
			}
			return false;
		}
	}

