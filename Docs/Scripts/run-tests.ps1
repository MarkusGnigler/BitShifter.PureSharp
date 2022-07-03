cd ../.. # cd to docker ocntext

docker build --tag test --file Dockerfile.Test .

docker run --rm --volume ${PWD}/coveragereport:/source/coveragereport test

exit 0