using Beltek66.HelloMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Beltek66.HelloMvc.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()//Action
        {
            //string name = "Ahmet";
            //ViewData["name"] = name;
            //ViewData["surname"] = "Mehmet";
            //ViewData["age"] = 25;

            //string name1 = "Kerim";
            //ViewData["name1"] = name1;
            //ViewData["surname1"] = "Sekili";
            //ViewData["age1"] = 22;
            //ViewBag.name = "Ali";
            //ViewBag.surname = "Veli";
            //ViewBag.age = 25;

            //string isim = "Mustafa";
            //var name = "Murat";
            //dynamic _name = " Osman";

            var ogr = new Student();
            ogr.Name = "Emre";
            ogr.Surname = "Kaya";
            ogr.Age = 22;

            ViewData["student"] = ogr;
            ViewBag.ogrenci = ogr;

            return View();
        }
        //ViewData :
        //Key-Value Pair
        //Dictionary Data
        //Collection = Dizilerin eleman sayısı belirlemeden kullanılabilen hali.
        //ViewBag arka planda ViewData koleksiyonunu kullanır.
        //ViewBag dynamic bir yapıdır.Dynamic yapıların tipine runtime sırasında karar verilir.
        public ViewResult StudentList()
        {
            var students = new List<Student>();
            students.Add(new Student { Name = "Murat", Surname = "Balaban", Age = 21 });
            students.Add(new Student { Name = "Kerim", Surname = "Sekban", Age = 18 });
            students.Add(new Student { Name = "Sultan", Surname = "Özdemir", Age = 28 });

            var teacher = new List<Teacher>();
            teacher.Add(new Teacher { Name = "Cihan", Surname = "Yetişken", Department = "C#" });
            teacher.Add(new Teacher { Name = "Müslüm", Surname = "Endam", Department = "Java" });

            var lst = new ListViewModel();
            lst.Teachers = teacher;
            lst.Students = students;
            //ViewData["lst"]=students;
            //ViewBag.lst = students;
            return View(lst);
        }
       
    }
}
//Pattern isteğin nasıl karşılanacağını belirler.
//Controller istekleri karşılar.(Uygulamaya gelen istekleri karşılar.)
// ISS: Internet Information Services -C# .NET dillerini tarayıcının anlayacağı şekilde çevirir.(Sunucuya gelen istekleri karşılar)