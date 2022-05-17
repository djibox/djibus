using Djibus.Core.Models;
using Telerik.Blazor.Components;

namespace Djibus.Pages
{
    public partial class ProfileUserpage
    {
        List<ProfileUser> ProfileUsers = new();
        string proprio;
        List<ApplicationUser> users;
        string selectedValue;

        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            await LoadProfilesAsync();
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

        public async Task LoadProfilesAsync()
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ProfileUsers = await ctx.ProfileUsers.ToListAsync();
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

        public async Task CreateProfile(GridCommandEventArgs args)
        {
            var fam = args.Item as ProfileUser;
            fam.CreateBy = proprio;
            fam.UpdateBy = proprio;
            fam.CreatedDate = DateTime.Now;
            fam.UpdatedDate = DateTime.Now;

            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.ProfileUsers.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadProfilesAsync();
            }
        }
        public async Task UpdateProfile(GridCommandEventArgs args)
        {
            var fam = args.Item as ProfileUser;
            fam.UpdateBy = proprio;
            fam.UpdatedDate = DateTime.Now;

            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.ProfileUsers.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadProfilesAsync();
            }
        }

        public async Task DeleteProfile(GridCommandEventArgs args)
        {
            var fam = args.Item as ProfileUser;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.ProfileUsers.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadProfilesAsync();
            }
        }
    }
}
