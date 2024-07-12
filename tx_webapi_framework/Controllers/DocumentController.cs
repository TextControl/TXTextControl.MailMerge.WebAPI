using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TXTextControl.DocumentServer;
using TXTextControl.DocumentProcessing.Models;
using System.Globalization;

public class DocumentController : Controller
{
	[HttpPost]
	public IActionResult Merge(
		[FromBody] MergeBody mergeBody)
	{

		#region Error Checking

		// error checking: MergeBody cannot be null
		if (mergeBody == null)
		{
			return BadRequest();
		}

		// error checking: Template must not be null
		if (mergeBody.Template == null)
		{
			return BadRequest("Template must not be null");
		}

		#endregion

		using (TXTextControl.ServerTextControl tx = new TXTextControl.ServerTextControl())
		{
			tx.Create();

			// load the template
			try { 				
				tx.Load(Convert.FromBase64String(mergeBody.Template), TXTextControl.BinaryStreamType.InternalUnicodeFormat);
			}
			catch (Exception ex) // format not valid
			{
				return BadRequest(ex.Message);
			}

			// create a new MailMerge object
			MailMerge mailMerge = new MailMerge()
			{
				TextComponent = tx,
				
				// set the merge settings
				DataSourceCulture = new CultureInfo(mergeBody.MergeSettings.DataSourceCulture),
				FormFieldMergeType = (FormFieldMergeType)mergeBody.MergeSettings.FormFieldMergeType,
				MergeCulture = new CultureInfo(mergeBody.MergeSettings.MergeCulture),
				RemoveEmptyBlocks = mergeBody.MergeSettings.RemoveEmptyBlocks ?? false,
				RemoveEmptyFields = mergeBody.MergeSettings.RemoveEmptyFields ?? false,
				RemoveEmptyImages = mergeBody.MergeSettings.RemoveEmptyImages ?? false,
				RemoveEmptyLines = mergeBody.MergeSettings.RemoveEmptyLines ?? false,
				RemoveTrailingWhitespace = mergeBody.MergeSettings.RemoveTrailingWhitespace ?? false,
			};

			// merge the data
			mailMerge.MergeJsonData(mergeBody.MergeData, true);

			// save settings
			TXTextControl.SaveSettings saveSettings = new TXTextControl.SaveSettings()
			{
				Author = mergeBody.MergeSettings.Author,
				CreationDate = (DateTime)mergeBody.MergeSettings.CreationDate,
				CreatorApplication = mergeBody.MergeSettings.CreatorApplication,
				DocumentSubject = mergeBody.MergeSettings.DocumentSubject,
				DocumentTitle = mergeBody.MergeSettings.DocumentTitle,
				LastModificationDate = (DateTime)mergeBody.MergeSettings.LastModificationDate,
				UserPassword = mergeBody.MergeSettings.UserPassword
			};

			byte[] results = null;

			// save the document as PDF
			tx.Save(out results, TXTextControl.BinaryStreamType.AdobePDF, saveSettings);

			// return the merged document as base64 string
			return Ok(Convert.ToBase64String(results));
		}
	}
}
