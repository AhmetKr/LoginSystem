using System;

namespace LoginSystem
{
    class Program
    {
        string timer = "Ekrana Yönlendiriliyorsunuz!!";
        static void Main(string[] args)
        {


            User user1 = new User()
            {
                UserName = "İlker",
                Password = "123"
            };
            User user2 = new User()
            {
                UserName = "Rıdvan",
                Password = "1234"
            };
            User user3 = new User()
            {
                UserName = "Ahmet",
                Password = "12345"
            };

            User[] users = new User[] { user1, user2, user3 };
            LogIn(users);


        }

        public static void LogIn(User[] users)
        {
            bool test = true;
            bool showMenu = true;


            while (test)
            {

                bool isUserName = false;
                Console.Write("Username: ");
                string inputUserName = Console.ReadLine();
                Console.Write("Password: ");
                string inputPassword = Console.ReadLine();
                for (int i = 0; i < users.Length; i++)
                {
                    if (users[i].UserName == inputUserName)
                    {
                        isUserName = true;

                        if (users[i].Password == inputPassword)
                        {
                            Console.WriteLine(inputUserName + " Adlı Kullanıcının Giriş Başarılı");
                            test = false;
                            showMenu = true;

                            break;
                        }
                        else
                        {
                            Console.WriteLine("Giriş başarısız");
                        }
                    }
                }

                if (isUserName == false)
                {
                    Console.WriteLine("Giriş başarısız");
                }

                Console.WriteLine("--------------------------");
            }
            
            string timer = "Ekrana Yönlendiriliyorsunuz";
            Console.WriteLine(timer);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            if (showMenu == true)
            {
                Menu menu = new Menu();
                string Course = menu.CourseList = "--Kursları Listele--";
                string Teacher = menu.Teacher = "--Ögretmenler--";




                Menu[] lists = new Menu[] { menu };

                foreach (Menu Menus in lists)
                {
                    Console.WriteLine(Menus.CourseList);
                    Console.WriteLine(Menus.Teacher);
                    Console.WriteLine("Seçmek İstediğiniz Menünün Adını Yazınız:");
                    string SelectedMenu = Console.ReadLine();

                    if (SelectedMenu == Menus.CourseList)
                    {
                        CourseList courseList = new CourseList();
                        courseList.CourseName = "Proglamlamaya Giriş Kursu";
                        courseList.TeachersName = "Engin Demiroğ";
                        courseList.CourseDetail = "Üstün Seviye Proglamla Kursuna Hoşgeldiniz";
                        courseList.CourseHour = 100;

                        CourseList[] courseLists = new CourseList[] { courseList };

                        foreach (CourseList ShowCourse in courseLists)
                        {
                            Console.WriteLine("------" + ShowCourse.CourseDetail + "------");
                            Console.WriteLine("Kurs Adı:" + ShowCourse.CourseName);
                            Console.WriteLine("Öğretmen Adı:" + ShowCourse.TeachersName);
                            Console.WriteLine("Kurs Saati:" + ShowCourse.CourseHour);
                            Console.WriteLine("---------------------------");
                        }
                    }
                    
                    if (SelectedMenu == Menus.Teacher)
                    {
                        TeacherList teacherList = new TeacherList();
                        teacherList.TeacherName = "Engin Demiroğ";
                        teacherList.TeacherDetail = "Engin Demiroğ 12.05.2000 Doğumlu 21 Yaşında İstanbul Üniversitesi Mezunu ve MCPP Sertifikasına Sahiptir ";
                        teacherList.TeacherReferances = "Arçelik,Beko,Tekno Yazılım";
                        teacherList.NumberOfCertificates = 1;

                        TeacherList[] teacherlists = new TeacherList[] { teacherList };

                        for (int i = 0; i < teacherlists.Length; i++)
                        {
                            Console.WriteLine("---------Öğretmen Listesi---------");
                            Console.WriteLine("Öğretmen Adı:" + teacherlists[i].TeacherName);
                            Console.WriteLine("Öğretmen Detayı:" + teacherlists[i].TeacherDetail);
                            Console.WriteLine("Öğretmen Referansları:" + teacherlists[i].TeacherReferances);
                            Console.WriteLine("Öğretmen Sertifika Sayısı:" + teacherlists[i].NumberOfCertificates);

                        }
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız Menü Adını Bulunamadı");
                        
                    }
                }
            }
        }
    }
}