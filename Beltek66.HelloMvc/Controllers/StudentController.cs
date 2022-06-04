using Microsoft.AspNetCore.Mvc;

namespace Beltek66.HelloMvc.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "Hello MVC";
        }
        public string StudentList()
        {
            return "Öğrenci Listesi";
        }
        public string StudentDetail(string id)
        {
            string ogr;
            if (id == "1")

                ogr = "Ali";

            else if (id == "2")

                ogr = "Ceyda";


            else
                ogr = "Bu id ile öğrenci yok ";
            return ogr;

        }
    }
}
//Pattern isteğin nasıl karşılanacağını belirler.
//Controller istekleri karşılar.(Uygulamaya gelen istekleri karşılar.)
// ISS: Internet Information Services -C# .NET dillerini tarayıcının anlayacağı şekilde çevirir.(Sunucuya gelen istekleri karşılar)