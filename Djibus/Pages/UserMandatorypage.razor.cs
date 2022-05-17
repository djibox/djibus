using Djibus.Core.Models;
using Microsoft.EntityFrameworkCore;
using Telerik.Blazor.Components;

namespace Djibus.Pages
{
    public partial class UserMandatorypage
    {
        List<UserMandatory> UserMandatories = new();
        string proprio;
        string ProfileName;
        List<ApplicationUser> users;
        int selectedValue;
        string _selectedValue="";

        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            await LoadRolesAsync();
        }






        public async Task LoadRolesAsync()
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                UserMandatories = await ctx.UserMandatories.Include(d => d.ProfileUser).ToListAsync();
                //SelectedValue = null;
            }
        }

        public string GetProfileById(int id)
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                var element = ctx.ProfileUsers.FirstOrDefault(f => f.Id.Equals(id));
                if (element != null)
                {
                    ProfileName = element.ProfileName;
                }
            }
            return ProfileName;

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

        public async Task CreateRole(GridCommandEventArgs args)
        {
            var fam = args.Item as UserMandatory;
            fam.ProfileUserId = selectedValue;
            fam.CreateBy = proprio;
            fam.UpdateBy = proprio;
            fam.CreatedDate = DateTime.Now;
            fam.UpdatedDate = DateTime.Now;
            //fam = UpdateOnCreation(fam);
            //fam.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.UserMandatories.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadRolesAsync();
            }
        }
        public async Task UpdateRole(GridCommandEventArgs args)
        {
            var fam = args.Item as UserMandatory;
            fam.ProfileUserId = selectedValue;
            fam.UpdateBy = proprio;
            fam.UpdatedDate = DateTime.Now;

            //fam = UpdateOnUpdate(fam);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.UserMandatories.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadRolesAsync();
            }
        }

        public async Task DeleteRole(GridCommandEventArgs args)
        {
            var fam = args.Item as UserMandatory;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.UserMandatories.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadRolesAsync();
            }
        }
    }
}
