FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Contaners/Contaners.csproj", "Contaners/"]
RUN dotnet restore "Contaners/Contaners.csproj"
COPY . .
WORKDIR "/src/Contaners"
RUN dotnet build "Contaners.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Contaners.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Contaners.dll"]