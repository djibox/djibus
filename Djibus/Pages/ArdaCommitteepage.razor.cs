using Djibus.Core.Models;
using Telerik.Blazor.Components;

namespace Djibus.Pages
{
    public partial class ArdaCommitteepage
    {
        List<ArdaCommittee> ArdaCommittees = new();
        string proprio;
        List<ApplicationUser> users;
        string selectedValue;

        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            await LoadAllArdasAsync();
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

        public async Task LoadAllArdasAsync()
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ArdaCommittees = await ctx.ArdaCommittees.Include(d => d.Demandes).ToListAsync();
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

        public async Task CreateArda(GridCommandEventArgs args)
        {
            var fam = args.Item as ArdaCommittee;
            //fam = UpdateOnCreation(fam);
            //fam.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.ArdaCommittees.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadAllArdasAsync();
            }
        }
        public async Task UpdateArda(GridCommandEventArgs args)
        {
            var fam = args.Item as ArdaCommittee;
            //fam = UpdateOnUpdate(fam);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.ArdaCommittees.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadAllArdasAsync();
            }
        }

        public async Task DeleteArda(GridCommandEventArgs args)
        {
            var fam = args.Item as ArdaCommittee;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.ArdaCommittees.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadAllArdasAsync();
            }
        }
    }
}
