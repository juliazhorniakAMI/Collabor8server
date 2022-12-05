FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["app.csproj", "./"]
RUN dotnet restore "./app.csproj"
COPY . .
RUN dotnet build "app.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "app.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
CMD ["/bin/bash", "-c", "dotnet app.dll"]