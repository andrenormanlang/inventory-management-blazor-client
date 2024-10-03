# Stage 1: Build the Blazor WebAssembly App
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the project files and restore dependencies
COPY *.sln ./
COPY InventoryManagementBlazorClient/*.csproj ./InventoryManagementBlazorClient/
RUN dotnet restore

# Copy the entire source code and build the project
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Stage 2: Serve the app using Nginx
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=build /app/publish/wwwroot .
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
