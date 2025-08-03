# consoleApp

A .NET Core console application for generating random text.

## Build

```sh
dotnet build
```

## Publish

```sh
dotnet publish ./RandomTextGenerator/RandomTextGenerator.csproj --configuration Release --output ./publish
```

## Usage

After publishing, run:

```sh
./publish/RandomTextGenerator generate --length 50 --numeric false --specialcharacter false
```

- `--length`: Length of the generated text.
- `--numeric`: Include numbers (true/false).
- `--specialcharacter`: Include special characters (true/false).

## CI/CD

This project uses GitHub Actions to build, test, and publish the application automatically.
