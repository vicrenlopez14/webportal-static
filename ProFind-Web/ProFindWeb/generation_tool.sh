openApiGenerator="6.2.0"
fileName="openapi-generator-cli-$openApiGenerator.jar"
openAPIPath=$(hostname).local

mkdir -p api

outputDir="api"
openAPIFile="swagger.json"

if test -f $fileName; then
    echo "Already downloaded"
else
    echo "Downloading OpenApiGenerator ..."
    curl -O "https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/$openApiGenerator/openapi-generator-cli-$openApiGenerator.jar"
fi

if test -f $openAPIFile; then
    echo "Already downloaded"
else
    echo "Downloading OPENAPI reference ..."
    echo "http:///swagger/v1/swagger.json"
    curl -O "http://$openAPIPath/swagger/v1/swagger.json"
fi

java -jar $fileName generate \
    -i $openAPIFile \
    -g dart-dio-next \
    -o $outputDirVaya mir

cd $outputDir
flutter pub get
flutter pub run build_runner build