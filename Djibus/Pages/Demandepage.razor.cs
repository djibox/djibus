using Djibus.Core.Models;
using Microsoft.EntityFrameworkCore;
using Telerik.Blazor.Components;

namespace Djibus.Pages
{
    public partial class Demandepage
    {
        List<Demande> Demandes = new();
        string proprio;
        string TypeDemandName;
        string OrgUnitName;
        string PrgName;
        string ArdaName;
        string DevName;
        string EaName;
        string BaName;
        List<ApplicationUser> users;
        int selectedValue;
        int? OrgUnitselectedValue;
        int? PrgselectedValue;
        int? ArdaselectedValue;
        int? BaselectedValue;
        int? EaselectedValue;
        int? DevselectedValue;

        protected override async Task OnInitializedAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            proprio = user.Identity.Name;
            await LoadDemandesAsync();
        }

        public string GetTypeDemandById(int id)
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                var element =  ctx.TypeDemandes.FirstOrDefault(f => f.Id.Equals(id));
                if (element != null)
                {
                    TypeDemandName =  element.DemandeTypeName;
                }
            }
            return TypeDemandName;

        }
        public string GetOrgUnitById(int? id)
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                var element = ctx.OrgUnits.FirstOrDefault(f => f.Id.Equals(id));
                if (element != null)
                {
                    OrgUnitName = element.OrgUnitName;
                }
            }
            return OrgUnitName;

        }

        public string GetPRGById(int? id)
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                var element = ctx.PrgCommittees.FirstOrDefault(f => f.Id.Equals(id));
                if (element != null)
                {
                    PrgName = element.Libelle;
                }
            }
            return PrgName;

        }
        public string GetARDAById(int? id)
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                var element = ctx.ArdaCommittees.FirstOrDefault(f => f.Id.Equals(id));
                if (element != null)
                {
                    ArdaName = element.Libelle;
                }
            }
            return ArdaName;

        }

        public string GetDevById(int? id)
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                var element = ctx.Developers.FirstOrDefault(f => f.Id.Equals(id));
                if (element != null)
                {
                    DevName = element.FullName;
                }
            }
            return DevName;

        }
        public string GetBaById(int? id)
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                var element = ctx.BusinessAnalysts.FirstOrDefault(f => f.Id.Equals(id));
                if (element != null)
                {
                    BaName = element.FullName;
                }
            }
            return BaName;

        }
        public string GetEaById(int? id)
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                var element = ctx.EntrepriseArchitects.FirstOrDefault(f => f.Id.Equals(id));
                if (element != null)
                {
                    EaName = element.FullName;
                }
            }
            return EaName;

        }

        public async Task LoadDemandesAsync()
        {
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                Demandes = await ctx.Demandes.ToListAsync();
                //SelectedValue = null;
                OrgUnitselectedValue = null;
                PrgselectedValue = null;
                ArdaselectedValue = null;
                BaselectedValue = null;
                EaselectedValue = null;
                DevselectedValue = null;
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

        public async Task CreateDemand(GridCommandEventArgs args)
        {
            var fam = args.Item as Demande;
            fam.TypeDemandeId = selectedValue;
            fam.OrgUnitId = OrgUnitselectedValue;
            fam.StartDate = DateTime.Today;
            fam.PrgCommitteeId = PrgselectedValue;
            fam.ArdaCommitteeId = ArdaselectedValue;
            fam.DeveloperId = DevselectedValue;
            fam.BusinessAnalystId = BaselectedValue;
            fam.EntrepriseArchitectId = EaselectedValue;
            fam.CreateBy = proprio;
            fam.UpdateBy = proprio;
            fam.CreatedDate = DateTime.Now;
            fam.UpdatedDate = DateTime.Now;
            //fam = UpdateOnCreation(fam);
            //fam.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Demandes.Add(fam);
                await ctx.SaveChangesAsync();
                await LoadDemandesAsync();
            }
        }
        public async Task UpdateDemand(GridCommandEventArgs args)
        {
            var fam = args.Item as Demande;
            fam.TypeDemandeId = selectedValue;
            fam.OrgUnitId = OrgUnitselectedValue;
            fam.PrgCommitteeId = PrgselectedValue;
            fam.ArdaCommitteeId = ArdaselectedValue;
            fam.DeveloperId = DevselectedValue;
            fam.BusinessAnalystId = BaselectedValue;
            fam.EntrepriseArchitectId = EaselectedValue;
            fam.UpdateBy = proprio;
            fam.UpdatedDate = DateTime.Now;

            //fam = UpdateOnUpdate(fam);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Demandes.Update(fam);
                await ctx.SaveChangesAsync();
                await LoadDemandesAsync();
            }
        }

        public async Task DeleteDemand(GridCommandEventArgs args)
        {
            var fam = args.Item as Demande;
            //entr = UpdateOnUpdate(entr);
            //entr.Proprietaire = proprio;
            using (var ctx = MyContextFactory.CreateDbContext())
            {
                ctx.Demandes.Remove(fam);
                await ctx.SaveChangesAsync();
                await LoadDemandesAsync();
            }
        }
    }
}
