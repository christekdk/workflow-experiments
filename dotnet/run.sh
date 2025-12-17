dotnet build
pwsh ./bin/Debug/net10.0/playwright.ps1 install
dotnet test -- NUnit.NumberOfTestWorkers=5