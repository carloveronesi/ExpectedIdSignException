using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using System.Reflection;

namespace ExpectedIdSignException
{
	public class ExpectedIdSignException : ExpectedExceptionBaseAttribute
	{
		/// <summary>
		/// Ottiene un valore che indica il tipo dell'eccezione prevista
		/// </summary>
		public Type ExceptionType
		{
			get;
			private set;
		}

		/// <summary>
		/// Ottiene un valore che indica il codice dell'eccezione prevista
		/// </summary>
		public string ExceptionCode
		{
			get;
			private set;
		}

		/// <summary>
		/// Ottiene o imposta un valore che indica se consentire a tipi derivati dal tipo dell'eccezione prevista
		/// di qualificarsi come previsto
		/// </summary>
		public bool AllowDerivedTypes
		{
			get;
			set;
		}

		/// <summary>
		/// Inizializza una nuova istanza della classe <see cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedExceptionAttribute" /> con il tipo previsto
		/// </summary>
		/// <param name="exceptionType">Tipo dell'eccezione prevista</param>
		public ExpectedIdSignException(Type exceptionType, string exceptionCode)
			: this(exceptionType, exceptionCode, string.Empty)
		{
		}

		/// <summary>
		/// Inizializza una nuova istanza della classe <see cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedExceptionAttribute" /> con
		/// il tipo previsto e il messaggio da includere quando il test non genera alcuna eccezione.
		/// </summary>
		/// <param name="exceptionType">Tipo dell'eccezione prevista</param>
		/// <param name="noExceptionMessage">
		/// Messaggio da includere nel risultato del test se il test non riesce perché non viene generata un'eccezione
		/// </param>
		public ExpectedIdSignException(Type exceptionType, string exceptionCode, string noExceptionMessage)
			: base(noExceptionMessage)
		{
			if (exceptionType is null)
			{
				throw new ArgumentNullException("exceptionType");
			}
			if (exceptionCode is null)
			{
				throw new ArgumentNullException("exceptionCode");
			}
			if (!typeof(Exception).GetTypeInfo().IsAssignableFrom(exceptionType.GetTypeInfo()))
			{
				throw new ArgumentException(FrameworkMessages.UTF_ExpectedExceptionTypeMustDeriveFromException, "exceptionType");
			}

			ExceptionType = exceptionType;
			ExceptionCode = exceptionCode;
		}

		/// <summary>
		/// Verifica che il tipo dell'eccezione generata dallo unit test sia prevista
		/// </summary>
		/// <param name="exception">Eccezione generata dallo unit test</param>
		protected override void Verify(Exception exception)
		{
			Type type = ((object)exception).GetType();
			// Getting exception's code
			string actualExceptionCode = (string)exception.GetType().GetProperty("Code").GetValue(exception);
			bool isWrongExceptionType;

			// Verifying ExceptionType
			if (AllowDerivedTypes)
			{
				isWrongExceptionType = !ExceptionType.GetTypeInfo().IsAssignableFrom(type.GetTypeInfo());
			}
			else
			{
				isWrongExceptionType = (object)type != ExceptionType;
			}

			// Verifying Exception code and throwing exception in one of the verifications fails
			if (isWrongExceptionType || !actualExceptionCode.Equals(ExceptionCode))
			{
				RethrowIfAssertException(exception);
				throw new Exception(string.Format(CultureInfo.CurrentCulture, FrameworkMessages.UTF_TestMethodWrongException, new object[3]
				{
				type.FullName,
				ExceptionType.FullName,
				ExceptionUtils.GetExceptionMsg(exception)
				}));
			}
		}
	}
}

