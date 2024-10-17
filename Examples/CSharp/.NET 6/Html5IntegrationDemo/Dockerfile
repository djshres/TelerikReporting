# command to BUILD docker IMAGE from the Windows Terminal:
# docker image build -f "{Replace With Installation Folder}\Examples\CSharp\.NET 6\Html5IntegrationDemo\Dockerfile" -t net6html5integrationdemo --build-arg TelerikNugetServerApiKey={Replace With Your TelerikNuGetApiKey} "{Replace With Installation Folder}"

# command to RUN docker CONTAINER from the Windows Terminal:
# docker run -e ConnectionStrings__Telerik.Reporting.Examples.CSharp.Properties.Settings.TelerikConnectionString__connectionString="{Replace With Connection String to AdventureWorks Database Accessible From the Docker Container}" -it -p 4041:80 net6html5integrationdemo


#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

WORKDIR /app
EXPOSE 80

RUN apt-get update
RUN apt-get install -y libfreetype6
RUN apt-get install -y libfontconfig1

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["Report Designer/Examples", "Reports"]
COPY ["Examples/CSharp/.NET 6/Html5IntegrationDemo", ".NET 6/Html5IntegrationDemo/"]
COPY ["Examples/CSharp/Business Objects", "Business Objects/"]
COPY ["Examples/CSharp/nuget.config", ""]

ARG TelerikNugetServerApiKey
ENV TelerikNugetServer_API_KEY $TelerikNugetServerApiKey

RUN dotnet restore "/src/.NET 6/Html5IntegrationDemo/CSharp.Net6.Html5IntegrationDemo.csproj"

WORKDIR "/src/.NET 6/Html5IntegrationDemo"
RUN dotnet build "./CSharp.Net6.Html5IntegrationDemo.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./CSharp.Net6.Html5IntegrationDemo.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app/Examples/CSharp/NET6/Html5IntegrationDemo
COPY --from=publish /app/publish .
COPY --from=build ["/src/Reports", "/app/Report Designer/Examples"]
ENTRYPOINT ["dotnet", "CSharp.Net6.Html5IntegrationDemo.dll"]
