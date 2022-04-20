using Djibus.Core.Models;
using Telerik.Blazor.Components;
namespace Djibus.Pages
{
    public partial class Developerpage
    {
        List<Developer> Developers = new();
        string proprio;
        List<ApplicationUser> users;
        string selectedValue;

        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            await LoadDevsAsync();
        }

        public async Task<List<ApplicationUser>> LoadUsers(string SV)
        {
            SV = selectedValue;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                users = await ctx.Users.Where(v => v.FullName.StartsWith(selectedValue)).ToListAsync(); ;
            }
            return users;
        }

        public async Task LoadDevsAsync()
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                Developers = await ctx.Developers.ToListAsync();
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

        public async Task CreateDev(GridCommandEventArgs args)
        {
            var fam = args.Item as Developer;
            fam.CreateBy = proprio;
            fam.UpdateBy = proprio;
            fam.CreatedDate = DateTime.Now;
            fam.UpdatedDate = DateTime.Now;
            //fam = UpdateOnCreation(fam);
            //fam.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Developers.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadDevsAsync();
            }
        }
        public async Task UpdateDev(GridCommandEventArgs args)
        {
            var fam = args.Item as Developer;
            fam.UpdateBy = proprio;
            fam.UpdatedDate = DateTime.Now;
            //fam = UpdateOnUpdate(fam);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Developers.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadDevsAsync();
            }
        }

        public async Task DeleteDev(GridCommandEventArgs args)
        {
            var fam = args.Item as Developer;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Developers.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadDevsAsync();
            }
        }
    }
}
