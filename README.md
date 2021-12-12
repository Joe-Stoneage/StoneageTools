# StoneageTools (12/2021)
# Language: English

A large collection of conversion methods for C#/.Net .Net is now on 6.0 and surely contains again much of the work herein, but you can't wait for eternity to get what you need right now...

At the moment: ca. 1500 conversion methods included

This C#-library-project manages units of measure and conversions between them. It is not a port of any other library, it is a pure collection, designed to be lightweight and simple to use, yet comprehensive. It includes a very large number of units of measure commonly found in science, engineering, technology, finance and the household, even some biblical units can be found here. These recognized systems of measurement include the International System of Units (SI), International Customary, United States and British Imperial. More unit conversions will be added when I find more formulas or someone contributes (see below). Each conversion method, b.t.w., has always its' vice versa method included in the library. 

## Participation: 
- Branch & pull request

## License: 
- complete public domain for any kind of use

## To-Do:
- Testing, would like to use https://docs.microsoft.com/en-us/dnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-6-0

## Usage: 
Download/clone and add a reference to your csproj-file:
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
