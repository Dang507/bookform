namespace VuBookStorev5.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using VuBookStorev5.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<VuBookStorev5.BookDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(VuBookStorev5.BookDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Authors.AddOrUpdate(c=>c.AuthorID, new Author ()         
            {
                AuthorID = "1",
                AuthorName = "Gấu Đen"
            },
           new Author()
           {
               AuthorID = "2",
               AuthorName = "Gấu Đỏ"
           },
           new Author()
           {
               AuthorID = "3",
               AuthorName = "Gấu Trắng"
           },
           new Author()
           {
               AuthorID = "4",
               AuthorName = "Gấu Xám"
           },
           new Author()
           {
               AuthorID = "5",
               AuthorName = "Gấu Hồng"
           },
           new Author()
           {
               AuthorID = "6",
               AuthorName = "Gấu Vàng"
           },
           new Author()
           {
               AuthorID = "7",
               AuthorName = "Gấu Đen"
           }, new Author()
           {
               AuthorID = "8",
               AuthorName = "Gấu Mèo"
           }
         
          
           
            );

            
            context.BookDeatails.AddOrUpdate(p => p.BookID, new BookDetail()
            {
                BookID="1",
                BookName="Tâm lý phụ nữ",
               


            },
            new BookDetail ()
            {
               BookID="2",
               BookName="Tâm lý tội phạm"
            },
            new BookDetail ()
            {
                BookID="3",
                BookName="Cách cua gái nhanh gọn"
                
            }
            );

            context.Users.AddOrUpdate(p => p.UserID, new Users()
            {
                UserID="1",
                UserName="Quang Vũ",
                UngayDK=DateTime.Parse("5/5/2020"),
                UngayHetHan=DateTime.Parse("10/6/2020"),
                UserPhone=int.Parse("098775624"),
                UserEmail="vuvu@gmail.com",
                Zipcode=int.Parse ("099996543")

            },
            new Users ()
            {

                UserID = "2",
                UserName = "Quang Vỹ",
                UngayDK = DateTime.Parse("3/5/2020"),
                UngayHetHan = DateTime.Parse("12/6/2020"),
                UserPhone = int.Parse("098774424"),
                UserEmail = "vuvy@gmail.com",
                Zipcode = int.Parse("099446543")
            },
            new Users ()
            {

                UserID = "3",
                UserName = "Quang Văn",
                UngayDK = DateTime.Parse("1/5/2020"),
                UngayHetHan = DateTime.Parse("20/6/2020"),
                UserPhone = int.Parse("098225624"),
                UserEmail = "vuvy@gmail.com",
                Zipcode = int.Parse("0123996543")
            }
            );
            context.Nxbs.AddOrUpdate(a => a.NxbID, new Nxb()
            {
                NxbID="1",
                NxbName="Bình Định"
            },
            new Nxb ()
            {
                NxbID="2",
                NxbName="Hồ Chí Minh"
            },
             new Nxb()
             {
                 NxbID = "3",
                 NxbName = "Hà Nội"
             }
            );
            
        }
    }
}
