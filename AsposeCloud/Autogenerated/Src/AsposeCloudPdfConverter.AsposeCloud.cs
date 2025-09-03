namespace Terrasoft.Configuration
{
	using Aspose.Words.Cloud.Sdk;
	using Aspose.Words.Cloud.Sdk.Model.Requests;
	using System;
	using System.IO;
	using System.Threading.Tasks;
	using Terrasoft.Common;
	using Terrasoft.Common.Threading;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	[DefaultBinding(typeof(IPdfConverter), Name = "PdfConverter")]
	public class AsposeCloudPdfConverter : IPdfConverter
	{

		private const string FORMAT = "pdf";
		private const string API_KEY_SETTINGS_CODE = "AsposeCloudApiKey";
		private const string APP_SID_SETTINGS_CODE = "AsposeCloudAppSID";
		private const string FONTS_LOCATION_SETTINGS_CODE = "AsposeCloudFontsLocation";

		private UserConnection _userConnection;

		private string TryGetSettingValue(string settingCode) {
			string settingValue = Core.Configuration.SysSettings.GetValue(_userConnection, settingCode, string.Empty);
			if (string.IsNullOrWhiteSpace(settingValue)) {
				throw new ArgumentNullOrEmptyException($"System settings {settingCode}");
			}
			return settingValue;
		}

		public AsposeCloudPdfConverter(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		public byte[] Convert(byte[] data) {
			string apiKey = TryGetSettingValue(API_KEY_SETTINGS_CODE);
			string appSID = TryGetSettingValue(APP_SID_SETTINGS_CODE);
			if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(appSID)) {
				throw new InvalidOperationException("API Key or App SID is missing.");
			}
			string fontsLocation =
				Core.Configuration.SysSettings.GetValue(_userConnection, FONTS_LOCATION_SETTINGS_CODE, string.Empty);
			using (var inputFileStream = new MemoryStream(data)) {
				WordsApi asposeCloudWordsApi = new WordsApi(apiKey, appSID);
				ConvertDocumentRequest convertDocumentRequest = new ConvertDocumentRequest(inputFileStream, FORMAT);
				if (!string.IsNullOrEmpty(fontsLocation)) {
					convertDocumentRequest.FontsLocation = fontsLocation;
				}
				try {
					Stream convertResult =
						AsyncPump.Run(() => asposeCloudWordsApi.ConvertDocument(convertDocumentRequest));
					using (var memoryStream = new MemoryStream()) {
						convertResult.CopyTo(memoryStream);
						return memoryStream.ToArray();
					}
				} catch (Exception e) {
					throw new InvalidOperationException("Error converting document.", e);
				}
			}
		}
	}
}

