define("BaseDataView", [],
	function() {
		return {
			diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
			mixins: {},
			messages: {},
			attributes: {},
			methods: {

				/**
				 * @inheritdoc Terrasoft.BaseSection#generatePrintForm
				 * @overriden
				 */
				generatePrintForm: function(printForm) {
					if (!printForm.$ConvertInPDF) {
						return this.callParent(arguments);
					}
					const config = this.mixins.PrintReportUtilities.getPrintFormConfig.call(this, printForm);
					this.showBodyMask();
					const apiKeySettingsCode = "AsposeCloudApiKey";
					const appSIDSettingsCode = "AsposeCloudAppSID";
					const asposeSysSettings = [apiKeySettingsCode, appSIDSettingsCode];
					Terrasoft.SysSettings.querySysSettings(asposeSysSettings, function(result) {
						const isEmptyApiKey = Ext.isEmpty(result[apiKeySettingsCode]);
						const isEmptyAppSID = Ext.isEmpty(result[appSIDSettingsCode]);
						if (isEmptyApiKey || isEmptyAppSID) {
							this.hideBodyMask();
							this.showInformationDialog(this.get("Resources.Strings.SysSettingsErrorMessage"));
							return;
						}
						this.callService(config.serviceRequest, function(responseObject, response) {
							this.hideBodyMask();
							const successResponse = response && response.status === 200;
							if (!successResponse) {
								this.error(Terrasoft.stripTags(Terrasoft.removeHtmlTags(response.responseText)));
								this.showInformationDialog(this.get("Resources.Strings.ConvertInPDFErrorMessage"));
							}
							config.callback.call(this, responseObject);
						}, this);
					}, this);
				}
			}
		};
	}
);
