using Microsoft.AspNetCore.Mvc;

namespace TXTextControl.DocumentProcessing.Models
{
	public class MergeBody
	{
		[BindProperty(Name = "mergeData")]
		public string MergeData { get; set; }

		[BindProperty(Name = "template")]
		public string Template { get; set; }

		[BindProperty(Name = "mergeSettings")]
		public MergeSettings MergeSettings { get; set; }
	}

	public class DocumentSettings
	{
		[BindProperty(Name = "author")]
		public string Author { get; set; }

		[BindProperty(Name = "creationDate")]
		public DateTime? CreationDate { get; set; }

		[BindProperty(Name = "creatorApplication")]
		public string CreatorApplication { get; set; }

		[BindProperty(Name = "documentSubject")]
		public string DocumentSubject { get; set; }

		[BindProperty(Name = "documentTitle")]
		public string DocumentTitle { get; set; }

		[BindProperty(Name = "lastModificationDate")]
		public DateTime? LastModificationDate { get; set; }

		[BindProperty(Name = "userPassword")]
		public string UserPassword { get; set; }
	}

	public class MergeSettings : DocumentSettings
	{
		[BindProperty(Name = "removeEmptyFields")]
		public bool? RemoveEmptyFields { get; set; }

		[BindProperty(Name = "removeEmptyBlocks")]
		public bool? RemoveEmptyBlocks { get; set; }

		[BindProperty(Name = "removeEmptyImages")]
		public bool? RemoveEmptyImages { get; set; }

		[BindProperty(Name = "removeTrailingWhitespace")]
		public bool? RemoveTrailingWhitespace { get; set; }

		[BindProperty(Name = "removeEmptyLines")]
		public bool? RemoveEmptyLines { get; set; }

		[BindProperty(Name = "formFieldMergeType")]
		public int? FormFieldMergeType { get; set; }

		[BindProperty(Name = "culture")]
		public string Culture { get; set; }

		[BindProperty(Name = "dataSourceCulture")]
		public string DataSourceCulture { get; set; }

		[BindProperty(Name = "mergeCulture")]
		public string MergeCulture { get; set; }
	}
}