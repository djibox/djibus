using Djibus.Core.Models;
using Telerik.Blazor.Components;

namespace Djibus.Pages
{
    public partial class Orgunit
    {
        List<OrgUnit> OrgUnits = new();
        string proprio;
        List<ApplicationUser> users;
        string selectedValue;

        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            await LoadOrgUnitsAsync();
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

        public async Task LoadOrgUnitsAsync()
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                OrgUnits = await ctx.OrgUnits.ToListAsync();
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

        public async Task CreateOrgUnit(GridCommandEventArgs args)
        {
            var fam = args.Item as OrgUnit;
            fam.CreateBy = proprio;
            fam.UpdateBy = proprio;
            fam.CreatedDate = DateTime.Now;
            fam.UpdatedDate = DateTime.Now;
            //fam = UpdateOnCreation(fam);
            //fam.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.OrgUnits.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadOrgUnitsAsync();
            }
        }
        public async Task UpdateOrgUnit(GridCommandEventArgs args)
        {
            var fam = args.Item as OrgUnit;
            fam.UpdateBy = proprio;
            fam.UpdatedDate = DateTime.Now;
            //fam = UpdateOnUpdate(fam);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.OrgUnits.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadOrgUnitsAsync();
            }
        }

        public async Task DeleteOrgUnit(GridCommandEventArgs args)
        {
            var fam = args.Item as OrgUnit;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.OrgUnits.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadOrgUnitsAsync();
            }
        }
    }
}
