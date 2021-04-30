rmdir /s /q "pack"
dotnet clean "src\Emphasis.ComputerVision.sln"
dotnet pack "src\Emphasis.ComputerVision.sln" -c Release --include-source --include-symbols -o pack
dotnet nuget push "pack\*.nupkg" -s https://api.nuget.org/v3/index.json --skip-duplicate