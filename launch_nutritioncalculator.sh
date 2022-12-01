#! /bin/bash
# Made by Simon Wilmots

echo
echo "=========================================="
echo "Starting Nutritioncalculator container "
echo "=========================================="
echo

docker build -t nutritioncalculator:latest .
docker run --rm -p  8000:80 --name nutritioncalculator nutritioncalculator

#docker-compose build --no-cache && docker-compose up --remove-orphans -d

#dotnet run --project ./proteincalculator/proteincalculator.csproj

#xdg-open "http://127.0.0.1:8000" 1>/dev/null 2>&1