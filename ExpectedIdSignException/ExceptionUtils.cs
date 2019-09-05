using System;
using System.Globalization;
using System.Text;

namespace ExpectedIdSignException
{
	internal static class ExceptionUtils
	{
		/// <summary>
		/// Ottiene i messaggi di eccezione in modo ricorsivo, inclusi quelli relativi a 
		/// tutte le eccezioni interne
		/// </summary>
		/// <param name="ex">Eccezione per cui ottenere i messaggi</param>
		/// <returns>stringa con le informazioni sul messaggio di errore</returns>
		internal static string GetExceptionMsg(Exception ex)
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = true;
			for (Exception ex2 = ex; ex2 != null; ex2 = ex2.InnerException)
			{
				string text;
				try
				{
					text = ex2.Message;
				}
				catch
				{
					text = string.Format(CultureInfo.CurrentCulture, FrameworkMessages.UTF_FailedToGetExceptionMessage, new object[1]
					{
					((object)ex2).GetType()
					});
				}
				stringBuilder.Append(string.Format(CultureInfo.CurrentCulture, "{0}{1}: {2}", new object[3]
				{
				flag ? string.Empty : " ---> ",
				((object)ex2).GetType(),
				text
				}));
				flag = false;
			}
			return stringBuilder.ToString();
		}
	}
}
