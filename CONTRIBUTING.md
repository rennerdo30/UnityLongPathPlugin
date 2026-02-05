# Contributing to UnityLongPathPlugin

Thanks for your interest in contributing.

## Getting Started

1. Fork the repository.
2. Create a branch for your change.
3. Restore and build locally:
   ```bash
   dotnet restore UnityLongPathPlugin.sln
   dotnet build UnityLongPathPlugin.sln -c Release
   ```
4. Open a pull request with a clear description.

## Pull Request Guidelines

- Keep PRs focused and small when possible.
- Include context on why the change is needed.
- Update docs if behavior changes.
- Ensure CI passes before requesting review.

## Code Style

- Follow existing C# conventions in the repo.
- Prefer clear, minimal changes over broad refactors.
- Keep logging actionable and concise.

## Reporting Issues

Please use the issue templates in GitHub and include:

- Reproduction steps
- Expected behavior
- Actual behavior
- Game/runtime environment details
