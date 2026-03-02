using MedicoDent.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace MedicoDent.Infrastructure.Persistence
{
    public partial class AppDbContext
    {
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                Salt.Add(GenerateSalt());
            }

            modelBuilder.Entity<User>().HasData
            (
                new User
                {
                    Id = 1,
                    Username = "Admin",
                    PasswordSalt = Salt[0],
                    PasswordHash = GenerateHash(Salt[0], "Medico123."),
                }
            );

            modelBuilder.Entity<Patient>().HasData
            (
               new Patient
               {
                   Id = 1,
               },
               new Patient
               {
                   Id = 2,
               },
                new Patient
                {
                    Id = 3,
                },
                new Patient
                {
                    Id = 4,
                },
                new Patient
                {
                    Id = 5,
                },
                new Patient
                {
                    Id = 6,
                },
                new Patient
                {
                    Id = 7,
                },
                new Patient
                {
                    Id = 8,
                },
                new Patient
                {
                    Id = 9,
                },
                new Patient
                {
                    Id = 10,
                },
                new Patient
                {
                    Id = 11,
                }




            );

            modelBuilder.Entity<PatientBasicInfo>().HasData
            (
                new PatientBasicInfo
                {
                    Id = 1,
                    FirstName = "Guzica",
                    LastName = "Doe",
                    BirthDate = new DateTime(1999, 1, 1),
                    PatientId = 1
                },
                new PatientBasicInfo
                {
                    Id = 2,
                    FirstName = "John",
                    LastName = "Doe",
                    BirthDate = new DateTime(1999, 1, 1),
                    PatientId = 2
                },
                new PatientBasicInfo
                {
                    Id = 3,
                    FirstName = "Jane",
                    LastName = "Doe",
                    BirthDate = new DateTime(1999, 1, 1),
                    PatientId = 3
                },
                new PatientBasicInfo
                {
                    Id = 4,
                    FirstName = "Jack",
                    LastName = "Doe",
                    BirthDate = new DateTime(1999, 1, 1),
                    PatientId = 4
                },
                new PatientBasicInfo
                {
                    Id = 5,
                    FirstName = "Jill",
                    LastName = "Doe",
                    BirthDate = new DateTime(1999, 1, 1),
                    PatientId = 5
                },
                new PatientBasicInfo
                {
                    Id = 6,
                    FirstName = "James",
                    LastName = "Doe",
                    BirthDate = new DateTime(1999, 1, 1),
                    PatientId = 6
                },
                new PatientBasicInfo
                {
                    Id = 7,
                    FirstName = "Jenny",
                    LastName = "Doe",
                    BirthDate = new DateTime(1999, 1, 1),
                    PatientId = 7
                },
                new PatientBasicInfo
                {
                    Id = 8,
                    FirstName = "Joe",
                    LastName = "Doe",
                    BirthDate = new DateTime(1999, 1, 1),
                    PatientId = 8
                },
                new PatientBasicInfo
                {
                    Id = 9,
                    FirstName = "Jessica",
                    LastName = "Doe",
                    BirthDate = new DateTime(1999, 1, 1),
                    PatientId = 9
                },
                new PatientBasicInfo
                {
                    Id = 10,
                    FirstName = "Jeremy",
                    LastName = "Doe",
                    BirthDate = new DateTime(1999, 1, 1),
                    PatientId = 10
                },
                new PatientBasicInfo
                {
                    Id = 11,
                    FirstName = "Julia",
                    LastName = "Doe",
                    BirthDate = new DateTime(1999, 1, 1),
                    PatientId = 11
                }

            );

            modelBuilder.Entity<PatientContact>().HasData
            (
                new PatientContact
                {
                    Id = 1,
                    PatientId = 1
                }
            );
        }
    }
}
