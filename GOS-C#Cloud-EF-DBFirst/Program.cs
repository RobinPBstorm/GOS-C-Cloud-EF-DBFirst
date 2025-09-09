// See https://aka.ms/new-console-template for more information
using GOS_C_Cloud_EF_DBFirst.Models;


ExoAdoContext context = new ExoAdoContext();
List<Section> sections = context.Sections.ToList();

foreach(Section section in sections)
{
    Console.WriteLine(section.SectionName);
}

Section nouvelleSection = new Section { Id = 1014, SectionName = "Data Analyse" };
context.Sections.Add(nouvelleSection);

Section sectionData = context.Sections.FirstOrDefault(s => s.Id == 1014);
context.Sections.Remove(sectionData);

context.SaveChanges();

sections = context.Sections.ToList();

foreach (Section section in sections)
{
    Console.WriteLine(section.SectionName);
}