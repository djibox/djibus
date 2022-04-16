using Djibus.Core.Models;
using Telerik.Blazor.Components;

namespace Djibus.Pages
{
    public partial class PrgCommitteepage
    {
        List<PrgCommittee> PrgCommittees = new();
        string proprio;
        List<ApplicationUser> users;
        string selectedValue;

        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            await LoadAllPRGsAsync();
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

        public async Task LoadAllPRGsAsync()
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                PrgCommittees = await ctx.PrgCommittees.Include(d=>d.Demandes).ToListAsync();
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

        public async Task CreatePrg(GridCommandEventArgs args)
        {
            var fam = args.Item as PrgCommittee;
            //fam = UpdateOnCreation(fam);
            //fam.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.PrgCommittees.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadAllPRGsAsync();
            }
        }
        public async Task UpdatePrg(GridCommandEventArgs args)
        {
            var fam = args.Item as PrgCommittee;
            //fam = UpdateOnUpdate(fam);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.PrgCommittees.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadAllPRGsAsync();
            }
        }

        public async Task DeletePrg(GridCommandEventArgs args)
        {
            var fam = args.Item as PrgCommittee;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.PrgCommittees.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadAllPRGsAsync();
            }
        }
    }
}
