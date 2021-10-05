FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app

EXPOSE 80
EXPOSE 443
EXPOSE 5000
EXPOSE 5001

ENV DOTNET_USE_POLLING_FILE_WATCHER=1
ENV ASPNETCORE_LOGGING__CONSOLE__DISABLECOLORS=true
ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_URLS=https://localhost:443;http://localhost:80;http://localhost:5000
ENV ASPNETCORE_HTTPS_PORT=5001
ENV NUGET_PACKAGES=/root/.nuget/fallbackpackages

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["PersonalServer.csproj", "."]
RUN dotnet restore "./PersonalServer.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "PersonalServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PersonalServer.csproj" -c Release -o /app/publish
WORKDIR /app/publish
RUN echo dotnet PersonalServer.dll
ENTRYPOINT ["dotnet", "PersonalServer.dll"]

#docker run -dt -v "C:\Users\hbroc\vsdbg\vs2017u5:/remote_debugger:rw" 
#-v "C:\Users\hbroc\Documents\Projects\personal-site\server\PersonalServer:/app" 
#-v "C:\Users\hbroc\Documents\Projects\personal-site\server\PersonalServer:/src/" 
#-v "C:\Users\hbroc\AppData\Roaming\Microsoft\UserSecrets:/root/.microsoft/usersecrets:ro" 
#-v "C:\Users\hbroc\AppData\Roaming\ASP.NET\Https:/root/.aspnet/https:ro" 
#-v "C:\Users\hbroc\.nuget\packages\:/root/.nuget/fallbackpackages" 
#-e "DOTNET_USE_POLLING_FILE_WATCHER=1" 
#-e "ASPNETCORE_LOGGING__CONSOLE__DISABLECOLORS=true" 
#-e "ASPNETCORE_ENVIRONMENT=Development" 
#-e "ASPNETCORE_URLS=https://+:443;http://+:80" 
#-e "ASPNETCORE_HTTPS_PORT=5001" 
#-e "NUGET_PACKAGES=/root/.nuget/fallbackpackages" 
#-e "NUGET_FALLBACK_PACKAGES=/root/.nuget/fallbackpackages" 
#-p 5000:80 -p 5001:443 
#-P --name PersonalServer 
#--entrypoint tail personalserver:dev 
#-f /dev/null