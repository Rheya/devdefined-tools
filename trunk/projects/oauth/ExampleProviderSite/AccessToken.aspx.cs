﻿using System;
using System.Web.UI;
using DevDefined.OAuth.Core;
using DevDefined.OAuth.Provider;

namespace ExampleProviderSite
{
    public partial class AccessToken : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OAuthContext context = new OAuthContextFactory().FromHttpRequest(Request);

            IOAuthProvider provider = OAuthServicesLocator.Services.Provider;

            IToken accessToken = provider.ExchangeRequestTokenForAccessToken(context);

            Response.Write(accessToken);
            Response.End();
        }
    }
}