echo "Setting up project"

cd ./Lib
dotnet restore

cd ../Tests
dotnet restore

echo "All done!"