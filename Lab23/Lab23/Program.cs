using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\andre\OneDrive\Документы\GitHub\RPM\Lab23\Джазз";

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                var musicians = new JazzMusician[]
                {
                new JazzMusician { Name = "John Coltrane", Album = "Blue Train", Copies = 1500, Year = 2024, Price = 60 },
                new JazzMusician { Name = "Miles Davis", Album = "Kind of Blue", Copies = 2000, Year = 2023, Price = 65 },
                new JazzMusician { Name = "Ella Fitzgerald", Album = "Ella and Louis", Copies = 1500, Year = 2024, Price = 70 }
                };

                foreach (var musician in musicians)
                {
                    musician.WriteToBinaryWriter(writer);
                }
            }

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    JazzMusician musician = JazzMusician.ReadFromBinaryReader(reader);
                    if (musician.Year == DateTime.Now.Year && musician.Copies > 1000 && musician.Price >= 50)
                    {
                        Console.WriteLine($"Исполнитель: {musician.Name}, Альбом: {musician.Album}, Тираж: {musician.Copies}, Год выпуска: {musician.Year}, Стоимость: {musician.Price}");
                    }
                }
                Console.ReadKey();
            }
        }
        class JazzMusician
        {
            public string Name { get; set; }
            public string Album { get; set; }
            public int Copies { get; set; }
            public int Year { get; set; }
            public decimal Price { get; set; }

            public void WriteToBinaryWriter(BinaryWriter writer)
            {
                writer.Write(Name);
                writer.Write(Album);
                writer.Write(Copies);
                writer.Write(Year);
                writer.Write(Price);
            }

            public static JazzMusician ReadFromBinaryReader(BinaryReader reader)
            {
                return new JazzMusician
                {
                    Name = reader.ReadString(),
                    Album = reader.ReadString(),
                    Copies = reader.ReadInt32(),
                    Year = reader.ReadInt32(),
                    Price = reader.ReadDecimal()
                };
            }
        }
    }
}
