#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
ENV DOTNET_RUNNING_IN_CONTAINER=true


# Use the .NET SDK as the build environment
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy the entire output directory since it contains the published application
COPY . .

# Publish the project (if you want to ensure it's built again)
# This is optional since you already published it in the GitHub Actions
# RUN dotnet publish "ImageAnalyzer.Api/ImageAnalyzer.Api.csproj" -c Release -o /app/publish

# Final stage/image
FROM base AS final
WORKDIR /app
# Copy all files from the output directory to the final image
# Assuming 'out' contains your built files
COPY --from=build /app ./
RUN echo $version > /app/wwwroot/version.txt

# Set the entry point for the application
ENTRYPOINT ["dotnet", "ImageAnalyzer.Api.dll"]