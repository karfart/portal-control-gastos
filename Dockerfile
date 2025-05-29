FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /app
COPY . ./
RUN dotnet restore PortalControlGastos.sln
RUN dotnet publish PortalControlGastos.Web/PortalControlGastos.Web.csproj -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview
WORKDIR /app
COPY --from=build /app/out .
EXPOSE 80
ENTRYPOINT ["dotnet", "PortalControlGastos.Web.dll"]