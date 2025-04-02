FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/PracticeProject.Web.Host/PracticeProject.Web.Host.csproj", "src/PracticeProject.Web.Host/"]
COPY ["src/PracticeProject.Web.Core/PracticeProject.Web.Core.csproj", "src/PracticeProject.Web.Core/"]
COPY ["src/PracticeProject.Application/PracticeProject.Application.csproj", "src/PracticeProject.Application/"]
COPY ["src/PracticeProject.Core/PracticeProject.Core.csproj", "src/PracticeProject.Core/"]
COPY ["src/PracticeProject.EntityFrameworkCore/PracticeProject.EntityFrameworkCore.csproj", "src/PracticeProject.EntityFrameworkCore/"]
WORKDIR "/src/src/PracticeProject.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/PracticeProject.Web.Host", "src/PracticeProject.Web.Host"]
COPY ["src/PracticeProject.Web.Core", "src/PracticeProject.Web.Core"]
COPY ["src/PracticeProject.Application", "src/PracticeProject.Application"]
COPY ["src/PracticeProject.Core", "src/PracticeProject.Core"]
COPY ["src/PracticeProject.EntityFrameworkCore", "src/PracticeProject.EntityFrameworkCore"]
WORKDIR "/src/src/PracticeProject.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "PracticeProject.Web.Host.dll"]
