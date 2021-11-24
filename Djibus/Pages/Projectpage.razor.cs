using Djibus.Core.Models;
using Microsoft.EntityFrameworkCore;
using Telerik.Blazor.Components;

namespace Djibus.Pages
{
    public partial class Projectpage:ComponentBase
    {
        List<Project> Projects = new();
        string proprio;

        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            await LoadProjectsAsync();
        }

        public async Task LoadProjectsAsync()
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                Projects = await ctx.Projects.ToListAsync();
            }
        }

        //public Project UpdateOnCreation(Project project)
        //{
        //    Commande.CreerPar = proprio;
        //    Commande.ModifierPar = proprio;
        //    Commande.DateCreation = DateTime.Now;
        //    Commande.DateModification = DateTime.Now;
        //    return Commande;
        //}
        //public Commande UpdateOnUpdate(Commande Commande)
        //{
        //    //entreprise.CreerPar = proprio;
        //    Commande.ModifierPar = proprio;
        //    //entreprise.DateCreation = DateTime.Now;
        //    Commande.DateModification = DateTime.Now;
        //    return Commande;
        //}

        public async Task CreateProject(GridCommandEventArgs args)
        {
            var fam = args.Item as Project;
            //fam = UpdateOnCreation(fam);
            //fam.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Projects.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadProjectsAsync();
            }
        }
        public async Task UpdateProject(GridCommandEventArgs args)
        {
            var fam = args.Item as Project;
            //fam = UpdateOnUpdate(fam);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Projects.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadProjectsAsync();
            }
        }

        public async Task DeleteProject(GridCommandEventArgs args)
        {
            var fam = args.Item as Project;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Projects.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadProjectsAsync();
            }
        }
    }
}
