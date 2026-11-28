# .NET Version Upgrade

## Preferences
- **Flow Mode**: Automatic
- **Target Framework**: net10.0
- **Commit Strategy**: Single Commit at End

## Source Control
- **Source Branch**: develop
- **Working Branch**: upgrade-dotnet-10
- **Commit Strategy**: After Each Task
- **Branch Sync**: Auto (Merge)

## Upgrade Options
**Source**: .github/upgrades/scenarios/dotnet-version-upgrade/upgrade-options.md

### Strategy
- Upgrade Strategy: All-at-Once

## Strategy
**Selected**: All-At-Once
**Rationale**: 2 projects, both already on net6.0 SDK-style format, with no incompatible packages or API blockers in assessment.

### Execution Constraints
- Apply project and package updates for all projects in a single upgrade pass.
- Use one consolidated compile-fix cycle after updating project files and packages.
- Run full solution validation only after the atomic upgrade step is complete.
- Keep task ordering simple: upgrade first, then final validation.
