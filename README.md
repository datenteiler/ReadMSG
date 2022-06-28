# ReadMSG
Ein Beispielprojekt in C#

Um das Projekt zu erstellen, muss das .NET 6 SDK unter Windows, Linux oder MacOS installiert sein. Mit den folgenden Befehlen wird die Konsolenanwendung erstellt:

```
dotnet new console -o ReadMSG
cd .\ReadMSG\
code .\Program.cs
```

In Visual Studio Code wird dann der Code aus diesem Repository in die Datei Program.cs eingefügt. Anschließend werden die benötigten Pakete geladen.

```
dotnet add package MSGReader
dotnet add package OpenMcdf
```

Welche Einstellungen noch möglich sind, findet man hier in der Datei "ReadMSG.csproj". Danach kann das Programm ausgeführt oder als ausführbares Programm kompiliert werden:

```
dotnet run
dotnet publish
```

Möchte man das Programm für Linux bauen, hängt man folgende Option an:

```
dotnet publish --runtime linux-x64
```

Damit das Programm unter Linux ausgeführt werden kann, muss dort noch die aktuelle libicu installiert sein.
