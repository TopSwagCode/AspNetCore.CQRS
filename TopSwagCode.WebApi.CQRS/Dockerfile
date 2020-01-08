FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["TopSwagCode.WebApi.CQRS/TopSwagCode.WebApi.CQRS.csproj", "TopSwagCode.WebApi.CQRS/"]
RUN dotnet restore "TopSwagCode.WebApi.CQRS/TopSwagCode.WebApi.CQRS.csproj"
COPY . .
WORKDIR "/src/TopSwagCode.WebApi.CQRS"
RUN dotnet build "TopSwagCode.WebApi.CQRS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TopSwagCode.WebApi.CQRS.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TopSwagCode.WebApi.CQRS.dll"]