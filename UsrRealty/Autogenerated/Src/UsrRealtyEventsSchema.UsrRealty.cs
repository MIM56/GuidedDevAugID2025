namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fca916e4-aa32-4c3c-8244-73ed1a7fc40b");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ed589b1-582f-4ea3-b356-d746e937bc30");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,107,219,64,16,189,7,242,31,6,209,131,4,102,73,174,77,27,168,141,91,2,161,45,177,210,75,233,97,189,26,43,91,246,67,236,172,156,186,37,255,189,179,90,185,118,228,20,50,23,105,103,222,188,121,111,24,112,210,34,117,82,33,212,24,130,36,191,137,98,225,221,70,183,125,144,81,123,119,126,246,231,252,12,56,122,210,174,133,213,142,34,218,171,227,212,113,163,181,222,253,183,24,80,44,93,212,81,35,189,6,35,150,91,116,113,15,253,62,164,119,67,238,86,179,8,135,161,92,169,7,180,242,51,123,128,247,80,220,83,184,67,105,226,174,168,126,228,166,174,95,27,173,64,25,73,4,185,246,2,13,188,133,185,36,124,161,146,89,198,5,28,17,250,45,75,214,13,194,214,235,6,190,184,149,220,178,145,210,175,127,162,138,64,232,26,12,51,200,132,115,220,176,171,129,246,67,104,9,176,58,208,29,49,167,88,179,10,241,143,109,79,131,213,213,115,88,230,133,48,248,97,227,101,78,84,185,97,2,110,80,105,43,13,116,65,171,180,165,220,37,62,97,172,119,29,54,11,111,122,235,190,73,211,227,187,17,122,93,166,77,126,77,248,98,58,90,111,160,204,76,215,112,121,177,143,234,57,104,226,42,5,138,27,90,72,167,208,96,195,34,98,232,145,153,79,113,20,67,186,8,190,73,146,45,214,104,59,35,99,146,237,240,17,110,189,146,70,255,150,107,131,171,1,87,142,102,238,9,3,31,173,227,229,243,197,138,59,36,223,7,197,32,31,152,101,6,167,115,82,28,238,37,31,90,49,131,226,100,4,137,97,55,55,84,123,63,215,109,126,21,149,168,253,40,161,122,133,15,214,159,19,226,163,15,86,198,114,226,143,7,95,138,139,249,155,147,117,167,136,15,193,63,14,254,151,191,20,118,201,225,190,127,10,127,58,60,199,95,254,60,253,5,245,86,193,153,228,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0625c18a-7c2e-4a75-da4f-3cb9160fcc86"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("8ed589b1-582f-4ea3-b356-d746e937bc30"),
				CreatedInSchemaUId = new Guid("fca916e4-aa32-4c3c-8244-73ed1a7fc40b"),
				ModifiedInSchemaUId = new Guid("fca916e4-aa32-4c3c-8244-73ed1a7fc40b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fca916e4-aa32-4c3c-8244-73ed1a7fc40b"));
		}

		#endregion

	}

	#endregion

}

