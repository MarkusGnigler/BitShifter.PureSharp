cd ../.. # cd to docker context

$LibraryVersion = 1.0.0
$NugetApiKey = ""

docker build --tag publish --build-arg Version=$LibraryVersion --file Dockerfile.Pack .

docker run --rm --volume ${PWD}/artifacts:/sln/artifacts publish

# docker run --rm --volume ${PWD}/artifacts:/sln/artifacts publish --api-key $NugetApiKey --source "https://api.nuget.org/v3/index.json"

exit 0