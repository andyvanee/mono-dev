# Mono Development Environment

This is a very minimal setup to compile and run Visual Basic
(and other Mono-supported languages) in Docker.

    docker build -t andyvanee/monodev .
    docker run --rm -it -v $(pwd):/app andyvanee/monodev bash
    $ vbnc GenerateGuid.vb
    $ mono GenerateGuid.exe
