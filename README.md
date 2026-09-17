# ShackIdaElias
k1 Projektinlämning

♟️ **ChessBoard**

Ett konsolbaserat schackbräde byggt i C# och .NET. 
Programmet låter användaren välja storleken på schackbrädet och 
skriver sedan ut brädet i konsolen.

🚨**Krav**

- .NET 10
- Git

🔧**Klona, bygga och köra**

Klona projektet:

git clone <https://github.com/Jaktlund96/ShackIdaElias.git>

Gå till projektmappen:

cd <cd ChessBoard>

Bygg projektet:

dotnet build

Kör programmet:

dotnet run

🎮**Användning**

När programmet startar får användaren ange storleken på schackbrädet.

Storleken måste vara mellan 3 och 50.

Exempel:

Ange storlek på brädet genom att skriva ett tal mellan 3-50:

8

Det resulterar i ett schackbräde med 8 × 8 rutor:
```
□ ■ □ ■ □ ■ □ ■
■ □ ■ □ ■ □ ■ □
□ ■ □ ■ □ ■ □ ■
■ □ ■ □ ■ □ ■ □
□ ■ □ ■ □ ■ □ ■
■ □ ■ □ ■ □ ■ □
□ ■ □ ■ □ ■ □ ■
■ □ ■ □ ■ □ ■ □
```

📦**NuGet-paket**
Spectre.Console

Projektet använder paketet Spectre.Console. Det valdes för att skapa ett mer visuellt tilltalande spel.
Vi valde att färga första textradens bakgrund blå, detta var för att det skulle hända något direkt när spelet öppnades.
Vi valde inte att göra detta på fler textrader då vi ansåg att det skulle se för klumpigt ut och inte snyggt.

🏗**Kodstruktur**

Klassen Chess representerar schackbrädet och innehåller bland annat:

Size – anger storleken på schackbrädet.
ReadSize() – läser in och validerar användarens input.
RenderBoard() – skapar och skriver ut schackbrädet i konsolen.

🔀**Git-arbete**

Projektet versionshanterades med Git. Vi gjorde commits löpande
under utvecklingen för att spara olika förändringar.

Mergeconflict uppstod under arbetets gång när en av utvecklarna av misstag sparade en ändring som han gjort lokalt på sin dator. 
Detta rättades till genom att klicka på "pending changes" i Visual studios där ändringen syntes och klicka på "undo"

⚙**Tekniska val**

Användarens input valideras med int.TryParse() för att säkerställa att
det användaren skriver går att omvandla till ett heltal. Storleken
kontrolleras även så att den ligger mellan 3 och 50.

För att växla mellan svarta och vita rutor används radens och kolumnens
position. Genom att kontrollera (rad + kolumn) % 2 kan programmet
avgöra vilken typ av ruta som ska skrivas ut.

Koden är uppdelad i en klass och flera metoder för att göra programmet
tydligare och separera olika ansvarsområden.
