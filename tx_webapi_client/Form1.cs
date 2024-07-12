using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net;
using System.Text;

namespace tx_webapi_client
{

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			byte[] data = null;

			textControl1.Save(out data, TXTextControl.BinaryStreamType.InternalUnicodeFormat);

			var MergeBody = new TXTextControl.DocumentProcessing.Models.MergeBody()
			{
				MergeData = JsonConvert.SerializeObject(customer),
				Template = Convert.ToBase64String(data),
				MergeSettings = new TXTextControl.DocumentProcessing.Models.MergeSettings()
				{
					Author = "John Doe",
					CreationDate = DateTime.Now,
					CreatorApplication = "TX Text Control",
					DocumentSubject = "Subject",
					DocumentTitle = "Title",
					LastModificationDate = DateTime.Now,
					UserPassword = "password",
					RemoveEmptyFields = true,
					RemoveEmptyBlocks = true,
					RemoveEmptyImages = true,
					RemoveTrailingWhitespace = true,
					RemoveEmptyLines = true,
					FormFieldMergeType = 1,
					Culture = "en-US",
					DataSourceCulture = "en-US",
					MergeCulture = "en-US"
				}
			};

			DocumentController documentController = new DocumentController();
			OkObjectResult test = (OkObjectResult)documentController.Merge(MergeBody);


			textControl1.Load(Convert.FromBase64String((string)test.Value), TXTextControl.BinaryStreamType.InternalUnicodeFormat);

		}

		Customer customer;

		private void button2_Click(object sender, EventArgs e)
		{
			customer = new Customer() { FirstName = "John", LastName = "Doe" };

			ribbonReportingTab1.DataSourceManager.LoadSingleObject(customer);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			byte[] data = null;

			textControl1.Save(out data, TXTextControl.BinaryStreamType.InternalUnicodeFormat);

			var MergeBody = new TXTextControl.DocumentProcessing.Models.MergeBody()
			{
				MergeData = JsonConvert.SerializeObject(customer),
				Template = Convert.ToBase64String(data),
				MergeSettings = new TXTextControl.DocumentProcessing.Models.MergeSettings()
				{
					Author = "John Doe",
					CreationDate = DateTime.Now,
					CreatorApplication = "TX Text Control",
					DocumentSubject = "Subject",
					DocumentTitle = "Title",
					LastModificationDate = DateTime.Now,
					UserPassword = "password",
					RemoveEmptyFields = true,
					RemoveEmptyBlocks = true,
					RemoveEmptyImages = true,
					RemoveTrailingWhitespace = true,
					RemoveEmptyLines = true,
					FormFieldMergeType = 1,
					Culture = "en-US",
					DataSourceCulture = "en-US",
					MergeCulture = "en-US"
				}
			};
		
			var client = new HttpClient();
			
			// convert content to json with lower case properties
			var content = new StringContent(JsonConvert.SerializeObject(MergeBody, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }), Encoding.UTF8, "application/json");
			var response = client.PostAsync("https://localhost:7241/Document/Merge", content).Result;
			
			// get the response as a string
			var responseString = response.Content.ReadAsStringAsync().Result;

			textControl1.Load(Convert.FromBase64String(responseString), TXTextControl.BinaryStreamType.InternalUnicodeFormat);
		}
	}
}
