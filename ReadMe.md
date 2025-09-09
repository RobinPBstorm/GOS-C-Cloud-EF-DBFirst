# Demo de porjet Entity Framework DB First

- Créer un projet vide
- Installez les dépendances
    - Microsoft.EntityFrameworkCore 
    - Microsoft.EntityFrameworkCore.SqlServer
    - Microsoft.EntityFrameworkCore.Tools
- Taper une des commandes suivates pour le scaffolding:
    - Option 1 depuis le terminal:
        Nécessite d'avoir dotnet tool d'installer en global.


        ``` bash
        # En étant dans le projet et pas dans la solution
        dotnet ef dbcontext scaffold "your_connection_string" Microsoft.EntityFrameworkCore.SqlServer -o Models
        ```
    - Option 2 : La console de gestionnaire de package Nuget:
        Cette console se trouve dans Tools > Gesionnaire de packages Nuget > Console de gestionnaire de package Nuget

        ``` Gestionnaire de Package
        Scaffold-DBContext "your_connection_string" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models 
        ```
- Pour chaque changement dans la DB, il faudra regénérer les classes avec l'étape précédente

- Utiliser le DB Context générer (il contient les collections des objets venant de la db):
```C#
//Par exemple:
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
```

## Pour réaliser l'opération précédente en ligne de commande
### Installer entityFramework cli
dotnet tool install --global dotnet-ef
### creer le projet console (où efdemo2 est le nom du projet)
dotnet new console -o efDemo2
### rentrer dans votre projet 
cd efDemo2
### installer les nugets
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.Data.SqlClient
### lancer le scaffold (remplacer pa votre connection string)
dotnet ef dbcontext scaffold "your_connection_string" Microsoft.EntityFrameworkCore.SqlServer -o Models

 