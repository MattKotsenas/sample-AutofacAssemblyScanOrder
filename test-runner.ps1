function run
{
    param
    (
        $Name
    )
    Set-StrictMode -Version 2
    echo "Building and running $Name"

    msbuild /t:"Clean;Rebuild" /p:Configuration=Debug /noconsolelogger /nologo $Name
    . .\bin\Debug\sample_AutofacAssemblyScanOrder.exe
}

run -Name AthenB.csproj
run -Name BthenA.csproj