using Djibus.Core.Models;
using Telerik.Blazor.Components;
namespace Djibus.Pages
{
    public partial class EntrepriseArchitectpage
    {
        List<EntrepriseArchitect> EntrepriseArchitects = new();
        string proprio;
        List<ApplicationUser> users;
        string selectedValue;

        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            await LoadEasAsync();
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

        public async Task LoadEasAsync()
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                EntrepriseArchitects = await ctx.EntrepriseArchitects.ToListAsync();
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

        public async Task CreateEa(GridCommandEventArgs args)
        {
            var fam = args.Item as EntrepriseArchitect;
            //fam = UpdateOnCreation(fam);
            //fam.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.EntrepriseArchitects.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadEasAsync();
            }
        }
        public async Task UpdateEa(GridCommandEventArgs args)
        {
            var fam = args.Item as EntrepriseArchitect;
            //fam = UpdateOnUpdate(fam);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.EntrepriseArchitects.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadEasAsync();
            }
        }

        public async Task DeleteEa(GridCommandEventArgs args)
        {
            var fam = args.Item as EntrepriseArchitect;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.EntrepriseArchitects.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadEasAsync();
            }
        }
    }
}
