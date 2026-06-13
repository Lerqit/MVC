Zadanie 4 – System zarządzania zadaniami domowymi

Prosta aplikacja do zapisywania zadań domowych.


Spis treści

- Co robi ta aplikacja
- Jak to uruchomić
- Struktura projektu


Co robi ta aplikacja

- wyświetla listę zadań domowych
- można dodać nowe zadanie (opis, termin, czy już zrobione)
- można edytować istniejące zadanie
- można usunąć zadanie


Jak to uruchomić

Czego potrzebujesz

- Visual Studio 2022 lub nowszy
- .NET 10
- SQL Server LocalDB

1. Otwórz .sln w Visual Studio

2. Zainstaluj paczki w Package Manager Console (krok do pominięcia jeśli paczki są już zainstalowane)

- Install-Package Microsoft.EntityFrameworkCore.SqlServer
- Install-Package Microsoft.EntityFrameworkCore.Tools

3. stwórz bazę danych

- Add-Migration [DowolnaNazwa]
- Update-Database

4. uruchom przez Ctrl+F5

