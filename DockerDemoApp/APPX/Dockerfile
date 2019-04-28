FROM microsoft/dotnet:latest

# Set environment variables
#ENV ASPNETCORE_URLS="http://*:5000"
#ENV ASPNETCORE_URLS="https://0.0.0.0:5000"
#ENV ASPNETCORE_ENVIRONMENT="Staging"

# Copy files to app directory
COPY /APPX/ /app

# Set working directory
WORKDIR /app

# Restore NuGet packages
RUN ["dotnet", "restore"]

# Build the app
RUN ["dotnet", "build"]

# Open port
#EXPOSE 5000/tcp
#EXPOSE 5000
EXPOSE 5001

# Run the app
#CMD ["dotnet", "run"]
ENTRYPOINT ["dotnet", "run", "--urls", "https://0.0.0.0:5001"]

