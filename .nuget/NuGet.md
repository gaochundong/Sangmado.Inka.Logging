Commands
------------
nuget setApiKey xxx-xxx-xxxx-xxxx

nuget pack ..\Sangmado.Inka.Logging\Sangmado.Inka.Logging.csproj -IncludeReferencedProjects -Symbols -Build -Prop Configuration=Release -OutputDirectory ".\packages"

nuget push .\packages\Sangmado.Inka.Logging.1.0.0.0.nupkg

