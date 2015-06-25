using System.Web.Mvc;

namespace PI_INFOX.Areas.Aluno
{
    public class AlunoAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Aluno";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Aluno_default",
                "Aluno/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
