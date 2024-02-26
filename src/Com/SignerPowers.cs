﻿using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Diadoc.Api.Com
{
	[ComVisible(true)]
	[Guid("A5F72179-B865-4FA0-86CF-085C961A3F62")]
	//NOTE: Это хотели, чтобы можно было использовать XML-сериализацию для классов
	[XmlType(TypeName = "SignerPowers", Namespace = "https://diadoc-api.kontur.ru")]
	public enum SignerPowers
	{
		SignerPowersUnspecified = -1,
		InvoiceSigner = 0,
		PersonMadeOperation = 1,
		MadeAndSignOperation = 2,
		PersonDocumentedOperation = 3,
		MadeOperationAndSignedInvoice = 4,
		MadeAndResponsibleForOperationAndSignedInvoice = 5,
		ResponsibleForOperationAndSignerForInvoice = 6,
		ChairmanCommission = 7,
		MemberCommission = 8,
		PersonApprovedDocument = 21,
		PersonConfirmedDocument = 22,
		PersonAgreedOnDocument = 23,
		PersonOtherPower = 29
    }
}
