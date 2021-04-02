using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchUI
{
    public partial class AzureSearchPlayground : Form
    {
        private readonly string SearchService = ConfigurationManager.AppSettings["SearchService"];
        private readonly string SearchServiceKey = ConfigurationManager.AppSettings["SearchServiceKey"];
        private readonly string SearchServiceIndex = ConfigurationManager.AppSettings["SearchServiceIndex"];

        public AzureSearchPlayground()
        {
            InitializeComponent();
        }

        private void ButtonIndex_Click(object sender, EventArgs e)
        {
            Article article = new Article
            {
                Title = InputTitle.Text,
                Category = InputCategory.Text,
                Text = InputText.Text
            };

            using (var serviceClient = new SearchServiceClient(SearchService, new SearchCredentials(SearchServiceKey)))
            {
                var actions = new IndexAction<Article>[]
                {
                    IndexAction.MergeOrUpload(article)
                };

                var batch = IndexBatch.New(actions);

                ISearchIndexClient indexClient = serviceClient.Indexes.GetClient(SearchServiceIndex);
                indexClient.Documents.Index(batch);
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            using (var indexClient = new SearchIndexClient(SearchService, SearchServiceIndex, new SearchCredentials(SearchServiceKey)))
            {
                var parameters = new SearchParameters()
                {
                    // Select = new[] { "" }
                };

                var results = indexClient.Documents.Search<Article>(Keyword.Text, parameters);

                ResultGrid.DataSource = results.Results.Select(x => new
                {
                    Score = x.Score,
                    Title = x.Document.Title,
                    Category = x.Document.Category,
                    Text = x.Document.Text
                }).OrderByDescending(x => x.Score).ToList();
            }
        }
    }
}
