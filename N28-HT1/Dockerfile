FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["N28-HT1/N28-HT1.csproj", "N28-HT1/"]
RUN dotnet restore "N28-HT1/N28-HT1.csproj"
COPY . .
WORKDIR "/src/N28-HT1"
RUN dotnet build "N28-HT1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "N28-HT1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "N28-HT1.dll"]
