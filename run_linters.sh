docker pull admiralawkbar/super-linter:latest
docker run -e RUN_LOCAL=true -v $PWD:/tmp/lint admiralawkbar/super-linter
