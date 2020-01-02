FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["POC_GraphQL/POC_GraphQL.csproj", "POC_GraphQL/"]
RUN dotnet restore "POC_GraphQL/POC_GraphQL.csproj"
COPY . .
WORKDIR "/src/POC_GraphQL"
RUN dotnet build "POC_GraphQL.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "POC_GraphQL.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "POC_GraphQL.dll"]