using CyberAdvisorApplication.Pages;
using CyberAdvisorApplication.Pages.AdvisoriesGrp;
using CyberAdvisorApplication.Pages.IncidentGrp;
using CyberAdvisorApplication.Pages.KBGrp;

namespace CyberAdvisorApplication;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Advisories
        Routing.RegisterRoute(nameof(KEVsPg), typeof(KEVsPg));
        Routing.RegisterRoute(nameof(CVEsPg), typeof(CVEsPg));
        Routing.RegisterRoute(nameof(SavedAdvisoriesPg), typeof(SavedAdvisoriesPg));

        // Knowledge Base
        Routing.RegisterRoute(nameof(NetworkingPg), typeof(NetworkingPg));
        Routing.RegisterRoute(nameof(IAMPg), typeof(IAMPg));
        Routing.RegisterRoute(nameof(EndpointSecurityMgmtPg), typeof(EndpointSecurityMgmtPg));
        Routing.RegisterRoute(nameof(VectorsPg), typeof(VectorsPg));

        // Incident Response
        Routing.RegisterRoute(nameof(PhishingResponsePg), typeof(PhishingResponsePg));
        Routing.RegisterRoute(nameof(MalwareResponsePg), typeof(MalwareResponsePg));
        Routing.RegisterRoute(nameof(AccountCompromisePg), typeof(AccountCompromisePg));
        Routing.RegisterRoute(nameof(NetworkIncidentPg), typeof(NetworkIncidentPg));
    }
}