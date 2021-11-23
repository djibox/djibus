using Microsoft.AspNetCore.Http;

namespace Djibus.Pages
{
    public partial class Index : ComponentBase
    {
        [Parameter]
        public string CurrentUser { get; set; }
        [Parameter]
        public string FullName { get; set; }

        private async Task GetCurrentUserAsync()
        {
            var auth = await GetAuthStateAsync.GetAuthenticationStateAsync();
            var user = auth.User;
            CurrentUser = user.Identity.Name;
        }



        private void GetFullNameByEmail(string email)
        {

            using (var myContext = MyContextFactory.CreateDbContext())
            {
                var user =  myContext.Users.Where(u => u.Email.Equals(email)).FirstOrDefault();
                if (user != null)
                {
                    FullName = user.FullName;
                }
                else
                {
                    FullName = "Nothing Founded !";
                }
            }

        }
        protected override async Task OnInitializedAsync()
        {
            await GetCurrentUserAsync();
            GetFullNameByEmail(CurrentUser);
        }
    }
}
