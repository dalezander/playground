# 01-upgrade-all-projects: Upgrade project TFMs and package baselines

Upgrade both `GrpcClient/GrpcClient.csproj` and `GrpcService/GrpcService.csproj` to `net10.0` in one atomic pass, then normalize package references that may need alignment with the new target framework. The assessment shows zero incompatible packages and zero API break incidents, so this task is expected to be mostly mechanical project-file updates with restore/build verification and focused fixes if any package constraints surface.

This task includes prerequisite verification for .NET 10 SDK compatibility and any `global.json` alignment needed for the solution. Because both projects are already SDK-style and independent, no phased dependency ordering is required.

**Done when**: Both project files target `net10.0`, restore succeeds, and the solution compiles successfully after required code/package fixes.

## Scope Inventory
- **Projects affected**: `dotnet/Grpc/GrpcClient/GrpcClient.csproj`, `dotnet/Grpc/GrpcService/GrpcService.csproj`
- **Distinct concerns**: target framework retargeting, package compatibility validation, restore/build verification
- **Project style**: both are SDK-style with target framework defined directly in each project file

## Assessment Findings
- **GrpcClient**: Mandatory issue `Project.0002` (retarget framework from net6.0 to net10.0); no package incompatibilities and no API migration issues.
- **GrpcService**: Mandatory issue `Project.0002` (retarget framework from net6.0 to net10.0); no package incompatibilities and no API migration issues.
- **Test coverage recommendation**: not required by assessment for either project.

## Dependency and Package Notes
- No Central Package Management detected; package versions are defined in each `.csproj`.
- `GrpcClient` direct packages: `Google.Protobuf`, `Grpc.Net.Client`, `Grpc.Tools`.
- `GrpcService` direct packages: `Grpc.AspNetCore`, `Grpc.Net.ClientFactory`.
- Assessment marks all packages compatible with target framework; perform restore/build to validate current versions under net10.0.

## Planned File Changes
- `dotnet/Grpc/GrpcClient/GrpcClient.csproj` — change `<TargetFramework>net6.0</TargetFramework>` to `net10.0`.
- `dotnet/Grpc/GrpcService/GrpcService.csproj` — change `<TargetFramework>net6.0</TargetFramework>` to `net10.0`.
- Additional package version updates only if restore/build reports compatibility issues.
