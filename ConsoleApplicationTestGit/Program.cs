using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Startup.AlwaysOn.DataAccess.Context;
using Startup.AlwaysOn.DataAccess.Table;

namespace ConsoleApplicationTestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Testing");
            Console.Write("Testing 2");
            ApplicationAccountDataAccess db = new ApplicationAccountDataAccess();
            db.Add(new ApplicationAccountTable
            {
                Address = "",
                ApplicationVersion = 1,
                Classes = new List<ClassTable>
                {
                    new ClassTable
                    {
                        Id = Guid.NewGuid(),
                        Group = "Mam",
                        Name = "Mam 2",
                        Teachers = new List<TeacherAccountTable>
                        {
                            new TeacherAccountTable
                            {
                                Id= Guid.NewGuid(),
                                Username=Guid.NewGuid().ToString(),
                                CreatedDate= DateTime.Now,
                                FullName=Guid.NewGuid().ToString(),
                                Password= Guid.NewGuid().ToString(),
                                Phone= Guid.NewGuid().ToString(),
                                Status= Startup.AlwaysOn.Common.Enums.AccountStatus.Active
                            }
                        },
                       

                    }
                },
                CreatedDate=DateTime.Now,
                ExpireDate= DateTime.Now.AddMonths(1),
                Id = Guid.NewGuid()
            });
            db.SaveChanges();
        }
    }
}
