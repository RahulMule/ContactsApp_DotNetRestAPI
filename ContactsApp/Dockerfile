# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy only the project file and restore dependencies
COPY ["ContactsApp.csproj", "ContactsApp/"]
WORKDIR "/src/ContactsApp"
RUN dotnet restore "./ContactsApp.csproj"

# Copy the entire source code
COPY . .

# Build the application
RUN dotnet build "./ContactsApp.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish Stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ContactsApp.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final Stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Copy the published output from the publish stage
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "ContactsApp.dll"]
