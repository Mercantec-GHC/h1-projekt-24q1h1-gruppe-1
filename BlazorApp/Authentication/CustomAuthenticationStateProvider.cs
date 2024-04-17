using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace BlazorApp.Authentication
{
    // We're using the build-in AuthenticationStateProvider from Blazor
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        // User details are saved in this ProtectedSessionStorage
        private readonly ProtectedSessionStorage _sessionStorage;

        // This is used for anonymous users
        private ClaimsPrincipal _anonymous = new ClaimsPrincipal(new ClaimsIdentity());

        public CustomAuthenticationStateProvider(ProtectedSessionStorage sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            // We use try / catch to prevent a user trying to change the session in the browser
            try
            {
                // User details are saved in the "UserSession" key
                var userSessionStorageResult = await _sessionStorage.GetAsync<UserSession>("UserSession");

                // If the value is successfully fetch, it will be true (null if false)
                var userSession = userSessionStorageResult.Success ? userSessionStorageResult.Value : null;

                // if null - return anonymous
                if (userSession == null)
                    return await Task.FromResult(new AuthenticationState(_anonymous));

                // if not null - new ClaimsPrincipal (name) saved as authentication string "CustomAuth". 
                var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userSession.UserName)
                    //new Claim(ClaimTypes.Role, userSession.Role)
                }, "CustomAuth"));
                return await Task.FromResult(new AuthenticationState(claimsPrincipal));
            }
            catch
            {
                return await Task.FromResult(new AuthenticationState(_anonymous));
            }
        }

        // We call this method, when a user login or logout.
        public async Task UpdateAuthenticationState(UserSession userSession)
        {
            ClaimsPrincipal claimsPrincipal;

            if (userSession != null)
            {
                // When the user login
                await _sessionStorage.SetAsync("UserSession", userSession);
                claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userSession.UserName)
                    //new Claim(ClaimTypes.Role, userSession.Role)
                }));
            }
            else
            {
                // When the user logout we delete the "UserSession" value
                await _sessionStorage.DeleteAsync("UserSession");

                // and make the claimsPrincipal anonymous
                claimsPrincipal = _anonymous;
            }

            // Call the NotifyAuthenticationStateChanged
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }
    }
}
