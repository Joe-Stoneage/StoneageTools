# StoneageTools (12/2021)
# Language: English / German (native)
Eine Sammlung von Konvertierungsmethoden in C#/.Net. .Net ist jezt auf Version 6 und mit jeder Version gibt es mehr coole Umrechnungsfunktionen, aber man kan nicht auf jede Neuigkeit immer nur warten...

Im Moment sind ca. 1500 Konvertierungen implementiert.

A large collection of conversion methods for C#/.Net .Net is now on 6.0 and surely contains again much of the work herein, but you can't wait for eternity to get what you need right now...

At the moment: ca. 1500 conversion methods included

## Teilnahme/Participation: 
- Branch & pull request

## Lizenz/License: 
- vollständig Public Domain für jede Art von Nutzung
- complete public domain for any kind of use

## To-Do:
- Tests entsprechend https://docs.microsoft.com/de-de/dotnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-6-0
- Testing, would like to use https://docs.microsoft.com/en-us/dnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-6-0

## Nutzung/Usage: 
Download/Clone and add a reference to your csproj-file:
```
<ItemGroup>
    <ProjectReference Include="<YOURPATH>/StoneageTools.csproj"/>
</ItemGroup>
```
Or add a package reference to your csproj-file from commandline: (need to figure out why this is not working yet)
```
dotnet add YOURPROJECT package StoneageTools --version 1.0.0
```
Or simply edit your csproj-file and add these lines: (need to figure out why this is not working yet)
```
<ItemGroup>
  <PackageReference Include="StoneageTools" Version ="1.0.0"/>
</ItemGroup>
```

## Hints:
- would like to go completely to static classes

***My dev-machine runs Ubuntu 21.10, I use Visual Studio Code for C#***
