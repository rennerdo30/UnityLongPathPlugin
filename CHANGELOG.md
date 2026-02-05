# Changelog

All notable changes to this project will be documented in this file.

The format is based on Keep a Changelog and this project adheres to Semantic Versioning.

## [Unreleased]

### Added
- GitHub Actions CI workflow for pull requests and pushes to `main`.
- GitHub Actions release workflow for version tags (`v*`).
- GitHub issue templates and pull request template.
- Community health files (`CONTRIBUTING.md`, `SECURITY.md`, `CODE_OF_CONDUCT.md`).

### Changed
- Improved `README.md` with install, development, and release documentation.
- Added `nuget.org` to `NuGet.Config` package sources.

### Fixed
- Corrected error log formatting in file move patch handling.
- Corrected long-path file existence logic to avoid directory false positives.
