# UnityLongPathPlugin

[![CI](https://github.com/rennerdo30/UnityLongPathPlugin/actions/workflows/ci.yml/badge.svg)](https://github.com/rennerdo30/UnityLongPathPlugin/actions/workflows/ci.yml)
[![Release](https://github.com/rennerdo30/UnityLongPathPlugin/actions/workflows/release.yml/badge.svg)](https://github.com/rennerdo30/UnityLongPathPlugin/actions/workflows/release.yml)

BepInEx plugin that patches `System.IO.File.Move` to support Windows long paths (paths longer than `MAX_PATH`, 260 chars) in Unity games/mods.

## Why

Some Unity + modded game workflows still hit path length issues when moving files, especially in deep folder structures.
This plugin intercepts file move calls and routes them through a long-path-capable implementation.

## Features

- Harmony patch for `System.IO.File.Move`.
- Windows long-path conversion (`\\?\` and `\\?\UNC\` handling).
- Drop-in BepInEx plugin (no game-side code changes required).

## Requirements

- Windows (plugin relies on `kernel32.dll` APIs).
- BepInEx 5.x.
- .NET Framework 4.6 target compatibility (`net46`).

## Installation

1. Build the project in `Release`.
2. Copy `UnityLongPathPlugin.dll` into your game's BepInEx plugins folder:
   `BepInEx/plugins/`
3. Start the game and verify plugin load in BepInEx logs.

## Development

```bash
dotnet restore UnityLongPathPlugin.sln
dotnet build UnityLongPathPlugin.sln -c Release
```

## Releases

- Tag a version like `v1.0.1`.
- Push the tag to GitHub.
- The `Release` workflow builds the plugin, packages it, and publishes a GitHub release asset.

## Repository Structure

- `UnityLongPathPlugin/Plugin.cs`: BepInEx entry point.
- `UnityLongPathPlugin/Patcher.cs`: Harmony patch registration and `File.Move` prefix.
- `UnityLongPathPlugin/LongFile.cs`: Win32 long-path file operations.
- `.github/workflows/ci.yml`: GitHub Actions CI workflow.
- `.github/workflows/release.yml`: GitHub Actions release workflow.

## Contributing

Contributions are welcome. Please read [CONTRIBUTING.md](CONTRIBUTING.md) before opening a pull request.

## Code of Conduct

Please review [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md) when participating in discussions and pull requests.

## Security

To report vulnerabilities, see [SECURITY.md](SECURITY.md).

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE).

## Changelog

See [CHANGELOG.md](CHANGELOG.md) for release notes and pending changes.
