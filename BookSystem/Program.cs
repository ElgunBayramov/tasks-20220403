using System;

namespace BookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Kitabxana sistemi
            // Kitab təsviri üçün Data Structure yaratmaq -Book.cs
            // Kitabın təsviri üçün aşağıdakı memberlər olmalıdır
            // Kitabın adı(Name)
            //Müəllifin adı(AuthorName)
            //Nəşr ili(PublishedDate)
            //Səhifə sayı(PageCount) (10 - dan az reqem daxil etmek olmasin)
            //Həmçinin bu class daxilində (Book.cs)
            //--------------------------------------------------------------
            //1) ToString metodunun override edilməsi və tostring edilərkən
            //kitab haqqında məlumat aşağıdakı kimi çap edilsin
            //Format: <authorName> "<bookName>" <publishedDate>
            //Çingiz Abdullayev "Qərb bürküsü" 2013 
            //Kitabları list şəklində depolamaq və sonra isə dövr opertorunun köməyi ilə
            //hər kitabı yuxarıdakı formatla hər sətrə çap etmək
            // 2) İkinci bir method olsun kitab obyektinin nusxesi uzre çağırılarkən aşağıdakı
            //formada tam məlumat qaytarsın
            //Əsər: Qərb bürküsü
            //Müəllif: Çingiz Abdullayev
            //Nəşr ili: 2013
            // Səhifə sayı: 300
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Book b1=new Book();
            b1.Name = "Qərb Bürküsü";
            b1.AuthorName = "Çingiz Abdullayev";
            b1.PublishedDate = 2013;
            b1.PageCount = 600;
           
            Console.WriteLine(b1);
            Console.WriteLine("--------------------------------------------------");
            b1.Book1();
        }
    }
}
