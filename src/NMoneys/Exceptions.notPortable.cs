using System;
using System.Runtime.Serialization;

namespace NMoneys
{
	[Serializable]
	public partial class MisconfiguredCurrencyException : Exception
	{
		/// <summary>
		/// Initializes a new instace of <see cref="MisconfiguredCurrencyException"/> with serialized data
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the <see cref="MisconfiguredCurrencyException"/>.</param>
		/// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
		protected MisconfiguredCurrencyException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}

	[Serializable]
	public partial class DifferentCurrencyException : InvalidOperationException
	{
		/// <summary>
		/// Initializes a new instace of <see cref="DifferentCurrencyException"/> with serialized data
		/// </summary>
		/// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the <see cref="DifferentCurrencyException"/>.</param>
		/// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
		protected DifferentCurrencyException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
