#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["ImagesStorage.Api/ImagesStorage.Api.csproj", "ImagesStorage.Api/"]
COPY ["ImagesStorage.Infrastructure/ImagesStorage.Infrastructure.csproj", "ImagesStorage.Infrastructure/"]
COPY ["ImagesStorage.Application/ImagesStorage.Application.csproj", "ImagesStorage.Application/"]
RUN dotnet restore "ImagesStorage.Api/ImagesStorage.Api.csproj"
COPY . .
WORKDIR "/src/ImagesStorage.Api"
RUN dotnet build "ImagesStorage.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ImagesStorage.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ImagesStorage.Api.dll"]