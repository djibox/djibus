using Ganss.Excel;
using Microsoft.CodeAnalysis;
using Telerik.Blazor.Components;
using Djibus.Core.Models;
namespace Djibus.Pages
{
    public partial class Processingpage
    {
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
            var filename = @"C:\ExcelProcessing\Projects.xls";
            var personnes = new ExcelMapper(filename).Fetch<Core.ViewModels.ProjectModel>();
        }
    }
}
