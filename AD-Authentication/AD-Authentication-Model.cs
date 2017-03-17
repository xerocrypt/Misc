using System;
using System.Net;
using System.Security.Claims;
using Microsoft.Owin.Security;
using System.DirectoryServices.AccountManagement;
using ADAuthenication;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;


namespace ADAuthenication.Models
{
    public class AdAuthenticationService
    {
        
        
        public class AuthenticationResult
        {
            public AuthenticationResult(string errorMessage = null)
            {
                ErrorMessage = errorMessage;
            }

            public String ErrorMessage { get; private set; }

        //    public Boolean IsSuccess => String.IsNullOrEmpty(ErrorMessage); 

            public Boolean IsSuccess()
            {
                return String.IsNullOrEmpty(ErrorMessage);
            } 
        }

        
        private readonly IAuthenticationManager _authenticationManager;

        
        
        public AdAuthenticationService(IAuthenticationManager authenticationManager)
        {
            this._authenticationManager = authenticationManager;
        }

        public string sUsername = string.Empty;



        /// <summary>
        /// Check if username and password matches existing account in AD. 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public AuthenticationResult SignIn(String username, String password)
        {
//#if DEBUG
            // authenticates against your local machine - for development time
          //  ContextType authenticationType = ContextType.Machine;
//#else
            // authenticates against your Domain AD
           // ContextType authenticationType = ContextType.Domain;
//#endif
           
            if (username.ToLower().Contains("cymru\\"))
               sUsername = username.Replace("cymru\\", "");
            else
               sUsername = username.ToString();
         
            string myAccount = ConfigurationManager.AppSettings["MyServiceAccount"].ToString();
            string myPassword = ConfigurationManager.AppSettings["MyServicePassword"].ToString();
            var myDomain = ConfigurationManager.ConnectionStrings["ADConnection"].ToString();

            PrincipalContext principalContext = new PrincipalContext(ContextType.Domain,myDomain.Replace("LDAP://", ""));
          
            bool isAuthenticated = false;

                UserPrincipal userPrincipal = null;
                try
                {
                    isAuthenticated = principalContext.ValidateCredentials(sUsername, password, ContextOptions.Negotiate);
                    if (isAuthenticated)
                    {
                        userPrincipal = UserPrincipal.FindByIdentity(principalContext, username);
                    }
                }
                catch (Exception)
                {
                    isAuthenticated = false;
                    userPrincipal = null;
                }

                if (!isAuthenticated || userPrincipal == null)
                {
                    return new AuthenticationResult("Username or Password is not correct");
                }

                if (userPrincipal.IsAccountLockedOut())
                {
                    // here can be a security related discussion weather it is worth 
                    // revealing this information
                    return new AuthenticationResult("Your account is locked.");
                }

                if (userPrincipal.Enabled.HasValue && userPrincipal.Enabled.Value == false)
                {
                    // here can be a security related discussion weather it is worth 
                    // revealing this information
                    return new AuthenticationResult("Your account is disabled");
                }

                var identity = CreateIdentity(userPrincipal);

                _authenticationManager.SignOut(MyAuthentication.ApplicationCookie);
                _authenticationManager.SignIn(new AuthenticationProperties() {IsPersistent = false}, identity);

                return new AuthenticationResult();   
        }

        
        
        private ClaimsIdentity CreateIdentity(UserPrincipal userPrincipal)
        {
            var identity = new ClaimsIdentity(MyAuthentication.ApplicationCookie, ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            identity.AddClaim(new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider", "Active Directory"));
            identity.AddClaim(new Claim(ClaimTypes.Name, userPrincipal.SamAccountName));
            identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, userPrincipal.SamAccountName));
            if (!String.IsNullOrEmpty(userPrincipal.EmailAddress))
            {
                identity.AddClaim(new Claim(ClaimTypes.Email, userPrincipal.EmailAddress));
            }

            // add your own claims if you need to add more information stored on the cookie



            return identity;
        }
    }
}