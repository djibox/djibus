
using Microsoft.Build.Evaluation;
using Telerik.Blazor;
using Telerik.Blazor.Components;

namespace Djibus.Pages
{
    public partial class Planningpage
    {
        [Parameter]
        public List<Project> Data { get; set; }
        public GanttView SelectedView { get; set; } = GanttView.Week;

        protected override async Task OnInitializedAsync()
        {
            await LoadDataAsync();
            await LoadDependenciesAsync();
        }

        private async Task LoadDataAsync()
        {

        }

        private async Task LoadDependenciesAsync()
        {
           
        }

        private async Task CreateTask(GanttCreateEventArgs args)
        {
            
            await LoadDataAsync();
        }

        private async Task UpdateTask(GanttUpdateEventArgs args)
        {
            
            await LoadDataAsync();
        }

        private async Task DeleteTask(GanttDeleteEventArgs args)
        {
            
            await LoadDataAsync();
        }

        private async Task CreateDependency(GanttDependencyCreateEventArgs args)
        {
           
            await LoadDependenciesAsync();
        }

        private async Task DeleteDependency(GanttDependencyDeleteEventArgs args)
        {
            
            await LoadDependenciesAsync();
        }
    }
}
