VERSION=$1
NUGET_API_KEY=$2

dotnet pack src/GlobalX.ChatBots.Core/GlobalX.ChatBots.Core.csproj -p:PackageVersion=$VERSION -o ../../
dotnet nuget push GlobalX.ChatBots.Core.$VERSION.nupkg -k $NUGET_API_KEY -s nuget.org