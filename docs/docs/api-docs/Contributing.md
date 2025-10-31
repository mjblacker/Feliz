---
title: Contributing
sidebar_position: 10
---

# Contributing

If you are enjoying the Feliz project, consider contributing back and helping out with the community. There are many ways you can contribute, the first of which is to simply use Feliz in your project and report issues you come across whether there are missing style properties or properties that were incorrectly implemeneted.

# I want to contribute! What should i do?

Thats awesome! There are many ways you can contribute to the Feliz project:

1. 🏷️ Start by creating an issue of your planned changes. This allows us to discuss the changes before you start working on them and ensure that they are aligned with the project goals.
2. 🛠️ Fork the repository and create a new branch for your changes.
    - Check out the section below to find the most important instructions for setting up your development environment.
3. ✨ Make your changes and ensure that you follow the coding style and conventions used in the project. (Styling should be automatically applied by Fantomas if you use VS Code with Ionide)
4. ✅ Write tests for your changes to ensure that they work as expected and do not introduce any regressions.
5. 📚 Document your changes! 
    - Every Feliz-.fsproj has a related "CHANGELOG" file. Add your changes following the instructions inside the file!
    - Write/Update documentation under `./docs`!
6. 📄 Create a pull request with a clear description of your changes and the issue it addresses.

---

# Setting up your development environment

## Requirements

1. [.NET SDK 8.0 or later](https://dotnet.microsoft.com/en-us/download)
2. [Node.js 20 or later](https://nodejs.org/)

## Setup

1. Clone the repository
2. Install dependencies: `dotnet run --project ./build/Build.fsproj setup`.

    <details>

    <summary>Alternatively, you can manually install the dependencies:</summary>

      - NPM dependencies:

        ```bash
        npm install
        ```

      - .NET dependencies:

        ```bash
        dotnet restore
        ```

      - .NET tools:

        ```bash
        dotnet tool restore
        ``` 

    </details>

3. Verify correct setup by running the tests `dotnet run --project ./build/Build.fsproj test`
4. Ready! 🎉 


# Workflows

Feliz uses a f# build project to run common tasks such as testing. You can find the entrypoint for the build project under `./build/Build.fsproj`.

:::info
- **On Windows** you can also use `.\build.cmd` to run the build tasks instead of `dotnet run --project ./build/Build.fsproj`.
- **On MacOS/Linux** you can also use `./build.sh` to run the build tasks instead of `dotnet run --project ./build/Build.fsproj`.
:::

## Testing

```bash
dotnet run --project ./build/Build.fsproj test
```

## Run docs

1. Go into docs folder:

    ```bash
    cd docs
    ```

2. Start docs server:

    ```bash
    npm run start
    ```
