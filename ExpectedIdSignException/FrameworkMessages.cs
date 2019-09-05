using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ExpectedIdSignException
{

	/// <summary>
	///   Classe di risorse fortemente tipizzata per la ricerca di stringhe localizzate e così via.
	/// </summary>
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class FrameworkMessages
	{
		private static ResourceManager resourceMan;

		/// <summary>
		///   Restituisce l'istanza di ResourceManager nella cache usata da questa classe.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (resourceMan == null)
				{
					resourceMan = new ResourceManager("ExpectedIdSignException.Properties.Resources", typeof(FrameworkMessages).GetTypeInfo().Assembly);
				}
				return resourceMan;
			}
		}

		/// <summary>
		///   Esegue l'override della proprietà CurrentUICulture del thread corrente per tutte
		///   le ricerche di risorse eseguite usando questa classe di risorse fortemente tipizzata.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture { get; set; }

		/// <summary>
		///   Cerca una stringa localizzata simile a La sintassi della stringa di accesso non è valida.
		/// </summary>
		internal static string AccessStringInvalidSyntax => ResourceManager.GetString("AccessStringInvalidSyntax", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a La raccolta prevista contiene {1} occorrenza/e di &lt;{2}&gt;, mentre quella effettiva ne contiene {3}. {0}.
		/// </summary>
		internal static string ActualHasMismatchedElements => ResourceManager.GetString("ActualHasMismatchedElements", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a È stato trovato un elemento duplicato:&lt;{1}&gt;. {0}.
		/// </summary>
		internal static string AllItemsAreUniqueFailMsg => ResourceManager.GetString("AllItemsAreUniqueFailMsg", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Il valore previsto è &lt;{1}&gt;, ma la combinazione di maiuscole/minuscole è diversa per il valore effettivo &lt;{2}&gt;. {0}.
		/// </summary>
		internal static string AreEqualCaseFailMsg => ResourceManager.GetString("AreEqualCaseFailMsg", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a È prevista una differenza minore di &lt;{3}&gt; tra il valore previsto &lt;{1}&gt; e il valore effettivo &lt;{2}&gt;. {0}.
		/// </summary>
		internal static string AreEqualDeltaFailMsg => ResourceManager.GetString("AreEqualDeltaFailMsg", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Valore previsto: &lt;{1} ({2})&gt;. Valore effettivo: &lt;{3} ({4})&gt;. {0}.
		/// </summary>
		internal static string AreEqualDifferentTypesFailMsg => ResourceManager.GetString("AreEqualDifferentTypesFailMsg", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Valore previsto: &lt;{1}&gt;. Valore effettivo: &lt;{2}&gt;. {0}.
		/// </summary>
		internal static string AreEqualFailMsg => ResourceManager.GetString("AreEqualFailMsg", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a È prevista una differenza maggiore di &lt;{3}&gt; tra il valore previsto &lt;{1}&gt; e il valore effettivo &lt;{2}&gt;. {0}.
		/// </summary>
		internal static string AreNotEqualDeltaFailMsg => ResourceManager.GetString("AreNotEqualDeltaFailMsg", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a È previsto un valore qualsiasi eccetto &lt;{1}&gt;. Valore effettivo: &lt;{2}&gt;. {0}.
		/// </summary>
		internal static string AreNotEqualFailMsg => ResourceManager.GetString("AreNotEqualFailMsg", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Non passare tipi valore a AreSame(). I valori convertiti in Object non saranno mai uguali. Usare AreEqual(). {0}.
		/// </summary>
		internal static string AreSameGivenValues => ResourceManager.GetString("AreSameGivenValues", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a {0} non riuscita. {1}.
		/// </summary>
		internal static string AssertionFailed => ResourceManager.GetString("AssertionFailed", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile ad async TestMethod con UITestMethodAttribute non supportata. Rimuovere async o usare TestMethodAttribute.
		/// </summary>
		internal static string AsyncUITestMethodNotSupported => ResourceManager.GetString("AsyncUITestMethodNotSupported", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Le raccolte sono entrambe vuote. {0}.
		/// </summary>
		internal static string BothCollectionsEmpty => ResourceManager.GetString("BothCollectionsEmpty", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Le raccolte contengono entrambe gli stessi elementi.
		/// </summary>
		internal static string BothCollectionsSameElements => ResourceManager.GetString("BothCollectionsSameElements", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a I riferimenti a raccolte puntano entrambi allo stesso oggetto Collection. {0}.
		/// </summary>
		internal static string BothCollectionsSameReference => ResourceManager.GetString("BothCollectionsSameReference", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Le raccolte contengono entrambe gli stessi elementi. {0}.
		/// </summary>
		internal static string BothSameElements => ResourceManager.GetString("BothSameElements", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a {0}({1}).
		/// </summary>
		internal static string CollectionEqualReason => ResourceManager.GetString("CollectionEqualReason", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a (Null).
		/// </summary>
		internal static string Common_NullInMessages => ResourceManager.GetString("Common_NullInMessages", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a (oggetto).
		/// </summary>
		internal static string Common_ObjectString => ResourceManager.GetString("Common_ObjectString", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a La stringa '{0}' non contiene la stringa '{1}'. {2}.
		/// </summary>
		internal static string ContainsFail => ResourceManager.GetString("ContainsFail", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a {0} ({1}).
		/// </summary>
		internal static string DataDrivenResultDisplayName => ResourceManager.GetString("DataDrivenResultDisplayName", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Per le asserzioni non usare Assert.Equals, ma preferire Assert.AreEqual e gli overload.
		/// </summary>
		internal static string DoNotUseAssertEquals => ResourceManager.GetString("DoNotUseAssertEquals", Culture);

		internal static string DynamicDataDisplayName => ResourceManager.GetString("DynamicDataDisplayName", Culture);

		internal static string DynamicDataIEnumerableNull => ResourceManager.GetString("DynamicDataIEnumerableNull", Culture);

		internal static string DynamicDataValueNull => ResourceManager.GetString("DynamicDataValueNull", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Il numero di elementi nelle raccolte non corrisponde. Valore previsto: &lt;{1}&gt;. Valore effettivo: &lt;{2}&gt;.{0}.
		/// </summary>
		internal static string ElementNumbersDontMatch => ResourceManager.GetString("ElementNumbersDontMatch", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a L'elemento alla posizione di indice {0} non corrisponde.
		/// </summary>
		internal static string ElementsAtIndexDontMatch => ResourceManager.GetString("ElementsAtIndexDontMatch", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a L'elemento alla posizione di indice {1} non è del tipo previsto. Tipo previsto: &lt;{2}&gt;. Tipo effettivo: &lt;{3}&gt;.{0}.
		/// </summary>
		internal static string ElementTypesAtIndexDontMatch => ResourceManager.GetString("ElementTypesAtIndexDontMatch", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a L'elemento alla posizione di indice {1} è (Null). Tipo previsto: &lt;{2}&gt;.{0}.
		/// </summary>
		internal static string ElementTypesAtIndexDontMatch2 => ResourceManager.GetString("ElementTypesAtIndexDontMatch2", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a La stringa '{0}' non termina con la stringa '{1}'. {2}.
		/// </summary>
		internal static string EndsWithFail => ResourceManager.GetString("EndsWithFail", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Argomento non valido: EqualsTester non può usare valori Null.
		/// </summary>
		internal static string EqualsTesterInvalidArgs => ResourceManager.GetString("EqualsTesterInvalidArgs", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Non è possibile convertire un oggetto di tipo {0} in {1}.
		/// </summary>
		internal static string ErrorInvalidCast => ResourceManager.GetString("ErrorInvalidCast", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a L'oggetto interno a cui si fa riferimento non è più valido.
		/// </summary>
		internal static string InternalObjectNotValid => ResourceManager.GetString("InternalObjectNotValid", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Il parametro '{0}' non è valido. {1}.
		/// </summary>
		internal static string InvalidParameterToAssert => ResourceManager.GetString("InvalidParameterToAssert", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Il tipo della proprietà {0} è {1}, ma quello previsto è {2}.
		/// </summary>
		internal static string InvalidPropertyType => ResourceManager.GetString("InvalidPropertyType", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Tipo previsto di {0}: &lt;{1}&gt;. Tipo effettivo: &lt;{2}&gt;.
		/// </summary>
		internal static string IsInstanceOfFailMsg => ResourceManager.GetString("IsInstanceOfFailMsg", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a La stringa '{0}' non corrisponde al criterio '{1}'. {2}.
		/// </summary>
		internal static string IsMatchFail => ResourceManager.GetString("IsMatchFail", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Tipo errato: &lt;{1}&gt;. Tipo effettivo: &lt;{2}&gt;. {0}.
		/// </summary>
		internal static string IsNotInstanceOfFailMsg => ResourceManager.GetString("IsNotInstanceOfFailMsg", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a La stringa '{0}' corrisponde al criterio '{1}'. {2}.
		/// </summary>
		internal static string IsNotMatchFail => ResourceManager.GetString("IsNotMatchFail", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Non è stato specificato alcun elemento DataRowAttribute. Con DataTestMethodAttribute è necessario almeno un elemento DataRowAttribute.
		/// </summary>
		internal static string NoDataRow => ResourceManager.GetString("NoDataRow", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Non è stata generata alcuna eccezione. Era prevista un'eccezione {1}. {0}.
		/// </summary>
		internal static string NoExceptionThrown => ResourceManager.GetString("NoExceptionThrown", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Il parametro '{0}' non è valido. Il valore non può essere Null. {1}.
		/// </summary>
		internal static string NullParameterToAssert => ResourceManager.GetString("NullParameterToAssert", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Il numero di elementi è diverso.
		/// </summary>
		internal static string NumberOfElementsDiff => ResourceManager.GetString("NumberOfElementsDiff", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a 
		///      Il costruttore con la firma specificata non è stato trovato. Potrebbe essere necessario rigenerare la funzione di accesso privata
		///       oppure il membro potrebbe essere privato e definito per una classe di base. In quest'ultimo caso, è necessario passare il tipo
		///       che definisce il membro nel costruttore di PrivateObject.
		///    .
		/// </summary>
		internal static string PrivateAccessorConstructorNotFound => ResourceManager.GetString("PrivateAccessorConstructorNotFound", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a 
		///      Il membro specificato ({0}) non è stato trovato. Potrebbe essere necessario rigenerare la funzione di accesso privata
		///       oppure il membro potrebbe essere privato e definito per una classe di base. In quest'ultimo caso, è necessario passare il tipo
		///       che definisce il membro nel costruttore di PrivateObject.
		///    .
		/// </summary>
		internal static string PrivateAccessorMemberNotFound => ResourceManager.GetString("PrivateAccessorMemberNotFound", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a La stringa '{0}' non inizia con la stringa '{1}'. {2}.
		/// </summary>
		internal static string StartsWithFail => ResourceManager.GetString("StartsWithFail", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Il tipo di eccezione previsto deve essere System.Exception o un tipo derivato da System.Exception.
		/// </summary>
		internal static string UTF_ExpectedExceptionTypeMustDeriveFromException => ResourceManager.GetString("UTF_ExpectedExceptionTypeMustDeriveFromException", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Non è stato possibile ottenere il messaggio per un'eccezione di tipo {0} a causa di un'eccezione.
		/// </summary>
		internal static string UTF_FailedToGetExceptionMessage => ResourceManager.GetString("UTF_FailedToGetExceptionMessage", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Il metodo di test non ha generato l'eccezione prevista {0}. {1}.
		/// </summary>
		internal static string UTF_TestMethodNoException => ResourceManager.GetString("UTF_TestMethodNoException", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Il metodo di test non ha generato un'eccezione. È prevista un'eccezione dall'attributo {0} definito nel metodo di test.
		/// </summary>
		internal static string UTF_TestMethodNoExceptionDefault => ResourceManager.GetString("UTF_TestMethodNoExceptionDefault", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Il metodo di test ha generato l'eccezione {0}, ma era prevista l'eccezione {1}. Messaggio dell'eccezione: {2}.
		/// </summary>
		internal static string UTF_TestMethodWrongException => ResourceManager.GetString("UTF_TestMethodWrongException", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a Il metodo di test ha generato l'eccezione {0}, ma era prevista l'eccezione {1} o un tipo derivato da essa. Messaggio dell'eccezione: {2}.
		/// </summary>
		internal static string UTF_TestMethodWrongExceptionDerivedAllowed => ResourceManager.GetString("UTF_TestMethodWrongExceptionDerivedAllowed", Culture);

		/// <summary>
		///   Cerca una stringa localizzata simile a È stata generata l'eccezione {2}, ma era prevista un'eccezione {1}. {0}
		///             Messaggio dell'eccezione: {3}
		///             Analisi dello stack: {4}.
		/// </summary>
		internal static string WrongExceptionThrown => ResourceManager.GetString("WrongExceptionThrown", Culture);

		internal FrameworkMessages()
		{
		}
	}
}
