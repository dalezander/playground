# 02-final-validation: Run full build and test validation

Run full-solution validation after the atomic upgrade completes to confirm runtime and compile-time correctness remain intact. This includes a clean build and test execution for the upgraded solution so the upgrade can be finalized with confidence.

Capture any warnings or regressions and resolve them within the upgraded project scope to leave the repository in a clean, warning-free state.

**Done when**: Solution build succeeds with zero errors/warnings and all discovered tests pass.

## Validation Scope
- **Solution**: `dotnet/Grpc/GrpcServiceClient.sln`
- **Projects in scope**: `GrpcClient`, `GrpcService`
- **Discovered test projects**: none
- **Validation approach**: run full solution build with warnings treated as errors to enforce warning-free completion, then confirm no tests are available to execute.
