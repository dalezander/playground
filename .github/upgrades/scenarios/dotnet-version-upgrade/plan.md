# .NET Version Upgrade Plan

## Overview

**Target**: Upgrade GrpcClient and GrpcService projects from net6.0 to net10.0.
**Scope**: Small solution (2 projects, low-risk assessment, no incompatible packages).

## Tasks

### Selected Strategy
**All-At-Once** — All projects upgraded simultaneously in a single operation.
**Rationale**: 2 projects, all on .NET 6, SDK-style, and no compatibility blockers identified.

### 01-upgrade-all-projects: Upgrade project TFMs and package baselines
Upgrade both `GrpcClient/GrpcClient.csproj` and `GrpcService/GrpcService.csproj` to `net10.0` in one atomic pass, then normalize package references that may need alignment with the new target framework. The assessment shows zero incompatible packages and zero API break incidents, so this task is expected to be mostly mechanical project-file updates with restore/build verification and focused fixes if any package constraints surface.

This task includes prerequisite verification for .NET 10 SDK compatibility and any `global.json` alignment needed for the solution. Because both projects are already SDK-style and independent, no phased dependency ordering is required.

**Done when**: Both project files target `net10.0`, restore succeeds, and the solution compiles successfully after required code/package fixes.

---

### 02-final-validation: Run full build and test validation
Run full-solution validation after the atomic upgrade completes to confirm runtime and compile-time correctness remain intact. This includes a clean build and test execution for the upgraded solution so the upgrade can be finalized with confidence.

Capture any warnings or regressions and resolve them within the upgraded project scope to leave the repository in a clean, warning-free state.

**Done when**: Solution build succeeds with zero errors/warnings and all discovered tests pass.
