using Djibus.Core.Models;
using Telerik.Blazor.Components;
namespace Djibus.Pages
{
    public partial class BusinessAnalystpage
    {
        List<BusinessAnalyst> BusinessAnalysts = new();
        string proprio;
        List<ApplicationUser> users;
        string selectedValue;

        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            await LoadBasAsync();
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

        public async Task LoadBasAsync()
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                BusinessAnalysts = await ctx.BusinessAnalysts.ToListAsync();
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

        public async Task CreateBa(GridCommandEventArgs args)
        {
            var fam = args.Item as BusinessAnalyst;
            fam.CreateBy = proprio;
            fam.UpdateBy = proprio;
            fam.CreatedDate = DateTime.Now;
            fam.UpdatedDate = DateTime.Now;

            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.BusinessAnalysts.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadBasAsync();
            }
        }
        public async Task UpdateBa(GridCommandEventArgs args)
        {
            var fam = args.Item as BusinessAnalyst;
            fam.UpdateBy = proprio;
            fam.UpdatedDate = DateTime.Now;

            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.BusinessAnalysts.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadBasAsync();
            }
        }

        public async Task DeleteBa(GridCommandEventArgs args)
        {
            var fam = args.Item as BusinessAnalyst;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.BusinessAnalysts.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadBasAsync();
            }
        }
    }
}
