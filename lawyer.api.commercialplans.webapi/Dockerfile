FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["lawyer.api.commercialplans.webapi/lawyer.api.commercialplans.webapi.csproj", "lawyer.api.commercialplans.webapi/"]
COPY ["lawyer.api.commercialplans.application/lawyer.api.commercialplans.application.csproj", "lawyer.api.commercialplans.application/"]
COPY ["lawyer.api.commercialplans.domain/lawyer.api.commercialplans.domain.csproj", "lawyer.api.commercialplans.domain/"]
COPY ["lawyer.api.commercialplans.datastore.mssql/lawyer.api.commercialplans.datastore.mssql.csproj", "lawyer.api.commercialplans.datastore.mssql/"]
RUN dotnet restore "lawyer.api.commercialplans.webapi/lawyer.api.commercialplans.webapi.csproj"
COPY . .
WORKDIR "/src/lawyer.api.commercialplans.webapi"
RUN dotnet build "./lawyer.api.commercialplans.webapi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./lawyer.api.commercialplans.webapi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lawyer.api.commercialplans.webapi.dll"]
