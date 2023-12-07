using Microsoft.EntityFrameworkCore;

namespace EvangelionDatabase.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EVAContext(
                serviceProvider.GetRequiredService<DbContextOptions<EVAContext>>()
            ))
            {
                if (context.Evangelion.Any())
                {
                    return;
                }

                List<Evangelion> evangelions = new List<Evangelion>{
                    new Evangelion
                    {
                        EVAUnit = 00,
                        EVAName = "Evangelion Unit-00",
                        Description = "Evangelion Unit-00 (エヴァンゲリオン零号機, Evangerion Zerogōki?) is the first functional Evangelion unit created, serving as the prototype for the rest of the Evangelion series. It is piloted by Rei Ayanami.",
                        Picture = "EVA00.png"
                    },
                    new Evangelion
                    {
                        EVAUnit = 01,
                        EVAName = "Evangelion Unit-01",
                        Description = "Evangelion Unit-01 (エヴァンゲリオン初号機, Evangerion Shogōki?) is the first non-prototype Evangelion unit, and is referred to as the \"EVA-01 TEST TYPE\". It houses the soul of Shinji's mother, Yui Ikari. It is mainly piloted by Shinji Ikari. Unit-01 serves as the flagship model for the series.",
                        Picture = "EVA01.png"
                    },
                    new Evangelion
                    {
                        EVAUnit = 02,
                        EVAName = "Evangelion Unit-02",
                        Description = "Evangelion Unit-02 (エヴァンゲリオン 弐号機, Evangerion Nigōki?) is the third Evangelion completed, the first Production Model Evangelion. The design of Unit-02 supposedly rectifies the mistakes made during the construction of Prototype Unit-00 and Test Type Unit-01, making it the first Evangelion built specifically for combat against the Angels. It is piloted by Asuka Langley Sohryu and briefly by Kaworu Nagisa.",
                        Picture = "EVA02.png"
                    }
                };
                context.AddRange(evangelions);

                List<Pilot> pilots = new List<Pilot>{
                    new Pilot
                    {
                        FirstName = "Rei",
                        LastName = "Ayanami",
                        Description = "Rei Ayanami (綾波 レイ/あやなみ れい/アヤナミ レイ), Ayanami Rei?) is a fictional character from the Neon Genesis Evangelion franchise. She is the First Child (referred as the First Children in the Japanese version), the pilot of Evangelion Unit-00 and one of the central characters.",
                        Picture = "Rei.png"
                    },
                    new Pilot
                    {
                        FirstName = "Shinji",
                        LastName = "Ikari",
                        Description = "Shinji Ikari (碇シンジ, Ikari Shinji?)[2] is the Third Child, the main protagonist of the series and the designated pilot of Evangelion Unit-01. He is the son of Gehirn bioengineer Yui Ikari and NERV Commander (formerly Chief of Gehirn) Gendo Ikari. After his mother's death, he was abandoned by his father and lived for 11 years with his sensei, until he was summoned to Tokyo-3 to pilot Unit-01 against the Angels. He lives initially just with Misato Katsuragi; they are later joined by Asuka Langley Soryu.",
                        Picture = "Shinji.png"
                    },
                    new Pilot
                    {
                        FirstName = "Asuka",
                        LastName = "Langley Soryu",
                        Description = "Asuka Langley Sohryu (惣流・アスカ・ラングレー, Sōryū Asuka Rangurē?) is a 14-year-old fictional character from the Neon Genesis Evangelion franchise and one of the main female characters. Asuka is designated as the Second Child (\"Second Children\" in the original Japanese versions) of the Evangelion Project and pilots the Evangelion Unit-02. Her surname is romanized as Soryu in the English manga and Sohryu in the English version of the TV series, the English version of the anime movie, and on Gainax's website.",
                        Picture = "Asuka.png"
                    }
                };
                context.AddRange(pilots);

                List<PilotEvangelions> assignedEVA = new List<PilotEvangelions>{
                    new PilotEvangelions {EvangelionID = 1, PilotID = 1},
                    new PilotEvangelions {EvangelionID = 2, PilotID = 2},
                    new PilotEvangelions {EvangelionID = 3, PilotID = 3}
                };
                context.AddRange(assignedEVA);

                context.SaveChanges();
            }
        }
    }
}