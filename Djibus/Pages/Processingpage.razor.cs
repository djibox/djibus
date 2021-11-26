using Ganss.Excel;
using Microsoft.CodeAnalysis;
using Telerik.Blazor.Components;
using Djibus.Core.Models;
using Djibus.Core.ViewModels;

namespace Djibus.Pages
{
    public partial class Processingpage
    {
        public IEnumerable<ProjectModel> ProjectModels { get; set; }
        private int NumberOfRows = 0;
        void OnSelectHandler(UploadSelectEventArgs e)
        {
        }

        void OnCancelHandler(UploadCancelEventArgs e)
        {

        }

        void OnRemoveHandler(UploadEventArgs e)
        {

        }

        void ProcessingHandler()
        {
            var filename = @"C:\ExcelProcessing\October2021.xlsx";
            ProjectModels = new ExcelMapper(filename).Fetch<Core.ViewModels.ProjectModel>();
            NumberOfRows = ProjectModels.Count();
        }
    }
}
