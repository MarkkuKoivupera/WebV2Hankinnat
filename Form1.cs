using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Web.WebView2.Core;

namespace WebView2Test
{
    public partial class Form1 : Form
    {
        //public Microsoft.Web.WebView2.Core.CoreWebView2 CoreWebView2 { get; }
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            wbvw_Selain.NavigationStarting += EnsureHttps;
            InitializeAsync();
        }
        async void InitializeAsync()
        {
            await wbvw_Selain.EnsureCoreWebView2Async(null);
            wbvw_Selain.CoreWebView2.WebMessageReceived += UpdateAddressBar;

            //await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            //await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");
        }
        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            txtAdress.Text = uri;
            wbvw_Selain.CoreWebView2.PostWebMessageAsString(uri);
        }
        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                wbvw_Selain.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            wbvw_Selain.Size = this.ClientSize - new System.Drawing.Size(wbvw_Selain.Location);
            btnGo.Left = this.ClientSize.Width - btnGo.Width;
            txtAdress.Width = btnGo.Left - txtAdress.Left;
        }
        private async void btnGetTrends_Click(object sender, EventArgs e)
        {
            var html = await wbvw_Selain.CoreWebView2.ExecuteScriptAsync("document.documentElement.outerHTML");


            var htmlDecoded = System.Text.Json.JsonSerializer.Deserialize<string>(html);

            var regex = new System.Text.RegularExpressions.Regex("<div bidi=\"value\" dir=\"ltr\"><span ng-bind=\"bidiText\">((.)*)</span></div>");
            var matches = regex.Matches(htmlDecoded);

            lstTrends.Items.Clear();
            foreach (System.Text.RegularExpressions.Match m in matches)
            {
                lstTrends.Items.Add(m.Groups[1].Value);
            }
        }

        private void webView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            btnGetTrends.Enabled = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
           
            if (wbvw_Selain != null && wbvw_Selain.CoreWebView2 != null)
            {
                btnGetTrends.Enabled = false;
                wbvw_Selain.CoreWebView2.Navigate(txtAdress.Text);
            }

        }
    }
}
