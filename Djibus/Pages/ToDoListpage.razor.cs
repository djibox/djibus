using Djibus.Core.Models;
using Microsoft.EntityFrameworkCore;
using Telerik.Blazor.Components;

namespace Djibus.Pages
{
    public partial class ToDoListpage
    {
        [Parameter]
        public string id { get; set; }
        List<Activity> Activities = new();
        string proprio;
        string DemandName;
        List<ApplicationUser> users;
        int? selectedValue;

        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            DemandName = GetDemandById(int.Parse(id));
            await LoadActivitiesAsync(id);
        }






        public async Task LoadActivitiesAsync(string id)
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                int _id = int.Parse(id);
                Activities = await ctx.Activities.Where(s=>s.DemandeId.Equals(int.Parse(id))).ToListAsync();
                //SelectedValue = null;
            }
        }

        public string GetDemandById(int? id)
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                var element = ctx.Demandes.FirstOrDefault(f => f.Id.Equals(id));
                if (element != null)
                {
                    DemandName = element.Title;
                }
            }
            return DemandName;

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

        public async Task CreateActivity(GridCommandEventArgs args)
        {
            var fam = args.Item as Activity;
            fam.DemandeId = selectedValue;
            fam.CreateBy = proprio;
            fam.UpdateBy = proprio;
            fam.CreatedDate = DateTime.Now;
            fam.UpdatedDate = DateTime.Now;
            //fam = UpdateOnCreation(fam);
            //fam.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Activities.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadActivitiesAsync(id);
            }
        }
        public async Task UpdateActivity(GridCommandEventArgs args)
        {
            var fam = args.Item as Activity;
            fam.DemandeId = selectedValue;
            fam.UpdateBy = proprio;
            fam.UpdatedDate = DateTime.Now;

            //fam = UpdateOnUpdate(fam);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Activities.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadActivitiesAsync(id);
            }
        }

        public async Task DeleteActivity(GridCommandEventArgs args)
        {
            var fam = args.Item as Activity;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Activities.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadActivitiesAsync(id);
            }
        }
    }
}
