# Use the ASP.NET Core runtime as the base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the .NET SDK as the build environment
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /

# Copy the entire output directory since it contains the published application
COPY . .

# Publish the project (if you want to ensure it's built again)
# This is optional since you already published it in the GitHub Actions
# RUN dotnet publish "ImageAnalyzer.Api/ImageAnalyzer.Api.csproj" -c Release -o /app/publish

# Final stage/image
FROM base AS final
WORKDIR /
# Copy all files from the output directory to the final image
# Assuming 'out' contains your built files
COPY --from=build / .  

# Set the entry point for the application
ENTRYPOINT ["dotnet", "ImageAnalyzer.Api.dll"]