using Djibus.Core.Models;
using Telerik.Blazor.Components;

namespace Djibus.Pages
{
    public partial class TypeDemandepage
    {
        List<TypeDemande> TypeDemandes = new();
        string proprio;
        List<ApplicationUser> users;
        string selectedValue;
        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            await LoadTypeDemandsAsync();
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

        public async Task LoadTypeDemandsAsync()
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                TypeDemandes = await ctx.TypeDemandes.ToListAsync();
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

        public async Task CreateTypeDemand(GridCommandEventArgs args)
        {
            var fam = args.Item as TypeDemande;
            //fam = UpdateOnCreation(fam);
            //fam.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.TypeDemandes.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadTypeDemandsAsync();
            }
        }
        public async Task UpdateTypeDemand(GridCommandEventArgs args)
        {
            var fam = args.Item as TypeDemande;
            //fam = UpdateOnUpdate(fam);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.TypeDemandes.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadTypeDemandsAsync();
            }
        }

        public async Task DeleteTypeDemand(GridCommandEventArgs args)
        {
            var fam = args.Item as TypeDemande;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.TypeDemandes.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadTypeDemandsAsync();
            }
        }
    }
}
